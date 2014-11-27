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
            // TODO: Complete member initialization
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

                if (rbChampionship.Checked)
                {
                    rbSingleEvents.Enabled = false;
                }
                else
                {
                    rbChampionship.Enabled = false;
                }

                tbPoints.Text = temp_series.points;
                tbGoalsPoints.Text = temp_series.series_goals.points;

                tbGoldTier.Text = temp_series.series_goals.tier_1;
                tbSilverTier.Text = temp_series.series_goals.tier_2;
                tbBronzeTier.Text = temp_series.series_goals.tier_3;
                                
                this.Refresh();
            }
            else
            {
                temp_series = new Series();              
            }                                    
            
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
                tbGoalsPoints.Enabled = true;
                lbOpponents.Enabled = true;

                tbGoldTier.Enabled = false;
                tbSilverTier.Enabled = false;
                tbBronzeTier.Enabled = false;
               
            }
            else
            {

                temp_series.isSingleEvents = rbSingleEvents.Checked;

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
                cbRequires.Text = ac_series_path[1].Substring(ac_series_path[0].LastIndexOf(@"\") + 1);                
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
            foreach (Skin skin in ACCGNewSeriesForm.champ_player_car.skins)
            {
                cbSkin.Items.Add(skin.skin_name);
            }

            if (current_selected_series != null)
            {
                cbSkin.Text = temp_series.skin.skin_name;
                skinPreviewImage = temp_series.skin.skin_preview;
            }
            else
            {
                cbSkin.Text = ACCGNewSeriesForm.champ_player_car.skins[0].skin_name;
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
                MessageBox.Show("");
            }
            else if (temp_series.isSingleEvents && !IsDigit(tbGoldTier.Text))
            {
                MessageBox.Show("Goals Points field have to contain only numbers!");
            }
            else if (temp_series.isSingleEvents && tbSilverTier.Text == "")
            {
                MessageBox.Show("");
            }
            else if (temp_series.isSingleEvents && !IsDigit(tbSilverTier.Text))
            {
                MessageBox.Show("Goals Points field have to contain only numbers!");
            }
            else if (temp_series.isSingleEvents && tbBronzeTier.Text == "")
            {
                MessageBox.Show("");
            }
            else if (temp_series.isSingleEvents && !IsDigit(tbBronzeTier.Text))
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
            else if (temp_series.isChampionship && !IsDigit(tbPoints.Text, ','))
            {
                MessageBox.Show("Points field have to contain only numbers!");
            }
            else if (temp_series.isChampionship && tbGoalsPoints.Text == "" ) 
            {                
                MessageBox.Show("Missing \"Goals\" field!");
            }
            else if (temp_series.isChampionship && !IsDigit(tbGoalsPoints.Text))
            {
                MessageBox.Show("Goals Points field have to contain only numbers!");
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
                    temp_series.model = champ_player_car;
                    temp_series.skin.skin_name = cbSkin.SelectedItem.ToString();
                    temp_series.skin.skin_preview = skinPreviewImage;
                    temp_series.points = tbPoints.Text;
                    temp_series.series_goals.points = tbGoalsPoints.Text;
                }
                else
                {
                    Car placeholder = new Car();
                    placeholder.model = "";
                    placeholder.skins.Add(new Skin());
                    temp_series.model = placeholder;
                    temp_series.series_goals.tier_1 = tbGoldTier.Text;
                    temp_series.series_goals.tier_2 = tbSilverTier.Text;
                    temp_series.series_goals.tier_3 = tbBronzeTier.Text;
                }                                    
                
                temp_series.isEdited = false;
                temp_series.isGenerated = false;

                /*
                string[] ac_series_id_list = Directory.GetDirectories(ACCGMainForm.ac_path, "series*", SearchOption.AllDirectories);
                int[] numbers = new int[ac_series_id_list.Length];

                if (ac_series_id_list.Length != 0)
                {
                    for (int i = 0; i < ac_series_id_list.Length; i++)
                    {
                        numbers[i] = Convert.ToInt32(ac_series_id_list[i].Substring(ac_series_id_list[i].LastIndexOf(@"s") + 1));
                    }

                }
                               
                temp_series.ID = numbers.Max() + 1;
                  */              
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
                ACCGMainForm.accg_resource.SaveACCGSeries(ACCGMainForm.accg_series_file_name, ACCGMainForm.accg_series_list, e);                               

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

            tbGoalsPoints.Enabled = rbChampionship.Checked;

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

                if (temp_series.isSingleEvents)
                {
                    rtbEventsInfo.AppendText("Car: " + current_selected_event.event_car + "\n");
                    rtbEventsInfo.AppendText("Skin: " + current_selected_event.event_car_skin + "\n"); 
                }
                
                rtbEventsInfo.AppendText("Number of cars: " + current_selected_event.numberOfCars + "\n");
                rtbEventsInfo.AppendText("Penalties: " + current_selected_event.penalties + "\n");

                if (temp_series.isChampionship)
                {
                    rtbEventsInfo.AppendText("Laps: " + current_selected_event.session_list.Find(x => x.type == 3).laps + "\n");
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
                rtbOpponentsInfo.AppendText("Car: " + current_selected_opponent.model.model + "\n");
                rtbOpponentsInfo.AppendText("Skin: " + current_selected_opponent.skin.skin_name + "\n");
                rtbOpponentsInfo.AppendText("Setup: " + current_selected_opponent.setup + "\n");
                rtbOpponentsInfo.AppendText("AI Level: " + current_selected_opponent.ai_level.ToString());
            }

            
        }


        private void btnNewEvent_Click(object sender, EventArgs e)
        {

            if (temp_series.isChampionship)
            {
                ACCGNewChampionshipEventForm newEventForm = new ACCGNewChampionshipEventForm();
                newEventForm.Text = "New Championship Event";
                newEventForm.ShowDialog();
            }
            else
            {
                ACCGNewSingleEventForm newSingleEventForm = new ACCGNewSingleEventForm();
                newSingleEventForm.Text = "New Single Event";
                newSingleEventForm.ShowDialog();
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

        private bool IsDigit(string text)
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

        private bool IsDigit(string text, char exclude)
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
                    startThumbnailImage = (Bitmap)ACCGMainForm.accg_resource.ScaleImage(temp_series.startImage, startImagePanel.Width, startImagePanel.Height);
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
                startThumbnailImage = (Bitmap)ACCGMainForm.accg_resource.ScaleImage(startThumbnailImage, startImagePanel.Width, startImagePanel.Height);
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
                    previewThumbnailImage = (Bitmap)temp_series.previewImage.GetThumbnailImage(100, 100, null, new IntPtr());
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
            skinPreviewImagePanel.Refresh();
        }

        private void skinPreviewImagePanel_Paint(object sender, PaintEventArgs e)
        {
            Bitmap skinPreviewImageThumb = (Bitmap)ACCGMainForm.accg_resource.ScaleImage(skinPreviewImage, skinPreviewImagePanel.Width, skinPreviewImagePanel.Height);

            e.Graphics.DrawImage(skinPreviewImageThumb,
                0,
                0,
                skinPreviewImageThumb.Width,
                skinPreviewImageThumb.Height);
        }

       
        

       
              

    }

}

