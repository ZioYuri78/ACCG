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
        public ACCGNewEventForm()
        {
            InitializeComponent();
        }

        private void ckbPractice_CheckedChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("DEBUG: CheckedChanged");
            tkbPracticeDuration.Enabled = ckbPractice.Checked;
        }

        private void ckbQualifying_CheckedChanged(object sender, EventArgs e)
        {
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

            cbTrack.Text = ACCGMainForm.ac_tracks_list[0];                                      
                           
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
                Event temp_event = new Event();

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

                Console.WriteLine("DEBUG: ID = {0}", temp_event.ID);
                temp_event.name = tbName.Text;
                temp_event.description = tbDescription.Text;
                temp_event.ambient_temperature = tkbAmbientTemperature.Value.ToString();
                temp_event.time = tkbTime.Value.ToString();
                temp_event.track = cbTrack.SelectedItem.ToString();
                temp_event.numberOfCars = tkbNumberOfCars.Value;

                if (ckbPenalties.Checked) {
                    temp_event.penalties = 1;
                }
                else
                {
                    temp_event.penalties = 0;
                }
                

                // Sessions of the event
                temp_event.session_list = new List<Session>();

                if (ckbPractice.Checked)
                {
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

                ACCGNewSeriesForm.temp_series.events_list.Add(temp_event);
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
