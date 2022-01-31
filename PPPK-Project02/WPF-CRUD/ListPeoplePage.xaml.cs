using System.Windows;
using System.Windows.Controls;
using WPF_CRUD.Models;
using WPF_CRUD.ViewModels;

namespace WPF_CRUD
{
    /// <summary>
    /// Interaction logic for ListPeoplePage.xaml
    /// </summary>
    public partial class ListPeoplePage : FramedPage
    {
        public ListPeoplePage(PersonViewModel personViewModel) : base(personViewModel)
        {
            InitializeComponent();
            LvUsers.ItemsSource = personViewModel.People;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e) => Frame.Navigate(new EditPersonPage(PersonViewModel) { Frame = Frame });

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (LvUsers.SelectedItem != null)
            {
                Frame.Navigate(new EditPersonPage(PersonViewModel, LvUsers.SelectedItem as Person) { Frame = Frame });
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (LvUsers.SelectedItem != null)
            {
                PersonViewModel.People.Remove(LvUsers.SelectedItem as Person);
            }
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e) => Frame.Navigate(new ListProfessionPage(new ViewModels.ProfessionViewModel()) { Frame = Frame });
    }
}
