using _2019_9_3_Dating_app_XAML_.Assets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _2019_9_3_Dating_app_XAML_.Models.DBA
{
    class FindMatchesRepo : Base
    {
        public string myProfileID { get; set; }
        public string myGender { get; set; }
        public string myAge { get; set; }
        public string myPrefGender { get; set; }
        public string myPrefMinAge { get; set; }
        public string myPrefMaxAge { get; set; }

        public string theirProfileID { get; set; }
        public string theirAge { get; set; }

        private void findMe(string email)
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();

            SQLiteCommand SqlCmd = new SQLiteCommand(
            "SELECT * FROM Users " +
            "INNER JOIN Profiles ON Users.userID = Profiles.userID " +
            "INNER JOIN Preferences ON Profiles.profileID = Preferences.profileID " +
            "INNER JOIN Ages ON Profiles.profileID = Ages.profileID " +
            "LEFT JOIN Liked ON Profiles.profileID = Liked.profileID " +
            "OR Profiles.profileID = Liked.shownProfileID " +                                         
            "WHERE Users.email = '" + email + "' ", Con);

            SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(SqlCmd);
            DataTable DT = new DataTable();
            SqlDA.Fill(DT);
            DataRow row = DT.Rows[0];
            Con.Close();

            myProfileID = row[3].ToString();
            myGender = row[6].ToString();
            myAge = row[15].ToString();
            myPrefGender = row[11].ToString();
            myPrefMinAge = row[12].ToString();
            myPrefMaxAge = row[13].ToString();
        }

        public void findThem(string email)
        {
            findMe(email);
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();

            SQLiteCommand SqlCmd = new SQLiteCommand(
            "SELECT * FROM Users " +
            "INNER JOIN Profiles ON Users.userID = Profiles.userID " +
            "INNER JOIN Preferences ON Profiles.profileID = Preferences.profileID " +
            "INNER JOIN Ages ON Profiles.profileID = Ages.profileID " +
            "LEFT JOIN Liked ON Profiles.profileID = Liked.profileID " +
            "OR Profiles.profileID = Liked.shownProfileID " +
            "WHERE Profiles.gender = '" + myPrefGender + "' " +
            "AND Ages.age >= " + myPrefMinAge + " " +
            "AND Ages.age <= " + myPrefMaxAge + " " +
            "AND Preferences.gender = '" + myGender + "' " +
            "AND Preferences.minAge <= " + myAge + " " +
            "AND Preferences.maxAge >= " + myAge + " ", Con);

            SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(SqlCmd);
            DataTable DT = new DataTable();
            SqlDA.Fill(DT);
            DataRow row = DT.Rows[0];
            Con.Close();

            theirProfileID = row[3].ToString();
            theirAge = row[15].ToString();
        }
    }
}
