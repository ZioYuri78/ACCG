﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCG
{
    public class ACCGResourceManager
    {

        private static ACCGResourceManager instance = null;

        private ACCGResourceManager() { }

        public static ACCGResourceManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ACCGResourceManager();
            }

            return instance;
        }

        public void LoadSettings(string _settings_path)
        {
            try
            {
                if (File.Exists(_settings_path))
                {
                    using (StreamReader sr = new StreamReader(_settings_path))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string tmp = sr.ReadLine();

                            switch (tmp)
                            {
                                case "[AC_PATH]":
                                    ACCGMainForm.ac_path = sr.ReadLine();
                                    break;                                    

                                default:
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Missing file \"" + _settings_path + "\"!");                    
                    Application.Exit();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }
        }
       
        public List<Series> LoadACCGSeries(string _accg_series_path)
        {
            List<Series> series_list = new List<Series>();

            try
            {
                if (File.Exists(_accg_series_path))
                {

                    using (Stream stream = File.Open(_accg_series_path, FileMode.Open))
                    {
                        var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        series_list = (List<Series>)bformatter.Deserialize(stream);
                    }
                }
                else 
                {
                    Console.WriteLine("DEBUG: File not exist, will be create later");
                    series_list = new List<Series>();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }

            return series_list;
        }

        public void SaveACCGSeries(string _accg_series_path, List<Series> _accg_series_list)
        {
            try
            {
                using (Stream stream = File.Open(_accg_series_path, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, _accg_series_list);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }
        }

        public List<Car> LoadCars(string _file_path)
        {
            List<Car> cars_list = new List<Car>();
            string car_name;
            string trimmed_car_name;

            try
            {
                if (File.Exists(_file_path))
                {
                    using (StreamReader sr = new StreamReader(_file_path))
                    {
                        while (sr.Peek() >= 0)
                        {
                            car_name = sr.ReadLine();

                            if (car_name.Contains("[") && car_name != "[END_SKINS]")
                            {
                                trimmed_car_name = car_name.Trim(new Char[] { '[', ']' });

                                Car tmp_car = new Car();
                                tmp_car.model = trimmed_car_name;
                                cars_list.Add(tmp_car);

                                Skin tmp_skin = new Skin();
                                tmp_skin.skin_name = sr.ReadLine().ToLower();
                                string skin_image_path = ACCGMainForm.ac_path + @"\content\cars\" + tmp_car.model + @"\skins\" + tmp_skin.skin_name + @"\preview.jpg";
                                Console.WriteLine("DEBUG: " + skin_image_path);
                                
                                if (File.Exists(skin_image_path))
                                {
                                    using (var tempImage = Image.FromFile(skin_image_path))
                                    {
                                        Bitmap bmp = new Bitmap(170, 96);
                                        using (Graphics g = Graphics.FromImage(bmp))
                                        {
                                            g.DrawImage(tempImage, new Rectangle(0, 0, bmp.Width, bmp.Height));
                                        }
                                        tmp_skin.skin_preview = bmp;
                                    }                                    
                                    
                                }
                                else
                                {
                                    tmp_skin.skin_preview = ACCG.Properties.Resources.placeholder;
                                }
                                
                                while (tmp_skin.skin_name.ToUpper() != "[END_SKINS]")
                                {
                                    tmp_car.skins.Add(tmp_skin);
                                    tmp_skin = new Skin();
                                    tmp_skin.skin_name = sr.ReadLine().ToLower();
                                    skin_image_path = ACCGMainForm.ac_path + @"\content\cars\" + tmp_car.model + @"\skins\" + tmp_skin.skin_name + @"\preview.jpg";
                                    Console.WriteLine("DEBUG: " + skin_image_path);

                                    if (File.Exists(skin_image_path))
                                    {
                                        using (var tempImage = Image.FromFile(skin_image_path))
                                        {
                                            Bitmap bmp = new Bitmap(170, 96);
                                            using (Graphics g = Graphics.FromImage(bmp))
                                            {
                                                g.DrawImage(tempImage, new Rectangle(0, 0, bmp.Width, bmp.Height));
                                            }
                                            tmp_skin.skin_preview = bmp;
                                        }
                                        
                                    }
                                    else
                                    {
                                        tmp_skin.skin_preview = ACCG.Properties.Resources.placeholder;
                                    }

                                }
                            }
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Missing file \"" + _file_path + "\"!");                    
                    Application.Exit();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }

            return cars_list;
        }

        private void SaveCars(string _file_path, List<Car> _cars_list) 
        {
            try
            {
                StringBuilder new_file = new StringBuilder();

                if (File.Exists(_file_path))
                {
                    for (int i = 0; i < _cars_list.Count; i++)
                    {
                        Car temp_car = _cars_list[i];

                        new_file.Append("[" + temp_car.model + "]");
                        new_file.Append("\r\n");

                        for (int j = 0; j < temp_car.skins.Count; j++)
                        {
                            Skin temp_skin = new Skin();
                            temp_skin.skin_name = temp_car.skins[j].skin_name;

                            new_file.Append(temp_skin.skin_name);
                            new_file.Append("\r\n");
                        }

                        new_file.Append("[END_SKINS]");
                        new_file.Append("\r\n");
                        new_file.Append("\r\n");
                    }

                    File.WriteAllText(_file_path, new_file.ToString());
                }
                else
                {
                    MessageBox.Show("Missing file \"" + _file_path + "\"!");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }
        
        }

        public List<string> LoadTracks(string _file_path)
        {
            List<string> track_list = new List<string>();

            try
            {
                if (File.Exists(_file_path))
                {
                    using (StreamReader sr = new StreamReader(_file_path))
                    {
                        while (sr.Peek() >= 0)
                        {
                            track_list.Add(sr.ReadLine());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Missing file \"" + _file_path + "\"!");
                    Application.Exit();                    
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }

            return track_list;
        }

        private void SaveTracks(string _file_path, List<string> _tracks_list) 
        {
            try
            {
                StringBuilder new_file = new StringBuilder();

                if (File.Exists(_file_path))
                {
                    
                    for(int i = 0; i < _tracks_list.Count; i++){
                                                
                        new_file.Append(_tracks_list[i] + "\r\n");
                    }

                    File.WriteAllText(_file_path, new_file.ToString());
                }
                else
                {
                    MessageBox.Show("Missing file \"" + _file_path + "\"!");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }
        }

        public void Sync(string _cars_file_name, string _tracks_file_name) 
        {

            string ac_path = ACCGMainForm.ac_path;

            if (ACCGMainForm.ac_cars_list != null)
            {
                foreach (Car car in ACCGMainForm.ac_cars_list)
                {
                    foreach (Skin skin in car.skins)
                    {
                        skin.skin_preview.Dispose();
                    }
                }
            }

            
            try
            {
                // Sync the cars
                string ac_cars_path = ac_path + @"\content\cars";
                string[] ac_cars = Directory.GetDirectories(ac_cars_path, "*", SearchOption.TopDirectoryOnly);
                List<Car> temp_cars_list = new List<Car>();

                Car temp_car;

                foreach (string car in ac_cars)
                {
                    temp_car = new Car();
                    temp_car.model = car.Substring(car.LastIndexOf(@"\") + 1);

                    string car_skins_path = ac_cars_path + @"\" + temp_car.model + @"\skins";
                    string[] car_skins = Directory.GetDirectories(car_skins_path, "*", SearchOption.TopDirectoryOnly);

                    foreach (string skin in car_skins)
                    {
                        Skin temp_skin = new Skin();
                        temp_skin.skin_name = skin.Substring(skin.LastIndexOf(@"\") + 1);

                        if(File.Exists(skin + @"\preview.jpg")){
                            using (var tempImage = Image.FromFile(skin + @"\preview.jpg"))
                            {
                                Bitmap bmp = new Bitmap(170, 96);
                                using (Graphics g = Graphics.FromImage(bmp))
                                {
                                    g.DrawImage(tempImage, new Rectangle(0, 0, bmp.Width, bmp.Height));
                                }
                                temp_skin.skin_preview = bmp;
                            }
                            
                        }
                        else
                        {
                            temp_skin.skin_preview = ACCG.Properties.Resources.placeholder;
                        }
                        
                        temp_car.skins.Add(temp_skin);
                    }

                    temp_cars_list.Add(temp_car);
                }

                SaveCars(_cars_file_name, temp_cars_list);

                // Sync the tracks
                string ac_tracks_path = ac_path + @"\content\tracks";
                string[] ac_tracks = Directory.GetDirectories(ac_tracks_path, "*", SearchOption.TopDirectoryOnly);
                List<string> temp_tracks_list = new List<string>();

                foreach (string track in ac_tracks)
                {
                    temp_tracks_list.Add(track.Substring(track.LastIndexOf(@"\") + 1));
                }

                SaveTracks(_tracks_file_name, temp_tracks_list);
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }
                                      
        }

        public List<Opponent> LoadOpponents(string _file_path)
        {
            List<Opponent> temp_opponents_list = new List<Opponent>();

            string line;
           
            try
            {
                if (File.Exists(_file_path))
                {
                    using (StreamReader sr = new StreamReader(_file_path))
                    {
                        while (sr.Peek() >= 0)
                        {
                            line = sr.ReadLine();

                            if(line.Contains("[")) {
                                
                                Opponent temp_opponent = new Opponent();

                                string[] splitted = line.Split('I');
                                temp_opponent.ID = Convert.ToInt32(splitted[1].Trim(new Char[] { '[', ']' }));

                                line = sr.ReadLine();

                                while (line != "")
                                {
                                                                        
                                    splitted = line.Split('=');

                                    switch (splitted[0])
                                    {
                                        case "MODEL":                                            
                                            temp_opponent.model.model = splitted[1];
                                            break;

                                        case "SETUP":                                            
                                            temp_opponent.setup = splitted[1];
                                            break;

                                        case "AI_LEVEL":                                            
                                            temp_opponent.ai_level = Convert.ToInt32(splitted[1]);
                                            break;

                                        case "SKIN":                                            
                                            temp_opponent.skin.skin_name = splitted[1].ToLower();
                                            Car temp_car = ACCGMainForm.ac_cars_list.Find(x => x.model == temp_opponent.model.model);
                                            Bitmap temp_skin_preview = temp_car.skins.Find(x => x.skin_name == temp_opponent.skin.skin_name).skin_preview;
                                            temp_opponent.skin.skin_preview = temp_skin_preview;
                                            break;

                                        case "DRIVER_NAME":                                            
                                            temp_opponent.name = splitted[1];
                                            break;

                                        case "NATIONALITY":                                            
                                            temp_opponent.nationality = splitted[1];
                                            break;
                                    }

                                    line = sr.ReadLine();
                                    if (line == null) break;
                                }
                                
                                temp_opponents_list.Add(temp_opponent);
                            }
                            
                        }
                    }
                }
            }
            catch (Exception exc)
            {

                Console.WriteLine("The process failed: {0}", exc.ToString());
            }

            return temp_opponents_list;
        }

        public void SaveOpponents(List<Opponent> _opponents_list, string _file_path)
        {
            string[][] opponents_file_content = new string[_opponents_list.Count][];

            for (int i = 0; i < _opponents_list.Count; i++)
            {
                Opponent temp_opponent = _opponents_list[i];

                string[] temp_opponent_attributes = {
                                       String.Format("[AI{0}]",temp_opponent.ID),
                                       "MODEL=" + temp_opponent.model.model,
                                       "SETUP=" + temp_opponent.setup,
                                       "AI_LEVEL=" + temp_opponent.ai_level.ToString(),
                                       "SKIN=" + temp_opponent.skin.skin_name,
                                       "DRIVER_NAME=" + temp_opponent.name,
                                       "NATIONALITY=" + temp_opponent.nationality,
                                       ""
                                   };

                opponents_file_content[i] = temp_opponent_attributes;

            }

            try
            {
                
                
                if (File.Exists(_file_path))
                {
                    File.Delete(_file_path);
                }

                for (int i = 0; i < opponents_file_content.Length; i++)
                {
                    File.AppendAllLines(_file_path, opponents_file_content[i]);
                }

                
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }
        }

        public Event LoadEvent(string _file_path)
        {
            Event temp_event = new Event();
            temp_event.opponents_list = new List<Opponent>();
            temp_event.session_list = new List<Session>();

            string line;

            try
            {
                if (File.Exists(_file_path))
                {

                    string path = Path.GetDirectoryName(_file_path);                    
                    temp_event.ID = Convert.ToInt32(path.Substring(path.LastIndexOf(@"t") + 1));
                    
                    using (StreamReader sr = new StreamReader(_file_path))
                    {
                        while (sr.Peek() >= 0)
                        {
                            line = sr.ReadLine();
                            if (line == null) break;
                            Console.WriteLine(line);

                            string[] splitted;

                            /*
                           if (line == "")
                           {
                               line = sr.ReadLine();
                               splitted = line.Split('=');

                               while (line != "")
                               {
                                   switch (splitted[0])
                                   {
                                       case "":                                           
                                           break;
                                   }
                                    
                                   line = sr.ReadLine();
                                   if (line == null) break;
                                   splitted = line.Split('=',';');
                               }
                           }
                           */

                            if (line.Contains("[EVENT]"))
                            {
                                line = sr.ReadLine();
                                splitted = line.Split('=', ';');

                                while (line != "")
                                {
                                    switch (splitted[0])
                                    {
                                        case "NAME":
                                            temp_event.name = splitted[1];
                                            break;

                                        case "DESCRIPTION":
                                            temp_event.description = splitted[1];
                                            break;
                                    }

                                    line = sr.ReadLine();
                                    if (line == null) break;
                                    splitted = line.Split('=', ';');
                                }                                

                            }else 

                            if (line.Contains("[TEMPERATURE]"))
                            {
                                line = sr.ReadLine();
                                splitted = line.Split('=', ';');

                                while (line != "")
                                {
                                    switch (splitted[0])
                                    {
                                        case "ROAD":
                                            // Not implemented yet
                                            break;

                                        case "AMBIENT":
                                            temp_event.ambient_temperature = Convert.ToInt32(splitted[1]);
                                            break;                                                                                  
                                    }

                                    line = sr.ReadLine();
                                    if (line == null) break;
                                    splitted = line.Split('=', ';');
                                }
                            }else 

                            if (line.Contains("[DYNAMIC_TRACK]"))  // Rotto
                            {
                                line = sr.ReadLine();
                                splitted = line.Split('=', ';');

                                while (line != "")
                                {
                                    switch (splitted[0])
                                    {
                                        case "PRESET":
                                            temp_event.dynamic_track_preset = Convert.ToInt32(splitted[1]);
                                            break;
                                    }

                                    line = sr.ReadLine();
                                    if (line == null) break;
                                    splitted = line.Split('=', ';');
                                }
                            }else

                            if (line.Contains("[RACE]"))
                            {
                                line = sr.ReadLine();
                                splitted = line.Split('=', ';');

                                while (line != "")
                                {
                                    switch (splitted[0])
                                    {
                                        case "TRACK":
                                            temp_event.track = splitted[1];
                                            break;

                                        case "MODEL":
                                            temp_event.event_car.model = splitted[1].ToLower();
                                            break;

                                        case "CARS":
                                            temp_event.numberOfCars = Convert.ToInt32(splitted[1]);
                                            break;

                                        case "PENALTIES":
                                            if (splitted[1] == "0")
                                            {
                                                temp_event.penalties = false;
                                            }
                                            else
                                            {
                                                temp_event.penalties = true;
                                            }
                                            break;

                                        case "RACE_LAPS":
                                            temp_event.numberOfLaps = Convert.ToInt32(splitted[1]);
                                            break;

                                        case "SKIN":
                                            string temp_skin_name = splitted[1].ToLower();
                                            
                                            Car temp_car = ACCGMainForm.ac_cars_list.Find(x => x.model == temp_event.event_car.model);                                            
                                            Bitmap temp_skin_preview = temp_car.skins.Find(x => x.skin_name == temp_skin_name).skin_preview;

                                            if (temp_skin_preview != null)
                                            {
                                                temp_event.event_car_skin.skin_name = temp_skin_name;
                                                temp_event.event_car_skin.skin_preview = temp_skin_preview;
                                            }                                            
                                            break;

                                    }

                                    line = sr.ReadLine();
                                    if (line == null) break;
                                    splitted = line.Split('=', ';');
                                }
                            }else 

                            
                           if (line.Contains("[LIGHTING]"))    // Rotto
                           {
                               line = sr.ReadLine();
                               splitted = line.Split('=', ';');

                               while (line != "")
                               {
                                   switch (splitted[0])
                                   {
                                       case "SUN_ANGLE":
                                           temp_event.time = Convert.ToInt32(splitted[1]);
                                           break;
                                   }
                                    
                                   line = sr.ReadLine();
                                   if (line == null) break;
                                   splitted = line.Split('=', ';');
                               }
                           }else

                            
                            if (line.Contains("SESSION_"))
                            {
                                Session session = new Session();
                                splitted = line.Trim('[',']').Split('_');
                                session.ID = Convert.ToInt32(splitted[1]);

                                line = sr.ReadLine();
                                splitted = line.Split('=', ';');

                                while (line != "")
                                {
                                    switch (splitted[0])
                                    {
                                        case "STARTING_POSITION":
                                            temp_event.start_position = Convert.ToInt32(splitted[1]);
                                            break;

                                        case "NAME":
                                            session.name = splitted[1];
                                            break;

                                        case "TYPE":    // 1 = Practice, 2 = Qualify, 3 = Race, 4 = Hotlap, 5 = Time Attack, 6 = Drift, 7 = Drag
                                            session.type = Convert.ToInt32(splitted[1]);
                                            switch (session.type)
                                            {
                                                case 1:
                                                    temp_event.practice = true;
                                                    break;

                                                case 2:
                                                    temp_event.qualifying = true;
                                                    break;
                                                    
                                                case 3:
                                                    temp_event.isQuickRace = true;
                                                    break;

                                                case 4:
                                                    temp_event.isHotlap = true;
                                                    break;

                                                case 5:
                                                    temp_event.isTimeAttack = true;
                                                    break;

                                                case 6:
                                                    break;

                                                case 7:
                                                    break;
                                            }
                                            break;

                                        case "LAPS":
                                            session.laps = Convert.ToInt32(splitted[1]);
                                            break;

                                        case "DURATION_MINUTES":
                                            session.duration_minutes = Convert.ToInt32(splitted[1]);
                                            break;

                                        case "SPAWN_SET":
                                            session.spawn_set = splitted[1];
                                            break;
                                    }
                                    
                                    line = sr.ReadLine();
                                    if (line == null) break;
                                    splitted = line.Split('=', ';');
                                }

                                temp_event.session_list.Add(session);
                            }
                            else

                            
                           if (line.Contains("[CAR_0]"))
                           {
                                                              
                               line = sr.ReadLine();
                               splitted = line.Split('=', ';');

                               while (line != "")
                               {
                                   switch (splitted[0])
                                   {
                                       case "SKIN":                                           
                                           string temp_skin_name = splitted[1].ToLower();
                                            
                                           Car temp_car = ACCGMainForm.ac_cars_list.Find(x => x.model == temp_event.event_car.model);
                                           Skin temp_skin = temp_car.skins.Find(x => x.skin_name == temp_skin_name);
                                           Bitmap temp_skin_preview;

                                           if (temp_skin != null)
                                           {
                                               temp_skin_preview = temp_skin.skin_preview;
                                               temp_event.event_car_skin.skin_name = temp_skin_name;
                                               temp_event.event_car_skin.skin_preview = temp_skin_preview;
                                           }
                                           else
                                           {
                                               temp_event.event_car_skin.skin_name = temp_car.skins[0].skin_name;
                                               temp_event.event_car_skin.skin_preview = temp_car.skins[0].skin_preview;
                                           }                                                                                                      
                                           break;                                                                            
                                   }
                                    
                                   line = sr.ReadLine();
                                   if (line == null) break;
                                   splitted = line.Split('=', ';');
                               }

                           }
                           else
                           
                           if (line != "[CAR_0]" && line.Contains("CAR_"))
                           {
                               Opponent opponent = new Opponent();
                               splitted = line.Trim('[', ']').Split('_');
                               opponent.ID = Convert.ToInt32(splitted[1]);
                               
                               Car opponent_car = new Car();
                   
                               line = sr.ReadLine();
                               splitted = line.Split('=', ';');

                               while (line != "")
                               {
                                   switch (splitted[0])
                                   {
                                       case "MODEL":
                                           opponent_car.model = splitted[1];
                                           opponent.model = opponent_car;
                                           break;                        
                                           
                                       case "SETUP":
                                           opponent.setup = splitted[1];
                                           break;

                                       case "AI_LEVEL":
                                           opponent.ai_level = Convert.ToInt32(splitted[1]);
                                           break;

                                       case "SKIN":
                                           string temp_skin_name = splitted[1].ToLower();

                                           Car temp_car = ACCGMainForm.ac_cars_list.Find(x => x.model == opponent.model.model);
                                           Skin temp_skin = temp_car.skins.Find(x => x.skin_name == temp_skin_name);
                                           Bitmap temp_skin_preview;

                                           if (temp_skin != null)
                                           {
                                               temp_skin_preview = temp_skin.skin_preview;
                                               opponent.skin.skin_name = temp_skin_name;
                                               opponent.skin.skin_preview = temp_skin_preview;
                                           }
                                           else
                                           {
                                               opponent.skin.skin_name = temp_car.skins[0].skin_name;
                                               opponent.skin.skin_preview = temp_car.skins[0].skin_preview;
                                           }                                                                                                                                                
                                           break;

                                       case "DRIVER_NAME":
                                           opponent.name = splitted[1];
                                           break;

                                       case "NATIONALITY":
                                           opponent.nationality = splitted[1];
                                           break;
                                   }
                                    
                                   line = sr.ReadLine();
                                   if (line == null) break;
                                   splitted = line.Split('=', ';');
                               }

                               temp_event.opponents_list.Add(opponent);

                           }
                           else

                           
                            if (line.Contains("CONDITION_"))                           
                            {
                                splitted = line.Trim('[', ']').Split('_');
                                int id = Convert.ToInt32(splitted[1]);
                                 
                                line = sr.ReadLine();
                                splitted = line.Split('=', ';');
                              
                                while (line != "")                             
                                {
                                
                                    switch (splitted[0])                                 
                                    {                                      
                                        case "TYPE":
                                            temp_event.event_goals.type = splitted[1];                                                                                   
                                            break;                                    
                                              
                                        case "OBJECTIVE":
                                            if (id == 0)
                                            {
                                                temp_event.event_goals.tier_1 = splitted[1].Trim();
                                            }
                                            else if (id == 1)
                                            {
                                                temp_event.event_goals.tier_2 = splitted[1].Trim();
                                            }
                                            else 
                                            {
                                                temp_event.event_goals.tier_3 = splitted[1].Trim();
                                            }
                                            break;
                                    }
                                                                      
                                    line = sr.ReadLine();
                                    if (line == null) break;
                                    splitted = line.Split('=', ';');
                             
                                }
                         
                            }
                            
                            
                        }



                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
            }

            return temp_event;
        }
    }
}
