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
    public partial class ACCGNewSeriesForm : Form
    {
        private Series current_selected_series;

        public ACCGNewSeriesForm()
        {
            InitializeComponent();
        }

        public ACCGNewSeriesForm(Series current_selected_series)
        {
            // TODO: Complete member initialization
            this.current_selected_series = current_selected_series;

            InitializeComponent();
        }

        private void rbChampionship_CheckedChanged(object sender, EventArgs e)
        {
            tbPoints.Enabled = rbChampionship.Checked;
            cbCar.Enabled = rbChampionship.Checked;
            cbSkin.Enabled = rbChampionship.Checked;
            tbGoalsPoints.Enabled = rbChampionship.Checked;
            lbOpponents.Enabled = rbChampionship.Checked;
            btnNewOpponent.Enabled = rbChampionship.Checked;
            btnEditOpponent.Enabled = rbChampionship.Checked;
            btnDeleteOpponent.Enabled = rbChampionship.Checked;
        }

        private void rbSingleEvents_CheckedChanged(object sender, EventArgs e)
        {
            tbGoldTier.Enabled = rbSingleEvents.Checked;
            tbSilverTier.Enabled = rbSingleEvents.Checked;
            tbBronzeTier.Enabled = rbSingleEvents.Checked;
        }

        private void NewSeriesForm_Load(object sender, EventArgs e)
        {

            if (current_selected_series != null)
            {
                temp_series = current_selected_series;
                tbCode.Text = temp_series.code;
                tbName.Text = temp_series.name;
                tbDescription.Text = temp_series.description;
                tbPoints.Text = temp_series.points;
                tbGoalsPoints.Text = temp_series.goalsPoints;
            }
            else
            {
                temp_series = new Series();              
            }
            
            
            // Manca try catch!
            
            if (rbChampionship.Checked)
            {

                if (current_selected_series == null)
                {
                    temp_series.opponents_list = new List<Opponent>();                    
                }
                                                            
                tbPoints.Enabled = true;
                cbCar.Enabled = true;
                cbSkin.Enabled = true;
                tbGoalsPoints.Enabled = true;
                lbOpponents.Enabled = true;

                tbGoldTier.Enabled = false;
                tbSilverTier.Enabled = false;
                tbBronzeTier.Enabled = false;
            }
            else if (rbSingleEvents.Checked)
            {
                tbPoints.Enabled = false;
                cbCar.Enabled = false;
                cbSkin.Enabled = false;
                tbGoalsPoints.Enabled = false;
                lbOpponents.Enabled = false;

                tbGoldTier.Enabled = true;
                tbSilverTier.Enabled = true;
                tbBronzeTier.Enabled = true;
            }
            

            // Populating the requires series combobox
            ac_series_path = Directory.GetDirectories(ACCGMainForm.ac_path, "series*", SearchOption.AllDirectories);
            
            /*
            Console.WriteLine("DEBUG:");
            foreach (string el in ac_series_path)
            {
                Console.WriteLine(el);
            }
            */
            //Array.Sort(ac_series_path, StringComparer.InvariantCulture);

            if (ac_series_path.Length != 0)
            {
                foreach (string el in ac_series_path)
                {
                    cbRequires.Items.Add(el.Substring(el.LastIndexOf(@"\") +1 ));
                }
            }

            if (current_selected_series != null)
            {
                cbRequires.Text = temp_series.requires;
            }
            else
            {
                cbRequires.Text = ac_series_path[0].Substring(ac_series_path[0].LastIndexOf(@"\") + 1);                
            }
            
                                    
            // Populating the models combobox
            foreach (Car car in ACCGMainForm.ac_cars_list)
            {
                cbCar.Items.Add(car.model);
            }

            if (current_selected_series != null)
            {
                cbCar.Text = temp_series.model.model;
            }
            else
            {
                cbCar.Text = ACCGMainForm.ac_cars_list.ElementAt(0).model;                       
            }
            

            // Set initial car model
            if (current_selected_series != null)
            {
                champ_player_car = temp_series.model;
            }
            else
            {
                champ_player_car = ACCGMainForm.ac_cars_list.Find(x => x.model == cbCar.SelectedItem.ToString());
            }
            

            // Populating the car skins combo box
            foreach (string skin in ACCGNewSeriesForm.champ_player_car.skins)
            {
                cbSkin.Items.Add(skin);
            }

            if (current_selected_series != null)
            {
                cbSkin.Text = temp_series.skin;
            }
            else
            {
                cbSkin.Text = ACCGNewSeriesForm.champ_player_car.skins[0];            
            }
            
            
            ShowData();
        }

        private void btOK_Click(object sender, EventArgs e)
        {

            if (temp_series.events_list.Count == 0)
            {
                MessageBox.Show("You need to create at least one event!");
            }
            else if (temp_series.opponents_list.Count == 0)
            {
                MessageBox.Show("You need to create at least one opponent!");
            }
            else if (tbCode.Text == "")
            {
                MessageBox.Show("Missing \"Code\" field!");

            }else if(tbName.Text == "") {

                MessageBox.Show("Missing \"Name\" field!");

            }else if(tbDescription.Text == "") {

                MessageBox.Show("Missing \"Description\" field!");

            }else if(tbPoints.Text == "") {

                MessageBox.Show("Missing \"Points\" field!");

            }else if(tbGoalsPoints.Text == "") {

                MessageBox.Show("Missing \"Goals\" field!");

            }
            else
            {
                temp_series.code = tbCode.Text;
                temp_series.name = tbName.Text;
                temp_series.description = tbDescription.Text;
                temp_series.requires = cbRequires.SelectedItem.ToString();
                temp_series.points = tbPoints.Text;
                temp_series.model = champ_player_car;
                temp_series.skin = cbSkin.SelectedItem.ToString();
                temp_series.goalsPoints = tbGoalsPoints.Text;
                temp_series.isEdited = false;
                temp_series.isGenerated = false;

                // Very instable code!
                if (ACCGMainForm.series_global_ID >= 100)
                {
                    if (current_selected_series == null)
                    {
                        temp_series.ID = ACCGMainForm.series_global_ID + 1;
                        ACCGMainForm.series_global_ID++;

                        // Save the new value of global series ID in settings.ini  (very instable code!)              
                        StringBuilder newFile = new StringBuilder();
                        //string temp_opponent = "";                  
                        string settings_file_name = @"cfg\settings.ini";

                        if (File.Exists(settings_file_name))
                        {
                            string[] file = File.ReadAllLines(settings_file_name);

                            for (int i = 0; i < file.Length; i++)
                            {
                                if (file[i].Contains("[SERIES_GLOBAL_ID]"))
                                {
                                    newFile.Append(file[i] + "\r\n");
                                    file[i + 1] = ACCGMainForm.series_global_ID.ToString();
                                    Console.WriteLine("DEBUG: SERIES_GLOBAL_ID" + ACCGMainForm.series_global_ID.ToString());

                                    newFile.Append(file[i + 1]);
                                    break;

                                }

                                newFile.Append(file[i] + "\r\n");
                            }

                            File.WriteAllText(settings_file_name, newFile.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Missing file \"" + settings_file_name + "\"!");
                        }
                    }
                                                           
                }

                Console.WriteLine("DEBUG: Code = {0}", temp_series.code);
                Console.WriteLine("DEBUG: Name = {0}", temp_series.name);
                Console.WriteLine("DEBUG: Description = {0}", temp_series.description);
                Console.WriteLine("DEBUG: Requires = {0}", temp_series.requires);
                Console.WriteLine("DEBUG: Points = {0}", temp_series.points);
                Console.WriteLine("DEBUG: Selected car: " + champ_player_car.model);
                Console.WriteLine("DEBUG: Goals = " + temp_series.goalsPoints + " points");
                Console.WriteLine("DEBUG: ID = {0}", temp_series.ID);
                Console.WriteLine("DEBUG: Events = {0}", temp_series.events_list.Count);

                // Add the current series to ACCG main series list
                if (current_selected_series != null) // Edit mode
                {
                    int series_index = ACCGMainForm.accg_series_list.IndexOf(current_selected_series);
                    ACCGMainForm.accg_series_list.Remove(current_selected_series);
                    ACCGMainForm.accg_series_list.Insert(series_index,temp_series);
                }
                else // New sereis mode
                {
                    ACCGMainForm.accg_series_list.Add(temp_series);
                }
                
                // Need datasource
                ACCGMainForm.bs_series_datasource.ResetBindings(false);

                Console.WriteLine("DEBUG: Numero di elementi nella lista series = {0}", ACCGMainForm.accg_series_list.Count);

                // Saving the series list 
                string dir = Directory.GetCurrentDirectory();
                Console.WriteLine("DEBUG: " + dir);
                string serializationFile = Path.Combine(dir, @"data\accg_series_list.dat");

                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, ACCGMainForm.accg_series_list);
                }

                this.Close();
            }
                             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

        private void cbCar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            champ_player_car = ACCGMainForm.ac_cars_list.Find(x => x.model == cbCar.SelectedItem.ToString());

            // Re-populating the car skins combo box
            cbSkin.Items.Clear();
            foreach (string skin in ACCGNewSeriesForm.champ_player_car.skins)
            {
                cbSkin.Items.Add(skin);
            }

            cbSkin.Text = ACCGNewSeriesForm.champ_player_car.skins[0];

        }

        private void lbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_selected_event = (Event)lbEvents.SelectedItem;

            if (current_selected_event != null)
            {
                rtbEventsInfo.ResetText();
                rtbEventsInfo.AppendText("Name: " + current_selected_event.name + "\n");
                rtbEventsInfo.AppendText("Description: " + current_selected_event.description + "\n");
                rtbEventsInfo.AppendText("Ambient temperature: " + current_selected_event.ambient_temperature + "\n");

                foreach (KeyValuePair<string, int> pair in ACCGMainForm.time_table)
                {
                    if (pair.Value == Convert.ToInt32(current_selected_event.time))
                    {
                        rtbEventsInfo.AppendText("Time: " + pair.Key + "\n");
                        break;
                    }
                }

                if (current_selected_event.practice)
                {
                    rtbEventsInfo.AppendText("Practice: " + current_selected_event.session_list.Find(x => x.type == 1).duration_minutes + "min\n");
                }

                if (current_selected_event.qualifying)
                {
                    rtbEventsInfo.AppendText("Qualifying: " + current_selected_event.session_list.Find(x => x.type == 2).duration_minutes + "min\n");
                }

                rtbEventsInfo.AppendText("Track: " + current_selected_event.track + "\n");
                //rtbEventsInfo.AppendText("Car: " + current_selected_event.); // Only for single events series, i will implement later
                rtbEventsInfo.AppendText("Number of cars: " + current_selected_event.numberOfCars + "\n");
                rtbEventsInfo.AppendText("Penalties: " + current_selected_event.penalties + "\n");
                rtbEventsInfo.AppendText("Laps: " + current_selected_event.session_list.Find(x => x.type == 3).laps + "\n");
            
            }            

        }


        private void lbOpponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_selected_opponent = (Opponent)lbOpponents.SelectedItem;

            if (current_selected_opponent != null)
            {
                rtbOpponentsInfo.ResetText();
                rtbOpponentsInfo.AppendText("Name: " + current_selected_opponent.name + "\n");
                rtbOpponentsInfo.AppendText("Nationality: " + current_selected_opponent.nationality + "\n");
                rtbOpponentsInfo.AppendText("Car: " + current_selected_opponent.model.model + "\n");
                rtbOpponentsInfo.AppendText("Skin: " + current_selected_opponent.skin + "\n");
                rtbOpponentsInfo.AppendText("Setup: " + current_selected_opponent.setup + "\n");
                rtbOpponentsInfo.AppendText("AI Level: " + current_selected_opponent.ai_level.ToString());
            }

            
        }


        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            ACCGNewEventForm newEventForm = new ACCGNewEventForm();
            newEventForm.ShowDialog();

            for (int i = 0; i < temp_series.events_list.Count; i++)
            {
                temp_series.events_list[i].ID = i + 1;
            }

        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (current_selected_event != null)
            {
                ACCGNewEventForm editEventForm = new ACCGNewEventForm(current_selected_event);
                editEventForm.ShowDialog();

                for (int i = 0; i < temp_series.events_list.Count; i++)
                {
                    temp_series.events_list[i].ID = i + 1;
                }
            }
            else
            {
                MessageBox.Show("You have to select an event!");
            }

        }      

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (current_selected_event == null)
            {
                MessageBox.Show("You have to select an event!");
            }
            else
            {
                DialogResult are_you_sure = MessageBox.Show("Are you sure?", "Delete event", MessageBoxButtons.YesNo);

                if (are_you_sure == DialogResult.Yes)
                {                    
                  
                    temp_series.events_list.Remove(current_selected_event);

                    for (int i = 0; i < temp_series.events_list.Count; i++)
                    {
                        temp_series.events_list[i].ID = i + 1;
                    }                    

                    bs_events_datasource.ResetBindings(false);
                    rtbEventsInfo.ResetText();
                }
            }
        }

        private void btnNewOpponent_Click(object sender, EventArgs e)
        {
            ACCGNewOpponentForm newOpponentForm = new ACCGNewOpponentForm();
            newOpponentForm.ShowDialog();

            for (int i = 0; i < temp_series.opponents_list.Count; i++)
            {
                temp_series.opponents_list[i].ID = i + 1;
            }
        }

        private void btnEditOpponent_Click(object sender, EventArgs e)
        {
            if (current_selected_opponent != null)
            {
                ACCGNewOpponentForm editOpponentForm = new ACCGNewOpponentForm(current_selected_opponent);
                editOpponentForm.ShowDialog();

                for (int i = 0; i < temp_series.opponents_list.Count; i++)
                {
                    temp_series.opponents_list[i].ID = i + 1;
                }
            }
            else
            {
                MessageBox.Show("You have to select an opponent!");
            }
            

        }

        private void btnDeleteOpponent_Click(object sender, EventArgs e)
        {
            if (current_selected_opponent == null)
            {
                MessageBox.Show("You have to select an opponent!");
            }
            else
            {
                DialogResult are_you_sure = MessageBox.Show("Are you sure?", "Delete opponent", MessageBoxButtons.YesNo);

                if (are_you_sure == DialogResult.Yes)
                {                    

                    temp_series.opponents_list.Remove(current_selected_opponent);

                    for (int i = 0; i < temp_series.opponents_list.Count; i++)
                    {
                        temp_series.opponents_list[i].ID = i + 1;
                    }
                    
                    bs_opponents_datasource.ResetBindings(false);
                    rtbOpponentsInfo.ResetText();
                }
            }
        }

      

    }

}

