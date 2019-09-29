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
    /// Interaction logic for ViewMatches.xaml
    /// </summary>
    public partial class ViewMatches : Window
    {
        public ViewMatches()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            myViewMatchesViewModel.viewMatchesRepo.getMatchesInfo(App.Current.Resources["loginEmail"].ToString());
            lsbMatches.ItemsSource = myViewMatchesViewModel.viewMatchesRepo.theirFullNames;
        }
        private void txtBoxSendMessage_TextInput(object sender, TextCompositionEventArgs e) { }
        private void btnFindMatches_Click(object sender, RoutedEventArgs e)
        {
            FindMatches findMatches = new FindMatches();
            findMatches.Show();
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
        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            if (lsbMatches.SelectedIndex < 0)
            {
                MessageBox.Show("You need to select a match before you can send a message");
                return;
            }
            int matchIndex = lsbMatches.SelectedIndex;
            myViewMatchesViewModel.viewMatchesRepo.sendMessage(matchIndex, txtBoxSendMessage.Text);
            myViewMatchesViewModel.viewMatchesRepo.getMessages(matchIndex);
            txtBoxSendMessage.Clear();
        }

        private void lsbMatches_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int matchIndex = lsbMatches.SelectedIndex;
            myViewMatchesViewModel.viewMatchesRepo.getMessages(matchIndex);
        }
    }
}
