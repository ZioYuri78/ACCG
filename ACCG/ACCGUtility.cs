using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    public static class ACCGUtility
    {

        public static bool IsDigit(string _text)
        {
            foreach (char digit in _text)
            {
                if (digit < '0' | digit > '9')
                {
                    return false;

                }
            }

            return true;
        }

        public static bool IsDigit(string _text, char _exclude)
        {
            foreach (char digit in _text)
            {
                if (digit < '0' | digit > '9' && digit != _exclude)
                {
                    return false;

                }
            }

            return true;
        }

        public static Image ScaleImage(Image _image, int _maxWidth, int _maxHeight)
        {

            var ratioX = (double)_maxWidth / _image.Width;
            var ratioY = (double)_maxHeight / _image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(_image.Width * ratio);
            var newHeight = (int)(_image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(_image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        public static double LapTimeToMilliseconds(double _minutes, double _seconds)
        {            
            double timeInMilliseconds = TimeSpan.FromMinutes(_minutes).TotalMilliseconds + TimeSpan.FromSeconds(_seconds).TotalMilliseconds;

            return timeInMilliseconds;
        }

        public static TimeSpan MillisecondsToLapTime(double _milliseconds)
        {
            TimeSpan ts = TimeSpan.FromMilliseconds(_milliseconds);

            return ts;
        }

        public static Event RandomizeEvent(Event _event, bool _single_event)
        {
            Random rnd = new Random();
            _event.session_list = new List<Session>();

            // Common events attributes
            _event.ambient_temperature = rnd.Next(10, 37);
            _event.time = rnd.Next(-80, 81);
            _event.track = ACCGMainForm.ac_tracks_list[rnd.Next(0, ACCGMainForm.ac_tracks_list.Count)];
            _event.dynamic_track_preset = rnd.Next(0, 6);            

            if (_single_event)
            {
                int rnd_car_model = rnd.Next(0, ACCGMainForm.ac_cars_list.Count);
                _event.event_car = ACCGMainForm.ac_cars_list[rnd_car_model];

                int rnd_skin_model = rnd.Next(0, _event.event_car.skins.Count);
                _event.event_car_skin = _event.event_car.skins[rnd_skin_model];

                // 1 == Quick Race, 2 == Time Attack, 3 == Hotlap
                int rnd_event_kind = rnd.Next(1, 4);

                switch (rnd_event_kind)
                {
                    case 1:
                        Console.WriteLine("DEBUG: Quick Race");
                        // Quick Race attributes
                        _event.isQuickRace = true;
                        int rnd_practice = rnd.Next(0, 2);
                        int rnd_qualifying = rnd.Next(0, 2);
                
                        if (rnd_practice == 1)
                        {
                            Session practice = new Session();
                            practice.name = "Practice";                    
                            practice.duration_minutes = rnd.Next(5, 91);                    
                            _event.session_list.Add(practice);
                        }

                        if (rnd_qualifying == 1)
                        {
                            Session qualifying = new Session();
                            qualifying.name = "Qualifying";
                            qualifying.duration_minutes = rnd.Next(5, 61);
                            _event.session_list.Add(qualifying);
                        }

                        _event.numberOfCars = rnd.Next(2, 25);
                        _event.numberOfLaps = rnd.Next(2, 11);
                        _event.start_position = rnd.Next(1, 11);
                        _event.event_goals.tier_3 = rnd.Next(1, 4).ToString();
                        _event.event_goals.tier_2 = rnd.Next(4, 6).ToString();
                        _event.event_goals.tier_1 = rnd.Next(6, 9).ToString();
                        break;

                    case 2:
                        Console.WriteLine("DEBUG: Time Attack");
                        // Time Attack attributes
                        _event.isTimeAttack = true;
                        _event.event_goals.tier_3 = rnd.Next(3000, 5001).ToString();
                        _event.event_goals.tier_2 = rnd.Next(1500, 3000).ToString();
                        _event.event_goals.tier_1 = rnd.Next(500, 1500).ToString();
                        break;

                    case 3:
                        Console.WriteLine("DEBUG: Hotlap");
                        // Hotlap attributes
                        _event.isHotlap = true;
                        _event.event_goals.tier_3 = rnd.Next(60000, 100000).ToString();
                        _event.event_goals.tier_2 = rnd.Next(100000, 130000).ToString();
                        _event.event_goals.tier_1 = rnd.Next(130000, 180000).ToString();
                        break;
                }

            }
            else 
            {
                int rnd_practice = rnd.Next(0, 2);
                int rnd_qualifying = rnd.Next(0, 2);
                
                if (rnd_practice == 1)
                {
                    Session practice = new Session();
                    practice.name = "Practice";                    
                    practice.duration_minutes = rnd.Next(5, 91);                    
                    _event.session_list.Add(practice);
                }

                if (rnd_qualifying == 1)
                {
                    Session qualifying = new Session();
                    qualifying.name = "Qualifying";
                    qualifying.duration_minutes = rnd.Next(5, 61);
                    _event.session_list.Add(qualifying);
                }

                Session race = new Session();
                race.name = "Race";
                race.laps = rnd.Next(2, 11);
                _event.numberOfLaps = rnd.Next(2, 11);    
                _event.numberOfCars = rnd.Next(2, 25);                                
                
            }                        
                                    
            return _event;
        }


        private static String RemoveDiacritics(String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }

        public static void RemoveDiacritics(Series _series = null, Event _event = null)
        {
            if (_series != null)
            {
                _series.code = RemoveDiacritics(_series.code);
                _series.name = RemoveDiacritics(_series.name);
                _series.description = RemoveDiacritics(_series.description);                
            }

            if (_event != null)
            {
                _event.name = RemoveDiacritics(_event.name);
                _event.description = RemoveDiacritics(_event.description);
            }
        }

    }
}
