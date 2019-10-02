using _2019_9_3_Dating_app_XAML_.Assets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_9_3_Dating_app_XAML_.Models.DBA
{
    class SettingsRepo : Base
    {
        private string userID;
        private string profileID;
        private string preferenceID;

        public void getUserInfo(string email)
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();
            
            SQLiteCommand SqlCmd = new SQLiteCommand(
            "SELECT * FROM Users " +
            "INNER JOIN Profiles ON Users.userID = Profiles.userID " +
            "INNER JOIN Preferences ON Profiles.profileID = Preferences.profileID " +
            "WHERE Users.email = '" + email + "' ", Con);

            SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(SqlCmd);
            DataTable DT = new DataTable();
            SqlDA.Fill(DT);
            DataRow row = DT.Rows[0];
            Con.Close();

            userID = row[0].ToString();
            profileID = row[3].ToString();
            preferenceID = row[11].ToString();
        }

        public void updateEmail(string email)
        {
            if (email == "") { return; }
            else
            {
                SQLiteConnection Con = new SQLiteConnection(sqlCon);
                Con.Open();
                SQLiteCommand SqlCmd = new SQLiteCommand("UPDATE Users " +
                                                         "SET email = '" + email + "'" +
                                                         "WHERE userID = '" + userID + "'", Con);

                SqlCmd.ExecuteNonQuery();
                Con.Close();
            }
        }
        public void updatePassword(string password)
        {
            if (password == "") { return; }
            else
            {
                SQLiteConnection Con = new SQLiteConnection(sqlCon);
                Con.Open();
                SQLiteCommand SqlCmd = new SQLiteCommand("UPDATE Users " +
                                                         "SET password = '" + password + "'" +
                                                         "WHERE userID = '" + userID + "'", Con);

                SqlCmd.ExecuteNonQuery();
                Con.Close();
            }
        }

        public void updateShortDesc(string shortDesc)
        {
            if (shortDesc == "") { return; }
            else
            {
                SQLiteConnection Con = new SQLiteConnection(sqlCon);
                Con.Open();
                SQLiteCommand SqlCmd = new SQLiteCommand("UPDATE profiles " +
                                                         "SET shortDesc = '" + shortDesc + "'" +
                                                         "WHERE profileID = '" + profileID + "'", Con);

                SqlCmd.ExecuteNonQuery();
                Con.Close();
            }
        }

        public void updateGenderPref(string genderPref)
        {
            if (genderPref == "") { return; }
            else
            {
                SQLiteConnection Con = new SQLiteConnection(sqlCon);
                Con.Open();
                SQLiteCommand SqlCmd = new SQLiteCommand("UPDATE preferences " +
                                                         "SET gender = '" + genderPref + "'" +
                                                         "WHERE preferenceID = '" + preferenceID + "'", Con);

                SqlCmd.ExecuteNonQuery();
                Con.Close();
            }
        }
        public void updateMinAgePref(string minAgePref)
        {
            if (minAgePref == "") { return; }
            else
            {
                SQLiteConnection Con = new SQLiteConnection(sqlCon);
                Con.Open();
                SQLiteCommand SqlCmd = new SQLiteCommand("UPDATE preferences " +
                                                         "SET minAge = '" + minAgePref + "'" +
                                                         "WHERE preferenceID = '" + preferenceID + "'", Con);

                SqlCmd.ExecuteNonQuery();
                Con.Close();
            }
        }
        public void updateMaxAgePref(string maxAgePref)
        {
            if (maxAgePref == "") { return; }
            else
            {
                SQLiteConnection Con = new SQLiteConnection(sqlCon);
                Con.Open();
                SQLiteCommand SqlCmd = new SQLiteCommand("UPDATE preferences " +
                                                         "SET maxAge = '" + maxAgePref + "'" +
                                                         "WHERE preferenceID = '" + preferenceID + "'", Con);

                SqlCmd.ExecuteNonQuery();
                Con.Close();
            }
        }

        public void deleteAccount()
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();

            SQLiteCommand SqlCmd = new SQLiteCommand("DELETE FROM Liked " +
                                                     "WHERE profileID = '" + profileID + "' " +
                                                     "OR shownProfileID = '" + profileID + "' ", Con);
            SqlCmd.ExecuteNonQuery();

            SqlCmd = new SQLiteCommand("DELETE FROM Messages " +
                                       "WHERE senderID = '" + profileID + "' " +
                                       "OR receiverID = '" + profileID + "' ", Con);
            SqlCmd.ExecuteNonQuery();

            SqlCmd = new SQLiteCommand("DELETE FROM Preferences " +
                                       "WHERE preferenceID = '" + preferenceID + "' ", Con);
            SqlCmd.ExecuteNonQuery();

            SqlCmd = new SQLiteCommand("DELETE FROM Profiles " +
                                       "WHERE profileID = '" + profileID + "' ", Con);
            SqlCmd.ExecuteNonQuery();

            SqlCmd = new SQLiteCommand("DELETE FROM Users " +
                                       "WHERE userID = '" + userID + "' ", Con);
            SqlCmd.ExecuteNonQuery();

            Con.Close();
        }
    }
}
