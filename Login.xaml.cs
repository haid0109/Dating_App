using _2019_9_3_Dating_app_XAML_.ViewModels;
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

namespace _2019_9_3_Dating_app_XAML_.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login() { InitializeComponent(); }

        private void TextBox_TextInputEmail(object sender, TextCompositionEventArgs e) { }
        private void TextBox_TextInputPassword(object sender, TextCompositionEventArgs e) { }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (myLoginViewModel.loginRepo.login(txtBoxEmail.Text, txtBoxUserPassword.Text))
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Close();
                }
                else { MessageBox.Show("User does not exist"); }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void BtnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Close();
        }
    }
}
