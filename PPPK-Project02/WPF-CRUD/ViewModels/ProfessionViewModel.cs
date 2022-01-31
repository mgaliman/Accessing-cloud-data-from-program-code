using System.Collections.ObjectModel;
using System.Linq;
using WPF_CRUD.Dal;
using WPF_CRUD.Models;

namespace WPF_CRUD.ViewModels
{
    public class ProfessionViewModel
    {
        public ObservableCollection<Profession> Professions { get; }
        public ProfessionViewModel()
        {
            Professions = new ObservableCollection<Profession>(RepositoryFactory.GetRepository().GetProfessions());
            Professions.CollectionChanged += Profession_CollectionChanged;
        }

        private void Profession_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    RepositoryFactory.GetRepository().AddProfession(Professions[e.NewStartingIndex]);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    RepositoryFactory.GetRepository().DeleteProfession(e.OldItems.OfType<Profession>().ToList()[0]);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    RepositoryFactory.GetRepository().UpdateProfession(e.NewItems.OfType<Profession>().ToList()[0]);
                    break;
            }
        }
        internal void Update(Profession profession) => Professions[Professions.IndexOf(profession)] = profession;
    }
}