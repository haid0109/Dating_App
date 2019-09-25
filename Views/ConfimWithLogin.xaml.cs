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
    /// Interaction logic for ConfimWithLogin.xaml
    /// </summary>
    public partial class ConfimWithLogin : Window
    {
        public ConfimWithLogin()
        {
            InitializeComponent();
            App.Current.Resources["confirmWithLoginBool"] = false;
        }
        private void txtBoxEmail_TextInput(object sender, TextCompositionEventArgs e) { }
        private void passBoxPassword_TextInput(object sender, TextCompositionEventArgs e) { }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["confirmWithLoginBool"] = false;
            this.Close();
        }
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if(txtBoxEmail.Text == App.Current.Resources["loginEmail"].ToString())
            {
                if (myLoginViewModel.loginRepo.login(txtBoxEmail.Text, passBoxPassword.Password))
                {
                    App.Current.Resources["confirmWithLoginBool"] = true;
                    this.Close();
                }
                else { MessageBox.Show("Your email or password is incorrect."); }
            }
            else
            {
                MessageBox.Show("Your email doesn't match.");
                return;
            }
        }
    }
}
