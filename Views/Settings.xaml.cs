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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings() { InitializeComponent(); }

        private void txtBoxUpdateEmail_TextInput(object sender, TextCompositionEventArgs e) { }
        private void txtBoxUpdatePassword_TextInput(object sender, TextCompositionEventArgs e){ }
        private void txtBoxUpdateConfirmPass_TextInput(object sender, TextCompositionEventArgs e) { }
        private void txtBoxUpdateShortDesc_TextInput(object sender, TextCompositionEventArgs e) { }
        private void txtBoxUpdateGenderPref_TextInput(object sender, TextCompositionEventArgs e) { }
        private void txtBoxUpdateMinAgePref_TextInput(object sender, TextCompositionEventArgs e) { }
        private void txtBoxUpdateMaxAgePref_TextInput(object sender, TextCompositionEventArgs e) { }

        private void cmbBoxUpdateGenderPref_TextInput(object sender, TextCompositionEventArgs e) { }
        private void btnFindMatches_Click(object sender, RoutedEventArgs e)
        {
            FindMatches findMatches = new FindMatches();
            findMatches.Show();
            this.Close();
        }
        private void btnViewMatches_Click(object sender, RoutedEventArgs e)
        {
            ViewMatches viewMatches = new ViewMatches();
            viewMatches.Show();
            this.Close();
        }
        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            string genderPref = "";
            if (cmbBoxUpdateGenderPref.Text == "Male") { genderPref = "M"; }
            else if (cmbBoxUpdateGenderPref.Text == "Female") { genderPref = "F"; }
            else if (cmbBoxUpdateGenderPref.Text == "Other") { genderPref = "O"; }

            if(txtBoxUpdatePassword.Password != txtBoxUpdateConfirmPass.Password)
            {
                MessageBox.Show("Your password doesn't match.");
                return;
            }

            ConfimWithLogin confirmWithLogin = new ConfimWithLogin();
            confirmWithLogin.ShowDialog();

            if (App.Current.Resources["confirmWithLoginBool"].ToString() == "True")
            {
                try
                {
                    mySettingsViewModel.settingsRepo.getUserInfo(App.Current.Resources["loginEmail"].ToString());

                    mySettingsViewModel.settingsRepo.updateEmail(txtBoxUpdateEmail.Text);
                    mySettingsViewModel.settingsRepo.updatePassword(txtBoxUpdatePassword.Password);
                    mySettingsViewModel.settingsRepo.updateShortDesc(txtBoxUpdateShortDesc.Text);
                    mySettingsViewModel.settingsRepo.updateGenderPref(genderPref);
                    mySettingsViewModel.settingsRepo.updateMinAgePref(txtBoxUpdateMinAgePref.Text);
                    mySettingsViewModel.settingsRepo.updateMaxAgePref(txtBoxUpdateMaxAgePref.Text);

                    MessageBox.Show("Your changes have been saved.");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                catch (Exception) { MessageBox.Show("Error: something went wrong"); }
            }
            else { return; }
        }
        private void btnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            ConfimWithLogin confirmWithLogin = new ConfimWithLogin();
            confirmWithLogin.ShowDialog();

            if (App.Current.Resources["confirmWithLoginBool"].ToString() == "True")
            {
                try
                {
                    mySettingsViewModel.settingsRepo.getUserInfo(App.Current.Resources["loginEmail"].ToString());
                    mySettingsViewModel.settingsRepo.deleteAccount();

                    MessageBox.Show("Your account has been deleted.");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                catch (Exception exc) { MessageBox.Show(exc.Message); }
            }
            else { return; }
        }
    }
}
