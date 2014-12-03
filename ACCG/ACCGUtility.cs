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

        public static double LapTimeToMilliseconds(double minutes, double seconds)
        {            
            double timeInMilliseconds = TimeSpan.FromMinutes(minutes).TotalMilliseconds + TimeSpan.FromSeconds(seconds).TotalMilliseconds;

            return timeInMilliseconds;
        }

        public static TimeSpan MillisecondsToLapTime(double milliseconds)
        {
            TimeSpan ts = TimeSpan.FromMilliseconds(milliseconds);

            return ts;
        }

        public static Event RandomizeEvent(Event _event)
        {
            Random rnd = new Random();

            // Common events attributes
            _event.ambient_temperature = rnd.Next(10, 36);
            _event.time = rnd.Next(-80, 80);
            _event.track = ACCGMainForm.ac_tracks_list[rnd.Next(0, ACCGMainForm.ac_tracks_list.Count)];
            _event.dynamic_track_preset = rnd.Next(0, 5);
            
            int rnd_car_model = rnd.Next(0, ACCGMainForm.ac_cars_list.Count);
            _event.event_car = ACCGMainForm.ac_cars_list[rnd_car_model];

            int rnd_skin_model = rnd.Next(0, _event.event_car.skins.Count);
            _event.event_car_skin = _event.event_car.skins[rnd_skin_model];

            // 1 == Quick Race, 2 == Time Attack, 3 == Hotlap
            int rnd_event_kind = rnd.Next(1, 3);

            switch (rnd_event_kind)
            {
                case 1:
                    // Quick Race attributes
                    _event.isQuickRace = true;
                    _event.numberOfCars = rnd.Next(2, 24);
                    _event.numberOfLaps = rnd.Next(2, 10);
                    _event.start_position = rnd.Next(1, 10);
                    _event.event_goals.tier_3 = rnd.Next(1, 3).ToString();
                    _event.event_goals.tier_2 = rnd.Next(3, 5).ToString();
                    _event.event_goals.tier_1 = rnd.Next(5, 7).ToString();
                    break;

                case 2:
                    // Time Attack attributes
                    _event.isTimeAttack = true;
                    _event.event_goals.tier_3 = rnd.Next(2000, 3000).ToString();
                    _event.event_goals.tier_2 = rnd.Next(1000, 1999).ToString();
                    _event.event_goals.tier_1 = rnd.Next(100, 999).ToString();
                    break;

                case 3:
                    // Hotlap attributes
                    _event.isHotlap = true;
                    //int rnd_hl_gold_tier = rnd.Next(, );
                    //int rnd_hl_gold_tier = rnd.Next(, );
                    //int rnd_hl_gold_tier = rnd.Next(, );
                    break;
            }
            
                                    
            return _event;
        }


    }
}
