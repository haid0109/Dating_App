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
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        public CreateAccount() { InitializeComponent(); WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen; }
        public void TextBox_TextInputCreateEmail(object sender, TextCompositionEventArgs e) { }
        private void TextBox_TextInputCreatePassword(object sender, TextCompositionEventArgs e) { }
        private void TextBox_TextInputConfirmPass(object sender, TextCompositionEventArgs e) { }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        private void BtnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtBoxCreatePassword.Password == txtBoxCreateConfirmPass.Password)
                {
                    App.Current.Resources["createAccountEmail"] = txtBoxCreateEmail.Text;
                    App.Current.Resources["createAccountPassword"] = txtBoxCreatePassword.Password;

                    CreateProfile createProfile = new CreateProfile();
                    createProfile.Show();
                    this.Close();
                }
                else { MessageBox.Show("Your password doesn't match."); }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
    }
}