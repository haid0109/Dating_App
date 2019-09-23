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
    /// Interaction logic for FindMatches.xaml
    /// </summary>
    public partial class FindMatches : Window
    {
        public FindMatches()
        {
            InitializeComponent();
            try
            {
                myFindMatchesViewModel.findMatchesRepo.findThem(App.Current.Resources["loginEmail"].ToString(), 0);
                MessageBox.Show(myFindMatchesViewModel.findMatchesRepo.theirFirstname + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirLastname + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirAge + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirShortDesc + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirProfileID);
            }
            catch (Exception)
            {
                MessageBox.Show("You have no more matches.");
            }
        }

        private void btnDislike_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myFindMatchesViewModel.findMatchesRepo.likeDislike(false);
                myFindMatchesViewModel.findMatchesRepo.findThem(App.Current.Resources["loginEmail"].ToString(), 0);
                MessageBox.Show(myFindMatchesViewModel.findMatchesRepo.theirFirstname + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirLastname + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirAge + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirShortDesc + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirProfileID);
            }
            catch (Exception)
            {
                MessageBox.Show("You have no more matches.");
                ViewMatches viewMatches = new ViewMatches();
                viewMatches.Show();
                this.Close();
            }
        }

        private void btnLike_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myFindMatchesViewModel.findMatchesRepo.likeDislike(true);
                myFindMatchesViewModel.findMatchesRepo.findThem(App.Current.Resources["loginEmail"].ToString(), 0);
                MessageBox.Show(myFindMatchesViewModel.findMatchesRepo.theirFirstname + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirLastname + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirAge + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirShortDesc + "\n" +
                                myFindMatchesViewModel.findMatchesRepo.theirProfileID);
            }
            catch (Exception)
            {
                MessageBox.Show("You have no more matches.");
                ViewMatches viewMatches = new ViewMatches();
                viewMatches.Show();
                this.Close();
            }
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
