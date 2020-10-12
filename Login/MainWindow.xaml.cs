using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static string ComputeHash(string rawData)
        {
            using (SHA512 mySHA512 = SHA512.Create())
            {

                byte[] bytes = mySHA512.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (var item in bytes)
                {
                    builder.Append(item.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void tbUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tblUsername.Text = "Enter Username";
            }
            else
            {
                tblUsername.Text = "";
            }
        }
        private void pwbPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pwbPass.Password == "")
            {
                tblPass.Text = "Enter Password";
            }
            else
            {
                tblPass.Text = "";
            }
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string pass = ComputeHash(pwbPass.Password);
            string username = tbUsername.Text;
            using (ProjectBEntities ctx = new ProjectBEntities())
            {
                var pwtest = ctx.Personeelslid.Where(p => p.Username == tbUsername.Text && p.Pass == pass).Count();
                if (pwtest== 1)
                {
                    Personeelslid ingelogdPersoneelslid = ctx.Personeelslid.Where(p => p.Username == username).FirstOrDefault();
                    Hoofdmenu hoofdmenu = new Hoofdmenu(ingelogdPersoneelslid);
                    hoofdmenu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam of wachtwoord verkeerd!");
                }
            }
        }

    }
}
