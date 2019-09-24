using _2019_9_3_Dating_app_XAML_.Assets;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_9_3_Dating_app_XAML_.Models.DBA
{
    class SettingsRepo : Base
    {
        public void createProfile(string email, string newEmail, string password)
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();
            SQLiteCommand SqlCmd = new SQLiteCommand("UPDATE Users " +
                                                     "SET email = '" + newEmail + "'," +
                                                     "password = '" + password + "'" +
                                                     "WHERE email = '" + email + "'", Con);

            SqlCmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
