using System.Windows.Controls;
using WPF_CRUD.ViewModels;

namespace WPF_CRUD
{
    public class FramedPage : Page
    {
        public FramedPage(PersonViewModel personViewModel)
        {
            PersonViewModel = personViewModel;
        }

        public FramedPage(ProfessionViewModel professionViewModel)
        {
            ProfessionViewModel = professionViewModel;
        }

        public PersonViewModel PersonViewModel { get; }
        public ProfessionViewModel ProfessionViewModel { get; }
        public Frame Frame { get; set; }
    }
}
