using System.Windows;
using WPF_CRUD.Models;
using WPF_CRUD.ViewModels;

namespace WPF_CRUD
{
    /// <summary>
    /// Interaction logic for ListProfessionPage.xaml
    /// </summary>
    public partial class ListProfessionPage : FramedPage
    {
        public ListProfessionPage(ProfessionViewModel professionViewModel) : base(professionViewModel)
        {
            InitializeComponent();
            LvProfessions.ItemsSource = professionViewModel.Professions;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e) => Frame.Navigate(new EditProfessionPage(ProfessionViewModel) { Frame = Frame });

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (LvProfessions.SelectedItem != null)
            {
                Frame.Navigate(new EditProfessionPage(ProfessionViewModel, LvProfessions.SelectedItem as Profession) { Frame = Frame });
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (LvProfessions.SelectedItem != null)
            {
                ProfessionViewModel.Professions.Remove(LvProfessions.SelectedItem as Profession);
            }
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e) => Frame.Navigate(new ListPeoplePage(new ViewModels.PersonViewModel()) { Frame = Frame });
    }
}
