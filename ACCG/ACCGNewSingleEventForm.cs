using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCG
{
    public partial class ACCGNewSingleEventForm : Form
    {
        private Event current_selected_event;

        public ACCGNewSingleEventForm()
        {
            InitializeComponent();
        }

        public ACCGNewSingleEventForm(Event current_selected_event)
        {
            // For edit mode
            this.current_selected_event = current_selected_event;

            InitializeComponent();
        }

        private void ACCGNewSingleEventForm_Load(object sender, EventArgs e)
        {

            grbTimeAttackGoals.Enabled = rbTimeAttack.Checked;
            grbHotlapGoals.Enabled = rbHotlap.Checked;
            grbQuickRace.Enabled = rbQuickRace.Checked;            
           
            if (current_selected_event != null)
            {
                temp_event = current_selected_event;
                tbName.Text = current_selected_event.name;
                tbDescription.Text = current_selected_event.description;

                tkbAmbientTemperature.Value = current_selected_event.ambient_temperature;
                lblAmbTemperatureValue.Text = tkbAmbientTemperature.Value.ToString() + " °C";

                tkbTime.Value = current_selected_event.time;
                // Bad code
                foreach (KeyValuePair<string, int> pair in ACCGMainForm.time_table)
                {
                    if (pair.Value == current_selected_event.time)
                    {
                        lblTimeValue.Text = pair.Key;
                        break;
                    }
                }

                tkbTrackCondition.Value = current_selected_event.dynamic_track_preset;
                // I don't like this way
                switch (tkbTrackCondition.Value)
                {
                    case 0:
                        lblTrackConditionValue.Text = "Dusty";
                        break;

                    case 1:
                        lblTrackConditionValue.Text = "Old";
                        break;

                    case 2:
                        lblTrackConditionValue.Text = "Slow";
                        break;

                    case 3:
                        lblTrackConditionValue.Text = "Green";
                        break;

                    case 4:
                        lblTrackConditionValue.Text = "Fast";
                        break;

                    case 5:
                        lblTrackConditionValue.Text = "Optimum";
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }                                                            

                               
                cbTrack.Text = current_selected_event.track;

                if (current_selected_event.isQuickRace)
                {
                    rbTimeAttack.Enabled = false;

                    tkbNumberOfCars.Value = current_selected_event.numberOfCars;
                    lblNumberOfCarsValue.Text = current_selected_event.numberOfCars.ToString();

                    tkbNumberOfLaps.Value = current_selected_event.numberOfLaps;
                    lblNumberOfLapsValue.Text = current_selected_event.numberOfLaps.ToString();

                    tkbStartPosition.Value = current_selected_event.start_position;
                    lblStartPositionValue.Text = current_selected_event.start_position.ToString();
                    
                    tbPositionGoldTier.Text = current_selected_event.event_goals.tier_3;
                    tbPositionSilverTier.Text = current_selected_event.event_goals.tier_2;
                    tbPositionBronzeTier.Text = current_selected_event.event_goals.tier_1;
                }
                else if(current_selected_event.isTimeAttack)
                {
                    rbQuickRace.Enabled = false;
                    grbQuickRace.Enabled = false;

                    tbPositionGoldTier.Enabled = false;
                    tbPositionSilverTier.Enabled = false;
                    tbPositionBronzeTier.Enabled = false;

                    rbTimeAttack.Checked = true;

                    tbPointsGoldTier.Enabled = true;
                    tbPointsSilverTier.Enabled = true;
                    tbPointsBronzeTier.Enabled = true;

                    tbPointsGoldTier.Text = current_selected_event.event_goals.tier_3;
                    tbPointsSilverTier.Text = current_selected_event.event_goals.tier_2;
                    tbPointsBronzeTier.Text = current_selected_event.event_goals.tier_1;
                }
                else if (current_selected_event.isHotlap)
                {

                }

            }
            else
            {
                temp_event = new Event();
                temp_event.isTimeAttack = rbTimeAttack.Checked;
                temp_event.isQuickRace = rbQuickRace.Checked;
                temp_event.isHotlap = rbHotlap.Checked;
            }

            if (current_selected_event == null && rbQuickRace.Checked)
            {
                temp_event.opponents_list = new List<Opponent>();
            }

           

            // Populating the track combo box
            foreach (string track in ACCGMainForm.ac_tracks_list)
            {
                cbTrack.Items.Add(track);               
            }

            if(current_selected_event != null)
            {              
                cbTrack.Text = current_selected_event.track;
            }
            else
            {
                cbTrack.Text = ACCGMainForm.ac_tracks_list[0];                
            }

            // Populating the cars combo box
            foreach (Car car in ACCGMainForm.ac_cars_list)
            {
                cbCar.Items.Add(car.model);
            }

            if(current_selected_event != null)
            {
                cbCar.Text = current_selected_event.event_car.model;
            }
            else
            {
                cbCar.Text = ACCGMainForm.ac_cars_list[0].model;
            }

            event_car = ACCGMainForm.ac_cars_list.Find(x => x.model == cbCar.SelectedItem.ToString());

            // Populating the skins combo box
            foreach (Skin skin in event_car.skins)
            {
                cbSkin.Items.Add(skin.skin_name);                
            }

            if (current_selected_event != null)
            {
                cbSkin.Text = current_selected_event.event_car_skin.skin_name;
                skinPreviewImage = current_selected_event.event_car_skin.skin_preview;
            }
            else
            {
                cbSkin.Text = event_car.skins[0].skin_name;
                skinPreviewImage = event_car.skins[0].skin_preview;
            }
            
            ShowData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("missing \"Name\" field!");
            }
            else if (tbDescription.Text == "")
            {
                MessageBox.Show("Missing \"Description\" field!");
            }
            else if (temp_event.isQuickRace && temp_event.opponents_list.Count == 0)
            {
                MessageBox.Show("You need to create at least one opponent!");
            }
            else if (temp_event.isQuickRace && tbPositionGoldTier.Text == "" )
            {
                MessageBox.Show("Missing \"Gold Position\" field!");
            }
            else if(temp_event.isQuickRace && !ACCGUtility.IsDigit(tbPositionGoldTier.Text))
            {
                MessageBox.Show("Gold Position field have to contain only numbers!");
            }
            else if (temp_event.isQuickRace && tbPositionSilverTier.Text == "")
            {
                MessageBox.Show("Missing \"Silver Position\" field!");
            }
            else if (temp_event.isQuickRace && !ACCGUtility.IsDigit(tbPositionSilverTier.Text))
            {
                MessageBox.Show("Silver Position field have to contain only numbers!");
            }
            else if (temp_event.isQuickRace && tbPositionBronzeTier.Text == "")
            {
                MessageBox.Show("Missing \"Bronze Position\" field!");
            }
            else if (temp_event.isQuickRace && !ACCGUtility.IsDigit(tbPositionBronzeTier.Text))
            {
                MessageBox.Show("Bronze Position field have to contain only numbers!");
            }
            else if (temp_event.isTimeAttack && tbPointsGoldTier.Text == "")
            {
                MessageBox.Show("Missing \"Gold Points\" field!");
            }
            else if(temp_event.isTimeAttack && !ACCGUtility.IsDigit(tbPointsGoldTier.Text)) 
            {
                MessageBox.Show("Gold Points field have to contain only numbers!");
            }
            else if (temp_event.isTimeAttack && tbPointsSilverTier.Text == "")
            {
                MessageBox.Show("Missing \"Silver Points\" field");
            }
            else if (temp_event.isTimeAttack && !ACCGUtility.IsDigit(tbPointsSilverTier.Text))
            {
                MessageBox.Show("Silver Points field have to contain only numbers!");
            }
            else if (temp_event.isTimeAttack && tbPointsBronzeTier.Text == "")
            {
                MessageBox.Show("Missing \"Bronze Points\" field!");
            }
            else if (temp_event.isTimeAttack && !ACCGUtility.IsDigit(tbPointsBronzeTier.Text))
            {
                MessageBox.Show("Bronze Points field have to contain only numbers!");
            }
            

            else
            {
                int event_index = 0;

                // Edit mode
                if (current_selected_event != null)
                {
                    event_index = ACCGNewSeriesForm.temp_series.events_list.IndexOf(temp_event);
                    ACCGNewSeriesForm.temp_series.events_list.Remove(current_selected_event);
                }

                temp_event.name = tbName.Text;
                temp_event.description = tbDescription.Text;
                temp_event.ambient_temperature = tkbAmbientTemperature.Value;
                temp_event.time = tkbTime.Value;
                temp_event.dynamic_track_preset = tkbTrackCondition.Value;

                temp_event.event_car = event_car;
                temp_event.event_car_skin.skin_name = cbSkin.SelectedItem.ToString();
                temp_event.event_car_skin.skin_preview = skinPreviewImage;

                temp_event.session_list = new List<Session>();

                if (temp_event.isQuickRace)
                {

                    if (current_selected_event != null)
                    {
                        temp_event.session_list.Remove(temp_event.session_list.Find(x => x.type == 3));
                    }
                    Session quickrace_session = new Session();

                    quickrace_session.ID = 0;
                    quickrace_session.name = "Quick Race";
                    quickrace_session.type = 3;
                    quickrace_session.spawn_set = "START";
                    quickrace_session.duration_minutes = 0;
                    quickrace_session.laps = tkbNumberOfLaps.Value;
                    temp_event.numberOfLaps = tkbNumberOfLaps.Value;
                    temp_event.session_list.Add(quickrace_session);

                    temp_event.start_position = tkbStartPosition.Value;
                    temp_event.track = cbTrack.SelectedItem.ToString();                                        
                    temp_event.numberOfCars = tkbNumberOfCars.Value;                    
                    
                    
                    temp_event.event_goals.tier_1 = tbPositionBronzeTier.Text;
                    temp_event.event_goals.tier_2 = tbPositionSilverTier.Text;
                    temp_event.event_goals.tier_3 = tbPositionGoldTier.Text;
                }
                else if(temp_event.isTimeAttack)
                {

                    if (current_selected_event != null)
                    {
                        temp_event.session_list.Remove(temp_event.session_list.Find(x => x.type == 5));
                    }

                    Session timeattack_session = new Session();

                    timeattack_session.ID = 0;
                    timeattack_session.name = "Time Attack";
                    timeattack_session.type = 5;
                    timeattack_session.spawn_set = "START";

                    temp_event.session_list.Add(timeattack_session);

                    temp_event.track = cbTrack.SelectedItem.ToString();
                    
                    temp_event.event_goals.tier_1 = tbPointsBronzeTier.Text;
                    temp_event.event_goals.tier_2 = tbPointsSilverTier.Text;
                    temp_event.event_goals.tier_3 = tbPointsGoldTier.Text;
                }
                else if (temp_event.isHotlap)
                {

                }

                if (current_selected_event != null)
                {
                    ACCGNewSeriesForm.temp_series.events_list.Insert(event_index, temp_event);
                }
                else
                {
                    ACCGNewSeriesForm.temp_series.events_list.Add(temp_event);
                }

                ACCGNewSeriesForm.bs_events_datasource.ResetBindings(false);
                
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tkbAmbientTemperature_Scroll(object sender, EventArgs e)
        {
            lblAmbTemperatureValue.Text = tkbAmbientTemperature.Value + " °C";
        }

        // Bad code, not work properly
        private void tkbTime_Scroll(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, int> pair in ACCGMainForm.time_table)
            {
                if (pair.Value == tkbTime.Value)
                {
                    lblTimeValue.Text = pair.Key;
                    break;
                }
            }

        }

        private void tkbCondition_Scroll(object sender, EventArgs e)
        {
            // placeolder code
            switch (tkbTrackCondition.Value)
            {
                case 0:
                    lblTrackConditionValue.Text = "Dusty";
                    break;

                case 1:
                    lblTrackConditionValue.Text = "Old";
                    break;

                case 2:
                    lblTrackConditionValue.Text = "Slow";
                    break;

                case 3:
                    lblTrackConditionValue.Text = "Green";
                    break;

                case 4:
                    lblTrackConditionValue.Text = "Fast";
                    break;

                case 5:
                    lblTrackConditionValue.Text = "Optimum";
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        private void tkbNumberOfCars_Scroll(object sender, EventArgs e)
        {
            lblNumberOfCarsValue.Text = tkbNumberOfCars.Value + " cars";
        }

        private void tkbNumberOfLaps_Scroll(object sender, EventArgs e)
        {
            lblNumberOfLapsValue.Text = tkbNumberOfLaps.Value + " laps";
        }

        private void tkbStartPosition_Scroll(object sender, EventArgs e)
        {
            lblStartPositionValue.Text = tkbStartPosition.Value + "";
        }

        private void lbOpponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_selected_opponent = (Opponent)lbOpponents.SelectedItem;
        }

        private void btnNewOpponent_Click(object sender, EventArgs e)
        {
            ACCGNewOpponentForm newOpponentForm = new ACCGNewOpponentForm();
            newOpponentForm.Text = "New Opponent";
            newOpponentForm.ShowDialog();

            for (int i = 0; i < temp_event.opponents_list.Count; i++)
            {
                temp_event.opponents_list[i].ID = i + 1;
            }
        }

        private void btnEditOpponent_Click(object sender, EventArgs e)
        {
            if (current_selected_opponent != null)
            {
                ACCGNewOpponentForm editOpponentForm = new ACCGNewOpponentForm(current_selected_opponent);
                editOpponentForm.Text = "Edit Opponent " + current_selected_opponent.name;
                editOpponentForm.ShowDialog();

                for (int i = 0; i < temp_event.opponents_list.Count; i++)
                {
                    temp_event.opponents_list[i].ID = i + 1;
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

                    temp_event.opponents_list.Remove(current_selected_opponent);

                    for (int i = 0; i < temp_event.opponents_list.Count; i++)
                    {
                        temp_event.opponents_list[i].ID = i + 1;
                    }

                    bs_opponents_datasource.ResetBindings(false);
                }
            }
        }

        private void rbQuickRace_CheckedChanged(object sender, EventArgs e)
        {
            temp_event.isQuickRace = rbQuickRace.Checked;
            grbQuickRace.Enabled = rbQuickRace.Checked;                                               
        }

        private void rbTimeAttack_CheckedChanged(object sender, EventArgs e)
        {
            temp_event.isTimeAttack = rbTimeAttack.Checked;
            grbTimeAttackGoals.Enabled = rbTimeAttack.Checked;            
        }

        private void rbHotlap_CheckedChanged(object sender, EventArgs e)
        {
            temp_event.isHotlap = rbHotlap.Checked;
            grbHotlapGoals.Enabled = rbHotlap.Checked;
        }

        private void cbCar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            event_car = ACCGMainForm.ac_cars_list.Find(x => x.model == cbCar.SelectedItem.ToString());

            // Re-populating the car skins combo box
            cbSkin.Items.Clear();

            foreach (Skin skin in event_car.skins)
            {
                cbSkin.Items.Add(skin.skin_name);
            }

            cbSkin.Text = event_car.skins[0].skin_name;
            skinPreviewImage = event_car.skins[0].skin_preview;
            skinPreviewImagePanel.Refresh();
        }

        private void cbSkin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            skinPreviewImage = event_car.skins.Find(x => x.skin_name == cbSkin.SelectedItem.ToString()).skin_preview;
            skinPreviewImagePanel.Refresh();
        }

        private void skinPreviewImagePanel_Paint(object sender, PaintEventArgs e)
        {
            Bitmap skinPreviewImageThumb = (Bitmap)ACCGUtility.ScaleImage(skinPreviewImage, skinPreviewImagePanel.Width, skinPreviewImagePanel.Height);
            e.Graphics.DrawImage(skinPreviewImageThumb,
                0,
                0,
                skinPreviewImageThumb.Width,
                skinPreviewImageThumb.Height);
        }

        private void btnOpenPreviewImage_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openImageFileDialog.FileName;
                Image image = Image.FromFile(filename);

                if (image.Width != 250 && image.Height != 125)
                {
                    MessageBox.Show("Image size must be 250x125");
                }
                else
                {
                    temp_event.previewImage = (Bitmap)image;

                }

            }

            previewImagePanel.Refresh();
        }

        private void previewImagePanel_Paint(object sender, PaintEventArgs e)
        {
            if (current_selected_event != null)
            {
                if (temp_event.previewImage != null)
                {
                    e.Graphics.DrawImage(current_selected_event.previewImage, 0, 0, current_selected_event.previewImage.Width, current_selected_event.previewImage.Height);
                }
                else
                {
                    e.Graphics.DrawImage(
                    ACCG.Properties.Resources.placeholder_250_125,
                    0,
                    0,
                    ACCG.Properties.Resources.placeholder_250_125.Width,
                    ACCG.Properties.Resources.placeholder_250_125.Height
                    );
                }

            }
            else if (temp_event.previewImage != null)
            {
                e.Graphics.DrawImage(temp_event.previewImage, 0, 0, temp_event.previewImage.Width, temp_event.previewImage.Height);
            }
            else
            {
                e.Graphics.DrawImage(
                    ACCG.Properties.Resources.placeholder_250_125,
                    0,
                    0,
                    ACCG.Properties.Resources.placeholder_250_125.Width,
                    ACCG.Properties.Resources.placeholder_250_125.Height
                    );
            }
        }

        private void btnLoadOpponents_Click(object sender, EventArgs e)
        {
            if (openOpponentsFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openOpponentsFileDialog.FileName;



                if (current_selected_event != null)
                {
                    current_selected_event.opponents_list = ACCGMainForm.accg_resource.LoadOpponents(filename);

                }
                else
                {
                    temp_event.opponents_list = ACCGMainForm.accg_resource.LoadOpponents(filename);

                }

                ACCGMainForm.bs_series_datasource.ResetBindings(false);
                ShowData();

                

            }
        }

        

       

        

       
        

        

       

        

        
        

        

       

       

        

        

        

        
    }
}
