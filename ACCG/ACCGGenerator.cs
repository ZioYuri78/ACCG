using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

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
       private string series_intro_video_filename = "start.ogv";

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

           // Create the series folder           
           ACCGMainForm.accg_log.WriteLog("GEN", "series path = " + series_path, 500);           
           Console.WriteLine("DEBUG: series path = " + series_path);

           try
           {
               DirectoryInfo series_folder = Directory.CreateDirectory(series_path);
               Console.WriteLine("DEBUG: " + series_folder.ToString());
           }
           catch (Exception exc)
           {
               ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
               Console.WriteLine("The process failed: {0}", exc.ToString());
           }

           // Create the series start.png image
           if (series.startImage != null)
           {
               ACCGMainForm.accg_log.WriteLog("GEN", "Create the series start.png image", 500);               
               series.startImage.Save(series_path + @"\" + series_start_png_filename, System.Drawing.Imaging.ImageFormat.Png);
           }
                   
           // Create the series preview.png image
           if (series.previewImage != null)
           {
               ACCGMainForm.accg_log.WriteLog("GEN", "Create the series preview.png image", 500);               
               series.previewImage.Save(series_path + @"\" + series_preview_png_filename, System.Drawing.Imaging.ImageFormat.Png);
           }           
           
           // Create the series intro video


           //-----------------------------
               
           if (series.isChampionship)
           {
               // Create the series.ini file   
               ACCGMainForm.accg_log.WriteLog("GEN", "Create the series.ini file", 500);               
               generateChampionshipSeriesIni(series, series_path, series_ini_filename);

               // Create the opponents.ini file
               ACCGMainForm.accg_log.WriteLog("GEN", "Create the opponents.ini file", 500);               
               generateOpponentsIni(series, series_path, opponents_ini_filename);

               // Create events sub-folders and contents           
               ACCGMainForm.accg_log.WriteLog("GEN", "Create events sub-folders and contents", 500);               
               generateChampionshipEventsIni(series, series_path, event_ini_filename, event_preview_png_filename);
           }
           else
           {
               // Create the series.ini file
               ACCGMainForm.accg_log.WriteLog("GEN", "Create the series.ini file", 500);               
               generateSingleEventsSeriesIni(series, series_path, series_ini_filename);

               // Create events sub-folders and contents
               ACCGMainForm.accg_log.WriteLog("GEN", "Create events sub-folders and contents", 500);               
               generateSingleEventsIni(series, series_path, event_ini_filename, event_preview_png_filename);
           }                                                                  
                      
           //System.Windows.Forms.MessageBox.Show("Series successfully generated!");

       }


       private void generateChampionshipSeriesIni(Series _series, string _series_path, string _series_filename)
       {

           string[] series_file_content = {
                                "[SERIES]",
                                "CODE=" + _series.code,
                                "NAME=" + _series.name,
                                "DESCRIPTION=" + _series.description,
                                "REQUIRES=" + _series.requires,
                                "POINTS=" + _series.points,
                                "MODEL=" + _series.car.model,
                                "\n",
                                "[GOALS]",
                                "POINTS=" + _series.series_goals.points,
                                "RANKING=" + _series.series_goals.ranking,    
                                "TIER1=0",
                                "TIER2=0",
                                "TIER3=0"
                            };

           try
           {
               if (Directory.Exists(_series_path))
               {
                   File.WriteAllLines(_series_path + @"\" + _series_filename, series_file_content);
               }
           }
           catch (Exception exc)
           {
               ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
               Console.WriteLine("The process failed: {0}", exc.ToString());
           }

       }


       private void generateOpponentsIni(Series _series, string _series_path, string _opponents_filename)
       {

           string[][] opponents_file_content = new string[_series.opponents_list.Count][];

           for (int i = 0; i < _series.opponents_list.Count; i++)
           {
               Opponent temp_opponent = _series.opponents_list[i];

               string[] temp_opponent_attributes = {
                                       String.Format("[AI{0}]",temp_opponent.ID),
                                       "MODEL=" + temp_opponent.car_model.model,
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
               if (Directory.Exists(_series_path))
               {
                   if (File.Exists(_series_path + @"\" + _opponents_filename))
                   {
                       File.Delete(_series_path + @"\" + _opponents_filename);
                   }

                   for (int i = 0; i < opponents_file_content.Length; i++)
                   {
                       File.AppendAllLines(_series_path + @"\" + _opponents_filename, opponents_file_content[i]);
                   }

               }
           }
           catch (Exception exc)
           {
               ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
               Console.WriteLine("The process failed: {0}", exc.ToString());
           }
       }


       private void generateChampionshipEventsIni(Series _series, string _series_path, string _event_filename, string _event_preview_png_filename) 
       {

           foreach (Event ev in _series.events_list)
           {
               string event_folder = "";

               try
               {
                   DirectoryInfo temp_event_folder = Directory.CreateDirectory(String.Format(_series_path + @"\event{0}", ev.ID));
                   ACCGMainForm.accg_log.WriteLog("GEN", temp_event_folder.ToString(), 500);                   
                   Console.WriteLine("DEBUG: " + temp_event_folder.ToString());
                   event_folder = _series_path + @"\" + temp_event_folder.ToString();

               }
               catch (Exception exc)
               {
                   ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
                   Console.WriteLine("The process failed: {0}", exc.ToString());
               }

               // Create event preview.png image
               if (ev.previewImage != null)
               {
                   ACCGMainForm.accg_log.WriteLog("GEN", "Create event preview.png image", 500);                   
                   ev.previewImage.Save(event_folder + @"\" + _event_preview_png_filename, System.Drawing.Imaging.ImageFormat.Png);
               }

               string penalties = "";
               if (ev.penalties)
               {
                   penalties = "1";
               }
               else
               {
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
                                                 "MODEL=" + _series.car.model,
                                                 "CARS=" + ev.numberOfCars,
                                                 "AI_LEVEL=100",        // Probably is a "multiplier" of AI opponents, need to ask devs
                                                 "FIXED_SETUP=0",
                                                 "PENALTIES=" + penalties,
                                                 "DRIFT_MODE=0",
                                                 "RACE_LAPS=" + ev.session_list.Find(x => x.type == 3).laps,
                                                 "ARM_FIRST_LAP=0",
                                                 "SKIN=" + _series.skin.skin_name,
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
                                                 "SKIN=" + _series.skin.skin_name,
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
                       if (File.Exists(event_folder + @"\" + _event_filename))
                       {
                           File.Delete(event_folder + @"\" + _event_filename);
                       }

                       File.WriteAllLines(event_folder + @"\" + _event_filename, event_file_content);

                       for (int i = 0; i < sessions_file_content.Length; i++)
                       {
                           File.AppendAllLines(event_folder + @"\" + _event_filename, sessions_file_content[i]);
                       }
                   }
               }
               catch (Exception exc)
               {
                   ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
                   Console.WriteLine("The process failed: {0}", exc.ToString());
               }

           }
       }


       private void generateSingleEventsSeriesIni(Series _series, string _series_path, string _series_filename)
       {
           string[] series_file_content = {
                                "[SERIES]",
                                "CODE=" + _series.code,
                                "NAME=" + _series.name,
                                "DESCRIPTION=" + _series.description,
                                "REQUIRES=" + _series.requires,
                                "POINTS=0",
                                "\n",
                                "[GOALS]",
                                "POINTS=0",
                                "TIER1=" + _series.series_goals.tier_1,
                                "TIER2=" + _series.series_goals.tier_2,
                                "TIER3=" + _series.series_goals.tier_3
                            };

           try
           {
               if (Directory.Exists(_series_path))
               {
                   File.WriteAllLines(_series_path + @"\" + _series_filename, series_file_content);
               }
           }
           catch (Exception exc)
           {
               ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
               Console.WriteLine("The process failsed: {0}", exc.ToString());
           }

       }

       private void generateSingleEventsIni(Series _series, string _series_path, string _event_filename, string _event_preview_png_filename)
       {
           foreach (Event ev in _series.events_list)
           {
               string event_folder = "";

               try
               {
                   DirectoryInfo temp_event_folder = Directory.CreateDirectory(String.Format(_series_path + @"\event{0}", ev.ID));
                   ACCGMainForm.accg_log.WriteLog("GEN", temp_event_folder.ToString(), 500);                   
                   Console.WriteLine("DEBUG: " + temp_event_folder.ToString());
                   event_folder = _series_path + @"\" + temp_event_folder.ToString();
               }
               catch (Exception exc)
               {
                   ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
                   Console.WriteLine("The process failed: {0}", exc.ToString());
               }

               // Create event preview.png image
               if (ev.previewImage != null)
               {
                   ACCGMainForm.accg_log.WriteLog("GEN", "Create event preview.png image", 500);                   
                   ev.previewImage.Save(event_folder + @"\" + _event_preview_png_filename, System.Drawing.Imaging.ImageFormat.Png);
               }

               string penalties = "";
               if (ev.penalties)
               {
                   penalties = "1";
               }
               else
               {
                   penalties = "0";
               }

               string[] event_file_content = new string[0];

               if (ev.isQuickRace)
               {    
                   event_file_content = new string[] {
                                                        "[EVENT]",
                                                        "NAME=" + ev.name,
                                                        "DESCRIPTION=" + ev.description,
                                                        "\n",
                                                        "[RACE]",
                                                        "TRACK=" + ev.track,
                                                        "MODEL=" + ev.event_car.model,
                                                        "CARS=" + ev.numberOfCars,
                                                        "AI_LEVEL=100",
                                                        "DRIFT_MODE=0",
                                                        "RACE_LAPS=" + ev.numberOfLaps,
                                                        "FIXED_SETUP=0",
                                                        "PENALTIES=" + penalties,
                                                        "\n",
                                                        "[GHOST_CAR]",
                                                        "RECORDING=0",
                                                        "PLAYING=0",
                                                        "SECOND_ADVANTAGE=0",
                                                        "LOAD=1",
                                                        "FILE=",
                                                        "ENABLED=0",
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
                                                        "[TEMPERATURE]",
                                                        "AMBIENT=" + ev.ambient_temperature,
                                                        "ROAD=32",
                                                        "\n",
                                                        "[DYNAMIC_TRACK]",
                                                        "PRESET=" + ev.dynamic_track_preset,
                                                        "\n",
                                                        "[CAR_0]",
                                                        "SETUP=",
                                                        "MODEL=-",
                                                        "SKIN=" + ev.event_car_skin.skin_name,
                                                        "DRIVER_NAME=",
                                                        "NATIONALITY=",
                                                        "\n"
                                                    };

               }
               else if (ev.isTimeAttack)
               {
                   event_file_content = new string[] {
                                                       "[EVENT]",
                                                        "NAME=" + ev.name,
                                                        "DESCRIPTION=" + ev.description,
                                                        "\n",
                                                        "[RACE]",
                                                        "TRACK=" + ev.track,
                                                        "MODEL=" + ev.event_car.model,
                                                        "CARS=1",
                                                        "AI_LEVEL=100",
                                                        "DRIFT_MODE=0",                                                        
                                                        "FIXED_SETUP=0",
                                                        "PENALTIES=" + penalties,
                                                        "\n",
                                                        //"[CAR_0]",
                                                        //"SETUP=",
                                                        //"MODEL=-",
                                                        //"SKIN=" + ev.event_car_skin.skin_name,
                                                        //"\n",
                                                        "[GHOST_CAR]",
                                                        "RECORDING=0",
                                                        "PLAYING=0",
                                                        "SECOND_ADVANTAGE=0",
                                                        "LOAD=1",
                                                        "FILE=",
                                                        "ENABLED=0",
                                                        "\n",
                                                        "[LIGHTING]",
                                                        "SUN_ANGLE=" + ev.time,
                                                        "TIME_MULT=1",
                                                        "CLOUD_SPEED=0.2",
                                                        "\n",
                                                        "[GROOVE]",
                                                        "VIRTUAL_LAPS=10",
                                                        "MAX_LAPS=1",
                                                        "STARTING_LAPS=1",
                                                        "\n",
                                                        "[LAP_INVALIDATOR]",
                                                        "ALLOW_TYRES_OUT=-1",
                                                        "\n",
                                                        "[TEMPERATURE]",
                                                        "AMBIENT=" + ev.ambient_temperature,
                                                        "ROAD=32",
                                                        "\n",
                                                        "[DYNAMIC_TRACK]",
                                                        "PRESET=" + ev.dynamic_track_preset,
                                                        "\n"                                                                                                                   
                                                    };

               }
               else if (ev.isHotlap)
               {
                   event_file_content = new string[] {
                                                        "[EVENT]",
                                                        "NAME=" + ev.name,
                                                        "DESCRIPTION=" + ev.description,
                                                        "\n",
                                                        "[RACE]",
                                                        "TRACK=" + ev.track,
                                                        "MODEL=" + ev.event_car.model,
                                                        "CARS=1",
                                                        "AI_LEVEL=100",
                                                        "PENALTIES=" + penalties,
                                                        "FIXED_SETUP=0",
                                                        "\n",
                                                        "[GHOST_CAR]",
                                                        "RECORDING=0",
                                                        "PLAYING=0",
                                                        "SECOND_ADVANTAGE=0",
                                                        "LOAD=1",
                                                        "FILE=",
                                                        "ENABLED=0",
                                                        "\n",
                                                        "[LIGHTING]",
                                                        "SUN_ANGLE=" + ev.time,
                                                        "TIME_MULT=1",
                                                        "CLOUD_SPEED=0.2",
                                                        "\n",
                                                        "[GROOVE]",
                                                        "VIRTUAL_LAPS=10",
                                                        "MAX_LAPS=1",
                                                        "STARTING_LAPS=1",
                                                        "\n",
                                                        "[TEMPERATURE]",
                                                        "AMBIENT=" + ev.ambient_temperature,
                                                        "ROAD=33",
                                                        "\n",
                                                        "[DYNAMIC_TRACK]",
                                                        "PRESET=" + ev.dynamic_track_preset,
                                                        "\n"
                                                    };
               }

               string[][] session_file_content = new string[ev.session_list.Count][];

               for (int i = 0; i < ev.session_list.Count; i++)
               {
                   Session temp_session = ev.session_list[i];

                   string[] temp_session_attributes = new string[0];

                   if (ev.isQuickRace)
                   {
                       temp_session_attributes = new string[] {
                                                                String.Format("[SESSION_{0}]", temp_session.ID),
                                                                "STARTING_POSITION=" + ev.start_position,
                                                                "NAME=" + temp_session.name,
                                                                "TYPE=" + temp_session.type,
                                                                "LAPS=" + temp_session.laps,
                                                                "DURATION_MINUTES=" + temp_session.duration_minutes,
                                                                "SPAWN_SET=" + temp_session.spawn_set,
                                                                "\n",
                                                                
                                                            };
                   }
                   else if (ev.isTimeAttack)
                   {
                       temp_session_attributes = new string[] {
                                                                String.Format("[SESSION_{0}]", temp_session.ID),
                                                                "NAME=" + temp_session.name,
                                                                "TYPE=" + temp_session.type,
                                                                "SPAWN_SET=" + temp_session.spawn_set,
                                                                "\n",
                                                                "[CAR_0]",
                                                                "SETUP=",
                                                                "MODEL=-",
                                                                "SKIN=" + ev.event_car_skin.skin_name,
                                                                "DRIVER_NAME=",
                                                                "NATIONALITY=",
                                                                "\n"
                                                            };
                   }
                   else if(ev.isHotlap)
                   {
                       temp_session_attributes = new string[] {
                                                                String.Format("[SESSION_{0}]", temp_session.ID),
                                                                "NAME=" + temp_session.name,
                                                                "TYPE=" + temp_session.type,
                                                                "SPAWN_SET=" + temp_session.spawn_set,
                                                                "\n",
                                                                "[CAR_0]",
                                                                "SETUP=",
                                                                "MODEL=-",
                                                                "SKIN=" + ev.event_car_skin.skin_name,
                                                                "DRIVER_NAME=",
                                                                "NATIONALITY=",
                                                                "\n"
                                                            };
                   }

                   session_file_content[i] = temp_session_attributes;
               }

               string[][] opponents_file_content = new string[0][];

               if (ev.isQuickRace)
               {
                   opponents_file_content = new string[ev.opponents_list.Count][];

                   for (int i = 0; i < ev.opponents_list.Count; i++)
                   {
                       Opponent temp_opponent = ev.opponents_list[i];

                       string[] temp_opponent_attributes = {
                                                               String.Format("[CAR_{0}]", temp_opponent.ID),
                                                               "MODEL=" + temp_opponent.car_model.model,
                                                               "SETUP=" + ev.track,
                                                               "AI_LEVEL=" + temp_opponent.ai_level,
                                                               "SKIN=" + temp_opponent.skin.skin_name,
                                                               "DRIVER_NAME=" + temp_opponent.name,
                                                               "NATIONALITY=" + temp_opponent.nationality,
                                                               ""
                                                           };

                       opponents_file_content[i] = temp_opponent_attributes;
                   }
               }

               // Need a rewrite, need to add "type" attributes to Goals class)
               string[] goals_file_content = new string[0];

               if (ev.isQuickRace)
               {
                   goals_file_content = new string[] {
                                                        "[CONDITION_0]",
                                                        "TYPE=POSITION",
                                                        "OBJECTIVE=" + ev.event_goals.tier_1,
                                                        "\n",
                                                        "[CONDITION_1]",
                                                        "TYPE=POSITION",
                                                        "OBJECTIVE=" + ev.event_goals.tier_2,
                                                        "\n",
                                                        "[CONDITION_2]",
                                                        "TYPE=POSITION",
                                                        "OBJECTIVE=" + ev.event_goals.tier_3,
                                                        "\n",

                                                    };
               }
               else if (ev.isTimeAttack)
               {
                   goals_file_content = new string[] {
                                                        "[CONDITION_0]",
                                                        "TYPE=POINTS",
                                                        "OBJECTIVE=" + ev.event_goals.tier_1,
                                                        "\n",
                                                        "[CONDITION_1]",
                                                        "TYPE=POINTS",
                                                        "OBJECTIVE=" + ev.event_goals.tier_2,
                                                        "\n",
                                                        "[CONDITION_2]",
                                                        "TYPE=POINTS",
                                                        "OBJECTIVE=" + ev.event_goals.tier_3,
                                                        "\n",

                                                    };
               }
               else if (ev.isHotlap)
               {
                   goals_file_content = new string[] {
                                                        "[CONDITION_0]",
                                                        "TYPE=TIME",
                                                        "OBJECTIVE=" + ev.event_goals.tier_1,
                                                        "\n",
                                                        "[CONDITION_1]",
                                                        "TYPE=TIME",
                                                        "OBJECTIVE=" + ev.event_goals.tier_2,
                                                        "\n",
                                                        "[CONDITION_2]",
                                                        "TYPE=TIME",
                                                        "OBJECTIVE=" + ev.event_goals.tier_3,
                                                        "\n",
                                                    };
               }

               try 
               {
                   if (Directory.Exists(event_folder))
                   {
                       if (File.Exists(event_folder + @"\" + _event_filename))
                       {
                           File.Delete(event_folder + @"\" + _event_filename);
                       }

                       File.WriteAllLines(event_folder + @"\" + _event_filename, event_file_content);

                       for (int i = 0; i < session_file_content.Length; i++)
                       {
                           File.AppendAllLines(event_folder + @"\" + _event_filename, session_file_content[i]);
                       }

                       if (ev.isQuickRace)
                       {
                           for (int i = 0; i < ev.opponents_list.Count; i++)
                           {
                               File.AppendAllLines(event_folder + @"\" + _event_filename, opponents_file_content[i]);
                           }
                       }

                       File.AppendAllLines(event_folder + @"\" + _event_filename, goals_file_content);
                   }
                   else Console.WriteLine("Something went wrong");
               }
               catch (Exception exc)
               {
                   ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
                   Console.WriteLine("The process failse: {0}", exc.ToString());
               }

           }
       }


    }
}
