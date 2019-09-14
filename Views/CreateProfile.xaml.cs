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
    /// Interaction logic for CreateProfile.xaml
    /// </summary>
    public partial class CreateProfile : Window
    {
        public CreateProfile() { InitializeComponent(); }
        private void TxtBoxCreateBirthdayDay_TextChanged(object sender, TextChangedEventArgs e) { }
        private void TxtBoxCreateFirstNameProf_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateLastNameProf_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateGenderProf_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateBirthDay_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateBirthMonth_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateBirthYear_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateShortDescProf_TextInput(object sender, TextCompositionEventArgs e) { }
        private void CmbBoxCreateGenderProf_TextInput(object sender, TextCompositionEventArgs e) { }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Close();
        }

        private void BtnCreateProfile_Click(object sender, RoutedEventArgs e)
        {
            string genderProf = "";
            if (cmbBoxCreateGenderProf.Text == "Male") { genderProf = "M"; }
            else if (cmbBoxCreateGenderProf.Text == "Female") { genderProf = "F"; }
            else if (cmbBoxCreateGenderProf.Text == "Other") { genderProf = "O"; }
            else
            {
                MessageBox.Show("You need to choose a gender.");
                return;
            }

            try
            {
                App.Current.Resources["createProfileFirstName"] = txtBoxCreateFirstNameProf.Text;
                App.Current.Resources["createProfileLastName"] = txtBoxCreateLastNameProf.Text;
                App.Current.Resources["createProfileGender"] = genderProf;
                App.Current.Resources["createProfileBirthdate"] = txtBoxCreateBirthYear.Text + "-" + 
                                                                  txtBoxCreateBirthMonth.Text + "-" + 
                                                                  txtBoxCreateBirthDay.Text;
                App.Current.Resources["createProfileShortDesc"] = txtBoxCreateShortDescProf.Text;

                CreatePreference createPreferences = new CreatePreference();
                createPreferences.Show();
                this.Close();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
    }
}
