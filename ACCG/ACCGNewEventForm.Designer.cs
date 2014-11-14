using System.Windows.Forms;
using System.Collections.Generic;

namespace ACCG
{
    partial class ACCGNewEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCGNewEventForm));
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblAmbTemperature = new System.Windows.Forms.Label();
            this.tkbAmbientTemperature = new System.Windows.Forms.TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.tkbTime = new System.Windows.Forms.TrackBar();
            this.lblPractice = new System.Windows.Forms.Label();
            this.ckbPractice = new System.Windows.Forms.CheckBox();
            this.lblPracticeDuration = new System.Windows.Forms.Label();
            this.tkbPracticeDuration = new System.Windows.Forms.TrackBar();
            this.tkbQualifyingDuration = new System.Windows.Forms.TrackBar();
            this.lblQualifyingDuration = new System.Windows.Forms.Label();
            this.ckbQualifying = new System.Windows.Forms.CheckBox();
            this.lblQualifying = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.cbTrack = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblNumberOfCars = new System.Windows.Forms.Label();
            this.tkbNumberOfCars = new System.Windows.Forms.TrackBar();
            this.lblPenalties = new System.Windows.Forms.Label();
            this.ckbPenalties = new System.Windows.Forms.CheckBox();
            this.tkbNumberOfLaps = new System.Windows.Forms.TrackBar();
            this.lblNumberOfLaps = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAmbTemperatureValue = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblPracticeDurationValue = new System.Windows.Forms.Label();
            this.lblQualifyingDurationValue = new System.Windows.Forms.Label();
            this.lblNumberOfCarsValue = new System.Windows.Forms.Label();
            this.lblNumberOfLapsValue = new System.Windows.Forms.Label();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAmbientTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbPracticeDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbQualifyingDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfLaps)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(79, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 39);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(79, 36);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 20);
            this.tbDescription.TabIndex = 3;
            // 
            // lblAmbTemperature
            // 
            this.lblAmbTemperature.AutoSize = true;
            this.lblAmbTemperature.Location = new System.Drawing.Point(218, 9);
            this.lblAmbTemperature.Name = "lblAmbTemperature";
            this.lblAmbTemperature.Size = new System.Drawing.Size(104, 13);
            this.lblAmbTemperature.TabIndex = 4;
            this.lblAmbTemperature.Text = "Ambient temperature";
            // 
            // tkbAmbientTemperature
            // 
            this.tkbAmbientTemperature.Location = new System.Drawing.Point(328, 3);
            this.tkbAmbientTemperature.Maximum = 36;
            this.tkbAmbientTemperature.Minimum = 10;
            this.tkbAmbientTemperature.Name = "tkbAmbientTemperature";
            this.tkbAmbientTemperature.RightToLeftLayout = true;
            this.tkbAmbientTemperature.Size = new System.Drawing.Size(104, 45);
            this.tkbAmbientTemperature.TabIndex = 5;
            this.tkbAmbientTemperature.Value = 26;
            this.tkbAmbientTemperature.Scroll += new System.EventHandler(this.tkbAmbientTemperature_Scroll);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(218, 57);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time";
            // 
            // tkbTime
            // 
            this.tkbTime.LargeChange = 8;
            this.tkbTime.Location = new System.Drawing.Point(328, 57);
            this.tkbTime.Maximum = 80;
            this.tkbTime.Minimum = -80;
            this.tkbTime.Name = "tkbTime";
            this.tkbTime.Size = new System.Drawing.Size(104, 45);
            this.tkbTime.SmallChange = 8;
            this.tkbTime.TabIndex = 7;
            this.tkbTime.TickFrequency = 8;
            this.tkbTime.Scroll += new System.EventHandler(this.tkbTime_Scroll);
            // 
            // lblPractice
            // 
            this.lblPractice.AutoSize = true;
            this.lblPractice.Location = new System.Drawing.Point(13, 111);
            this.lblPractice.Name = "lblPractice";
            this.lblPractice.Size = new System.Drawing.Size(46, 13);
            this.lblPractice.TabIndex = 8;
            this.lblPractice.Text = "Practice";
            // 
            // ckbPractice
            // 
            this.ckbPractice.AutoSize = true;
            this.ckbPractice.Location = new System.Drawing.Point(66, 111);
            this.ckbPractice.Name = "ckbPractice";
            this.ckbPractice.Size = new System.Drawing.Size(15, 14);
            this.ckbPractice.TabIndex = 9;
            this.ckbPractice.UseVisualStyleBackColor = true;
            this.ckbPractice.CheckedChanged += new System.EventHandler(this.ckbPractice_CheckedChanged);
            // 
            // lblPracticeDuration
            // 
            this.lblPracticeDuration.AutoSize = true;
            this.lblPracticeDuration.Location = new System.Drawing.Point(13, 131);
            this.lblPracticeDuration.Name = "lblPracticeDuration";
            this.lblPracticeDuration.Size = new System.Drawing.Size(47, 13);
            this.lblPracticeDuration.TabIndex = 10;
            this.lblPracticeDuration.Text = "Duration";
            // 
            // tkbPracticeDuration
            // 
            this.tkbPracticeDuration.Location = new System.Drawing.Point(66, 131);
            this.tkbPracticeDuration.Maximum = 90;
            this.tkbPracticeDuration.Minimum = 5;
            this.tkbPracticeDuration.Name = "tkbPracticeDuration";
            this.tkbPracticeDuration.Size = new System.Drawing.Size(104, 45);
            this.tkbPracticeDuration.TabIndex = 11;
            this.tkbPracticeDuration.Value = 5;
            this.tkbPracticeDuration.Scroll += new System.EventHandler(this.tkbPracticeDuration_Scroll);
            // 
            // tkbQualifyingDuration
            // 
            this.tkbQualifyingDuration.Location = new System.Drawing.Point(271, 131);
            this.tkbQualifyingDuration.Maximum = 60;
            this.tkbQualifyingDuration.Minimum = 5;
            this.tkbQualifyingDuration.Name = "tkbQualifyingDuration";
            this.tkbQualifyingDuration.Size = new System.Drawing.Size(104, 45);
            this.tkbQualifyingDuration.TabIndex = 15;
            this.tkbQualifyingDuration.Value = 5;
            this.tkbQualifyingDuration.Scroll += new System.EventHandler(this.tkbQualifyingDuration_Scroll);
            // 
            // lblQualifyingDuration
            // 
            this.lblQualifyingDuration.AutoSize = true;
            this.lblQualifyingDuration.Location = new System.Drawing.Point(218, 131);
            this.lblQualifyingDuration.Name = "lblQualifyingDuration";
            this.lblQualifyingDuration.Size = new System.Drawing.Size(47, 13);
            this.lblQualifyingDuration.TabIndex = 14;
            this.lblQualifyingDuration.Text = "Duration";
            // 
            // ckbQualifying
            // 
            this.ckbQualifying.AutoSize = true;
            this.ckbQualifying.Location = new System.Drawing.Point(271, 111);
            this.ckbQualifying.Name = "ckbQualifying";
            this.ckbQualifying.Size = new System.Drawing.Size(15, 14);
            this.ckbQualifying.TabIndex = 13;
            this.ckbQualifying.UseVisualStyleBackColor = true;
            this.ckbQualifying.CheckedChanged += new System.EventHandler(this.ckbQualifying_CheckedChanged);
            // 
            // lblQualifying
            // 
            this.lblQualifying.AutoSize = true;
            this.lblQualifying.Location = new System.Drawing.Point(218, 111);
            this.lblQualifying.Name = "lblQualifying";
            this.lblQualifying.Size = new System.Drawing.Size(53, 13);
            this.lblQualifying.TabIndex = 12;
            this.lblQualifying.Text = "Qualifying";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(13, 193);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 16;
            this.lblRace.Text = "Race";
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(13, 223);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(35, 13);
            this.lblTrack.TabIndex = 17;
            this.lblTrack.Text = "Track";
            // 
            // cbTrack
            // 
            this.cbTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrack.FormattingEnabled = true;
            this.cbTrack.Location = new System.Drawing.Point(66, 220);
            this.cbTrack.Name = "cbTrack";
            this.cbTrack.Size = new System.Drawing.Size(121, 21);
            this.cbTrack.TabIndex = 18;
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.Enabled = false;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(66, 247);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 21);
            this.cbModel.TabIndex = 20;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 250);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 19;
            this.lblModel.Text = "Model";
            // 
            // lblNumberOfCars
            // 
            this.lblNumberOfCars.AutoSize = true;
            this.lblNumberOfCars.Location = new System.Drawing.Point(13, 288);
            this.lblNumberOfCars.Name = "lblNumberOfCars";
            this.lblNumberOfCars.Size = new System.Drawing.Size(28, 13);
            this.lblNumberOfCars.TabIndex = 21;
            this.lblNumberOfCars.Text = "Cars";
            // 
            // tkbNumberOfCars
            // 
            this.tkbNumberOfCars.Location = new System.Drawing.Point(66, 274);
            this.tkbNumberOfCars.Maximum = 24;
            this.tkbNumberOfCars.Minimum = 1;
            this.tkbNumberOfCars.Name = "tkbNumberOfCars";
            this.tkbNumberOfCars.Size = new System.Drawing.Size(104, 45);
            this.tkbNumberOfCars.TabIndex = 22;
            this.tkbNumberOfCars.Value = 1;
            this.tkbNumberOfCars.Scroll += new System.EventHandler(this.tkbNumberOfCars_Scroll);
            // 
            // lblPenalties
            // 
            this.lblPenalties.AutoSize = true;
            this.lblPenalties.Location = new System.Drawing.Point(13, 372);
            this.lblPenalties.Name = "lblPenalties";
            this.lblPenalties.Size = new System.Drawing.Size(50, 13);
            this.lblPenalties.TabIndex = 23;
            this.lblPenalties.Text = "Penalties";
            // 
            // ckbPenalties
            // 
            this.ckbPenalties.AutoSize = true;
            this.ckbPenalties.Location = new System.Drawing.Point(66, 372);
            this.ckbPenalties.Name = "ckbPenalties";
            this.ckbPenalties.Size = new System.Drawing.Size(15, 14);
            this.ckbPenalties.TabIndex = 24;
            this.ckbPenalties.UseVisualStyleBackColor = true;
            // 
            // tkbNumberOfLaps
            // 
            this.tkbNumberOfLaps.Location = new System.Drawing.Point(66, 325);
            this.tkbNumberOfLaps.Minimum = 2;
            this.tkbNumberOfLaps.Name = "tkbNumberOfLaps";
            this.tkbNumberOfLaps.Size = new System.Drawing.Size(104, 45);
            this.tkbNumberOfLaps.TabIndex = 26;
            this.tkbNumberOfLaps.Value = 2;
            this.tkbNumberOfLaps.Scroll += new System.EventHandler(this.tkbNumberOfLaps_Scroll);
            // 
            // lblNumberOfLaps
            // 
            this.lblNumberOfLaps.AutoSize = true;
            this.lblNumberOfLaps.Location = new System.Drawing.Point(13, 336);
            this.lblNumberOfLaps.Name = "lblNumberOfLaps";
            this.lblNumberOfLaps.Size = new System.Drawing.Size(30, 13);
            this.lblNumberOfLaps.TabIndex = 25;
            this.lblNumberOfLaps.Text = "Laps";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(377, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(296, 403);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAmbTemperatureValue
            // 
            this.lblAmbTemperatureValue.AutoSize = true;
            this.lblAmbTemperatureValue.Location = new System.Drawing.Point(433, 13);
            this.lblAmbTemperatureValue.Name = "lblAmbTemperatureValue";
            this.lblAmbTemperatureValue.Size = new System.Drawing.Size(33, 13);
            this.lblAmbTemperatureValue.TabIndex = 31;
            this.lblAmbTemperatureValue.Text = "26 °C";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Location = new System.Drawing.Point(439, 68);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(34, 13);
            this.lblTimeValue.TabIndex = 32;
            this.lblTimeValue.Text = "13:00";
            // 
            // lblPracticeDurationValue
            // 
            this.lblPracticeDurationValue.AutoSize = true;
            this.lblPracticeDurationValue.Location = new System.Drawing.Point(166, 141);
            this.lblPracticeDurationValue.Name = "lblPracticeDurationValue";
            this.lblPracticeDurationValue.Size = new System.Drawing.Size(32, 13);
            this.lblPracticeDurationValue.TabIndex = 33;
            this.lblPracticeDurationValue.Text = "5 min";
            // 
            // lblQualifyingDurationValue
            // 
            this.lblQualifyingDurationValue.AutoSize = true;
            this.lblQualifyingDurationValue.Location = new System.Drawing.Point(382, 141);
            this.lblQualifyingDurationValue.Name = "lblQualifyingDurationValue";
            this.lblQualifyingDurationValue.Size = new System.Drawing.Size(32, 13);
            this.lblQualifyingDurationValue.TabIndex = 34;
            this.lblQualifyingDurationValue.Text = "5 min";
            // 
            // lblNumberOfCarsValue
            // 
            this.lblNumberOfCarsValue.AutoSize = true;
            this.lblNumberOfCarsValue.Location = new System.Drawing.Point(174, 284);
            this.lblNumberOfCarsValue.Name = "lblNumberOfCarsValue";
            this.lblNumberOfCarsValue.Size = new System.Drawing.Size(36, 13);
            this.lblNumberOfCarsValue.TabIndex = 35;
            this.lblNumberOfCarsValue.Text = "1 cars";
            // 
            // lblNumberOfLapsValue
            // 
            this.lblNumberOfLapsValue.AutoSize = true;
            this.lblNumberOfLapsValue.Location = new System.Drawing.Point(174, 336);
            this.lblNumberOfLapsValue.Name = "lblNumberOfLapsValue";
            this.lblNumberOfLapsValue.Size = new System.Drawing.Size(35, 13);
            this.lblNumberOfLapsValue.TabIndex = 36;
            this.lblNumberOfLapsValue.Text = "2 laps";
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.Location = new System.Drawing.Point(197, 251);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(178, 13);
            this.lblPlaceholder.TabIndex = 37;
            this.lblPlaceholder.Text = "(placeholder for single events series)";
            // 
            // ACCGNewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 438);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.lblNumberOfLapsValue);
            this.Controls.Add(this.lblNumberOfCarsValue);
            this.Controls.Add(this.lblQualifyingDurationValue);
            this.Controls.Add(this.lblPracticeDurationValue);
            this.Controls.Add(this.lblTimeValue);
            this.Controls.Add(this.lblAmbTemperatureValue);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tkbNumberOfLaps);
            this.Controls.Add(this.lblNumberOfLaps);
            this.Controls.Add(this.ckbPenalties);
            this.Controls.Add(this.lblPenalties);
            this.Controls.Add(this.tkbNumberOfCars);
            this.Controls.Add(this.lblNumberOfCars);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cbTrack);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.tkbQualifyingDuration);
            this.Controls.Add(this.lblQualifyingDuration);
            this.Controls.Add(this.ckbQualifying);
            this.Controls.Add(this.lblQualifying);
            this.Controls.Add(this.tkbPracticeDuration);
            this.Controls.Add(this.lblPracticeDuration);
            this.Controls.Add(this.ckbPractice);
            this.Controls.Add(this.lblPractice);
            this.Controls.Add(this.tkbTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tkbAmbientTemperature);
            this.Controls.Add(this.lblAmbTemperature);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ACCGNewEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Event";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbAmbientTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbPracticeDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbQualifyingDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfLaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private TextBox tbName;
        private Label lblDescription;
        private TextBox tbDescription;
        private Label lblAmbTemperature;
        private TrackBar tkbAmbientTemperature;
        private Label lblTime;
        private TrackBar tkbTime;
        private Label lblPractice;
        private CheckBox ckbPractice;
        private Label lblPracticeDuration;
        private TrackBar tkbPracticeDuration;
        private TrackBar tkbQualifyingDuration;
        private Label lblQualifyingDuration;
        private CheckBox ckbQualifying;
        private Label lblQualifying;
        private Label lblRace;
        private Label lblTrack;
        private ComboBox cbTrack;
        private ComboBox cbModel;
        private Label lblModel;
        private Label lblNumberOfCars;
        private TrackBar tkbNumberOfCars;
        private Label lblPenalties;
        private CheckBox ckbPenalties;
        private TrackBar tkbNumberOfLaps;
        private Label lblNumberOfLaps;
        private Button btnCancel;
        private Button btnOK;
        private Label lblAmbTemperatureValue;
        private Label lblTimeValue;
        private Label lblPracticeDurationValue;
        private Label lblQualifyingDurationValue;
        private Label lblNumberOfCarsValue;
        private Label lblNumberOfLapsValue;
        private Label lblPlaceholder;
        
    }
}