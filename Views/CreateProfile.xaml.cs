using Microsoft.Win32;
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
        public CreateProfile() { InitializeComponent(); WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen; }
        private void TxtBoxCreateBirthdayDay_TextChanged(object sender, TextChangedEventArgs e) { }
        private void TxtBoxCreateFirstNameProf_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateLastNameProf_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateGenderProf_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateBirthDay_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateBirthMonth_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateBirthYear_TextInput(object sender, TextCompositionEventArgs e) { }
        private void TxtBoxCreateShortDescProf_TextInput(object sender, TextCompositionEventArgs e) { }
        private void CmbBoxCreateGenderProf_TextInput(object sender, TextCompositionEventArgs e) { }

        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog browseImage = new OpenFileDialog();
            browseImage.Filter = "Image files (*.jpg,*.jpeg,*.jpe,*.jfif,*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png";

            if (browseImage.ShowDialog() == true)
            {
                imgProfilePicture.Source = new BitmapImage(new Uri(browseImage.FileName));
            }
        }
        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Close();
        }
        private void BtnCreateProfile_Click(object sender, RoutedEventArgs e)
        {
            #region checks the persons gender
            string genderProf = "";
            if (cmbBoxCreateGenderProf.Text == "Male") { genderProf = "M"; }
            else if (cmbBoxCreateGenderProf.Text == "Female") { genderProf = "F"; }
            else if (cmbBoxCreateGenderProf.Text == "Other") { genderProf = "O"; }
            else
            {
                MessageBox.Show("You need to choose a gender.");
                return;
            }
            #endregion
            #region checks if birthdate is in correct format, and calculates the age from birthdate
            int birthdateNum;
            if (Int32.TryParse(txtBoxCreateBirthYear.Text + txtBoxCreateBirthMonth.Text + txtBoxCreateBirthDay.Text, out birthdateNum))
            {
                birthdateNum = (Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")) - Int32.Parse(txtBoxCreateBirthYear.Text + string.Format("{0:D2}", Int32.Parse(txtBoxCreateBirthMonth.Text)) + string.Format("{0:D2}", Int32.Parse(txtBoxCreateBirthDay.Text)))) / 10000;
            }
            else
            {
                MessageBox.Show("Your birthdate is not in the right format.");
                return;
            }
            #endregion
            #region checks if the person is too young or too old
            if (birthdateNum < 18)
            {
                MessageBox.Show("You are too young to use this dating app.");
                return;
            }
            else if (birthdateNum > 125)
            {
                MessageBox.Show("You are too old to use this dating app.");
                return;
            }
            #endregion
            #region saves the input data, and opens preferences window
            try
            {
                App.Current.Resources["createProfileFirstName"] = txtBoxCreateFirstNameProf.Text;
                App.Current.Resources["createProfileLastName"] = txtBoxCreateLastNameProf.Text;
                App.Current.Resources["createProfileGender"] = genderProf;
                App.Current.Resources["createProfileBirthdate"] = txtBoxCreateBirthYear.Text + "-" +
                                                                  string.Format("{0:D2}", Int32.Parse(txtBoxCreateBirthMonth.Text)) + "-" +
                                                                  string.Format("{0:D2}", Int32.Parse(txtBoxCreateBirthDay.Text));
                App.Current.Resources["createProfileShortDesc"] = txtBoxCreateShortDescProf.Text;

                CreatePreference createPreferences = new CreatePreference();
                createPreferences.Show();
                this.Close();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
            #endregion
        }
    }
}
