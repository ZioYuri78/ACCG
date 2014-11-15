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
    public partial class ACCGNewOpponentForm : Form
    {
        private Opponent current_selected_opponent;

        public ACCGNewOpponentForm()
        {
            InitializeComponent();
        }

        public ACCGNewOpponentForm(Opponent current_selected_opponent)
        {
            // TODO: Complete member initialization
            this.current_selected_opponent = current_selected_opponent;

            InitializeComponent();
        }

        private void ACCGNewOpponentForm_Load(object sender, EventArgs e)
        {
            // Edit mode
            if (current_selected_opponent != null)
            {
                tbName.Text = current_selected_opponent.name;
                tbNationality.Text = current_selected_opponent.nationality;
                tkbAIlevel.Value = current_selected_opponent.ai_level;
                lblAIlevelValue.Text = current_selected_opponent.ai_level.ToString();
            }

            // Populating cars combo box
            foreach (Car car in ACCGMainForm.ac_cars_list)
            {
                cbCar.Items.Add(car.model);
            }

            // Edit mode
            if (current_selected_opponent != null)
            {
                cbCar.Text = current_selected_opponent.model.model;
            }
            else // New opponent mode
            {
                cbCar.Text = ACCGMainForm.ac_cars_list.ElementAt(0).model;
            }
           
            opponent_car = ACCGMainForm.ac_cars_list.Find(x => x.model == cbCar.SelectedItem.ToString());

            // Populating the car skins combo box
            foreach (string skin in opponent_car.skins)
            {
                cbSkin.Items.Add(skin);
            }

            // Edit mode
            if (current_selected_opponent != null)
            {
                cbSkin.Text = current_selected_opponent.skin;
            }
            else // New opponent mode
            {
                cbSkin.Text = opponent_car.skins[0];
            }
            
        }

        private void tkbAIlevel_Scroll(object sender, EventArgs e)
        {
            lblAIlevelValue.Text = tkbAIlevel.Value.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {           

            if (tbName.Text == "")
            {
                MessageBox.Show("Missing \"Name\" field!");
            }
            else if (tbNationality.Text == "")
            {
                MessageBox.Show("Missing \"Nationality\" field!");
            }
            else
            {
                // The opponent
                Opponent temp_opponent;
                int opponent_index = 0;

                // Edit mode
                if (current_selected_opponent != null)
                {
                    temp_opponent = current_selected_opponent;
                    opponent_index = ACCGNewSeriesForm.temp_series.opponents_list.IndexOf(temp_opponent);
                    ACCGNewSeriesForm.temp_series.opponents_list.Remove(current_selected_opponent);
                }
                else // New opponent mode
                {
                    temp_opponent = new Opponent();
                    /*
                    if (ACCGNewSeriesForm.opponents_global_ID == 0)
                    {
                        temp_opponent.ID = 1;
                        ACCGNewSeriesForm.opponents_global_ID++;
                    }
                    else
                    {
                        temp_opponent.ID = ACCGNewSeriesForm.opponents_global_ID + 1;
                        ACCGNewSeriesForm.opponents_global_ID++;
                    }*/
                }
                                
                Console.WriteLine("DEBUG: ID = {0}",temp_opponent.ID);
                temp_opponent.model = opponent_car;
                temp_opponent.setup = "";   //temp_opponent.setup = cbSetup.SelectedItem.ToString(); 
                temp_opponent.ai_level = tkbAIlevel.Value;
                temp_opponent.skin = cbSkin.SelectedItem.ToString();
                temp_opponent.name = tbName.Text;
                temp_opponent.nationality = tbNationality.Text;

                if (current_selected_opponent != null)
                {                    
                    ACCGNewSeriesForm.temp_series.opponents_list.Insert(opponent_index, temp_opponent);
                }
                else
                {
                    ACCGNewSeriesForm.temp_series.opponents_list.Add(temp_opponent);                
                }
                
                ACCGNewSeriesForm.bs_opponents_datasource.ResetBindings(false);

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            opponent_car = ACCGMainForm.ac_cars_list.Find(x => x.model == cbCar.SelectedItem.ToString());

            // Re-populating the car skins combo box
            cbSkin.Items.Clear();
            foreach (string skin in opponent_car.skins)
            {
                cbSkin.Items.Add(skin);
            }

            cbSkin.Text = opponent_car.skins[0];
        }
    }
}
