using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    public static class ACCGUtility
    {

        public static bool IsDigit(string text)
        {
            foreach (char digit in text)
            {
                if (digit < '0' | digit > '9')
                {
                    return false;

                }
            }

            return true;
        }

        public static bool IsDigit(string text, char exclude)
        {
            foreach (char digit in text)
            {
                if (digit < '0' | digit > '9' && digit != exclude)
                {
                    return false;

                }
            }

            return true;
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {

            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        public static double TimeToMilliseconds(double minutes, double seconds)
        {            
            double timeInMilliseconds = TimeSpan.FromMinutes(minutes).TotalMilliseconds + TimeSpan.FromSeconds(seconds).TotalMilliseconds;

            return timeInMilliseconds;
        }
    }
}
