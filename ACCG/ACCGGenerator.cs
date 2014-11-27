using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ACCG
{
   public class ACCGGenerator
    {

       private static ACCGGenerator instance = null;       

       private Series series;       
       private string series_path;
       
       private string series_ini_filename = "series.ini";
       private string opponents_ini_filename = "opponents.ini";
       private string event_ini_filename = "event.ini";
       private string series_start_png_filename = "start.png";
       private string series_preview_png_filename = "preview.png";
       private string event_preview_png_filename = "preview.png";

       private ACCGGenerator() { }

       public static ACCGGenerator GetInstance()
       {
           
           if (instance == null)
           {
               instance = new ACCGGenerator();
           }
                         
           return instance;
       }

       public void Generate(Series _series, string _path)
       {

           this.series = _series;

           if (!series.isGenerated)
           {
               string[] ac_series_id_list = Directory.GetDirectories(ACCGMainForm.ac_path, "series*", SearchOption.AllDirectories);
               int[] numbers = new int[ac_series_id_list.Length];

               if (ac_series_id_list.Length != 0)
               {
                   for (int i = 0; i < ac_series_id_list.Length; i++)
                   {
                       numbers[i] = Convert.ToInt32(ac_series_id_list[i].Substring(ac_series_id_list[i].LastIndexOf(@"s") + 1));
                   }

               }

               series.ID = numbers.Max() + 1;
           }
           

           this.series_path = String.Format(_path + @"\content\career\series{0}", series.ID);           

           // Creating the series folder           
           Console.WriteLine("DEBUG: series path = " + series_path);

           try
           {
               DirectoryInfo series_folder = Directory.CreateDirectory(series_path);
               Console.WriteLine("DEBUG: " + series_folder.ToString());
           }
           catch (Exception exc)
           {
               Console.WriteLine("The process failed: {0}", exc.ToString());
           }

           // Create the series start.png image
           if (series.startImage != null)
           {
               series.startImage.Save(series_path + @"\" + series_start_png_filename, System.Drawing.Imaging.ImageFormat.Png);
           }
                   
           // Create the series preview.png image
           if (series.previewImage != null)
           {
               series.previewImage.Save(series_path + @"\" + series_preview_png_filename, System.Drawing.Imaging.ImageFormat.Png);
           }           
                      
           // Creating the series.ini file           
           string[] series_file_content = {
                                "[SERIES]",
                                "CODE=" + series.code,
                                "NAME=" + series.name,
                                "DESCRIPTION=" + series.description,
                                "REQUIRES=" + series.requires,
                                "POINTS=" + series.points,
                                "MODEL=" + series.model.model,
                                "\n",
                                "[GOALS]",
                                "POINTS=" + series.series_goals.points,
                                "TIER1=" + series.series_goals.tier_1,
                                "TIER2=" + series.series_goals.tier_2,
                                "TIER3=" + series.series_goals.tier_3        
                            };

           try
           {
               if (Directory.Exists(series_path))
               {
                   File.WriteAllLines(series_path + @"\" + series_ini_filename, series_file_content);
               }
           }
           catch (Exception exc)
           {
               Console.WriteLine("The process failed: {0}", exc.ToString());
           }

           // Create the opponents.ini file
           string[][] opponents_file_content = new string[series.opponents_list.Count][];
           

           for (int i = 0; i < series.opponents_list.Count; i++)
           {
               Opponent temp_opponent = series.opponents_list[i];

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
               if (Directory.Exists(series_path))
               {
                   if (File.Exists(series_path + @"\" + opponents_ini_filename))
                   {
                       File.Delete(series_path + @"\" + opponents_ini_filename);
                   }

                   for (int i = 0; i < opponents_file_content.Length; i++)
                   {                       
                       File.AppendAllLines(series_path + @"\" + opponents_ini_filename, opponents_file_content[i]);
                   }
                       
               }
           }
           catch (Exception exc)
           {
                Console.WriteLine("The process failed: {0}", exc.ToString());
           }

           // Create events sub folders and contents
           foreach (Event ev in series.events_list)
           {
               string event_folder = "";

               try
               {
                   DirectoryInfo temp_event_folder = Directory.CreateDirectory(String.Format(series_path + @"\event{0}", ev.ID));
                   Console.WriteLine("DEBUG: " + temp_event_folder.ToString());
                   event_folder = series_path + @"\" + temp_event_folder.ToString();

               }
               catch (Exception exc)
               {
                   Console.WriteLine("The process failed: {0}", exc.ToString());
               }

               // Create event preview.png image
               if (ev.previewImage != null)
               {
                   ev.previewImage.Save(event_folder + @"\" + event_preview_png_filename, System.Drawing.Imaging.ImageFormat.Png);
               }               
               
               string penalties = "";
               if (ev.penalties)
               {
                   penalties = "1";
               }else{
                   penalties = "0";
               }

               string[] event_file_content = {
                                                 "[EVENT]",
                                                 "NAME=" + ev.name,
                                                 "DESCRIPTION=" + ev.description,
                                                 "\n",
                                                 "[TEMPERATURE]",
                                                 "ROAD=33", // Road temperature range ?
                                                 "AMBIENT=" + ev.ambient_temperature,
                                                 "\n",
                                                 "[DYNAMIC_TRACK]",     
                                                 "PRESET=" + ev.dynamic_track_preset,            
                                                 //"SESSION_START=98",    //
                                                 //"RANDOMNESS=2",        // Need more info from devs
                                                 //"LAP_GAIN=20",         //
                                                 //"SESSION_TRANSFER=80", //
                                                 "\n",
                                                 "[RACE]",
                                                 "TRACK=" + ev.track,
                                                 "MODEL=" + series.model.model,
                                                 "CARS=" + ev.numberOfCars,
                                                 "AI_LEVEL=100",        // Probably is a "multiplier" of AI opponents, need to ask devs
                                                 "FIXED_SETUP=0",
                                                 "PENALTIES=" + penalties,
                                                 "DRIFT_MODE=0",
                                                 "RACE_LAPS=" + ev.session_list.Find(x => x.type == 3).laps,
                                                 "ARM_FIRST_LAP=0",
                                                 "SKIN=" + series.skin.skin_name,
                                                 "\n",
                                                 "[GHOST_CAR]",
                                                 "RECORDING=0",
                                                 "PLAYING=0",
                                                 "SECOND_ADVANTAGE=0",
                                                 "LOAD=1",
                                                 "FILE=",
                                                 "ENABLED=0",
                                                 "\n",
                                                 "[REPLAY]",
                                                 "FILENAME=",
                                                 "ACTIVE=0",
                                                 "\n",
                                                 "[LIGHTING]",
                                                 "SUN_ANGLE=" + ev.time,
                                                 "TIME_MULT=1",
                                                 "CLOUD_SPEED=0.2",
                                                 "\n",
                                                 "[GROOVE]",
                                                 "VIRTUAL_LAPS=10",
                                                 "MAX_LAPS=30",
                                                 "STARTING_LAPS=0",
                                                 "\n",
                                                 "[REMOTE]",
                                                 "ACTIVE=0",
                                                 "SERVER_IP=",
                                                 "SERVER_PORT=",
                                                 "NAME=",
                                                 "TEAM=",
                                                 "GUID=",
                                                 "REQUESTED_CAR=",
                                                 "PASSWORD=",
                                                 "\n",
                                                 "[LAP_INVALIDATOR]",
                                                 "ALLOWED_TYRES_OUT=-1",
                                                 "\n",
                                                 "[CAR_0]",
                                                 "SETUP=",
                                                 "MODEL=-",
                                                 "SKIN=" + series.skin.skin_name,
                                                 "DRIVER_NAME=",
                                                 "NATIONALITY=",
                                                 "\n"
                                              };

               string[][] sessions_file_content = new string[ev.session_list.Count][];

               for (int i = 0; i < ev.session_list.Count; i++)
               {
                   Session temp_session = ev.session_list[i];

                   string[] temp_session_attributes = {
                                                        String.Format("[SESSION_{0}]", temp_session.ID),
                                                        "NAME=" + temp_session.name,
                                                        "TYPE=" + temp_session.type,
                                                        "DURATION_MINUTES=" + temp_session.duration_minutes,
                                                        "SPAWN_SET=" + temp_session.spawn_set,
                                                        "LAPS=" + temp_session.laps,
                                                        ""
                                                    };

                   sessions_file_content[i] = temp_session_attributes;
               }

                   try
                   {
                       if (Directory.Exists(event_folder))
                       {
                           if (File.Exists(event_folder + @"\" + event_ini_filename))
                           {
                               File.Delete(event_folder + @"\" + event_ini_filename);
                           }

                           File.WriteAllLines(event_folder + @"\" + event_ini_filename, event_file_content);

                           for (int i = 0; i < sessions_file_content.Length; i++)
                           {
                               File.AppendAllLines(event_folder + @"\" + event_ini_filename, sessions_file_content[i]);
                           }
                       }
                   }
                   catch (Exception exc)
                   {
                       Console.WriteLine("The process failed: {0}", exc.ToString());
                   }

           }

           System.Windows.Forms.MessageBox.Show("Series successfully generated!");

       }
    }
}
