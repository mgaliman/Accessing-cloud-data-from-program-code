﻿using Azure.Storage.Blobs.Models;
using RemoteFileStorage.Dao;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteFileStorage.ViewModels
{
    class ItemsViewModel
    {
        public const string ForwardSlash = "/";
        private string directory;
        public string Directory
        {
            get => directory;
            set
            {
                directory = value;
                Refresh();
            }
        }
        public ObservableCollection<BlobItem> Items { get; }
        public ObservableCollection<string> Directories { get; }
        public ItemsViewModel()
        {
            Items = new ObservableCollection<BlobItem>();
            Directories = new ObservableCollection<string>();
            Refresh();
        }

        private void Refresh()
        {
            Directories.Clear();
            Items.Clear();
            var check = Repository.Container.GetBlobs();

            Repository.Container.GetBlobs().ToList().ForEach(item =>
            {
                if (item.Name.Contains(ForwardSlash))
                {
                    string directory = item.Name.Substring(0, item.Name.LastIndexOf(ForwardSlash));
                    if (!Directories.Contains(directory))
                    {
                        Directories.Add(directory);
                    }
                }
                if (string.IsNullOrEmpty(Directory) && !item.Name.Contains(ForwardSlash))
                {
                    Items.Add(item);
                }
                else if (!string.IsNullOrEmpty(Directory) && item.Name.Contains($"{Directory}{ForwardSlash}"))
                {
                    Items.Add(item);
                }
            });
        }

        public async Task UploadAsync(string path, string directory)
        {
            string filename = path.Substring(path.LastIndexOf(Path.DirectorySeparatorChar) + 1);
            directory = Path.GetExtension(filename).Substring(Path.GetExtension(filename).LastIndexOf(".") + 1).ToUpper();
            filename = string.IsNullOrEmpty(directory?.Trim()) ? filename : $"{directory}{Path.DirectorySeparatorChar}{filename}";
            using (var fs = File.OpenRead(path))
            {
                await Repository.Container.GetBlobClient(filename).UploadAsync(fs, true);
            }
            Refresh();
            Directory = directory;
        }

        public async Task DeleteAsync(BlobItem blobItem)
        {
            await Repository.Container.GetBlobClient(blobItem.Name).DeleteAsync();
            Refresh();

        }

        public async Task DownloadAsync(BlobItem blobItem, string filename)
        {
            using (var fs = File.OpenWrite(filename))
            {
                await Repository.Container.GetBlobClient(blobItem.Name).DownloadToAsync(fs);
            }
        }
    }
}
