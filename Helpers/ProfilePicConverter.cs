using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Drawing;

namespace _2019_9_3_Dating_app_XAML_.Helpers
{
    class ProfilePicConverter
    {
        public byte[] imageToByteArray(string ProfilePicPath)
        {
            Image profilePic = Image.FromFile(ProfilePicPath);
            ImageConverter imageConverter = new ImageConverter();
            byte[] byteArray = (byte[])imageConverter.ConvertTo(profilePic, typeof(byte[]));
            return byteArray;
        }

        public BitmapImage byteArrayToBitmapImage(byte[] byteArray)
        {
            MemoryStream mryStr = new MemoryStream(byteArray);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = mryStr;
            bitmapImage.EndInit();
            return bitmapImage;
        }
    }
}
