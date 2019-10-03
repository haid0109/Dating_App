using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _2019_9_3_Dating_app_XAML_.Helpers
{
    class ProfilePicConverter
    {
        public Byte[] bitmapImageToByteArray(BitmapImage bitmapImage)
        {
            Stream stream = bitmapImage.StreamSource;
            Byte[] byteArray = null;
            using (BinaryReader binaryReader = new BinaryReader(stream))
            {
                byteArray = binaryReader.ReadBytes((Int32)stream.Length);
            }
            return byteArray;
        }

        public BitmapImage byteArrayToBitmapImage(Byte[] byteArray)
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
