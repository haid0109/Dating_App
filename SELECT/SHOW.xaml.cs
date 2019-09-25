using _2019_9_3_Dating_app_XAML_.Assets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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

namespace _2019_9_3_Dating_app_XAML_.SELECT
{
    /// <summary>
    /// Interaction logic for SHOW.xaml
    /// </summary>
    public partial class SHOW : Window
    {
        public SHOW()
        {
            InitializeComponent();
        }
        private int anumber = 0;

        private void getData_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(anumber.ToString());
            //anumber++;
            //SQLiteConnection Con = new SQLiteConnection(@"Data Source=..\..\Database\dating_app.db;Version=3");
            //Con.Open();
            //SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(
            //"SELECT * FROM Users " +
            //"INNER JOIN Profiles ON Users.userID = Profiles.userID " +
            //"INNER JOIN Preferences ON Profiles.profileID = Preferences.profileID " +
            //"INNER JOIN Ages ON Profiles.profileID = Ages.profileID " +
            //"LEFT JOIN Liked ON Liked.profileID = 1 " +
            //"AND Profiles.profileID = Liked.shownProfileID " +
            //"WHERE Profiles.gender = 'F' " +
            //"AND Ages.age >= 18 " +
            //"AND Ages.age <= 20 " +
            //"AND Preferences.gender = 'M' " +
            //"AND Preferences.minAge <= 18 " +
            //"AND Preferences.maxAge >= 18 " +
            //"AND Liked.profileID IS NULL ", Con);
            //DataTable DT = new DataTable();
            //SqlDA.Fill(DT);
            //DataRow row;
            //if(DT.Rows[0] == null)
            //{
            //    MessageBox.Show("den er null");
            //}
            //dataGrid.ItemsSource = DT.DefaultView;
            //Con.Close();

            SQLiteConnection Con = new SQLiteConnection(@"Data Source=..\..\Database\dating_app.db;Version=3");
            Con.Open();
            SQLiteCommand SqlCmd = new SQLiteCommand("UPDATE Users, Profiles " +
                                                     "SET shortDesc = 'ddd'" +
                                                     "WHERE email = '1'", Con);

            SqlCmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
