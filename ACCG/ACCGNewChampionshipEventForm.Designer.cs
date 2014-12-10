using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace ACCG
{
    partial class ACCGNewChampionshipEventForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCGNewChampionshipEventForm));
            this.lblAmbTemperature = new System.Windows.Forms.Label();
            this.tkbAmbientTemperature = new System.Windows.Forms.TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.tkbTime = new System.Windows.Forms.TrackBar();
            this.ckbPractice = new System.Windows.Forms.CheckBox();
            this.lblPracticeDuration = new System.Windows.Forms.Label();
            this.tkbPracticeDuration = new System.Windows.Forms.TrackBar();
            this.tkbQualifyingDuration = new System.Windows.Forms.TrackBar();
            this.lblQualifyingDuration = new System.Windows.Forms.Label();
            this.ckbQualifying = new System.Windows.Forms.CheckBox();
            this.lblTrack = new System.Windows.Forms.Label();
            this.cbTrack = new System.Windows.Forms.ComboBox();
            this.lblNumberOfCars = new System.Windows.Forms.Label();
            this.tkbNumberOfCars = new System.Windows.Forms.TrackBar();
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
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.grbAmbient = new System.Windows.Forms.GroupBox();
            this.grbTrack = new System.Windows.Forms.GroupBox();
            this.lblTrackConditionValue = new System.Windows.Forms.Label();
            this.lblTrackTemperatureValue = new System.Windows.Forms.Label();
            this.tkbTrackCondition = new System.Windows.Forms.TrackBar();
            this.tkbTrackTemperature = new System.Windows.Forms.TrackBar();
            this.lblTrackCondition = new System.Windows.Forms.Label();
            this.lblTrackTemperature = new System.Windows.Forms.Label();
            this.grbSessions = new System.Windows.Forms.GroupBox();
            this.grbSessionRace = new System.Windows.Forms.GroupBox();
            this.grbSessionQualifying = new System.Windows.Forms.GroupBox();
            this.grbPracticeSession = new System.Windows.Forms.GroupBox();
            this.grbImages = new System.Windows.Forms.GroupBox();
            this.btnOpenPreviewImage = new System.Windows.Forms.Button();
            this.previewImagePanel = new System.Windows.Forms.Panel();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ckbPenalties = new System.Windows.Forms.CheckBox();
            this.lblPenalties = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grbEvent = new System.Windows.Forms.GroupBox();
            this.tltLoadPreviewImage = new System.Windows.Forms.ToolTip(this.components);
            this.btnRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAmbientTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbPracticeDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbQualifyingDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfLaps)).BeginInit();
            this.grbButtons.SuspendLayout();
            this.grbAmbient.SuspendLayout();
            this.grbTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackTemperature)).BeginInit();
            this.grbSessions.SuspendLayout();
            this.grbSessionRace.SuspendLayout();
            this.grbSessionQualifying.SuspendLayout();
            this.grbPracticeSession.SuspendLayout();
            this.grbImages.SuspendLayout();
            this.grbEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAmbTemperature
            // 
            this.lblAmbTemperature.AutoSize = true;
            this.lblAmbTemperature.Location = new System.Drawing.Point(6, 22);
            this.lblAmbTemperature.Name = "lblAmbTemperature";
            this.lblAmbTemperature.Size = new System.Drawing.Size(67, 13);
            this.lblAmbTemperature.TabIndex = 4;
            this.lblAmbTemperature.Text = "Temperature";
            // 
            // tkbAmbientTemperature
            // 
            this.tkbAmbientTemperature.Location = new System.Drawing.Point(79, 19);
            this.tkbAmbientTemperature.Maximum = 36;
            this.tkbAmbientTemperature.Minimum = 10;
            this.tkbAmbientTemperature.Name = "tkbAmbientTemperature";
            this.tkbAmbientTemperature.RightToLeftLayout = true;
            this.tkbAmbientTemperature.Size = new System.Drawing.Size(123, 45);
            this.tkbAmbientTemperature.TabIndex = 5;
            this.tkbAmbientTemperature.Value = 26;
            this.tkbAmbientTemperature.Scroll += new System.EventHandler(this.tkbAmbientTemperature_Scroll);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(6, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time";
            // 
            // tkbTime
            // 
            this.tkbTime.LargeChange = 8;
            this.tkbTime.Location = new System.Drawing.Point(79, 67);
            this.tkbTime.Maximum = 80;
            this.tkbTime.Minimum = -80;
            this.tkbTime.Name = "tkbTime";
            this.tkbTime.Size = new System.Drawing.Size(123, 45);
            this.tkbTime.SmallChange = 8;
            this.tkbTime.TabIndex = 6;
            this.tkbTime.TickFrequency = 8;
            this.tkbTime.Scroll += new System.EventHandler(this.tkbTime_Scroll);
            // 
            // ckbPractice
            // 
            this.ckbPractice.AutoSize = true;
            this.ckbPractice.Location = new System.Drawing.Point(6, 19);
            this.ckbPractice.Name = "ckbPractice";
            this.ckbPractice.Size = new System.Drawing.Size(15, 14);
            this.ckbPractice.TabIndex = 9;
            this.ckbPractice.UseVisualStyleBackColor = true;
            this.ckbPractice.CheckedChanged += new System.EventHandler(this.ckbPractice_CheckedChanged);
            // 
            // lblPracticeDuration
            // 
            this.lblPracticeDuration.AutoSize = true;
            this.lblPracticeDuration.Location = new System.Drawing.Point(3, 41);
            this.lblPracticeDuration.Name = "lblPracticeDuration";
            this.lblPracticeDuration.Size = new System.Drawing.Size(47, 13);
            this.lblPracticeDuration.TabIndex = 10;
            this.lblPracticeDuration.Text = "Duration";
            // 
            // tkbPracticeDuration
            // 
            this.tkbPracticeDuration.Location = new System.Drawing.Point(56, 41);
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
            this.tkbQualifyingDuration.Location = new System.Drawing.Point(56, 42);
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
            this.lblQualifyingDuration.Location = new System.Drawing.Point(3, 42);
            this.lblQualifyingDuration.Name = "lblQualifyingDuration";
            this.lblQualifyingDuration.Size = new System.Drawing.Size(47, 13);
            this.lblQualifyingDuration.TabIndex = 14;
            this.lblQualifyingDuration.Text = "Duration";
            // 
            // ckbQualifying
            // 
            this.ckbQualifying.AutoSize = true;
            this.ckbQualifying.Location = new System.Drawing.Point(6, 19);
            this.ckbQualifying.Name = "ckbQualifying";
            this.ckbQualifying.Size = new System.Drawing.Size(15, 14);
            this.ckbQualifying.TabIndex = 13;
            this.ckbQualifying.UseVisualStyleBackColor = true;
            this.ckbQualifying.CheckedChanged += new System.EventHandler(this.ckbQualifying_CheckedChanged);
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(6, 20);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(35, 13);
            this.lblTrack.TabIndex = 17;
            this.lblTrack.Text = "Track";
            // 
            // cbTrack
            // 
            this.cbTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrack.FormattingEnabled = true;
            this.cbTrack.Location = new System.Drawing.Point(47, 17);
            this.cbTrack.Name = "cbTrack";
            this.cbTrack.Size = new System.Drawing.Size(145, 21);
            this.cbTrack.TabIndex = 18;
            // 
            // lblNumberOfCars
            // 
            this.lblNumberOfCars.AutoSize = true;
            this.lblNumberOfCars.Location = new System.Drawing.Point(6, 47);
            this.lblNumberOfCars.Name = "lblNumberOfCars";
            this.lblNumberOfCars.Size = new System.Drawing.Size(28, 13);
            this.lblNumberOfCars.TabIndex = 21;
            this.lblNumberOfCars.Text = "Cars";
            // 
            // tkbNumberOfCars
            // 
            this.tkbNumberOfCars.Location = new System.Drawing.Point(47, 44);
            this.tkbNumberOfCars.Maximum = 24;
            this.tkbNumberOfCars.Minimum = 1;
            this.tkbNumberOfCars.Name = "tkbNumberOfCars";
            this.tkbNumberOfCars.Size = new System.Drawing.Size(104, 45);
            this.tkbNumberOfCars.TabIndex = 22;
            this.tkbNumberOfCars.Value = 1;
            this.tkbNumberOfCars.Scroll += new System.EventHandler(this.tkbNumberOfCars_Scroll);
            // 
            // tkbNumberOfLaps
            // 
            this.tkbNumberOfLaps.Location = new System.Drawing.Point(47, 95);
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
            this.lblNumberOfLaps.Location = new System.Drawing.Point(6, 98);
            this.lblNumberOfLaps.Name = "lblNumberOfLaps";
            this.lblNumberOfLaps.Size = new System.Drawing.Size(30, 13);
            this.lblNumberOfLaps.TabIndex = 25;
            this.lblNumberOfLaps.Text = "Laps";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(87, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(6, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 48;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAmbTemperatureValue
            // 
            this.lblAmbTemperatureValue.AutoSize = true;
            this.lblAmbTemperatureValue.Location = new System.Drawing.Point(208, 22);
            this.lblAmbTemperatureValue.Name = "lblAmbTemperatureValue";
            this.lblAmbTemperatureValue.Size = new System.Drawing.Size(33, 13);
            this.lblAmbTemperatureValue.TabIndex = 31;
            this.lblAmbTemperatureValue.Text = "26 °C";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Location = new System.Drawing.Point(207, 70);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(34, 13);
            this.lblTimeValue.TabIndex = 32;
            this.lblTimeValue.Text = "13:00";
            // 
            // lblPracticeDurationValue
            // 
            this.lblPracticeDurationValue.AutoSize = true;
            this.lblPracticeDurationValue.Location = new System.Drawing.Point(166, 41);
            this.lblPracticeDurationValue.Name = "lblPracticeDurationValue";
            this.lblPracticeDurationValue.Size = new System.Drawing.Size(32, 13);
            this.lblPracticeDurationValue.TabIndex = 33;
            this.lblPracticeDurationValue.Text = "5 min";
            // 
            // lblQualifyingDurationValue
            // 
            this.lblQualifyingDurationValue.AutoSize = true;
            this.lblQualifyingDurationValue.Location = new System.Drawing.Point(166, 42);
            this.lblQualifyingDurationValue.Name = "lblQualifyingDurationValue";
            this.lblQualifyingDurationValue.Size = new System.Drawing.Size(32, 13);
            this.lblQualifyingDurationValue.TabIndex = 34;
            this.lblQualifyingDurationValue.Text = "5 min";
            // 
            // lblNumberOfCarsValue
            // 
            this.lblNumberOfCarsValue.AutoSize = true;
            this.lblNumberOfCarsValue.Location = new System.Drawing.Point(157, 47);
            this.lblNumberOfCarsValue.Name = "lblNumberOfCarsValue";
            this.lblNumberOfCarsValue.Size = new System.Drawing.Size(36, 13);
            this.lblNumberOfCarsValue.TabIndex = 35;
            this.lblNumberOfCarsValue.Text = "1 cars";
            // 
            // lblNumberOfLapsValue
            // 
            this.lblNumberOfLapsValue.AutoSize = true;
            this.lblNumberOfLapsValue.Location = new System.Drawing.Point(157, 98);
            this.lblNumberOfLapsValue.Name = "lblNumberOfLapsValue";
            this.lblNumberOfLapsValue.Size = new System.Drawing.Size(35, 13);
            this.lblNumberOfLapsValue.TabIndex = 36;
            this.lblNumberOfLapsValue.Text = "2 laps";
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnOK);
            this.grbButtons.Controls.Add(this.btnCancel);
            this.grbButtons.Location = new System.Drawing.Point(322, 580);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(183, 54);
            this.grbButtons.TabIndex = 46;
            this.grbButtons.TabStop = false;
            // 
            // grbAmbient
            // 
            this.grbAmbient.Controls.Add(this.tkbAmbientTemperature);
            this.grbAmbient.Controls.Add(this.lblAmbTemperature);
            this.grbAmbient.Controls.Add(this.lblTime);
            this.grbAmbient.Controls.Add(this.tkbTime);
            this.grbAmbient.Controls.Add(this.lblAmbTemperatureValue);
            this.grbAmbient.Controls.Add(this.lblTimeValue);
            this.grbAmbient.Location = new System.Drawing.Point(12, 204);
            this.grbAmbient.Name = "grbAmbient";
            this.grbAmbient.Size = new System.Drawing.Size(263, 114);
            this.grbAmbient.TabIndex = 40;
            this.grbAmbient.TabStop = false;
            this.grbAmbient.Text = "Ambient";
            // 
            // grbTrack
            // 
            this.grbTrack.Controls.Add(this.lblTrackConditionValue);
            this.grbTrack.Controls.Add(this.lblTrackTemperatureValue);
            this.grbTrack.Controls.Add(this.tkbTrackCondition);
            this.grbTrack.Controls.Add(this.tkbTrackTemperature);
            this.grbTrack.Controls.Add(this.lblTrackCondition);
            this.grbTrack.Controls.Add(this.lblTrackTemperature);
            this.grbTrack.Location = new System.Drawing.Point(12, 324);
            this.grbTrack.Name = "grbTrack";
            this.grbTrack.Size = new System.Drawing.Size(263, 124);
            this.grbTrack.TabIndex = 41;
            this.grbTrack.TabStop = false;
            this.grbTrack.Text = "Track";
            // 
            // lblTrackConditionValue
            // 
            this.lblTrackConditionValue.AutoSize = true;
            this.lblTrackConditionValue.Location = new System.Drawing.Point(207, 72);
            this.lblTrackConditionValue.Name = "lblTrackConditionValue";
            this.lblTrackConditionValue.Size = new System.Drawing.Size(27, 13);
            this.lblTrackConditionValue.TabIndex = 5;
            this.lblTrackConditionValue.Text = "Fast";
            // 
            // lblTrackTemperatureValue
            // 
            this.lblTrackTemperatureValue.AutoSize = true;
            this.lblTrackTemperatureValue.Location = new System.Drawing.Point(208, 23);
            this.lblTrackTemperatureValue.Name = "lblTrackTemperatureValue";
            this.lblTrackTemperatureValue.Size = new System.Drawing.Size(33, 13);
            this.lblTrackTemperatureValue.TabIndex = 4;
            this.lblTrackTemperatureValue.Text = "33 °C";
            // 
            // tkbTrackCondition
            // 
            this.tkbTrackCondition.Location = new System.Drawing.Point(80, 72);
            this.tkbTrackCondition.Maximum = 5;
            this.tkbTrackCondition.Name = "tkbTrackCondition";
            this.tkbTrackCondition.Size = new System.Drawing.Size(122, 45);
            this.tkbTrackCondition.TabIndex = 8;
            this.tkbTrackCondition.Value = 4;
            this.tkbTrackCondition.Scroll += new System.EventHandler(this.tkbTrackCondition_Scroll);
            // 
            // tkbTrackTemperature
            // 
            this.tkbTrackTemperature.Enabled = false;
            this.tkbTrackTemperature.Location = new System.Drawing.Point(81, 20);
            this.tkbTrackTemperature.Maximum = 40;
            this.tkbTrackTemperature.Minimum = 10;
            this.tkbTrackTemperature.Name = "tkbTrackTemperature";
            this.tkbTrackTemperature.Size = new System.Drawing.Size(121, 45);
            this.tkbTrackTemperature.TabIndex = 7;
            this.tkbTrackTemperature.Value = 33;
            // 
            // lblTrackCondition
            // 
            this.lblTrackCondition.AutoSize = true;
            this.lblTrackCondition.Location = new System.Drawing.Point(6, 72);
            this.lblTrackCondition.Name = "lblTrackCondition";
            this.lblTrackCondition.Size = new System.Drawing.Size(51, 13);
            this.lblTrackCondition.TabIndex = 1;
            this.lblTrackCondition.Text = "Condition";
            // 
            // lblTrackTemperature
            // 
            this.lblTrackTemperature.AutoSize = true;
            this.lblTrackTemperature.Location = new System.Drawing.Point(6, 23);
            this.lblTrackTemperature.Name = "lblTrackTemperature";
            this.lblTrackTemperature.Size = new System.Drawing.Size(67, 13);
            this.lblTrackTemperature.TabIndex = 0;
            this.lblTrackTemperature.Text = "Temperature";
            // 
            // grbSessions
            // 
            this.grbSessions.Controls.Add(this.grbSessionRace);
            this.grbSessions.Controls.Add(this.grbSessionQualifying);
            this.grbSessions.Controls.Add(this.grbPracticeSession);
            this.grbSessions.Location = new System.Drawing.Point(281, 71);
            this.grbSessions.Name = "grbSessions";
            this.grbSessions.Size = new System.Drawing.Size(224, 377);
            this.grbSessions.TabIndex = 42;
            this.grbSessions.TabStop = false;
            this.grbSessions.Text = "Sessions";
            // 
            // grbSessionRace
            // 
            this.grbSessionRace.Controls.Add(this.lblTrack);
            this.grbSessionRace.Controls.Add(this.cbTrack);
            this.grbSessionRace.Controls.Add(this.lblNumberOfLapsValue);
            this.grbSessionRace.Controls.Add(this.lblNumberOfCarsValue);
            this.grbSessionRace.Controls.Add(this.lblNumberOfCars);
            this.grbSessionRace.Controls.Add(this.tkbNumberOfLaps);
            this.grbSessionRace.Controls.Add(this.tkbNumberOfCars);
            this.grbSessionRace.Controls.Add(this.lblNumberOfLaps);
            this.grbSessionRace.Location = new System.Drawing.Point(6, 213);
            this.grbSessionRace.Name = "grbSessionRace";
            this.grbSessionRace.Size = new System.Drawing.Size(212, 145);
            this.grbSessionRace.TabIndex = 45;
            this.grbSessionRace.TabStop = false;
            this.grbSessionRace.Text = "Race";
            // 
            // grbSessionQualifying
            // 
            this.grbSessionQualifying.Controls.Add(this.tkbQualifyingDuration);
            this.grbSessionQualifying.Controls.Add(this.lblQualifyingDurationValue);
            this.grbSessionQualifying.Controls.Add(this.lblQualifyingDuration);
            this.grbSessionQualifying.Controls.Add(this.ckbQualifying);
            this.grbSessionQualifying.Location = new System.Drawing.Point(6, 116);
            this.grbSessionQualifying.Name = "grbSessionQualifying";
            this.grbSessionQualifying.Size = new System.Drawing.Size(212, 91);
            this.grbSessionQualifying.TabIndex = 44;
            this.grbSessionQualifying.TabStop = false;
            this.grbSessionQualifying.Text = "Qualifying";
            // 
            // grbPracticeSession
            // 
            this.grbPracticeSession.Controls.Add(this.tkbPracticeDuration);
            this.grbPracticeSession.Controls.Add(this.ckbPractice);
            this.grbPracticeSession.Controls.Add(this.lblPracticeDurationValue);
            this.grbPracticeSession.Controls.Add(this.lblPracticeDuration);
            this.grbPracticeSession.Location = new System.Drawing.Point(6, 19);
            this.grbPracticeSession.Name = "grbPracticeSession";
            this.grbPracticeSession.Size = new System.Drawing.Size(212, 91);
            this.grbPracticeSession.TabIndex = 43;
            this.grbPracticeSession.TabStop = false;
            this.grbPracticeSession.Text = "Practice";
            // 
            // grbImages
            // 
            this.grbImages.Controls.Add(this.btnOpenPreviewImage);
            this.grbImages.Controls.Add(this.previewImagePanel);
            this.grbImages.Location = new System.Drawing.Point(12, 454);
            this.grbImages.Name = "grbImages";
            this.grbImages.Size = new System.Drawing.Size(263, 180);
            this.grbImages.TabIndex = 47;
            this.grbImages.TabStop = false;
            this.grbImages.Text = "Preview image";
            // 
            // btnOpenPreviewImage
            // 
            this.btnOpenPreviewImage.Image = global::ACCG.Properties.Resources.Open_6529_24;
            this.btnOpenPreviewImage.Location = new System.Drawing.Point(6, 150);
            this.btnOpenPreviewImage.Name = "btnOpenPreviewImage";
            this.btnOpenPreviewImage.Size = new System.Drawing.Size(37, 23);
            this.btnOpenPreviewImage.TabIndex = 1;
            this.tltLoadPreviewImage.SetToolTip(this.btnOpenPreviewImage, "Load preview image");
            this.btnOpenPreviewImage.UseVisualStyleBackColor = true;
            this.btnOpenPreviewImage.Click += new System.EventHandler(this.btnOpenPreviewImage_Click);
            // 
            // previewImagePanel
            // 
            this.previewImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewImagePanel.Location = new System.Drawing.Point(6, 19);
            this.previewImagePanel.Name = "previewImagePanel";
            this.previewImagePanel.Size = new System.Drawing.Size(250, 125);
            this.previewImagePanel.TabIndex = 0;
            this.previewImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.previewImagePanel_Paint);
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = "png files (*.png)|*.png";
            // 
            // ckbPenalties
            // 
            this.ckbPenalties.AutoSize = true;
            this.ckbPenalties.Location = new System.Drawing.Point(72, 163);
            this.ckbPenalties.Name = "ckbPenalties";
            this.ckbPenalties.Size = new System.Drawing.Size(15, 14);
            this.ckbPenalties.TabIndex = 4;
            this.ckbPenalties.UseVisualStyleBackColor = true;
            // 
            // lblPenalties
            // 
            this.lblPenalties.AutoSize = true;
            this.lblPenalties.Location = new System.Drawing.Point(6, 164);
            this.lblPenalties.Name = "lblPenalties";
            this.lblPenalties.Size = new System.Drawing.Size(50, 13);
            this.lblPenalties.TabIndex = 23;
            this.lblPenalties.Text = "Penalties";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(72, 42);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(169, 107);
            this.tbDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 45);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(72, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grbEvent
            // 
            this.grbEvent.Controls.Add(this.lblName);
            this.grbEvent.Controls.Add(this.tbName);
            this.grbEvent.Controls.Add(this.lblDescription);
            this.grbEvent.Controls.Add(this.tbDescription);
            this.grbEvent.Controls.Add(this.lblPenalties);
            this.grbEvent.Controls.Add(this.ckbPenalties);
            this.grbEvent.Location = new System.Drawing.Point(12, 12);
            this.grbEvent.Name = "grbEvent";
            this.grbEvent.Size = new System.Drawing.Size(263, 186);
            this.grbEvent.TabIndex = 39;
            this.grbEvent.TabStop = false;
            this.grbEvent.Text = "Event";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(303, 17);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(196, 41);
            this.btnRandom.TabIndex = 60;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // ACCGNewChampionshipEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 645);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.grbImages);
            this.Controls.Add(this.grbSessions);
            this.Controls.Add(this.grbTrack);
            this.Controls.Add(this.grbAmbient);
            this.Controls.Add(this.grbEvent);
            this.Controls.Add(this.grbButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ACCGNewChampionshipEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Event";
            this.Load += new System.EventHandler(this.NewEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbAmbientTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbPracticeDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbQualifyingDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfLaps)).EndInit();
            this.grbButtons.ResumeLayout(false);
            this.grbAmbient.ResumeLayout(false);
            this.grbAmbient.PerformLayout();
            this.grbTrack.ResumeLayout(false);
            this.grbTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackTemperature)).EndInit();
            this.grbSessions.ResumeLayout(false);
            this.grbSessionRace.ResumeLayout(false);
            this.grbSessionRace.PerformLayout();
            this.grbSessionQualifying.ResumeLayout(false);
            this.grbSessionQualifying.PerformLayout();
            this.grbPracticeSession.ResumeLayout(false);
            this.grbPracticeSession.PerformLayout();
            this.grbImages.ResumeLayout(false);
            this.grbEvent.ResumeLayout(false);
            this.grbEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAmbTemperature;
        private TrackBar tkbAmbientTemperature;
        private Label lblTime;
        private TrackBar tkbTime;
        private CheckBox ckbPractice;
        private Label lblPracticeDuration;
        private TrackBar tkbPracticeDuration;
        private TrackBar tkbQualifyingDuration;
        private Label lblQualifyingDuration;
        private CheckBox ckbQualifying;
        private Label lblTrack;
        private ComboBox cbTrack;
        private Label lblNumberOfCars;
        private TrackBar tkbNumberOfCars;
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
        private GroupBox grbButtons;
        private GroupBox grbAmbient;
        private GroupBox grbTrack;
        private Label lblTrackCondition;
        private Label lblTrackTemperature;
        private TrackBar tkbTrackCondition;
        private TrackBar tkbTrackTemperature;
        private Label lblTrackConditionValue;
        private Label lblTrackTemperatureValue;
        private GroupBox grbSessions;
        private GroupBox grbSessionRace;
        private GroupBox grbSessionQualifying;
        private GroupBox grbPracticeSession;
        private GroupBox grbImages;
        private Panel previewImagePanel;
        private Button btnOpenPreviewImage;
        private OpenFileDialog openImageFileDialog;
        private CheckBox ckbPenalties;
        private Label lblPenalties;
        private TextBox tbDescription;
        private Label lblDescription;
        private TextBox tbName;
        private Label lblName;
        private GroupBox grbEvent;
        private ToolTip tltLoadPreviewImage;
        private Button btnRandom;

        public static Event temp_event { get; set; }
                        
    }
}