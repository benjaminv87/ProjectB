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
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for Hoofdmenu.xaml
    /// </summary>
    public partial class Hoofdmenu : Window
    {
        public Hoofdmenu(Personeelslid ActiefPersoneelslid)
        {
            InitializeComponent();
            personeelslid = ActiefPersoneelslid;
            miUser.Header = ActiefPersoneelslid.Voornaam;
            if (ActiefPersoneelslid.FunctieID == 1)
            {
                tabGebruikers.IsEnabled = true;
               
                tabGebruikers.Visibility = Visibility.Visible;
            }
            else
            {
                tabGebruikers.Visibility = Visibility.Hidden;
                tabGebruikers.IsEnabled = false;
            }
            updateListBoxUsers();
        }

        public Personeelslid personeelslid;

        private void miLogOut_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Wil je zeker uitloggen?","Logout",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MainWindow loginmenu = new MainWindow();
                loginmenu.Show();
                this.Close();
            }
        }

        private void miGegevensAanpassen_Click(object sender, RoutedEventArgs e)
        {

        }

        public void updateListBoxUsers()
        {
            using(ProjectBEntities ctx = new ProjectBEntities())
            {
                var personeelsQuery = ctx.Personeelslid.Select(p => p).ToList();
                lbUsers.ItemsSource = personeelsQuery;
            }
        }

        private void btnGebruikerAanpassen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGebruikerToevoegen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
