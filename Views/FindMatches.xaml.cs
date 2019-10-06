using _2019_9_3_Dating_app_XAML_.ViewModels;
using _2019_9_3_Dating_app_XAML_.Helpers;
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
    /// Interaction logic for FindMatches.xaml
    /// </summary>
    public partial class FindMatches : Window
    {
        private string NameAge()
        {
            return myFindMatchesViewModel.findMatchesRepo.theirFirstname + " " +
                   myFindMatchesViewModel.findMatchesRepo.theirLastname + ", " +
                   myFindMatchesViewModel.findMatchesRepo.theirAge;
        }

        ProfilePicConverter PPC = new ProfilePicConverter();

        public FindMatches()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            try
            {
                myFindMatchesViewModel.findMatchesRepo.findThem(App.Current.Resources["loginEmail"].ToString());
                txtblNameAge.Text = NameAge();
                txtblShortDesc.Text = myFindMatchesViewModel.findMatchesRepo.theirShortDesc;
                imgProfilePicture.Source = PPC.byteArrayToBitmapImage(myFindMatchesViewModel.findMatchesRepo.theirProfilePicByteArray);
            }
            catch (Exception exc) { MessageBox.Show("You have no more matches."); }
        }

        private void btnViewMatches_Click(object sender, RoutedEventArgs e)
        {
            ViewMatches viewMatches = new ViewMatches();
            viewMatches.Show();
            this.Close();
        }
        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }
        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }


        private void btnDislike_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myFindMatchesViewModel.findMatchesRepo.likeDislike(false);
                myFindMatchesViewModel.findMatchesRepo.findThem(App.Current.Resources["loginEmail"].ToString());
                txtblNameAge.Text = NameAge();
                txtblShortDesc.Text = myFindMatchesViewModel.findMatchesRepo.theirShortDesc;
                imgProfilePicture.Source = PPC.byteArrayToBitmapImage(myFindMatchesViewModel.findMatchesRepo.theirProfilePicByteArray);
            }
            catch (Exception)
            {
                txtblNameAge.Text = null;
                txtblShortDesc.Text = null;
                imgProfilePicture.Source = null;
                MessageBox.Show("You have no more matches.");
            }
        }

        private void btnLike_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myFindMatchesViewModel.findMatchesRepo.likeDislike(true);
                myFindMatchesViewModel.findMatchesRepo.findThem(App.Current.Resources["loginEmail"].ToString());
                txtblNameAge.Text = NameAge();
                txtblShortDesc.Text = myFindMatchesViewModel.findMatchesRepo.theirShortDesc;
                imgProfilePicture.Source = PPC.byteArrayToBitmapImage(myFindMatchesViewModel.findMatchesRepo.theirProfilePicByteArray);
            }
            catch (Exception)
            {
                txtblNameAge.Text = null;
                txtblShortDesc.Text = null;
                imgProfilePicture.Source = null;
                MessageBox.Show("You have no more matches.");
            }
        }
    }
}
