using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ACCG
{
    public partial class ACCGMainForm : Form
    {
        public ACCGMainForm()
        {
            InitializeComponent();            
        }
        
        private void ACCGMainForm_Load(object sender, EventArgs e)
        {
            // Load setting.ini
            try
            {
                if (File.Exists(@"cfg\settings.ini"))
                {
                    using (StreamReader sr = new StreamReader(@"cfg\settings.ini"))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string tmp = sr.ReadLine();

                            switch (tmp)
                            {
                                case "[AC_PATH]":
                                    ac_path = sr.ReadLine();
                                    Console.WriteLine("DEBUG: " + ac_path);
                                    break;

                                case "[SERIES_GLOBAL_ID]":
                                    series_global_ID = Convert.ToInt32(sr.ReadLine());
                                    Console.WriteLine("DEBUG: " + series_global_ID);
                                    break;

                                default:                                  
                                    Console.WriteLine("DEBUG: default case");
                                    break;
                            }                                                   

                        }

                    }
                }
                else
                {
                    Console.WriteLine("File settings.ini not exists!");
                }
            }
            catch
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
                                    
            // ACCG Series list (list with only user created series)            
            string dir = Directory.GetCurrentDirectory() + @"\data";
            Console.WriteLine("DEBUG: " + dir);

            try
            {
                if(File.Exists(Path.Combine(dir,"accg_series_list.dat"))) {

                    string serializationFile = Path.Combine(dir, "accg_series_list.dat");

                    using (Stream stream = File.Open(serializationFile, FileMode.Open))
                    {
                        var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        accg_series_list = (List<Series>)bformatter.Deserialize(stream);                
                    }
                }
                else
                {
                    accg_series_list = new List<Series>();
                    Console.WriteLine("DEBUG: File not exist, will be create later");
                }
                
            }
            catch
            {
                Console.WriteLine(e.ToString());
            }
            

            ShowData();

            // Events list
            Console.WriteLine("DEBUG: Serie corrente: " + lbSeries.SelectedItem);
            //Series tmp_series = accg_series_list.Find(x => x.name == lbSeries.SelectedItem.ToString());
            
           
            
            // Populating Cars list
            ac_cars_list = new List<Car>();
            string car_name;
            string trimmed_car_name;
            string cars_file_name = @"data\cars_skins.txt";
    
            try
            {
                if (File.Exists(cars_file_name))
                {
                    using (StreamReader sr = new StreamReader(cars_file_name))
                    {
                        while (sr.Peek() >= 0)
                        {
                            car_name = sr.ReadLine();
                            if (car_name.Contains("[") && car_name != "[END_SKINS]")
                            {
                                Console.WriteLine("DEBUG: Contiene [");
                                trimmed_car_name = car_name.Trim(new Char[] { '[', ']' });
                                Console.WriteLine("DEBUG: " + trimmed_car_name);

                                Car tmp_car = new Car();
                                ac_cars_list.Add(tmp_car);
                                tmp_car.model = trimmed_car_name;
                                
                                string tmp_skin = sr.ReadLine();

                                while (tmp_skin != "[END_SKINS]")
                                {
                                    tmp_car.skins.Add(tmp_skin);
                                    tmp_skin = sr.ReadLine();
                                    Console.WriteLine("DEBUG: " + tmp_skin);
                                }
                                
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Missing file \"" + cars_file_name + "\"!");
                    Console.WriteLine("File cars.txt non esistente!");
                    Application.Exit();
                }
            }
            catch
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            // Tracks list
            ac_tracks_list = new List<string>();
            string tracks_file_name = @"data\tracks.txt";

            try
            {
                if (File.Exists(tracks_file_name))
                {
                    using (StreamReader sr = new StreamReader(tracks_file_name))
                    {
                        while (sr.Peek() >= 0)
                        {
                            ac_tracks_list.Add(sr.ReadLine());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Missing file \"" + tracks_file_name + "\"!");                    
                    Application.Exit();
                    Console.WriteLine("File track.txt non esistente!");
                }
            }
            catch
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            // Creating the time table             
            time_table = new Dictionary<string, int>();
      
            time_table.Add("08:00", -80);
            time_table.Add("08:30", -72);
            time_table.Add("09:00", -64);
            time_table.Add("09:30", -56);
            time_table.Add("10:00", -48);
            time_table.Add("10:30", -40);
            time_table.Add("11:00", -32);
            time_table.Add("11:30", -24);
            time_table.Add("12:00", -16);
            time_table.Add("12:30", -8);
            time_table.Add("13:00", 0);
            time_table.Add("13:30", 8);
            time_table.Add("14:00", 16);
            time_table.Add("14:30", 24);
            time_table.Add("15:00", 32);
            time_table.Add("15:30", 40);
            time_table.Add("16:00", 48);
            time_table.Add("16:30", 56);
            time_table.Add("17:00", 64);
            time_table.Add("17:30", 72);
            time_table.Add("18:00", 80);

            
        }

        private void lbSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_selected_series = (Series)lbSeries.SelectedItem;

            // Bugged as hell
            if (current_selected_series != null)
            {
                if (!current_selected_series.isGenerated)
                {
                    lblCurrentSeries.ForeColor = Color.Red;
                }
                else if (current_selected_series.isGenerated)
                {
                    lblCurrentSeries.ForeColor = Color.Green;
                }
                else if (current_selected_series.isEdited)
                {
                    lblCurrentSeries.ForeColor = Color.Yellow;
                }

                lblCurrentSeries.Text = "Current series: " + current_selected_series.name;

                Car tmp_car = current_selected_series.model;

                rtbSeriesInfo.ResetText();
                rtbSeriesInfo.AppendText("Code: " + current_selected_series.code + "\n");
                rtbSeriesInfo.AppendText("Name: " + current_selected_series.name + "\n");
                rtbSeriesInfo.AppendText("Description: " + current_selected_series.description + "\n");
                rtbSeriesInfo.AppendText("Requires: " + current_selected_series.requires + "\n");
                rtbSeriesInfo.AppendText("Points: " + current_selected_series.points + "\n");
                rtbSeriesInfo.AppendText("Car: " + tmp_car.model + "\n");
                rtbSeriesInfo.AppendText("Skin: " + current_selected_series.skin + "\n");
                rtbSeriesInfo.AppendText("Goals: " + current_selected_series.goalsPoints + " points\n");
                rtbSeriesInfo.AppendText("Events: " + current_selected_series.events_list.Count + "\n");
                rtbSeriesInfo.AppendText("Opponents: " + current_selected_series.opponents_list.Count);
            }
                                            
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACCGCredits credits = new ACCGCredits();
            credits.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewSeries_Click(object sender, EventArgs e)
        {
            ACCGNewSeriesForm newSeriesForm = new ACCGNewSeriesForm();
            newSeriesForm.ShowDialog();
        }

        private void btnEditSeries_Click(object sender, EventArgs e)
        {
            if (current_selected_series == null)
            {
                MessageBox.Show("You have to select a series!");
            }
            else
            {
               
                
            }
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (current_selected_series == null)
            {
                MessageBox.Show("You have to select a series!");
            }
            else
            {
                ACCGGenerator accg_generator = new ACCGGenerator(current_selected_series, Directory.GetCurrentDirectory());
                accg_generator.Generate();
                current_selected_series.isGenerated = true;
            }
            
        }

        private void btnDeleteSeries_Click(object sender, EventArgs e)
        {
            
            
            if (current_selected_series == null)
            {
                MessageBox.Show("You have to select a series!");
            }
            else
            {
                DialogResult are_you_sure = MessageBox.Show("Are you sure?","Delete series", MessageBoxButtons.YesNo);

                if (are_you_sure == DialogResult.Yes)
                {
                    string series_path = String.Format(@"ACCG_series\series{0}", current_selected_series.ID);

                    try
                    {
                        if (Directory.Exists(series_path))
                        {
                            Directory.Delete(series_path, true);
                        }
                        
                        accg_series_list.Remove(current_selected_series);
                        bs_series_datasource.ResetBindings(false);
                        rtbSeriesInfo.ResetText();

                        // Saving the series list 
                        string dir = Directory.GetCurrentDirectory();
                        Console.WriteLine("DEBUG: " + dir);
                        string serializationFile = Path.Combine(dir, @"data\accg_series_list.dat");

                        using (Stream stream = File.Open(serializationFile, FileMode.Create))
                        {
                            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                            bformatter.Serialize(stream, ACCGMainForm.accg_series_list);        
                        }
                        
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("The process failed: {0}", exc.ToString());
                    }
                }                
               
            }
        }
              
    }
}
