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
using System.Text.RegularExpressions;


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
            
            this.current_selected_series = current_selected_series;

            InitializeComponent();
        }

        private void NewSeriesForm_Load(object sender, EventArgs e)
        {

            if (current_selected_series != null)
            {
                temp_series = current_selected_series;
                tbCode.Text = temp_series.code;
                tbName.Text = temp_series.name;
                tbDescription.Text = temp_series.description;                

                rbChampionship.Checked = temp_series.isChampionship;
                rbSingleEvents.Checked = temp_series.isSingleEvents;
                rbGoalsPoints.Checked = rbChampionship.Checked;

                

                if (rbChampionship.Checked)
                {
                    rbSingleEvents.Enabled = false;
                    tbPoints.Enabled = true;
                    cbCar.Enabled = true;

                    if (temp_series.series_goals.points != "")
                    {
                        rbRanking.Checked = false;
                        tbRanking.Enabled = false;
                        rbGoalsPoints.Checked = true;
                        tbGoalsPoints.Enabled = true;

                        tbGoldTier.Enabled = false;
                        tbSilverTier.Enabled = false;
                        tbBronzeTier.Enabled = false;
                    }
                    else if (temp_series.series_goals.ranking != "")
                    {
                        
                        rbRanking.Checked = true;
                        tbRanking.Enabled = true;
                        rbGoalsPoints.Checked = false;
                        tbGoalsPoints.Enabled = false;

                        tbGoldTier.Enabled = false;
                        tbSilverTier.Enabled = false;
                        tbBronzeTier.Enabled = false;
                    }
                    else
                    {
                        rbRanking.Checked = false;
                        tbRanking.Enabled = false;
                        rbGoalsPoints.Checked = true;
                        tbGoalsPoints.Enabled = true;
                    }
                }
                else
                {
                    rbChampionship.Enabled = false;                    
                    skinPreviewImage = ACCG.Properties.Resources.placeholder;
                }

                
                tbPoints.Text = temp_series.points;
                tbGoalsPoints.Text = temp_series.series_goals.points;
                tbRanking.Text = temp_series.series_goals.ranking;
                tbGoldTier.Text = temp_series.series_goals.tier_3;
                tbSilverTier.Text = temp_series.series_goals.tier_2;
                tbBronzeTier.Text = temp_series.series_goals.tier_1;
                                
                this.Refresh();
            }
            else
            {
                temp_series = new Series();

                if (rbChampionship.Checked)
                {

                    temp_series.isChampionship = rbChampionship.Checked;

                    if (current_selected_series == null)
                    {
                        temp_series.opponents_list = new List<Opponent>();
                    }

                    tbPoints.Enabled = true;
                    cbCar.Enabled = true;
                    cbSkin.Enabled = true;
                    tbRanking.Enabled = false;
                    lbOpponents.Enabled = true;

                    tbGoldTier.Enabled = false;
                    tbSilverTier.Enabled = false;
                    tbBronzeTier.Enabled = false;

                }
                else if (rbSingleEvents.Checked)
                {

                    temp_series.isSingleEvents = rbSingleEvents.Checked;

                    tbPoints.Enabled = false;
                    cbCar.Enabled = false;
                    cbSkin.Enabled = false;

                    lbOpponents.Enabled = false;

                    tbGoldTier.Enabled = true;
                    tbSilverTier.Enabled = true;
                    tbBronzeTier.Enabled = true;

                }
            }                                    
            

            // Populating the requires series combobox
            cbRequires.Items.Add("");

            ac_series_path = Directory.GetDirectories(ACCGMainForm.ac_path, "series*", SearchOption.AllDirectories);

            Array.Sort(ac_series_path, new AlphanumComparatorFast());
                        
            if (ac_series_path.Length != 0)
            {
                for (int i = 1; i < ac_series_path.Length; i++)
                {
                    cbRequires.Sorted = false;
                    cbRequires.Items.Add(ac_series_path[i].Substring(ac_series_path[i].LastIndexOf(@"\") + 1));                    
                }

            }


            if (current_selected_series != null)
            {
                cbRequires.Text = temp_series.requires;
            }
            else
            {
                cbRequires.Text = "";                
            }
            
                                    
            // Populating the models combobox
            foreach (Car car in ACCGMainForm.ac_cars_list)
            {
                cbCar.Items.Add(car.model);
            }


            if (current_selected_series != null && current_selected_series.isChampionship)
            {
                cbCar.Text = temp_series.car.model;
            }
            else
            {
                cbCar.Text = ACCGMainForm.ac_cars_list.ElementAt(0).model;                       
            }
            

            // Set initial car model
            if (current_selected_series != null && current_selected_series.isChampionship)
            {               
                champ_player_car = temp_series.car;
                champ_player_car.skins = ACCGMainForm.ac_cars_list.Find(x => x.model == champ_player_car.model).skins;        
            }
            else
            {
                champ_player_car = ACCGMainForm.ac_cars_list.Find(x => x.model == cbCar.SelectedItem.ToString());
                //temp_series.car = champ_player_car;
            }
            

            // Populating the car skins combo box
            if (current_selected_series == null)
            {
                foreach (Skin skin in ACCGNewSeriesForm.champ_player_car.skins)
                {
                    cbSkin.Items.Add(skin.skin_name);
                }
            }
            

            if (current_selected_series != null && current_selected_series.isChampionship)
            {
                foreach (Skin skin in ACCGNewSeriesForm.champ_player_car.skins)
                {
                    cbSkin.Items.Add(skin.skin_name);
                }
            }
            
            if (current_selected_series != null)
            {
                if (current_selected_series.isChampionship)
                {
                    if (current_selected_series.skin.skin_name == "")
                    {
                        cbSkin.Text = champ_player_car.skins[0].skin_name;
                        skinPreviewImage = champ_player_car.skins[0].skin_preview;
                    }
                    else
                    {
                        cbSkin.Text = temp_series.skin.skin_name;
                        skinPreviewImage = temp_series.skin.skin_preview;
                    }

                    
                }
                
            }
            else
            {
                cbSkin.Text = ACCGNewSeriesForm.champ_player_car.skins[0].skin_name;
                //temp_series.skin = champ_player_car.skins[0];
                skinPreviewImage = champ_player_car.skins[0].skin_preview;
            }
            
            
            ShowData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (temp_series.events_list.Count == 0)
            {
                MessageBox.Show("You need to create at least one event!");
            }
            else if (tbCode.Text == "")
            {
                MessageBox.Show("Missing \"Code\" field!");
            }
            else if(tbName.Text == "") 
            {
                MessageBox.Show("Missing \"Name\" field!");            
            }
            else if(tbDescription.Text == "") 
            {
                MessageBox.Show("Missing \"Description\" field!");
            }
            else if (temp_series.isSingleEvents && tbGoldTier.Text == "")
            {
                MessageBox.Show("Missing \"Gold\" field!");
            }            
            else if (temp_series.isSingleEvents && !ACCGUtility.IsDigit(tbGoldTier.Text))
            {
                MessageBox.Show("Goals Points field have to contain only numbers!");
            }
            else if (temp_series.isSingleEvents && tbSilverTier.Text == "")
            {
                MessageBox.Show("Missing \"Silver\" field!");
            }
            else if (temp_series.isSingleEvents && !ACCGUtility.IsDigit(tbSilverTier.Text))
            {
                MessageBox.Show("Goals Points field have to contain only numbers!");
            }
            else if (temp_series.isSingleEvents && tbBronzeTier.Text == "")
            {
                MessageBox.Show("Missing \"Bronze\" field!");
            }
            else if (temp_series.isSingleEvents && !ACCGUtility.IsDigit(tbBronzeTier.Text))
            {
                MessageBox.Show("Goals Points field have to contain only numbers!");
            }
            else if (temp_series.isChampionship && temp_series.opponents_list.Count == 0)
            {
                MessageBox.Show("You need to create at least one opponent!");
            }
            else if (temp_series.isChampionship && tbPoints.Text == "") 
            {
                MessageBox.Show("Missing \"Points\" field!");
            }
            else if (temp_series.isChampionship && (tbPoints.Text.First() == ',' || tbPoints.Text.Last() == ','))
            {
                MessageBox.Show("The points field can't start or finish with \",\"!");            
            }
            else if (temp_series.isChampionship && !ACCGUtility.IsDigit(tbPoints.Text, ','))
            {
                MessageBox.Show("Points field have to contain only numbers!");
            }
            else if (temp_series.isChampionship && rbGoalsPoints.Checked && tbGoalsPoints.Text == "" ) 
            {                
                MessageBox.Show("Missing \"Goals Points\" field!");
            }
            else if (temp_series.isChampionship && rbGoalsPoints.Checked && !ACCGUtility.IsDigit(tbGoalsPoints.Text))
            {
                MessageBox.Show("Goals Points field have to contain only numbers!");
            }
            else if (temp_series.isChampionship && rbRanking.Checked && tbRanking.Text == "")
            {
                MessageBox.Show("Missing \"Ranking\" field!");
            }
            else if (temp_series.isChampionship && rbRanking.Checked && !ACCGUtility.IsDigit(tbRanking.Text))
            {
                MessageBox.Show("Ranking field have to contain only numbers!");
            }
            else                                                                                      
            {
                temp_series.code = tbCode.Text;
                temp_series.name = tbName.Text;
                temp_series.description = tbDescription.Text;                                
                temp_series.requires = cbRequires.SelectedItem.ToString();                               
                temp_series.isChampionship = rbChampionship.Checked;
                temp_series.isSingleEvents = rbSingleEvents.Checked;
                
                

                if (temp_series.isChampionship)
                {
                    temp_series.car = champ_player_car;
                    temp_series.skin.skin_name = cbSkin.SelectedItem.ToString();
                    temp_series.skin.skin_preview = skinPreviewImage;
                    temp_series.points = tbPoints.Text;                    
                    temp_series.series_goals.points = tbGoalsPoints.Text;
                    temp_series.series_goals.ranking = tbRanking.Text;
                }
                else
                {
                    Car placeholder = new Car();
                    placeholder.model = "";
                    placeholder.skins.Add(new Skin());
                    temp_series.car = placeholder;
                    temp_series.series_goals.tier_1 = tbBronzeTier.Text;
                    temp_series.series_goals.tier_2 = tbSilverTier.Text;
                    temp_series.series_goals.tier_3 = tbGoldTier.Text;
                }

                ACCGUtility.RemoveDiacritics(temp_series);
                    
                // Add the current series to ACCG main series list
                if (current_selected_series != null) // Edit mode
                {
                    current_selected_series.isEdited = true;
                    int series_index = ACCGMainForm.accg_series_list.IndexOf(current_selected_series);
                    ACCGMainForm.accg_series_list.Remove(current_selected_series);
                    ACCGMainForm.accg_series_list.Insert(series_index,temp_series);
                }
                else // New series mode
                {
                    ACCGMainForm.accg_series_list.Add(temp_series);
                }
                
                // Need datasource
                ACCGMainForm.bs_series_datasource.ResetBindings(false);
                
                // Saving the accg series list                 
                ACCGMainForm.accg_resource.SaveACCGSeries(ACCGMainForm.accg_series_file_name, ACCGMainForm.accg_series_list);                               

                this.Close();
            }
                             
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbChampionship_CheckedChanged(object sender, EventArgs e)
        {
            temp_series.isChampionship = rbChampionship.Checked;

            tbPoints.Enabled = rbChampionship.Checked;
            grbCar.Enabled = rbChampionship.Checked;
            grbOpponents.Enabled = rbChampionship.Checked;

            rbGoalsPoints.Enabled = rbChampionship.Checked;
            tbGoalsPoints.Enabled = rbGoalsPoints.Checked;

            rbRanking.Enabled = rbChampionship.Checked;
            tbRanking.Enabled = rbRanking.Checked;

            tbGoldTier.Text = "";
            tbSilverTier.Text = "";
            tbBronzeTier.Text = "";
        }

        private void rbSingleEvents_CheckedChanged(object sender, EventArgs e)
        {
            temp_series.isSingleEvents = rbSingleEvents.Checked;

            tbGoldTier.Enabled = rbSingleEvents.Checked;
            tbSilverTier.Enabled = rbSingleEvents.Checked;
            tbBronzeTier.Enabled = rbSingleEvents.Checked;

            tbPoints.Text = "";
            tbGoalsPoints.Text = "";
            tbGoalsPoints.Enabled = false;
            tbRanking.Text = "";
            tbRanking.Enabled = false;
        }

        private void rbGoalsPoints_CheckedChanged(object sender, EventArgs e)
        {
            tbGoalsPoints.Enabled = rbGoalsPoints.Checked;
            if (rbGoalsPoints.Checked)
            {
                tbRanking.Text = "";
            }
        }

        private void rbRanking_CheckedChanged(object sender, EventArgs e)
        {
            tbRanking.Enabled = rbRanking.Checked;
            if (rbRanking.Checked)
            {
                tbGoalsPoints.Text = "";
            }
        }

        private void cbCar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            champ_player_car = ACCGMainForm.ac_cars_list.Find(x => x.model == cbCar.SelectedItem.ToString());

            // Re-populating the car skins combo box
            cbSkin.Items.Clear();

            foreach (Skin skin in ACCGNewSeriesForm.champ_player_car.skins)
            {
                cbSkin.Items.Add(skin.skin_name);
            }

            cbSkin.Text = ACCGNewSeriesForm.champ_player_car.skins[0].skin_name;
            skinPreviewImage = ACCGNewSeriesForm.champ_player_car.skins[0].skin_preview;
            skinPreviewImagePanel.Refresh();
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
                    if (pair.Value == current_selected_event.time)//Convert.ToInt32(current_selected_event.time))
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

                if (temp_series.isSingleEvents)
                {
                    rtbEventsInfo.AppendText("Car: " + current_selected_event.event_car.model + "\n");
                    rtbEventsInfo.AppendText("Skin: " + current_selected_event.event_car_skin.skin_name + "\n"); 
                }
                
                rtbEventsInfo.AppendText("Number of cars: " + current_selected_event.numberOfCars + "\n");
                rtbEventsInfo.AppendText("Penalties: " + current_selected_event.penalties + "\n");

                if (temp_series.isChampionship)
                {
                    try
                    {
                        rtbEventsInfo.AppendText("Laps: " + current_selected_event.session_list.Find(x => x.type == 3).laps + "\n");
                    }
                    catch (Exception exc)
                    {
                        ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
                        Console.WriteLine("The process failed: {0}", exc.ToString());
                    }
                   
                }
                else
                {
                    rtbEventsInfo.AppendText("Laps: " + current_selected_event.numberOfLaps + "\n");
                }
                
            
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
                rtbOpponentsInfo.AppendText("Car: " + current_selected_opponent.car_model.model + "\n");
                rtbOpponentsInfo.AppendText("Skin: " + current_selected_opponent.skin.skin_name + "\n");
                rtbOpponentsInfo.AppendText("Setup: " + current_selected_opponent.setup + "\n");
                rtbOpponentsInfo.AppendText("AI Level: " + current_selected_opponent.ai_level.ToString());
            }

            
        }

        private void btnLoadEvent_Click(object sender, EventArgs e)
        {
            openEventFileDialog.InitialDirectory = ACCGMainForm.ac_path + @"\content\career";

            if (openEventFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openEventFileDialog.FileName;

                if (current_selected_series != null)
                {
                    current_selected_series.events_list.Add(ACCGMainForm.accg_resource.LoadEvent(filename));
                }
                else
                {
                    temp_series.events_list.Add(ACCGMainForm.accg_resource.LoadEvent(filename));
                }

                bs_events_datasource.ResetBindings(false);
                ShowData();

                rtbEventsInfo.ResetText();
            }
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            if (saveEventFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = saveEventFileDialog.FileName;

                if (current_selected_series != null)
                {
                    ACCGMainForm.accg_resource.SaveEvent(current_selected_series, current_selected_event, filename);
                }
                else
                {
                    ACCGMainForm.accg_resource.SaveEvent(temp_series, current_selected_event, filename);
                }
            }
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {

            if (temp_series.isChampionship)
            {
                
                ACCGNewChampionshipEventForm newEventForm = new ACCGNewChampionshipEventForm();
                newEventForm.Text = "New Championship Event";
                newEventForm.ShowDialog();

                if (temp_series.events_list.Count == 0)
                {
                    rbSingleEvents.Enabled = true;
                }
                else rbSingleEvents.Enabled = false;
            }
            else
            {
                
                ACCGNewSingleEventForm newSingleEventForm = new ACCGNewSingleEventForm();
                newSingleEventForm.Text = "New Single Event";
                newSingleEventForm.ShowDialog();

                if (temp_series.events_list.Count == 0)
                {
                    rbChampionship.Enabled = true;
                }
                else rbChampionship.Enabled = false;
            }
            
            for (int i = 0; i < temp_series.events_list.Count; i++)
            {
                temp_series.events_list[i].ID = i + 1;
            }

        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (current_selected_event != null)
            {
                if (temp_series.isChampionship)
                {
                    ACCGNewChampionshipEventForm editEventForm = new ACCGNewChampionshipEventForm(current_selected_event);
                    editEventForm.Text = "Edit Event " + current_selected_event.name;
                    editEventForm.ShowDialog();
                }
                else
                {
                    ACCGNewSingleEventForm editSingleEventForm = new ACCGNewSingleEventForm(current_selected_event);
                    editSingleEventForm.Text = "Edit Event " + current_selected_event.name;
                    editSingleEventForm.ShowDialog();
                }
                
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

                    if (temp_series.isChampionship)
                    {
                        if (temp_series.events_list.Count == 0)
                        {
                            rbSingleEvents.Enabled = true;
                        }
                        else rbSingleEvents.Enabled = false;
                    }
                    else
                    {
                        if (temp_series.events_list.Count == 0)
                        {
                            rbChampionship.Enabled = true;
                        }
                        else rbChampionship.Enabled = false;
                    }
                }
            }
        }


        private void btnLoadOpponents_Click(object sender, EventArgs e)
        {
            if (openOpponentsFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openOpponentsFileDialog.FileName;
                
                if (current_selected_series != null)
                {
                    current_selected_series.opponents_list = ACCGMainForm.accg_resource.LoadOpponents(filename);
                    
                }
                else
                {
                    temp_series.opponents_list = ACCGMainForm.accg_resource.LoadOpponents(filename);
                    
                }

                bs_opponents_datasource.ResetBindings(false);
                ShowData();

                rtbOpponentsInfo.ResetText();
                
            }
        }


        private void btnSaveOpponents_Click(object sender, EventArgs e)
        {
            
            if (saveOpponentsFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = saveOpponentsFileDialog.FileName;

                if (current_selected_series != null)
                {
                    ACCGMainForm.accg_resource.SaveOpponents(current_selected_series.opponents_list, filename);
                }
                else
                {
                    ACCGMainForm.accg_resource.SaveOpponents(temp_series.opponents_list, filename);
                }
            }
        }

        private void btnNewOpponent_Click(object sender, EventArgs e)
        {
            ACCGNewOpponentForm newOpponentForm = new ACCGNewOpponentForm();
            newOpponentForm.Text = "New Opponent";
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
                editOpponentForm.Text = "Edit Opponent " + current_selected_opponent.name;
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
        
        private void btnOpenStartImage_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openImageFileDialog.FileName;                
                Image image = Image.FromFile(filename);

                if(image.Width != 1240 && image.Height != 560){

                    MessageBox.Show("Image size must be 1240x560");

                }
                else
                {
                    temp_series.startImage = (Bitmap)image;                                                         
                    startThumbnailImage = (Bitmap)temp_series.startImage.GetThumbnailImage(100, 100, null, new IntPtr());
                }
                                
            }

            this.Refresh();
        }

        private void btnOpenPreviewImage_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openImageFileDialog.FileName;
                Image image = Image.FromFile(filename);

                if (image.Width != 206 && image.Height != 206)
                {
                    MessageBox.Show("Image size must be 206x206");
                }
                else
                {
                    temp_series.previewImage = (Bitmap)image;
                    previewThumbnailImage = (Bitmap)temp_series.previewImage.GetThumbnailImage(100, 100, null, new IntPtr());
                }
                
            }

            this.Refresh();
        }

        private void startImagePanel_Paint(object sender, PaintEventArgs e)
        {
            if (current_selected_series != null)
            {
                if (temp_series.startImage != null)
                {
                    try
                    {
                        startThumbnailImage = (Bitmap)ACCGUtility.ScaleImage(temp_series.startImage, startImagePanel.Width, startImagePanel.Height);
                    }
                    catch (Exception exc)
                    {
                        ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
                    }
                    
                }
                else
                {
                    e.Graphics.DrawImage(
                    ACCG.Properties.Resources.placeholder_1240_560,
                    0,
                    0,
                    ACCG.Properties.Resources.placeholder_1240_560.Width,
                    ACCG.Properties.Resources.placeholder_1240_560.Height
                    );
                }
            }
            else if(startThumbnailImage != null)
            {
                startThumbnailImage = (Bitmap)ACCGUtility.ScaleImage(startThumbnailImage, startImagePanel.Width, startImagePanel.Height);
            }
            

            if (startThumbnailImage != null)
            {
                e.Graphics.DrawImage(startThumbnailImage, 0, 0, startImagePanel.Width, startImagePanel.Height);
            }
            else
            {
                e.Graphics.DrawImage(
                    ACCG.Properties.Resources.placeholder_1240_560, 
                    0, 
                    0, 
                    ACCG.Properties.Resources.placeholder_1240_560.Width, 
                    ACCG.Properties.Resources.placeholder_1240_560.Height
                    );
            }
        }

        private void previewImagePanel_Paint(object sender, PaintEventArgs e)
        {
            if (current_selected_series != null) 
            {
                if (temp_series.previewImage != null)
                {
                    try
                    {
                        previewThumbnailImage = (Bitmap)temp_series.previewImage.GetThumbnailImage(100, 100, null, new IntPtr());
                    }
                    catch (Exception exc)
                    {
                        ACCGMainForm.accg_log.WriteLog("ERROR", "The process failed: " + exc.ToString());
                    }
                    
                }
                else
                {
                    e.Graphics.DrawImage(
                    ACCG.Properties.Resources.placeholder_206_206,
                    0,
                    0,
                    ACCG.Properties.Resources.placeholder_206_206.Width,
                    ACCG.Properties.Resources.placeholder_206_206.Height
                    );
                }
            }

            if (previewThumbnailImage != null) 
            {
                e.Graphics.DrawImage(previewThumbnailImage, 0, 0, previewThumbnailImage.Width, previewThumbnailImage.Height);
            }
            else 
            {
                e.Graphics.DrawImage(
                    ACCG.Properties.Resources.placeholder_206_206,
                    0,
                    0,
                    ACCG.Properties.Resources.placeholder_206_206.Width,
                    ACCG.Properties.Resources.placeholder_206_206.Height
                    );
            }

        }
        
        private void cbSkin_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            skinPreviewImage = ACCGNewSeriesForm.champ_player_car.skins.Find(x => x.skin_name == cbSkin.SelectedItem.ToString()).skin_preview;
            if (skinPreviewImage == null){
                skinPreviewImage = ACCG.Properties.Resources.placeholder;
            }
            skinPreviewImagePanel.Refresh();
        }

        private void skinPreviewImagePanel_Paint(object sender, PaintEventArgs e)
        {
            
            if (temp_series.isChampionship)
            {
                Bitmap skinPreviewImageThumb = (Bitmap)ACCGUtility.ScaleImage(skinPreviewImage, skinPreviewImagePanel.Width, skinPreviewImagePanel.Height);

                e.Graphics.DrawImage(skinPreviewImageThumb,
                0,
                0,
                skinPreviewImageThumb.Width,
                skinPreviewImageThumb.Height);
            }
            else
            {                                
                e.Graphics.DrawImage(skinPreviewImage,
                0,
                0,
                skinPreviewImage.Width,
                skinPreviewImage.Height);
            }
            
            
        }

        

        

                                       

    }

}

