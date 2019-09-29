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
    class ViewMatchesRepo : Base
    {
        private string myProfileID;
        private string myFirstName;

        private List<string> matchesProfileIDs = new List<string>();
        public List<string> theirFullNames = new List<string>();

        private void getMyLikedMatches(string email)
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();

            SQLiteCommand SqlCmd = new SQLiteCommand(
            "SELECT * FROM Users " +
            "INNER JOIN Profiles ON Users.userID = Profiles.userID " +
            "WHERE Users.email = '" + email + "' ", Con);

            SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(SqlCmd);
            DataTable DT = new DataTable();
            SqlDA.Fill(DT);
            DataRow row = DT.Rows[0];
            myProfileID = row[3].ToString();
            myFirstName = row[4].ToString();

            SqlCmd = new SQLiteCommand(
            "SELECT * FROM Liked " +
            "WHERE Liked.profileID = " + myProfileID + " " +
            "AND Liked.liked = 1 ", Con);

            SqlDA = new SQLiteDataAdapter(SqlCmd);
            DT = new DataTable();
            SqlDA.Fill(DT);
            SQLiteCommand SqlCmd2;
            SQLiteDataAdapter SqlDA2;
            DataTable DT2;

            foreach (DataRow dr in DT.Rows)
            {
                SqlCmd2 = new SQLiteCommand(
                "SELECT * FROM Liked " +
                "WHERE Liked.profileID = " + dr[2].ToString() + " " +
                "AND Liked.shownProfileID = " + myProfileID + " " +
                "AND Liked.liked = 1 ", Con);

                SqlDA2 = new SQLiteDataAdapter(SqlCmd2);
                DT2 = new DataTable();
                SqlDA2.Fill(DT2);
                foreach(DataRow dr2 in DT2.Rows) { matchesProfileIDs.Add(dr2[1].ToString()); }
            }
            Con.Close();
        }
        public void getMatchesInfo(string email)
        {
            getMyLikedMatches(email);
            SQLiteConnection Con;
            SQLiteCommand SqlCmd;
            SQLiteDataAdapter SqlDA;
            DataTable DT;
            DataRow row;

            foreach (string ID in matchesProfileIDs)
            {
                Con = new SQLiteConnection(sqlCon);
                Con.Open();

                SqlCmd = new SQLiteCommand(
                "SELECT * FROM Profiles " +
                "WHERE profileID = '" + ID + "' ", Con);

                SqlDA = new SQLiteDataAdapter(SqlCmd);
                DT = new DataTable();
                SqlDA.Fill(DT);
                row = DT.Rows[0];
                theirFullNames.Add(row[1].ToString() + " " + row[2].ToString());
                Con.Close();
            }
        }
        public string getMessages(int matchIndex)
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();

            SQLiteCommand SqlCmd = new SQLiteCommand(
            "SELECT * FROM Profiles " +
            "WHERE profileID = " + matchesProfileIDs[matchIndex] + " ", Con);

            SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(SqlCmd);
            DataTable DT = new DataTable();
            SqlDA.Fill(DT);
            DataRow row = DT.Rows[0];
            string theirFirstName = row[1].ToString();

            SqlCmd = new SQLiteCommand(
            "SELECT * FROM Messages " +
            "WHERE senderID = " + myProfileID + " " +
            "AND receiverID = " + matchesProfileIDs[matchIndex] + " " +
            "OR senderID = " + matchesProfileIDs[matchIndex] + " " +
            "AND receiverID = " + myProfileID + " " +
            "ORDER BY date ASC", Con);

            SqlDA = new SQLiteDataAdapter(SqlCmd);
            DT = new DataTable();
            SqlDA.Fill(DT);
            string allMessages = "";

            foreach (DataRow row2 in DT.Rows)
            {
                if(row[1].ToString() == myProfileID) { allMessages += myFirstName + ": " + row[3].ToString() + "\n"; }
                else { allMessages += theirFirstName + ": " + row[3].ToString() + "\n"; }
            }
            
            Con.Close();
            return allMessages;
        }
        public void sendMessage(int matchIndex, string message)
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();

            SQLiteCommand SqlCmd = new SQLiteCommand(
            "INSERT INTO Messages ([senderID], [receiverID], [message]) " +
            "VALUES (" + myProfileID + ", " + matchesProfileIDs[matchIndex] + ", '" + message + "') ", Con);

            SqlCmd.ExecuteNonQuery();
            Con.Close();
            getMessages(matchIndex);
        }
    }
}
