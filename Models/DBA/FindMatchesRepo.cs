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
        private string myProfileID { get; set; }
        private string myGender { get; set; }
        private string myAge { get; set; }
        private string myPrefGender { get; set; }
        private string myPrefMinAge { get; set; }
        private string myPrefMaxAge { get; set; }

        public string theirProfileID { get; set; }
        public string theirFirstname { get; set; }
        public string theirLastname { get; set; }
        public string theirShortDesc { get; set; }
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
            myAge = row[16].ToString();
            myPrefGender = row[12].ToString();
            myPrefMinAge = row[13].ToString();
            myPrefMaxAge = row[14].ToString();
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
            "LEFT JOIN Liked ON Liked.profileID = " + myProfileID + " " +
            "AND Profiles.profileID = Liked.shownProfileID " +
            "WHERE Profiles.gender = '" + myPrefGender + "' " +
            "AND Ages.age >= " + myPrefMinAge + " " +
            "AND Ages.age <= " + myPrefMaxAge + " " +
            "AND Preferences.gender = '" + myGender + "' " +
            "AND Preferences.minAge <= " + myAge + " " +
            "AND Preferences.maxAge >= " + myAge + " " +
            "AND Liked.profileID IS NULL ", Con);

            SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(SqlCmd);
            DataTable DT = new DataTable();
            SqlDA.Fill(DT);
            DataRow row = DT.Rows[0];

            theirProfileID = row[3].ToString();
            theirFirstname = row[4].ToString();
            theirLastname = row[5].ToString();
            theirShortDesc = row[8].ToString();
            theirAge = row[16].ToString();

            Con.Close();
        }
        public void likeDislike(bool like_dislike)
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();
            SQLiteCommand SqlCmd;
            if(theirProfileID == null) {}
            else
            {
                if (like_dislike)
                {
                    SqlCmd = new SQLiteCommand("INSERT INTO Liked([profileID], [shownProfileID], [liked]) " +
                                               "VALUES('" + myProfileID + "', '" + theirProfileID + "', 1)", Con);
                }
                else
                {
                    SqlCmd = new SQLiteCommand("INSERT INTO Liked([profileID], [shownProfileID], [liked]) " +
                                               "VALUES('" + myProfileID + "', '" + theirProfileID + "', 0)", Con);
                }
                SqlCmd.ExecuteNonQuery();
            }
            Con.Close();
        }
    }
}
