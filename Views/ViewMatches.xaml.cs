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

        private void lsbMatches_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int person = lsbMatches.SelectedIndex;
            MessageBox.Show(person.ToString());
        }
    }
}
