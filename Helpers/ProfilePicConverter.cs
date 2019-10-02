using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_9_3_Dating_app_XAML_.Helpers
{
    class ProfilePicConverter
    {
        protected byte[] imageToByteArray(Image profilePic)
        {
            MemoryStream mryStr = new MemoryStream();
            profilePic.Save(mryStr, System.Drawing.Imaging.ImageFormat.Gif);
            return mryStr.ToArray();
        }

        protected Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
