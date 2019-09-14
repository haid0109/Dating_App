using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2019_9_3_Dating_app_XAML_.Assets;

namespace _2019_9_3_Dating_app_XAML_.Models.DBA
{
    class LoginRepo : Base
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(Email);
            }
        }
        private string password;
        public string Password 
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(Password);
            }
        }
        public bool login(string email, string password)
        {
            SQLiteConnection Con = new SQLiteConnection(sqlCon);
            Con.Open();
            SQLiteCommand SqlCmd = new SQLiteCommand("SELECT * FROM Users WHERE email = '" + email + "' and [Password] = '" + password + "'", Con);

            SQLiteDataAdapter SqlDA = new SQLiteDataAdapter(SqlCmd);
            DataTable DT = new DataTable();
            SqlDA.Fill(DT);
            Con.Close();
            if (DT.Rows.Count > 0) { return true; }
            else { return false; }
        }
    }
}
