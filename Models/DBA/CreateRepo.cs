using _2019_9_3_Dating_app_XAML_.Assets;
using _2019_9_3_Dating_app_XAML_.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_9_3_Dating_app_XAML_.Models.DBA
{
    class CreateRepo : Base
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                OnPropertyChanged("Gender");
            }
        }

        private string birthdate;
        public string Birthdate
        {
            get { return birthdate; }
            set
            {
                birthdate = value;
                OnPropertyChanged("Birthdate");
            }
        }

        private string shortDesc;
        public string ShortDesc
        {
            get { return shortDesc; }
            set
            {
                shortDesc = value;
                OnPropertyChanged("ShortDesc");
            }
        }

        private string profilePicPath;
        public string ProfilePicPath
        {
            get { return profilePicPath; }
            set
            {
                profilePicPath = value;
                OnPropertyChanged("ProfilePicPath");
            }
        }

        private string genderPref;
        public string GenderPref
        {
            get { return genderPref; }
            set
            {
                genderPref = value;
                OnPropertyChanged("GenderPref");
            }
        }

        private int minAge;
        public int MinAge
        {
            get { return minAge; }
            set
            {
                minAge = value;
                OnPropertyChanged("MinAge");
            }
        }

        private int maxAge;
        public int MaxAge
        {
            get { return maxAge; }
            set
            {
                maxAge = value;
                OnPropertyChanged("MaxAge");
            }
        }

        public void createAccount()
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();

            //How you should do it:
            //SqlCommand SqlCmd = new SqlCommand("INSERT INTO Users([email], [password]) VALUES(@email, @password)", Con);
            //SqlCmd.Parameters.Add("@email", email);
            //https://stackoverflow.com/questions/625029/how-do-i-store-and-retrieve-a-blob-from-sqlite

            SQLiteCommand SqlCmd = new SQLiteCommand("INSERT INTO Users([email], [password]) VALUES('" + Email + "', '" + Password + "')", Con);

            SqlCmd.ExecuteNonQuery();
            Con.Close();
        }

        private string profileFKInsert()
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();
            SQLiteCommand SqlCmd = new SQLiteCommand("SELECT * FROM Users WHERE email = '" + email + "'", Con);

            SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(SqlCmd);
            DataTable DT = new DataTable();
            SqlDA.Fill(DT);
            DataRow row = DT.Rows[0];
            Con.Close();
            return row[0].ToString();
        }

        public void createProfile()
        {
            ProfilePicConverter PPC = new ProfilePicConverter();
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();

            SQLiteCommand SqlCmd = new SQLiteCommand(
            "INSERT INTO Profiles([firstName], [lastName], [gender], [birthdate], [shortDesc], [profilePicture], [userID]) " +
            "VALUES(@firstName, @lastName, @gender, @birthdate, @shortDesc, @profilePicture, @userID)", Con);

            SqlCmd.Parameters.AddWithValue("@firstName", firstName);
            SqlCmd.Parameters.AddWithValue("@lastName", lastName);
            SqlCmd.Parameters.AddWithValue("@gender", gender);
            SqlCmd.Parameters.AddWithValue("@birthdate", birthdate);
            SqlCmd.Parameters.AddWithValue("@shortDesc", shortDesc);
            SqlCmd.Parameters.Add("@profilePicture", DbType.Binary, PPC.imageToByteArray(profilePicPath).Length);
            SqlCmd.Parameters.AddWithValue("@profilePicture", PPC.imageToByteArray(profilePicPath));
            SqlCmd.Parameters.AddWithValue("@userID", profileFKInsert());

            SqlCmd.ExecuteNonQuery();
            Con.Close();
        }

        private string preferencesFKInsert()
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();
            SQLiteCommand SqlCmd = new SQLiteCommand("SELECT * FROM Users WHERE email = '" + email + "'", Con);

            SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(SqlCmd);
            DataTable DT = new DataTable();
            SqlDA.Fill(DT);
            DataRow row = DT.Rows[0];

            string userID = row[0].ToString();
            SqlCmd = new SQLiteCommand("SELECT * FROM Profiles WHERE userID = '" + userID + "'", Con);

            SqlDA = new SQLiteDataAdapter(SqlCmd);
            DT = new DataTable();
            SqlDA.Fill(DT);
            row = DT.Rows[0];
            Con.Close();
            return row[0].ToString();
        }

        public void createPreferences()
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();
            SQLiteCommand SqlCmd = new SQLiteCommand("INSERT INTO Preferences([gender], [minAge], [maxAge], [profileID]) " +
                                                     "VALUES ('" + genderPref + "', '" + minAge + "', '" + maxAge + "', '" + preferencesFKInsert() + "')", Con);

            SqlCmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
