using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Webshop.Model;

namespace Webshop.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlHusok.xaml
    /// </summary>
    public partial class UserControlUsers : UserControl
    {
        List<User> Users;
        User SelectedUser;
        public UserControlUsers()
        {
            InitializeComponent();
            AdatbazisLekerdezes();
            Users = new List<User>();
        }

        private void AdatbazisLekerdezes()
        {
            var felhasznaloRepo = new GenericRepository<User>(App.databasePath);
            var lekerdezes = felhasznaloRepo.GetAll();
            datagridFelhasznalok.ItemsSource = lekerdezes;

            mentesBtn.Visibility = Visibility.Visible;
            torlesBtn.Visibility = Visibility.Hidden;
        }

        private void datagridFelhasznalok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mentesBtn.Visibility = Visibility.Collapsed;
            torlesBtn.Visibility = Visibility.Visible;

            if (datagridFelhasznalok.SelectedItem != null)
            {
                SelectedUser = (User)datagridFelhasznalok.SelectedItem;
                felhasznalonevText.Text = SelectedUser.Username;
                teljesnevText.Text = SelectedUser.Email;
            }
        }

        private void torlesBtn_Click(object sender, RoutedEventArgs e)
        {
            var felhasznaloRepo = new GenericRepository<User>(App.databasePath);
            felhasznaloRepo.Delete(SelectedUser);
            AdatbazisLekerdezes();
        }

        private void mentesBtn_Click(object sender, RoutedEventArgs e)
        { 

            User NewUser = new User(felhasznalonevText.Text,
                teljesnevText.Text);

            var felhasznaloRepo = new GenericRepository<User>(App.databasePath);
            felhasznaloRepo.Insert(NewUser);

            AdatbazisLekerdezes();
        }
    }
}
