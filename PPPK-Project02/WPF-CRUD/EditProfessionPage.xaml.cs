using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPF_CRUD.Dal;
using WPF_CRUD.Models;
using WPF_CRUD.ViewModels;

namespace WPF_CRUD
{
    /// <summary>
    /// Interaction logic for EditProfessionPage.xaml
    /// </summary>
    public partial class EditProfessionPage : FramedPage
    {
        private readonly Profession profession;
        public EditProfessionPage(ProfessionViewModel professionViewModel, Profession profession = null) : base(professionViewModel)
        {
            InitializeComponent();
            this.profession = profession ?? new Profession();
            DataContext = profession;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e) => Frame.NavigationService.GoBack();

        private void BtnCommit_Click(object sender, RoutedEventArgs e)
        {            
            profession.ProfessionName = TbProfessionName.Text.Trim();
            if (profession.IDProfession == 0)
            {
                ProfessionViewModel.Professions.Add(profession);
            }
            else
            {
                ProfessionViewModel.Update(profession);
            }
            Frame.NavigationService.GoBack();            
        }
    }
}
