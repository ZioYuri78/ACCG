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
    public partial class ACCGNewEventForm : Form
    {
        private Event current_selected_event;

        public ACCGNewEventForm()
        {
            InitializeComponent();
        }

        public ACCGNewEventForm(Event current_selected_event)
        {
            // TODO: Complete member initialization
            this.current_selected_event = current_selected_event;

            InitializeComponent();
        }

        private void ckbPractice_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbPractice.Checked)
            {
                if (current_selected_event != null)
                {
                    current_selected_event.session_list.Remove(current_selected_event.session_list.Find(x => x.type == 1));
                    
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
                }
            }

            tkbQualifyingDuration.Enabled = ckbQualifying.Checked;
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
                
                ckbPractice.Checked = current_selected_event.practice;

                if (ckbPractice.Checked)
                {
                    tkbPracticeDuration.Value = current_selected_event.session_list.Find(x => x.type == 1).duration_minutes;
                }
                
                lblPracticeDurationValue.Text = tkbPracticeDuration.Value.ToString() + " min";
                
                ckbQualifying.Checked = current_selected_event.qualifying;

                if (ckbQualifying.Checked)
                {
                    tkbQualifyingDuration.Value = current_selected_event.session_list.Find(x => x.type == 2).duration_minutes;
                }
                
                lblQualifyingDurationValue.Text = tkbQualifyingDuration.Value.ToString() + " min";
                cbTrack.Text = current_selected_event.track;
                tkbNumberOfCars.Value = current_selected_event.numberOfCars;
                lblNumberOfCarsValue.Text = tkbNumberOfCars.Value.ToString() + " cars";
                tkbNumberOfLaps.Value = current_selected_event.session_list.Find(x => x.type == 3).laps;
                lblNumberOfLapsValue.Text = tkbNumberOfLaps.Value.ToString() + " laps";
                ckbPenalties.Checked = current_selected_event.penalties;
            }
            else // New event mode
            {
                cbTrack.Text = ACCGMainForm.ac_tracks_list[0]; 
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
                // The event
                Event temp_event;
                int event_index = 0;

                // Edit mode
                if (current_selected_event != null)
                {
                    temp_event = current_selected_event;
                    event_index = ACCGNewSeriesForm.temp_series.events_list.IndexOf(temp_event);
                    ACCGNewSeriesForm.temp_series.events_list.Remove(current_selected_event);
                }
                else // New event mode
                {
                    temp_event = new Event();

                    if (ACCGNewSeriesForm.events_global_ID == 0)
                    {
                        temp_event.ID = 1;
                        ACCGNewSeriesForm.events_global_ID++;
                    }
                    else
                    {
                        temp_event.ID = ACCGNewSeriesForm.events_global_ID + 1;
                        ACCGNewSeriesForm.events_global_ID++;
                    }
                }
                
                Console.WriteLine("DEBUG: ID = {0}", temp_event.ID);
                temp_event.name = tbName.Text;
                temp_event.description = tbDescription.Text;
                temp_event.ambient_temperature = tkbAmbientTemperature.Value;
                temp_event.time = tkbTime.Value;
                temp_event.track = cbTrack.SelectedItem.ToString();
                temp_event.numberOfCars = tkbNumberOfCars.Value;
                temp_event.penalties = ckbPenalties.Checked;
                                
                // Sessions of the event
                // Edit mode
                if (current_selected_event != null)
                {
                    temp_event.session_list = current_selected_event.session_list;
                }
                else
                {
                    temp_event.session_list = new List<Session>();
                }
                

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
                    practice_session.laps = 0;  // Will not included during generation
                    temp_event.session_list.Add(practice_session);
                }

                if (ckbQualifying.Checked)
                {
                    if (current_selected_event != null)
                    {
                        temp_event.session_list.Remove(temp_event.session_list.Find(x => x.type == 3));
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
                    qualifying_session.laps = 0;    // Will not included during generation
                    temp_event.session_list.Add(qualifying_session);
                }

                // Race sessions (always present)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
