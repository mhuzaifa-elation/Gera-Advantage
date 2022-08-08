using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GeraAdvantage.Utils
{
    public static class UtilServices
    {

        // Converting Image to Base 64 string format
        public static ImageSource ConvertBase64TexttoImage(string Base64Text)
        {
            var bytes = Convert.FromBase64String(Base64Text);
            return ImageSource.FromStream(() => new MemoryStream(bytes));
        }


        // Converting Base 64 string to Image format
        public static async Task<string> ConvertImagetoBase64Text(FileResult photo)
        {
            
           var ImageStream = await photo.OpenReadAsync();
            byte[] data;
            var ImgMemoryStream = new MemoryStream();
            ImageStream.CopyTo(ImgMemoryStream);
            data = ImgMemoryStream.ToArray();
            return Convert.ToBase64String(data);
        }
    }
}
