using System.Drawing;
using System.Windows.Forms;
namespace ACCG
{
    partial class ACCGNewSingleEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCGNewSingleEventForm));
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grbImages = new System.Windows.Forms.GroupBox();
            this.btnOpenPreviewImage = new System.Windows.Forms.Button();
            this.previewImagePanel = new System.Windows.Forms.Panel();
            this.grbTrack = new System.Windows.Forms.GroupBox();
            this.lblTrack = new System.Windows.Forms.Label();
            this.cbTrack = new System.Windows.Forms.ComboBox();
            this.lblTrackConditionValue = new System.Windows.Forms.Label();
            this.lblTrackTemperatureValue = new System.Windows.Forms.Label();
            this.tkbTrackCondition = new System.Windows.Forms.TrackBar();
            this.tkbTrackTemperature = new System.Windows.Forms.TrackBar();
            this.lblTrackCondition = new System.Windows.Forms.Label();
            this.lblTrackTemperature = new System.Windows.Forms.Label();
            this.grbAmbient = new System.Windows.Forms.GroupBox();
            this.tkbAmbientTemperature = new System.Windows.Forms.TrackBar();
            this.lblAmbTemperature = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tkbTime = new System.Windows.Forms.TrackBar();
            this.lblAmbTemperatureValue = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.grbEvent = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblPenalties = new System.Windows.Forms.Label();
            this.ckbPenalties = new System.Windows.Forms.CheckBox();
            this.grbEventKind = new System.Windows.Forms.GroupBox();
            this.rbHotlap = new System.Windows.Forms.RadioButton();
            this.rbTimeAttack = new System.Windows.Forms.RadioButton();
            this.rbQuickRace = new System.Windows.Forms.RadioButton();
            this.grbQuickRaceGoals = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbPositionGoldTier = new System.Windows.Forms.TextBox();
            this.tbPositionSilverTier = new System.Windows.Forms.TextBox();
            this.tbPositionBronzeTier = new System.Windows.Forms.TextBox();
            this.lblBronzeTier = new System.Windows.Forms.Label();
            this.lblSilverTier = new System.Windows.Forms.Label();
            this.lblGoldTier = new System.Windows.Forms.Label();
            this.tbTimeSecondsBronzeTier = new System.Windows.Forms.TextBox();
            this.tbTimeMinutesBronzeTier = new System.Windows.Forms.TextBox();
            this.tbTimeSecondsSilverTier = new System.Windows.Forms.TextBox();
            this.tbTimeMinutesSilverTier = new System.Windows.Forms.TextBox();
            this.tbTimeSecondsGoldTier = new System.Windows.Forms.TextBox();
            this.tbTimeMinutesGoldTier = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tbPointsGoldTier = new System.Windows.Forms.TextBox();
            this.tbPointsSilverTier = new System.Windows.Forms.TextBox();
            this.tbPointsBronzeTier = new System.Windows.Forms.TextBox();
            this.grbCar = new System.Windows.Forms.GroupBox();
            this.skinPreviewImagePanel = new System.Windows.Forms.Panel();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSkin = new System.Windows.Forms.Label();
            this.cbSkin = new System.Windows.Forms.ComboBox();
            this.grbQuickRace = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStartPositionValue = new System.Windows.Forms.Label();
            this.tkbStartPosition = new System.Windows.Forms.TrackBar();
            this.lblStartingPosition = new System.Windows.Forms.Label();
            this.grbOpponents = new System.Windows.Forms.GroupBox();
            this.btnSaveOpponents = new System.Windows.Forms.Button();
            this.btnLoadOpponents = new System.Windows.Forms.Button();
            this.lbOpponents = new System.Windows.Forms.ListBox();
            this.btnDeleteOpponent = new System.Windows.Forms.Button();
            this.btnEditOpponent = new System.Windows.Forms.Button();
            this.btnNewOpponent = new System.Windows.Forms.Button();
            this.lblNumberOfLapsValue = new System.Windows.Forms.Label();
            this.lblNumberOfCarsValue = new System.Windows.Forms.Label();
            this.lblNumberOfCars = new System.Windows.Forms.Label();
            this.tkbNumberOfLaps = new System.Windows.Forms.TrackBar();
            this.tkbNumberOfCars = new System.Windows.Forms.TrackBar();
            this.lblNumberOfLaps = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tltNewOpponent = new System.Windows.Forms.ToolTip(this.components);
            this.tltEditOpponent = new System.Windows.Forms.ToolTip(this.components);
            this.tltDeleteOpponent = new System.Windows.Forms.ToolTip(this.components);
            this.tltLoadPreviewImage = new System.Windows.Forms.ToolTip(this.components);
            this.openOpponentsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tltLoadOpponents = new System.Windows.Forms.ToolTip(this.components);
            this.grbTimeAttackGoals = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbHotlapGoals = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveOpponentsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tltTimeTrackbar = new System.Windows.Forms.ToolTip(this.components);
            this.grbButtons.SuspendLayout();
            this.grbImages.SuspendLayout();
            this.grbTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackTemperature)).BeginInit();
            this.grbAmbient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAmbientTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTime)).BeginInit();
            this.grbEvent.SuspendLayout();
            this.grbEventKind.SuspendLayout();
            this.grbQuickRaceGoals.SuspendLayout();
            this.grbCar.SuspendLayout();
            this.grbQuickRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStartPosition)).BeginInit();
            this.grbOpponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfLaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfCars)).BeginInit();
            this.grbTimeAttackGoals.SuspendLayout();
            this.grbHotlapGoals.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnCancel);
            this.grbButtons.Controls.Add(this.btnOK);
            this.grbButtons.Location = new System.Drawing.Point(513, 615);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(183, 54);
            this.grbButtons.TabIndex = 48;
            this.grbButtons.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(98, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(17, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grbImages
            // 
            this.grbImages.Controls.Add(this.btnOpenPreviewImage);
            this.grbImages.Controls.Add(this.previewImagePanel);
            this.grbImages.Location = new System.Drawing.Point(5, 489);
            this.grbImages.Name = "grbImages";
            this.grbImages.Size = new System.Drawing.Size(263, 180);
            this.grbImages.TabIndex = 49;
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
            // grbTrack
            // 
            this.grbTrack.Controls.Add(this.lblTrack);
            this.grbTrack.Controls.Add(this.cbTrack);
            this.grbTrack.Controls.Add(this.lblTrackConditionValue);
            this.grbTrack.Controls.Add(this.lblTrackTemperatureValue);
            this.grbTrack.Controls.Add(this.tkbTrackCondition);
            this.grbTrack.Controls.Add(this.tkbTrackTemperature);
            this.grbTrack.Controls.Add(this.lblTrackCondition);
            this.grbTrack.Controls.Add(this.lblTrackTemperature);
            this.grbTrack.Location = new System.Drawing.Point(5, 319);
            this.grbTrack.Name = "grbTrack";
            this.grbTrack.Size = new System.Drawing.Size(263, 164);
            this.grbTrack.TabIndex = 52;
            this.grbTrack.TabStop = false;
            this.grbTrack.Text = "Track";
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(3, 27);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(35, 13);
            this.lblTrack.TabIndex = 19;
            this.lblTrack.Text = "Track";
            // 
            // cbTrack
            // 
            this.cbTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrack.FormattingEnabled = true;
            this.cbTrack.Location = new System.Drawing.Point(81, 24);
            this.cbTrack.Name = "cbTrack";
            this.cbTrack.Size = new System.Drawing.Size(145, 21);
            this.cbTrack.TabIndex = 20;
            // 
            // lblTrackConditionValue
            // 
            this.lblTrackConditionValue.AutoSize = true;
            this.lblTrackConditionValue.Location = new System.Drawing.Point(205, 117);
            this.lblTrackConditionValue.Name = "lblTrackConditionValue";
            this.lblTrackConditionValue.Size = new System.Drawing.Size(27, 13);
            this.lblTrackConditionValue.TabIndex = 5;
            this.lblTrackConditionValue.Text = "Fast";
            // 
            // lblTrackTemperatureValue
            // 
            this.lblTrackTemperatureValue.AutoSize = true;
            this.lblTrackTemperatureValue.Location = new System.Drawing.Point(206, 68);
            this.lblTrackTemperatureValue.Name = "lblTrackTemperatureValue";
            this.lblTrackTemperatureValue.Size = new System.Drawing.Size(33, 13);
            this.lblTrackTemperatureValue.TabIndex = 4;
            this.lblTrackTemperatureValue.Text = "33 °C";
            // 
            // tkbTrackCondition
            // 
            this.tkbTrackCondition.Location = new System.Drawing.Point(78, 117);
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
            this.tkbTrackTemperature.Location = new System.Drawing.Point(79, 65);
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
            this.lblTrackCondition.Location = new System.Drawing.Point(4, 117);
            this.lblTrackCondition.Name = "lblTrackCondition";
            this.lblTrackCondition.Size = new System.Drawing.Size(51, 13);
            this.lblTrackCondition.TabIndex = 1;
            this.lblTrackCondition.Text = "Condition";
            // 
            // lblTrackTemperature
            // 
            this.lblTrackTemperature.AutoSize = true;
            this.lblTrackTemperature.Location = new System.Drawing.Point(4, 68);
            this.lblTrackTemperature.Name = "lblTrackTemperature";
            this.lblTrackTemperature.Size = new System.Drawing.Size(67, 13);
            this.lblTrackTemperature.TabIndex = 0;
            this.lblTrackTemperature.Text = "Temperature";
            // 
            // grbAmbient
            // 
            this.grbAmbient.Controls.Add(this.tkbAmbientTemperature);
            this.grbAmbient.Controls.Add(this.lblAmbTemperature);
            this.grbAmbient.Controls.Add(this.lblTime);
            this.grbAmbient.Controls.Add(this.tkbTime);
            this.grbAmbient.Controls.Add(this.lblAmbTemperatureValue);
            this.grbAmbient.Controls.Add(this.lblTimeValue);
            this.grbAmbient.Location = new System.Drawing.Point(5, 199);
            this.grbAmbient.Name = "grbAmbient";
            this.grbAmbient.Size = new System.Drawing.Size(263, 114);
            this.grbAmbient.TabIndex = 51;
            this.grbAmbient.TabStop = false;
            this.grbAmbient.Text = "Ambient";
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
            // lblAmbTemperature
            // 
            this.lblAmbTemperature.AutoSize = true;
            this.lblAmbTemperature.Location = new System.Drawing.Point(6, 22);
            this.lblAmbTemperature.Name = "lblAmbTemperature";
            this.lblAmbTemperature.Size = new System.Drawing.Size(67, 13);
            this.lblAmbTemperature.TabIndex = 4;
            this.lblAmbTemperature.Text = "Temperature";
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
            this.tkbTime.MouseEnter += new System.EventHandler(this.tkbTime_MouseEnter);
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
            // grbEvent
            // 
            this.grbEvent.Controls.Add(this.lblName);
            this.grbEvent.Controls.Add(this.tbName);
            this.grbEvent.Controls.Add(this.lblDescription);
            this.grbEvent.Controls.Add(this.tbDescription);
            this.grbEvent.Controls.Add(this.lblPenalties);
            this.grbEvent.Controls.Add(this.ckbPenalties);
            this.grbEvent.Location = new System.Drawing.Point(5, 7);
            this.grbEvent.Name = "grbEvent";
            this.grbEvent.Size = new System.Drawing.Size(263, 186);
            this.grbEvent.TabIndex = 50;
            this.grbEvent.TabStop = false;
            this.grbEvent.Text = "Event";
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
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(72, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 1;
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
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(72, 42);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(169, 107);
            this.tbDescription.TabIndex = 3;
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
            // ckbPenalties
            // 
            this.ckbPenalties.AutoSize = true;
            this.ckbPenalties.Location = new System.Drawing.Point(72, 163);
            this.ckbPenalties.Name = "ckbPenalties";
            this.ckbPenalties.Size = new System.Drawing.Size(15, 14);
            this.ckbPenalties.TabIndex = 4;
            this.ckbPenalties.UseVisualStyleBackColor = true;
            // 
            // grbEventKind
            // 
            this.grbEventKind.Controls.Add(this.rbHotlap);
            this.grbEventKind.Controls.Add(this.rbTimeAttack);
            this.grbEventKind.Controls.Add(this.rbQuickRace);
            this.grbEventKind.Location = new System.Drawing.Point(274, 7);
            this.grbEventKind.Name = "grbEventKind";
            this.grbEventKind.Size = new System.Drawing.Size(206, 72);
            this.grbEventKind.TabIndex = 55;
            this.grbEventKind.TabStop = false;
            this.grbEventKind.Text = "Event Kind";
            // 
            // rbHotlap
            // 
            this.rbHotlap.AutoSize = true;
            this.rbHotlap.Location = new System.Drawing.Point(7, 43);
            this.rbHotlap.Name = "rbHotlap";
            this.rbHotlap.Size = new System.Drawing.Size(56, 17);
            this.rbHotlap.TabIndex = 59;
            this.rbHotlap.TabStop = true;
            this.rbHotlap.Text = "Hotlap";
            this.rbHotlap.UseVisualStyleBackColor = true;
            this.rbHotlap.CheckedChanged += new System.EventHandler(this.rbHotlap_CheckedChanged);
            // 
            // rbTimeAttack
            // 
            this.rbTimeAttack.AutoSize = true;
            this.rbTimeAttack.Location = new System.Drawing.Point(118, 19);
            this.rbTimeAttack.Name = "rbTimeAttack";
            this.rbTimeAttack.Size = new System.Drawing.Size(82, 17);
            this.rbTimeAttack.TabIndex = 58;
            this.rbTimeAttack.TabStop = true;
            this.rbTimeAttack.Text = "Time Attack";
            this.rbTimeAttack.UseVisualStyleBackColor = true;
            this.rbTimeAttack.CheckedChanged += new System.EventHandler(this.rbTimeAttack_CheckedChanged);
            // 
            // rbQuickRace
            // 
            this.rbQuickRace.AutoSize = true;
            this.rbQuickRace.Checked = true;
            this.rbQuickRace.Location = new System.Drawing.Point(6, 19);
            this.rbQuickRace.Name = "rbQuickRace";
            this.rbQuickRace.Size = new System.Drawing.Size(82, 17);
            this.rbQuickRace.TabIndex = 57;
            this.rbQuickRace.TabStop = true;
            this.rbQuickRace.Text = "Quick Race";
            this.rbQuickRace.UseVisualStyleBackColor = true;
            this.rbQuickRace.CheckedChanged += new System.EventHandler(this.rbQuickRace_CheckedChanged);
            // 
            // grbQuickRaceGoals
            // 
            this.grbQuickRaceGoals.Controls.Add(this.label15);
            this.grbQuickRaceGoals.Controls.Add(this.label14);
            this.grbQuickRaceGoals.Controls.Add(this.lblPosition);
            this.grbQuickRaceGoals.Controls.Add(this.tbPositionGoldTier);
            this.grbQuickRaceGoals.Controls.Add(this.tbPositionSilverTier);
            this.grbQuickRaceGoals.Controls.Add(this.tbPositionBronzeTier);
            this.grbQuickRaceGoals.Controls.Add(this.lblBronzeTier);
            this.grbQuickRaceGoals.Controls.Add(this.lblSilverTier);
            this.grbQuickRaceGoals.Controls.Add(this.lblGoldTier);
            this.grbQuickRaceGoals.Location = new System.Drawing.Point(8, 326);
            this.grbQuickRaceGoals.Name = "grbQuickRaceGoals";
            this.grbQuickRaceGoals.Size = new System.Drawing.Size(194, 117);
            this.grbQuickRaceGoals.TabIndex = 56;
            this.grbQuickRaceGoals.TabStop = false;
            this.grbQuickRaceGoals.Text = "Quick Race Goals";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(119, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "position";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "position";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(119, 32);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(43, 13);
            this.lblPosition.TabIndex = 48;
            this.lblPosition.Text = "position";
            // 
            // tbPositionGoldTier
            // 
            this.tbPositionGoldTier.Location = new System.Drawing.Point(88, 29);
            this.tbPositionGoldTier.MaxLength = 2;
            this.tbPositionGoldTier.Name = "tbPositionGoldTier";
            this.tbPositionGoldTier.Size = new System.Drawing.Size(25, 20);
            this.tbPositionGoldTier.TabIndex = 39;
            // 
            // tbPositionSilverTier
            // 
            this.tbPositionSilverTier.Location = new System.Drawing.Point(88, 55);
            this.tbPositionSilverTier.MaxLength = 2;
            this.tbPositionSilverTier.Name = "tbPositionSilverTier";
            this.tbPositionSilverTier.Size = new System.Drawing.Size(25, 20);
            this.tbPositionSilverTier.TabIndex = 40;
            // 
            // tbPositionBronzeTier
            // 
            this.tbPositionBronzeTier.Location = new System.Drawing.Point(88, 81);
            this.tbPositionBronzeTier.MaxLength = 2;
            this.tbPositionBronzeTier.Name = "tbPositionBronzeTier";
            this.tbPositionBronzeTier.Size = new System.Drawing.Size(25, 20);
            this.tbPositionBronzeTier.TabIndex = 41;
            // 
            // lblBronzeTier
            // 
            this.lblBronzeTier.AutoSize = true;
            this.lblBronzeTier.Location = new System.Drawing.Point(42, 84);
            this.lblBronzeTier.Name = "lblBronzeTier";
            this.lblBronzeTier.Size = new System.Drawing.Size(40, 13);
            this.lblBronzeTier.TabIndex = 44;
            this.lblBronzeTier.Text = "Bronze";
            // 
            // lblSilverTier
            // 
            this.lblSilverTier.AutoSize = true;
            this.lblSilverTier.Location = new System.Drawing.Point(42, 58);
            this.lblSilverTier.Name = "lblSilverTier";
            this.lblSilverTier.Size = new System.Drawing.Size(33, 13);
            this.lblSilverTier.TabIndex = 43;
            this.lblSilverTier.Text = "Silver";
            // 
            // lblGoldTier
            // 
            this.lblGoldTier.AutoSize = true;
            this.lblGoldTier.Location = new System.Drawing.Point(43, 32);
            this.lblGoldTier.Name = "lblGoldTier";
            this.lblGoldTier.Size = new System.Drawing.Size(29, 13);
            this.lblGoldTier.TabIndex = 42;
            this.lblGoldTier.Text = "Gold";
            // 
            // tbTimeSecondsBronzeTier
            // 
            this.tbTimeSecondsBronzeTier.Location = new System.Drawing.Point(112, 94);
            this.tbTimeSecondsBronzeTier.MaxLength = 2;
            this.tbTimeSecondsBronzeTier.Name = "tbTimeSecondsBronzeTier";
            this.tbTimeSecondsBronzeTier.Size = new System.Drawing.Size(25, 20);
            this.tbTimeSecondsBronzeTier.TabIndex = 57;
            // 
            // tbTimeMinutesBronzeTier
            // 
            this.tbTimeMinutesBronzeTier.Location = new System.Drawing.Point(72, 94);
            this.tbTimeMinutesBronzeTier.MaxLength = 2;
            this.tbTimeMinutesBronzeTier.Name = "tbTimeMinutesBronzeTier";
            this.tbTimeMinutesBronzeTier.Size = new System.Drawing.Size(25, 20);
            this.tbTimeMinutesBronzeTier.TabIndex = 56;
            // 
            // tbTimeSecondsSilverTier
            // 
            this.tbTimeSecondsSilverTier.Location = new System.Drawing.Point(112, 68);
            this.tbTimeSecondsSilverTier.MaxLength = 2;
            this.tbTimeSecondsSilverTier.Name = "tbTimeSecondsSilverTier";
            this.tbTimeSecondsSilverTier.Size = new System.Drawing.Size(25, 20);
            this.tbTimeSecondsSilverTier.TabIndex = 54;
            // 
            // tbTimeMinutesSilverTier
            // 
            this.tbTimeMinutesSilverTier.Location = new System.Drawing.Point(72, 68);
            this.tbTimeMinutesSilverTier.MaxLength = 2;
            this.tbTimeMinutesSilverTier.Name = "tbTimeMinutesSilverTier";
            this.tbTimeMinutesSilverTier.Size = new System.Drawing.Size(25, 20);
            this.tbTimeMinutesSilverTier.TabIndex = 53;
            // 
            // tbTimeSecondsGoldTier
            // 
            this.tbTimeSecondsGoldTier.Location = new System.Drawing.Point(112, 42);
            this.tbTimeSecondsGoldTier.MaxLength = 2;
            this.tbTimeSecondsGoldTier.Name = "tbTimeSecondsGoldTier";
            this.tbTimeSecondsGoldTier.Size = new System.Drawing.Size(25, 20);
            this.tbTimeSecondsGoldTier.TabIndex = 51;
            // 
            // tbTimeMinutesGoldTier
            // 
            this.tbTimeMinutesGoldTier.Location = new System.Drawing.Point(72, 42);
            this.tbTimeMinutesGoldTier.MaxLength = 2;
            this.tbTimeMinutesGoldTier.Name = "tbTimeMinutesGoldTier";
            this.tbTimeMinutesGoldTier.Size = new System.Drawing.Size(25, 20);
            this.tbTimeMinutesGoldTier.TabIndex = 50;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(128, 22);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(35, 13);
            this.lblPoints.TabIndex = 49;
            this.lblPoints.Text = "points";
            // 
            // tbPointsGoldTier
            // 
            this.tbPointsGoldTier.Location = new System.Drawing.Point(89, 19);
            this.tbPointsGoldTier.MaxLength = 4;
            this.tbPointsGoldTier.Name = "tbPointsGoldTier";
            this.tbPointsGoldTier.Size = new System.Drawing.Size(33, 20);
            this.tbPointsGoldTier.TabIndex = 45;
            // 
            // tbPointsSilverTier
            // 
            this.tbPointsSilverTier.Location = new System.Drawing.Point(89, 45);
            this.tbPointsSilverTier.MaxLength = 4;
            this.tbPointsSilverTier.Name = "tbPointsSilverTier";
            this.tbPointsSilverTier.Size = new System.Drawing.Size(33, 20);
            this.tbPointsSilverTier.TabIndex = 46;
            // 
            // tbPointsBronzeTier
            // 
            this.tbPointsBronzeTier.Location = new System.Drawing.Point(89, 71);
            this.tbPointsBronzeTier.MaxLength = 4;
            this.tbPointsBronzeTier.Name = "tbPointsBronzeTier";
            this.tbPointsBronzeTier.Size = new System.Drawing.Size(33, 20);
            this.tbPointsBronzeTier.TabIndex = 47;
            // 
            // grbCar
            // 
            this.grbCar.Controls.Add(this.skinPreviewImagePanel);
            this.grbCar.Controls.Add(this.cbCar);
            this.grbCar.Controls.Add(this.lblModel);
            this.grbCar.Controls.Add(this.lblSkin);
            this.grbCar.Controls.Add(this.cbSkin);
            this.grbCar.Location = new System.Drawing.Point(274, 85);
            this.grbCar.Name = "grbCar";
            this.grbCar.Size = new System.Drawing.Size(206, 186);
            this.grbCar.TabIndex = 57;
            this.grbCar.TabStop = false;
            this.grbCar.Text = "Car";
            // 
            // skinPreviewImagePanel
            // 
            this.skinPreviewImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinPreviewImagePanel.Location = new System.Drawing.Point(18, 79);
            this.skinPreviewImagePanel.Name = "skinPreviewImagePanel";
            this.skinPreviewImagePanel.Size = new System.Drawing.Size(170, 96);
            this.skinPreviewImagePanel.TabIndex = 38;
            this.skinPreviewImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.skinPreviewImagePanel_Paint);
            // 
            // cbCar
            // 
            this.cbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(50, 22);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(146, 21);
            this.cbCar.TabIndex = 14;
            this.cbCar.SelectionChangeCommitted += new System.EventHandler(this.cbCar_SelectionChangeCommitted);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(7, 25);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model";
            // 
            // lblSkin
            // 
            this.lblSkin.AutoSize = true;
            this.lblSkin.Location = new System.Drawing.Point(7, 52);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(28, 13);
            this.lblSkin.TabIndex = 37;
            this.lblSkin.Text = "Skin";
            // 
            // cbSkin
            // 
            this.cbSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkin.FormattingEnabled = true;
            this.cbSkin.Location = new System.Drawing.Point(50, 49);
            this.cbSkin.Name = "cbSkin";
            this.cbSkin.Size = new System.Drawing.Size(146, 21);
            this.cbSkin.TabIndex = 15;
            this.cbSkin.SelectionChangeCommitted += new System.EventHandler(this.cbSkin_SelectionChangeCommitted);
            // 
            // grbQuickRace
            // 
            this.grbQuickRace.Controls.Add(this.label3);
            this.grbQuickRace.Controls.Add(this.lblStartPositionValue);
            this.grbQuickRace.Controls.Add(this.tkbStartPosition);
            this.grbQuickRace.Controls.Add(this.lblStartingPosition);
            this.grbQuickRace.Controls.Add(this.grbOpponents);
            this.grbQuickRace.Controls.Add(this.grbQuickRaceGoals);
            this.grbQuickRace.Controls.Add(this.lblNumberOfLapsValue);
            this.grbQuickRace.Controls.Add(this.lblNumberOfCarsValue);
            this.grbQuickRace.Controls.Add(this.lblNumberOfCars);
            this.grbQuickRace.Controls.Add(this.tkbNumberOfLaps);
            this.grbQuickRace.Controls.Add(this.tkbNumberOfCars);
            this.grbQuickRace.Controls.Add(this.lblNumberOfLaps);
            this.grbQuickRace.Location = new System.Drawing.Point(486, 85);
            this.grbQuickRace.Name = "grbQuickRace";
            this.grbQuickRace.Size = new System.Drawing.Size(210, 451);
            this.grbQuickRace.TabIndex = 58;
            this.grbQuickRace.TabStop = false;
            this.grbQuickRace.Text = "Quick Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "position";
            // 
            // lblStartPositionValue
            // 
            this.lblStartPositionValue.AutoSize = true;
            this.lblStartPositionValue.Location = new System.Drawing.Point(159, 124);
            this.lblStartPositionValue.Name = "lblStartPositionValue";
            this.lblStartPositionValue.Size = new System.Drawing.Size(13, 13);
            this.lblStartPositionValue.TabIndex = 50;
            this.lblStartPositionValue.Text = "1";
            // 
            // tkbStartPosition
            // 
            this.tkbStartPosition.Location = new System.Drawing.Point(53, 121);
            this.tkbStartPosition.Maximum = 20;
            this.tkbStartPosition.Minimum = 1;
            this.tkbStartPosition.Name = "tkbStartPosition";
            this.tkbStartPosition.Size = new System.Drawing.Size(104, 45);
            this.tkbStartPosition.TabIndex = 49;
            this.tkbStartPosition.Value = 1;
            this.tkbStartPosition.Scroll += new System.EventHandler(this.tkbStartPosition_Scroll);
            // 
            // lblStartingPosition
            // 
            this.lblStartingPosition.AutoSize = true;
            this.lblStartingPosition.Location = new System.Drawing.Point(8, 122);
            this.lblStartingPosition.Name = "lblStartingPosition";
            this.lblStartingPosition.Size = new System.Drawing.Size(43, 13);
            this.lblStartingPosition.TabIndex = 48;
            this.lblStartingPosition.Text = "Starting";
            // 
            // grbOpponents
            // 
            this.grbOpponents.Controls.Add(this.btnSaveOpponents);
            this.grbOpponents.Controls.Add(this.btnLoadOpponents);
            this.grbOpponents.Controls.Add(this.lbOpponents);
            this.grbOpponents.Controls.Add(this.btnDeleteOpponent);
            this.grbOpponents.Controls.Add(this.btnEditOpponent);
            this.grbOpponents.Controls.Add(this.btnNewOpponent);
            this.grbOpponents.Location = new System.Drawing.Point(8, 172);
            this.grbOpponents.Name = "grbOpponents";
            this.grbOpponents.Size = new System.Drawing.Size(194, 148);
            this.grbOpponents.TabIndex = 47;
            this.grbOpponents.TabStop = false;
            this.grbOpponents.Text = "Opponents";
            // 
            // btnSaveOpponents
            // 
            this.btnSaveOpponents.Image = global::ACCG.Properties.Resources.Save_6530;
            this.btnSaveOpponents.Location = new System.Drawing.Point(144, 46);
            this.btnSaveOpponents.Name = "btnSaveOpponents";
            this.btnSaveOpponents.Size = new System.Drawing.Size(37, 23);
            this.btnSaveOpponents.TabIndex = 32;
            this.btnSaveOpponents.UseVisualStyleBackColor = true;
            this.btnSaveOpponents.Click += new System.EventHandler(this.btnSaveOpponents_Click);
            // 
            // btnLoadOpponents
            // 
            this.btnLoadOpponents.Image = global::ACCG.Properties.Resources.Open_6529_24;
            this.btnLoadOpponents.Location = new System.Drawing.Point(144, 17);
            this.btnLoadOpponents.Name = "btnLoadOpponents";
            this.btnLoadOpponents.Size = new System.Drawing.Size(37, 23);
            this.btnLoadOpponents.TabIndex = 31;
            this.tltLoadOpponents.SetToolTip(this.btnLoadOpponents, "Load Opponents");
            this.btnLoadOpponents.UseVisualStyleBackColor = true;
            this.btnLoadOpponents.Click += new System.EventHandler(this.btnLoadOpponents_Click);
            // 
            // lbOpponents
            // 
            this.lbOpponents.FormattingEnabled = true;
            this.lbOpponents.Location = new System.Drawing.Point(15, 17);
            this.lbOpponents.Name = "lbOpponents";
            this.lbOpponents.Size = new System.Drawing.Size(123, 95);
            this.lbOpponents.TabIndex = 25;
            this.lbOpponents.SelectedIndexChanged += new System.EventHandler(this.lbOpponents_SelectedIndexChanged);
            // 
            // btnDeleteOpponent
            // 
            this.btnDeleteOpponent.Image = global::ACCG.Properties.Resources.Clearallrequests_8816;
            this.btnDeleteOpponent.Location = new System.Drawing.Point(101, 118);
            this.btnDeleteOpponent.Name = "btnDeleteOpponent";
            this.btnDeleteOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnDeleteOpponent.TabIndex = 29;
            this.tltDeleteOpponent.SetToolTip(this.btnDeleteOpponent, "Delete Opponent");
            this.btnDeleteOpponent.UseVisualStyleBackColor = true;
            this.btnDeleteOpponent.Click += new System.EventHandler(this.btnDeleteOpponent_Click);
            // 
            // btnEditOpponent
            // 
            this.btnEditOpponent.Image = global::ACCG.Properties.Resources.EditTitleString_357;
            this.btnEditOpponent.Location = new System.Drawing.Point(58, 118);
            this.btnEditOpponent.Name = "btnEditOpponent";
            this.btnEditOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnEditOpponent.TabIndex = 28;
            this.tltEditOpponent.SetToolTip(this.btnEditOpponent, "Edit Opponent");
            this.btnEditOpponent.UseVisualStyleBackColor = true;
            this.btnEditOpponent.Click += new System.EventHandler(this.btnEditOpponent_Click);
            // 
            // btnNewOpponent
            // 
            this.btnNewOpponent.Image = global::ACCG.Properties.Resources.NewFile_6276;
            this.btnNewOpponent.Location = new System.Drawing.Point(15, 118);
            this.btnNewOpponent.Name = "btnNewOpponent";
            this.btnNewOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnNewOpponent.TabIndex = 27;
            this.tltNewOpponent.SetToolTip(this.btnNewOpponent, "New Opponent");
            this.btnNewOpponent.UseVisualStyleBackColor = true;
            this.btnNewOpponent.Click += new System.EventHandler(this.btnNewOpponent_Click);
            // 
            // lblNumberOfLapsValue
            // 
            this.lblNumberOfLapsValue.AutoSize = true;
            this.lblNumberOfLapsValue.Location = new System.Drawing.Point(159, 73);
            this.lblNumberOfLapsValue.Name = "lblNumberOfLapsValue";
            this.lblNumberOfLapsValue.Size = new System.Drawing.Size(35, 13);
            this.lblNumberOfLapsValue.TabIndex = 36;
            this.lblNumberOfLapsValue.Text = "2 laps";
            // 
            // lblNumberOfCarsValue
            // 
            this.lblNumberOfCarsValue.AutoSize = true;
            this.lblNumberOfCarsValue.Location = new System.Drawing.Point(159, 22);
            this.lblNumberOfCarsValue.Name = "lblNumberOfCarsValue";
            this.lblNumberOfCarsValue.Size = new System.Drawing.Size(36, 13);
            this.lblNumberOfCarsValue.TabIndex = 35;
            this.lblNumberOfCarsValue.Text = "2 cars";
            // 
            // lblNumberOfCars
            // 
            this.lblNumberOfCars.AutoSize = true;
            this.lblNumberOfCars.Location = new System.Drawing.Point(8, 22);
            this.lblNumberOfCars.Name = "lblNumberOfCars";
            this.lblNumberOfCars.Size = new System.Drawing.Size(28, 13);
            this.lblNumberOfCars.TabIndex = 21;
            this.lblNumberOfCars.Text = "Cars";
            // 
            // tkbNumberOfLaps
            // 
            this.tkbNumberOfLaps.Location = new System.Drawing.Point(53, 70);
            this.tkbNumberOfLaps.Maximum = 50;
            this.tkbNumberOfLaps.Minimum = 1;
            this.tkbNumberOfLaps.Name = "tkbNumberOfLaps";
            this.tkbNumberOfLaps.Size = new System.Drawing.Size(104, 45);
            this.tkbNumberOfLaps.TabIndex = 26;
            this.tkbNumberOfLaps.Value = 2;
            this.tkbNumberOfLaps.Scroll += new System.EventHandler(this.tkbNumberOfLaps_Scroll);
            // 
            // tkbNumberOfCars
            // 
            this.tkbNumberOfCars.Location = new System.Drawing.Point(49, 19);
            this.tkbNumberOfCars.Maximum = 24;
            this.tkbNumberOfCars.Minimum = 1;
            this.tkbNumberOfCars.Name = "tkbNumberOfCars";
            this.tkbNumberOfCars.Size = new System.Drawing.Size(104, 45);
            this.tkbNumberOfCars.TabIndex = 22;
            this.tkbNumberOfCars.Value = 2;
            this.tkbNumberOfCars.Scroll += new System.EventHandler(this.tkbNumberOfCars_Scroll);
            // 
            // lblNumberOfLaps
            // 
            this.lblNumberOfLaps.AutoSize = true;
            this.lblNumberOfLaps.Location = new System.Drawing.Point(8, 73);
            this.lblNumberOfLaps.Name = "lblNumberOfLaps";
            this.lblNumberOfLaps.Size = new System.Drawing.Size(30, 13);
            this.lblNumberOfLaps.TabIndex = 25;
            this.lblNumberOfLaps.Text = "Laps";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(497, 26);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(196, 41);
            this.btnRandom.TabIndex = 59;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // openOpponentsFileDialog
            // 
            this.openOpponentsFileDialog.Filter = "opponents files (opponents.ini)|opponents.ini";
            // 
            // grbTimeAttackGoals
            // 
            this.grbTimeAttackGoals.Controls.Add(this.label17);
            this.grbTimeAttackGoals.Controls.Add(this.label16);
            this.grbTimeAttackGoals.Controls.Add(this.label1);
            this.grbTimeAttackGoals.Controls.Add(this.label2);
            this.grbTimeAttackGoals.Controls.Add(this.label4);
            this.grbTimeAttackGoals.Controls.Add(this.lblPoints);
            this.grbTimeAttackGoals.Controls.Add(this.tbPointsBronzeTier);
            this.grbTimeAttackGoals.Controls.Add(this.tbPointsSilverTier);
            this.grbTimeAttackGoals.Controls.Add(this.tbPointsGoldTier);
            this.grbTimeAttackGoals.Location = new System.Drawing.Point(274, 277);
            this.grbTimeAttackGoals.Name = "grbTimeAttackGoals";
            this.grbTimeAttackGoals.Size = new System.Drawing.Size(206, 100);
            this.grbTimeAttackGoals.TabIndex = 60;
            this.grbTimeAttackGoals.TabStop = false;
            this.grbTimeAttackGoals.Text = "Time Attack Goals";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(128, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "points";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(128, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Bronze";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Silver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Gold";
            // 
            // grbHotlapGoals
            // 
            this.grbHotlapGoals.Controls.Add(this.label19);
            this.grbHotlapGoals.Controls.Add(this.label18);
            this.grbHotlapGoals.Controls.Add(this.label13);
            this.grbHotlapGoals.Controls.Add(this.label12);
            this.grbHotlapGoals.Controls.Add(this.label11);
            this.grbHotlapGoals.Controls.Add(this.label8);
            this.grbHotlapGoals.Controls.Add(this.label5);
            this.grbHotlapGoals.Controls.Add(this.label6);
            this.grbHotlapGoals.Controls.Add(this.label9);
            this.grbHotlapGoals.Controls.Add(this.label7);
            this.grbHotlapGoals.Controls.Add(this.tbTimeSecondsBronzeTier);
            this.grbHotlapGoals.Controls.Add(this.label10);
            this.grbHotlapGoals.Controls.Add(this.tbTimeMinutesGoldTier);
            this.grbHotlapGoals.Controls.Add(this.tbTimeMinutesBronzeTier);
            this.grbHotlapGoals.Controls.Add(this.tbTimeSecondsGoldTier);
            this.grbHotlapGoals.Controls.Add(this.tbTimeSecondsSilverTier);
            this.grbHotlapGoals.Controls.Add(this.tbTimeMinutesSilverTier);
            this.grbHotlapGoals.Location = new System.Drawing.Point(274, 383);
            this.grbHotlapGoals.Name = "grbHotlapGoals";
            this.grbHotlapGoals.Size = new System.Drawing.Size(206, 125);
            this.grbHotlapGoals.TabIndex = 61;
            this.grbHotlapGoals.TabStop = false;
            this.grbHotlapGoals.Text = "Hotlap Goals";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(112, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 68;
            this.label19.Text = "sec";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(73, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 67;
            this.label18.Text = "min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = ".000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Bronze";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Silver";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = ".000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Gold";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = ".000";
            // 
            // saveOpponentsFileDialog
            // 
            this.saveOpponentsFileDialog.Filter = "opponents files (*.ini)|*.ini|opponents files (*.txt)|*.txt";
            // 
            // ACCGNewSingleEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 674);
            this.Controls.Add(this.grbHotlapGoals);
            this.Controls.Add(this.grbTimeAttackGoals);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.grbQuickRace);
            this.Controls.Add(this.grbCar);
            this.Controls.Add(this.grbEventKind);
            this.Controls.Add(this.grbTrack);
            this.Controls.Add(this.grbAmbient);
            this.Controls.Add(this.grbEvent);
            this.Controls.Add(this.grbImages);
            this.Controls.Add(this.grbButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ACCGNewSingleEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ACCGNewSingleEventForm";
            this.Load += new System.EventHandler(this.ACCGNewSingleEventForm_Load);
            this.grbButtons.ResumeLayout(false);
            this.grbImages.ResumeLayout(false);
            this.grbTrack.ResumeLayout(false);
            this.grbTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackTemperature)).EndInit();
            this.grbAmbient.ResumeLayout(false);
            this.grbAmbient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAmbientTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTime)).EndInit();
            this.grbEvent.ResumeLayout(false);
            this.grbEvent.PerformLayout();
            this.grbEventKind.ResumeLayout(false);
            this.grbEventKind.PerformLayout();
            this.grbQuickRaceGoals.ResumeLayout(false);
            this.grbQuickRaceGoals.PerformLayout();
            this.grbCar.ResumeLayout(false);
            this.grbCar.PerformLayout();
            this.grbQuickRace.ResumeLayout(false);
            this.grbQuickRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStartPosition)).EndInit();
            this.grbOpponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfLaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfCars)).EndInit();
            this.grbTimeAttackGoals.ResumeLayout(false);
            this.grbTimeAttackGoals.PerformLayout();
            this.grbHotlapGoals.ResumeLayout(false);
            this.grbHotlapGoals.PerformLayout();
            this.ResumeLayout(false);

        }

        private void ShowData()
        {
            // Opponents listbox data source
            bs_opponents_datasource.DataSource = temp_event.opponents_list;

            lbOpponents.DisplayMember = "Name";
            lbOpponents.ValueMember = "ID";

            lbOpponents.DataSource = bs_opponents_datasource;
        }

        #endregion

        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grbImages;
        private System.Windows.Forms.Button btnOpenPreviewImage;
        private System.Windows.Forms.Panel previewImagePanel;
        private System.Windows.Forms.GroupBox grbTrack;
        private System.Windows.Forms.Label lblTrackConditionValue;
        private System.Windows.Forms.Label lblTrackTemperatureValue;
        private System.Windows.Forms.TrackBar tkbTrackCondition;
        private System.Windows.Forms.TrackBar tkbTrackTemperature;
        private System.Windows.Forms.Label lblTrackCondition;
        private System.Windows.Forms.Label lblTrackTemperature;
        private System.Windows.Forms.GroupBox grbAmbient;
        private System.Windows.Forms.TrackBar tkbAmbientTemperature;
        private System.Windows.Forms.Label lblAmbTemperature;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TrackBar tkbTime;
        private System.Windows.Forms.Label lblAmbTemperatureValue;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.GroupBox grbEvent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblPenalties;
        private System.Windows.Forms.CheckBox ckbPenalties;
        private System.Windows.Forms.GroupBox grbEventKind;
        private System.Windows.Forms.GroupBox grbQuickRaceGoals;
        private System.Windows.Forms.RadioButton rbQuickRace;
        private System.Windows.Forms.RadioButton rbTimeAttack;
        private System.Windows.Forms.GroupBox grbCar;
        private System.Windows.Forms.Panel skinPreviewImagePanel;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSkin;
        private System.Windows.Forms.ComboBox cbSkin;
        private System.Windows.Forms.GroupBox grbQuickRace;
        private System.Windows.Forms.Label lblNumberOfLapsValue;
        private System.Windows.Forms.Label lblNumberOfCarsValue;
        private System.Windows.Forms.Label lblNumberOfCars;
        private System.Windows.Forms.TrackBar tkbNumberOfLaps;
        private System.Windows.Forms.TrackBar tkbNumberOfCars;
        private System.Windows.Forms.Label lblNumberOfLaps;
        private System.Windows.Forms.GroupBox grbOpponents;
        private System.Windows.Forms.ListBox lbOpponents;
        private System.Windows.Forms.Button btnDeleteOpponent;
        private System.Windows.Forms.Button btnEditOpponent;
        private System.Windows.Forms.Button btnNewOpponent;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tbPointsGoldTier;
        private System.Windows.Forms.TextBox tbPointsSilverTier;
        private System.Windows.Forms.TextBox tbPointsBronzeTier;
        private System.Windows.Forms.TextBox tbPositionGoldTier;
        private System.Windows.Forms.TextBox tbPositionSilverTier;
        private System.Windows.Forms.TextBox tbPositionBronzeTier;
        private System.Windows.Forms.Label lblBronzeTier;
        private System.Windows.Forms.Label lblSilverTier;
        private System.Windows.Forms.Label lblGoldTier;
        private System.Windows.Forms.Label lblStartPositionValue;
        private System.Windows.Forms.TrackBar tkbStartPosition;
        private System.Windows.Forms.Label lblStartingPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;

        public static BindingSource bs_opponents_datasource = new BindingSource();
        private ToolTip tltNewOpponent;
        private ToolTip tltEditOpponent;
        private ToolTip tltDeleteOpponent;
        private ToolTip tltLoadPreviewImage;
        private Button btnLoadOpponents;
        private OpenFileDialog openOpponentsFileDialog;
        private ToolTip tltLoadOpponents;
        private RadioButton rbHotlap;
        private TextBox tbTimeSecondsBronzeTier;
        private TextBox tbTimeMinutesBronzeTier;
        private TextBox tbTimeSecondsSilverTier;
        private TextBox tbTimeMinutesSilverTier;
        private TextBox tbTimeSecondsGoldTier;
        private TextBox tbTimeMinutesGoldTier;
        private Label lblTrack;
        private ComboBox cbTrack;
        private Label label15;
        private Label label14;
        private GroupBox grbTimeAttackGoals;
        private Label label17;
        private Label label16;
        private Label label1;
        private Label label2;
        private Label label4;
        private GroupBox grbHotlapGoals;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label7;
        private Label label10;
        private Label label19;
        private Label label18;
        private Button btnSaveOpponents;
        private SaveFileDialog saveOpponentsFileDialog;
        private ToolTip tltTimeTrackbar;

        public static Event temp_event { get; set; }
        public static Car event_car { get; set; }
        public static Opponent current_selected_opponent { get; set; }
        
        public Bitmap skinPreviewImage { get; set; }

    }
}