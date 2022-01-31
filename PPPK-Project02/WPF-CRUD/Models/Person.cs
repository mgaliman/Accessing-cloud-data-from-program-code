using System.Windows.Media.Imaging;
using WPF_CRUD.Utils;

namespace WPF_CRUD.Models
{
    public class Person
    {
        public int IDPerson { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
        public int ProfessionID { get; set; }
        public string ProfessionName { get; set; }
        public BitmapImage Image
        {
            get => ImageUtils.ByteArrayToBitmapImage(Picture);
        }
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
