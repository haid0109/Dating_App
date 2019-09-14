using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_9_3_Dating_app_XAML_.Assets
{
    public class Base : INotifyPropertyChanged
    {
        #region INotifyPropertyChange
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion //INotifyPropertyChanged
        protected string sqlCon = @"Data Source=.\dating_app.db;Version=3";
    }
}
