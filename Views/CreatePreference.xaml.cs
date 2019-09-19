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
    /// Interaction logic for CreatePreference.xaml
    /// </summary>
    public partial class CreatePreference : Window
    {
        public CreatePreference() { InitializeComponent(); }
        private void TxtBoxCreateGenderPref_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateMinAgePref_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateMaxAgePref_TextInput(object sender, TextCompositionEventArgs e) { }
        private void CmbBoxCreateGenderPref_TextInput(object sender, TextCompositionEventArgs e) { }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            CreateProfile createProfile = new CreateProfile();
            createProfile.Show();
            this.Close();
        }

        private void BtnCreatePreferences_Click(object sender, RoutedEventArgs e)
        {
            string genderPref = "";
            if (cmbBoxCreateGenderPref.Text == "Male") { genderPref = "M"; }
            else if (cmbBoxCreateGenderPref.Text == "Female") { genderPref = "F"; }
            else if (cmbBoxCreateGenderPref.Text == "Other") { genderPref = "O"; }
            else
            {
                MessageBox.Show("You need to choose a preference.");
                return;
            }
            
            if(Convert.ToInt16(txtBoxCreateMinAgePref.Text) < 18 && Convert.ToInt16(txtBoxCreateMaxAgePref.Text) > 125)
            {
                MessageBox.Show("That age group is too young and too old for you.");
                return;
            }
            else if (Convert.ToInt16(txtBoxCreateMinAgePref.Text) < 18)
            {
                MessageBox.Show("That age group is too young for you.");
                return;
            }
            else if (Convert.ToInt16(txtBoxCreateMaxAgePref.Text) > 125)
            {
                MessageBox.Show("That age group is too old for you.");
                return;
            }

            try
            {
                myCreatePreferencesViewModel.createRepo.Email = App.Current.Resources["createAccountEmail"].ToString();
                myCreatePreferencesViewModel.createRepo.Password = App.Current.Resources["createAccountPassword"].ToString();

                myCreatePreferencesViewModel.createRepo.FirstName = App.Current.Resources["createProfileFirstName"].ToString();
                myCreatePreferencesViewModel.createRepo.LastName = App.Current.Resources["createProfileLastName"].ToString();
                myCreatePreferencesViewModel.createRepo.Gender = App.Current.Resources["createProfileGender"].ToString();
                myCreatePreferencesViewModel.createRepo.Birthdate = App.Current.Resources["createProfileBirthdate"].ToString();
                myCreatePreferencesViewModel.createRepo.ShortDesc = App.Current.Resources["createProfileShortDesc"].ToString();

                myCreatePreferencesViewModel.createRepo.GenderPref = genderPref;
                myCreatePreferencesViewModel.createRepo.MinAge = Convert.ToInt16(txtBoxCreateMinAgePref.Text);
                myCreatePreferencesViewModel.createRepo.MaxAge = Convert.ToInt16(txtBoxCreateMaxAgePref.Text);

                myCreatePreferencesViewModel.createRepo.createAccount();
                myCreatePreferencesViewModel.createRepo.createProfile();
                myCreatePreferencesViewModel.createRepo.createPreferences();

                Login login = new Login();
                login.Show();
                this.Close();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
    }
}
