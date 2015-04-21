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
    public partial class ACCGNewChampionshipEventForm : Form
    {
        private Event current_selected_event;

        public ACCGNewChampionshipEventForm()
        {
            InitializeComponent();
        }

        public ACCGNewChampionshipEventForm(Event current_selected_event)
        {
            // For edit mode
            this.current_selected_event = current_selected_event;

            InitializeComponent();
        }
       
        private void NewEventForm_Load(object sender, EventArgs e)
        {
            tkbPracticeDuration.Enabled = ckbPractice.Checked;

            tkbQualifyingDuration.Enabled = ckbQualifying.Checked;

             // Populating the Tracks combo box
            foreach (string track in ACCGMainForm.ac_tracks_list)
            {
                cbTrack.Items.Add(track);
            }            

            // Editing mode
            if (current_selected_event != null)
            {
                btnRandom.Enabled = false;

                temp_event = current_selected_event;
                tbName.Text = current_selected_event.name;
                tbDescription.Text = current_selected_event.description;
                
                tkbAmbientTemperature.Value = current_selected_event.ambient_temperature;
                tkbAmbientTemperature_Scroll(sender, e);
                
                tkbTime.Value = current_selected_event.time;
                tkbTime_Scroll(sender, e);

                if (current_selected_event.weather != 0)
                {
                    tkbWeather.Value = current_selected_event.weather;
                }
                else
                {
                    tkbWeather.Value = 3;
                }
                
                
                tkbWeather_Scroll(sender, e);

                tkbTrackCondition.Value = current_selected_event.dynamic_track_preset;
                tkbTrackCondition_Scroll(sender, e);               
                                                
                ckbPractice.Checked = current_selected_event.practice;

                if (ckbPractice.Checked)
                {
                    tkbPracticeDuration.Value = current_selected_event.session_list.Find(x => x.type == 1).duration_minutes;
                }

                tkbPracticeDuration_Scroll(sender, e);
                
                ckbQualifying.Checked = current_selected_event.qualifying;

                if (ckbQualifying.Checked)
                {
                    tkbQualifyingDuration.Value = current_selected_event.session_list.Find(x => x.type == 2).duration_minutes;
                }

                tkbQualifyingDuration_Scroll(sender, e);

                if (current_selected_event.track.CompareTo("ks_nordschleife") == 0)
                {
                    if (current_selected_event.track_layout.CompareTo("nordschleife") == 0)
                    {
                        cbTrack.Text = "nurb_nordschleife";
                    }
                    else if (current_selected_event.track_layout.CompareTo("endurance") == 0)
                    {
                        cbTrack.Text = "nurb_endurance";
                    }
                    else if (current_selected_event.track_layout.CompareTo("touristenfahrten") == 0)
                    {
                        cbTrack.Text = "nurb_touristenfahrten";
                    }

                }
                else if (current_selected_event.track.CompareTo("vallelunga") == 0)
                {
                    if (current_selected_event.track_layout.CompareTo("extended_circuit") == 0)
                    {
                        cbTrack.Text = "vallelunga";
                    }
                    else if (current_selected_event.track_layout.CompareTo("club_circuit") == 0)
                    {
                        cbTrack.Text = "vallelunga_club";
                    }
                }
                else
                {
                    cbTrack.Text = current_selected_event.track;
                }

                tkbNumberOfCars.Value = current_selected_event.numberOfCars;
                tkbNumberOfCars_Scroll(sender, e);

                tkbNumberOfLaps.Value = current_selected_event.session_list.Find(x => x.type == 3).laps;
                tkbNumberOfLaps_Scroll(sender, e);

                ckbPenalties.Checked = current_selected_event.penalties;                

            }
            else 
            {
                if (sender != btnRandom)  // New event mode
                {
                    temp_event = new Event();
                    cbTrack.Text = ACCGMainForm.ac_tracks_list[0];
                }
                else  // Random mode
                {
                    tkbAmbientTemperature.Value = temp_event.ambient_temperature;
                    tkbAmbientTemperature_Scroll(sender, e);

                    tkbTime.Value = temp_event.time;
                    tkbTime_Scroll(sender, e);

                    tkbWeather.Value = temp_event.weather;
                    tkbWeather_Scroll(sender, e);

                    tkbTrackCondition.Value = temp_event.dynamic_track_preset;
                    tkbTrackCondition_Scroll(sender, e);

                    cbTrack.Text = temp_event.track;

                    tkbNumberOfCars.Value = temp_event.numberOfCars;
                    tkbNumberOfCars_Scroll(sender, e);

                    tkbNumberOfLaps.Value = temp_event.numberOfLaps;
                    tkbNumberOfLaps_Scroll(sender, e);

                    foreach (Session session in temp_event.session_list)
                    {
                        switch (session.name)
                        {
                            case "Practice":
                                ckbPractice.Checked = true;
                                tkbPracticeDuration.Value = session.duration_minutes;
                                tkbPracticeDuration_Scroll(sender, e);
                                break;

                            case "Qualifying":
                                ckbQualifying.Checked = true;
                                tkbQualifyingDuration.Value = session.duration_minutes;
                                tkbQualifyingDuration_Scroll(sender, e);
                                break;                            

                        }
                    }

                }
                                
            }
                                                          
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Missing \"Name\" field!");
            }
            else if (tbDescription.Text == "")
            {
                MessageBox.Show("Missing \"Description\" field!");
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
                temp_event.track = cbTrack.SelectedItem.ToString();

                if (temp_event.track.CompareTo("nurb_nordschleife") == 0)
                {
                    temp_event.track = "ks_nordschleife";
                    temp_event.track_layout = "nordschleife";
                }
                else if (temp_event.track.CompareTo("nurb_endurance") == 0)
                {
                    temp_event.track = "ks_nordschleife";
                    temp_event.track_layout = "endurance";
                }
                else if (temp_event.track.CompareTo("nurb_touristenfahrten") == 0)
                {
                    temp_event.track = "ks_nordschleife";
                    temp_event.track_layout = "touristenfahrten";
                }
                else if (temp_event.track.CompareTo("vallelunga") == 0)
                {
                    temp_event.track = "vallelunga";
                    temp_event.track_layout = "extended_circuit";
                }
                else if (temp_event.track.CompareTo("vallelunga_club") == 0)
                {
                    temp_event.track = "vallelunga";
                    temp_event.track_layout = "club_circuit";
                }

                temp_event.numberOfCars = tkbNumberOfCars.Value;
                temp_event.penalties = ckbPenalties.Checked;
                temp_event.weather = tkbWeather.Value;
                temp_event.dynamic_track_preset = tkbTrackCondition.Value;
                                
                // Sessions of the event                                
                temp_event.session_list = new List<Session>();
                                              
                if (ckbPractice.Checked)
                {
                    if (current_selected_event != null)
                    {
                        temp_event.session_list.Remove(temp_event.session_list.Find(x => x.type == 1));
                    }
                    
                    temp_event.practice = true;

                    Session practice_session = new Session();
                    practice_session.ID = 0;
                    practice_session.name = "Practice";
                    practice_session.type = 1;
                    practice_session.spawn_set = "PIT";
                    practice_session.duration_minutes = tkbPracticeDuration.Value;
                    practice_session.laps = 0;  // Will not included during generation (but I'm lying)
                    temp_event.session_list.Add(practice_session);
                }

                if (ckbQualifying.Checked)
                {
                    if (current_selected_event != null)
                    {
                        temp_event.session_list.Remove(temp_event.session_list.Find(x => x.type == 2)); // era 3
                    }

                    temp_event.qualifying = true;

                    Session qualifying_session = new Session();

                    if (ckbPractice.Checked)
                    {
                        qualifying_session.ID = 1;
                    }
                    else
                    {
                        qualifying_session.ID = 0;
                    }

                    qualifying_session.name = "Qualifying";
                    qualifying_session.type = 2;
                    qualifying_session.spawn_set = "PIT";
                    qualifying_session.duration_minutes = tkbQualifyingDuration.Value;
                    qualifying_session.laps = 0;    // Will not included during generation (but I'm lying)
                    temp_event.session_list.Add(qualifying_session);
                }

                // Race session (always present)
                if (current_selected_event != null)
                {
                    temp_event.session_list.Remove(temp_event.session_list.Find(x => x.type == 3));
                }

                Session race_session = new Session();

                if (ckbPractice.Checked & !ckbQualifying.Checked)
                {
                    race_session.ID = 1;
                }
                else if (ckbQualifying.Checked & !ckbPractice.Checked)
                {
                    race_session.ID = 1;
                }
                else if (ckbPractice.Checked & ckbQualifying.Checked)
                {
                    race_session.ID = 2;
                }
                else
                {
                    race_session.ID = 0;
                }

                race_session.name = "Race";
                race_session.type = 3;
                race_session.spawn_set = "START";
                race_session.laps = tkbNumberOfLaps.Value;
                temp_event.session_list.Add(race_session);

                ACCGUtility.RemoveDiacritics(null ,temp_event);

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

        private void tkbWeather_Scroll(object sender, EventArgs e)
        {
            switch (tkbWeather.Value)
            {
                case 1:
                    lblWeatherValue.Text = "Heavy\nfog";
                    break;
                case 2:
                    lblWeatherValue.Text = "Light\nfog";
                    break;
                case 3:
                    lblWeatherValue.Text = "Clear";
                    break;
                case 4:
                    lblWeatherValue.Text = "Mid\nclear";
                    break;
                case 5:
                    lblWeatherValue.Text = "Light\nclouds";
                    break;
                case 6:
                    lblWeatherValue.Text = "Mid\nclouds";
                    break;
                case 7:
                    lblWeatherValue.Text = "Heavy\nclouds";
                    break;
            }
        }      

        private void tkbTrackCondition_Scroll(object sender, EventArgs e)
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

        private void ckbPractice_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbPractice.Checked)
            {
                if (current_selected_event != null)
                {
                    current_selected_event.session_list.Remove(current_selected_event.session_list.Find(x => x.type == 1));
                    current_selected_event.practice = false;
                }
            }
            tkbPracticeDuration.Enabled = ckbPractice.Checked;
        }

        private void ckbQualifying_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbQualifying.Checked)
            {
                if (current_selected_event != null)
                {
                    current_selected_event.session_list.Remove(current_selected_event.session_list.Find(x => x.type == 2));
                    current_selected_event.qualifying = false;
                }
            }

            tkbQualifyingDuration.Enabled = ckbQualifying.Checked;
        }

        private void tkbPracticeDuration_Scroll(object sender, EventArgs e)
        {
            lblPracticeDurationValue.Text = tkbPracticeDuration.Value + " min";
        }

        private void tkbQualifyingDuration_Scroll(object sender, EventArgs e)
        {
            lblQualifyingDurationValue.Text = tkbQualifyingDuration.Value + " min";
        }

        private void tkbNumberOfCars_Scroll(object sender, EventArgs e)
        {
            lblNumberOfCarsValue.Text = tkbNumberOfCars.Value + " cars";
        }

        private void tkbNumberOfLaps_Scroll(object sender, EventArgs e)
        {
            lblNumberOfLapsValue.Text = tkbNumberOfLaps.Value + " laps";
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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ResetAll(sender, e);

            if (current_selected_event != null)
            {
                current_selected_event = ACCGUtility.RandomizeEvent(current_selected_event, false);
            }
            else
            {
                temp_event = ACCGUtility.RandomizeEvent(temp_event, false);
            }

            
            cbTrack.Items.Clear();
            this.NewEventForm_Load(sender, e);
        }

        private void ResetAll(object sender, EventArgs e)
        {
            ckbPenalties.Checked = false;

            tkbAmbientTemperature.Value = 26;
            tkbAmbientTemperature_Scroll(sender, e);

            tkbTime.Value = 0;
            tkbTime_Scroll(sender, e);

            cbTrack.Text = ACCGMainForm.ac_tracks_list[0];

            tkbWeather.Value = 3;
            tkbWeather_Scroll(sender, e);

            tkbTrackCondition.Value = 4;
            tkbTrackCondition_Scroll(sender, e);

            ckbPractice.Checked = false;
            ckbPractice_CheckedChanged(sender, e);
            tkbPracticeDuration.Value = 5;
            tkbPracticeDuration_Scroll(sender, e);

            ckbQualifying.Checked = false;
            ckbQualifying_CheckedChanged(sender, e);
            tkbQualifyingDuration.Value = 5;
            tkbQualifyingDuration_Scroll(sender, e);

            tkbNumberOfCars.Value = 2;
            tkbNumberOfCars_Scroll(sender, e);

            tkbNumberOfLaps.Value = 2;
            tkbNumberOfLaps_Scroll(sender, e);
            
        }

        private void tkbTime_MouseEnter(object sender, EventArgs e)
        {
            tltTimeTrackbar.Show("This control still broken with mouse, please use arrow keys!", tkbTime, 5000);
        }

               
    }
}
