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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCGNewSingleEventForm));
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grbImages = new System.Windows.Forms.GroupBox();
            this.btnOpenPreviewImage = new System.Windows.Forms.Button();
            this.previewImagePanel = new System.Windows.Forms.Panel();
            this.grbTrack = new System.Windows.Forms.GroupBox();
            this.lblTrackConditionValue = new System.Windows.Forms.Label();
            this.lblTrackTemperatureValue = new System.Windows.Forms.Label();
            this.tkbCondition = new System.Windows.Forms.TrackBar();
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
            this.grbTimeAttack = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimeAttackTrack = new System.Windows.Forms.ComboBox();
            this.grbEventKind = new System.Windows.Forms.GroupBox();
            this.rbTimeAttack = new System.Windows.Forms.RadioButton();
            this.rbQuickRace = new System.Windows.Forms.RadioButton();
            this.grbEventGoals = new System.Windows.Forms.GroupBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbPointsGoldTier = new System.Windows.Forms.TextBox();
            this.tbPointsSilverTier = new System.Windows.Forms.TextBox();
            this.tbPointsBronzeTier = new System.Windows.Forms.TextBox();
            this.tbPositionGoldTier = new System.Windows.Forms.TextBox();
            this.tbPositionSilverTier = new System.Windows.Forms.TextBox();
            this.tbPositionBronzeTier = new System.Windows.Forms.TextBox();
            this.lblBronzeTier = new System.Windows.Forms.Label();
            this.lblSilverTier = new System.Windows.Forms.Label();
            this.lblGoldTier = new System.Windows.Forms.Label();
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
            this.lbOpponents = new System.Windows.Forms.ListBox();
            this.btnDeleteOpponent = new System.Windows.Forms.Button();
            this.btnEditOpponent = new System.Windows.Forms.Button();
            this.btnNewOpponent = new System.Windows.Forms.Button();
            this.lblTrack = new System.Windows.Forms.Label();
            this.cbQuickRaceTrack = new System.Windows.Forms.ComboBox();
            this.lblNumberOfLapsValue = new System.Windows.Forms.Label();
            this.lblNumberOfCarsValue = new System.Windows.Forms.Label();
            this.lblNumberOfCars = new System.Windows.Forms.Label();
            this.tkbNumberOfLaps = new System.Windows.Forms.TrackBar();
            this.tkbNumberOfCars = new System.Windows.Forms.TrackBar();
            this.lblNumberOfLaps = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grbButtons.SuspendLayout();
            this.grbImages.SuspendLayout();
            this.grbTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackTemperature)).BeginInit();
            this.grbAmbient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAmbientTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTime)).BeginInit();
            this.grbEvent.SuspendLayout();
            this.grbTimeAttack.SuspendLayout();
            this.grbEventKind.SuspendLayout();
            this.grbEventGoals.SuspendLayout();
            this.grbCar.SuspendLayout();
            this.grbQuickRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStartPosition)).BeginInit();
            this.grbOpponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfLaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfCars)).BeginInit();
            this.SuspendLayout();
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnCancel);
            this.grbButtons.Controls.Add(this.btnOK);
            this.grbButtons.Location = new System.Drawing.Point(503, 635);
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
            this.grbImages.Location = new System.Drawing.Point(5, 449);
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
            this.btnOpenPreviewImage.Size = new System.Drawing.Size(30, 23);
            this.btnOpenPreviewImage.TabIndex = 1;
            this.btnOpenPreviewImage.UseVisualStyleBackColor = true;
            this.btnOpenPreviewImage.Click += new System.EventHandler(this.btnOpenPreviewImage_Click);
            // 
            // previewImagePanel
            // 
            this.previewImagePanel.Location = new System.Drawing.Point(6, 19);
            this.previewImagePanel.Name = "previewImagePanel";
            this.previewImagePanel.Size = new System.Drawing.Size(250, 125);
            this.previewImagePanel.TabIndex = 0;
            this.previewImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.previewImagePanel_Paint);
            // 
            // grbTrack
            // 
            this.grbTrack.Controls.Add(this.lblTrackConditionValue);
            this.grbTrack.Controls.Add(this.lblTrackTemperatureValue);
            this.grbTrack.Controls.Add(this.tkbCondition);
            this.grbTrack.Controls.Add(this.tkbTrackTemperature);
            this.grbTrack.Controls.Add(this.lblTrackCondition);
            this.grbTrack.Controls.Add(this.lblTrackTemperature);
            this.grbTrack.Location = new System.Drawing.Point(5, 319);
            this.grbTrack.Name = "grbTrack";
            this.grbTrack.Size = new System.Drawing.Size(263, 124);
            this.grbTrack.TabIndex = 52;
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
            // tkbCondition
            // 
            this.tkbCondition.Location = new System.Drawing.Point(80, 72);
            this.tkbCondition.Maximum = 5;
            this.tkbCondition.Name = "tkbCondition";
            this.tkbCondition.Size = new System.Drawing.Size(122, 45);
            this.tkbCondition.TabIndex = 8;
            this.tkbCondition.Value = 4;
            this.tkbCondition.Scroll += new System.EventHandler(this.tkbCondition_Scroll);
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
            // grbTimeAttack
            // 
            this.grbTimeAttack.Controls.Add(this.label1);
            this.grbTimeAttack.Controls.Add(this.cbTimeAttackTrack);
            this.grbTimeAttack.Location = new System.Drawing.Point(274, 449);
            this.grbTimeAttack.Name = "grbTimeAttack";
            this.grbTimeAttack.Size = new System.Drawing.Size(206, 53);
            this.grbTimeAttack.TabIndex = 54;
            this.grbTimeAttack.TabStop = false;
            this.grbTimeAttack.Text = "Time Attack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Track";
            // 
            // cbTimeAttackTrack
            // 
            this.cbTimeAttackTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeAttackTrack.FormattingEnabled = true;
            this.cbTimeAttackTrack.Location = new System.Drawing.Point(49, 21);
            this.cbTimeAttackTrack.Name = "cbTimeAttackTrack";
            this.cbTimeAttackTrack.Size = new System.Drawing.Size(145, 21);
            this.cbTimeAttackTrack.TabIndex = 20;
            // 
            // grbEventKind
            // 
            this.grbEventKind.Controls.Add(this.rbTimeAttack);
            this.grbEventKind.Controls.Add(this.rbQuickRace);
            this.grbEventKind.Location = new System.Drawing.Point(274, 7);
            this.grbEventKind.Name = "grbEventKind";
            this.grbEventKind.Size = new System.Drawing.Size(206, 47);
            this.grbEventKind.TabIndex = 55;
            this.grbEventKind.TabStop = false;
            this.grbEventKind.Text = "Event Kind";
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
            // grbEventGoals
            // 
            this.grbEventGoals.Controls.Add(this.lblPoints);
            this.grbEventGoals.Controls.Add(this.lblPosition);
            this.grbEventGoals.Controls.Add(this.tbPointsGoldTier);
            this.grbEventGoals.Controls.Add(this.tbPointsSilverTier);
            this.grbEventGoals.Controls.Add(this.tbPointsBronzeTier);
            this.grbEventGoals.Controls.Add(this.tbPositionGoldTier);
            this.grbEventGoals.Controls.Add(this.tbPositionSilverTier);
            this.grbEventGoals.Controls.Add(this.tbPositionBronzeTier);
            this.grbEventGoals.Controls.Add(this.lblBronzeTier);
            this.grbEventGoals.Controls.Add(this.lblSilverTier);
            this.grbEventGoals.Controls.Add(this.lblGoldTier);
            this.grbEventGoals.Location = new System.Drawing.Point(486, 252);
            this.grbEventGoals.Name = "grbEventGoals";
            this.grbEventGoals.Size = new System.Drawing.Size(206, 191);
            this.grbEventGoals.TabIndex = 56;
            this.grbEventGoals.TabStop = false;
            this.grbEventGoals.Text = "Event Goals";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(112, 16);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 49;
            this.lblPoints.Text = "Points";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(58, 16);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 48;
            this.lblPosition.Text = "Position";
            // 
            // tbPointsGoldTier
            // 
            this.tbPointsGoldTier.Location = new System.Drawing.Point(115, 35);
            this.tbPointsGoldTier.MaxLength = 4;
            this.tbPointsGoldTier.Name = "tbPointsGoldTier";
            this.tbPointsGoldTier.Size = new System.Drawing.Size(33, 20);
            this.tbPointsGoldTier.TabIndex = 45;
            // 
            // tbPointsSilverTier
            // 
            this.tbPointsSilverTier.Location = new System.Drawing.Point(115, 61);
            this.tbPointsSilverTier.MaxLength = 4;
            this.tbPointsSilverTier.Name = "tbPointsSilverTier";
            this.tbPointsSilverTier.Size = new System.Drawing.Size(33, 20);
            this.tbPointsSilverTier.TabIndex = 46;
            // 
            // tbPointsBronzeTier
            // 
            this.tbPointsBronzeTier.Location = new System.Drawing.Point(115, 87);
            this.tbPointsBronzeTier.MaxLength = 4;
            this.tbPointsBronzeTier.Name = "tbPointsBronzeTier";
            this.tbPointsBronzeTier.Size = new System.Drawing.Size(33, 20);
            this.tbPointsBronzeTier.TabIndex = 47;
            // 
            // tbPositionGoldTier
            // 
            this.tbPositionGoldTier.Location = new System.Drawing.Point(61, 35);
            this.tbPositionGoldTier.MaxLength = 2;
            this.tbPositionGoldTier.Name = "tbPositionGoldTier";
            this.tbPositionGoldTier.Size = new System.Drawing.Size(25, 20);
            this.tbPositionGoldTier.TabIndex = 39;
            // 
            // tbPositionSilverTier
            // 
            this.tbPositionSilverTier.Location = new System.Drawing.Point(61, 61);
            this.tbPositionSilverTier.MaxLength = 2;
            this.tbPositionSilverTier.Name = "tbPositionSilverTier";
            this.tbPositionSilverTier.Size = new System.Drawing.Size(25, 20);
            this.tbPositionSilverTier.TabIndex = 40;
            // 
            // tbPositionBronzeTier
            // 
            this.tbPositionBronzeTier.Location = new System.Drawing.Point(61, 87);
            this.tbPositionBronzeTier.MaxLength = 2;
            this.tbPositionBronzeTier.Name = "tbPositionBronzeTier";
            this.tbPositionBronzeTier.Size = new System.Drawing.Size(25, 20);
            this.tbPositionBronzeTier.TabIndex = 41;
            // 
            // lblBronzeTier
            // 
            this.lblBronzeTier.AutoSize = true;
            this.lblBronzeTier.Location = new System.Drawing.Point(5, 90);
            this.lblBronzeTier.Name = "lblBronzeTier";
            this.lblBronzeTier.Size = new System.Drawing.Size(40, 13);
            this.lblBronzeTier.TabIndex = 44;
            this.lblBronzeTier.Text = "Bronze";
            // 
            // lblSilverTier
            // 
            this.lblSilverTier.AutoSize = true;
            this.lblSilverTier.Location = new System.Drawing.Point(5, 64);
            this.lblSilverTier.Name = "lblSilverTier";
            this.lblSilverTier.Size = new System.Drawing.Size(33, 13);
            this.lblSilverTier.TabIndex = 43;
            this.lblSilverTier.Text = "Silver";
            // 
            // lblGoldTier
            // 
            this.lblGoldTier.AutoSize = true;
            this.lblGoldTier.Location = new System.Drawing.Point(6, 38);
            this.lblGoldTier.Name = "lblGoldTier";
            this.lblGoldTier.Size = new System.Drawing.Size(29, 13);
            this.lblGoldTier.TabIndex = 42;
            this.lblGoldTier.Text = "Gold";
            // 
            // grbCar
            // 
            this.grbCar.Controls.Add(this.skinPreviewImagePanel);
            this.grbCar.Controls.Add(this.cbCar);
            this.grbCar.Controls.Add(this.lblModel);
            this.grbCar.Controls.Add(this.lblSkin);
            this.grbCar.Controls.Add(this.cbSkin);
            this.grbCar.Location = new System.Drawing.Point(486, 60);
            this.grbCar.Name = "grbCar";
            this.grbCar.Size = new System.Drawing.Size(206, 186);
            this.grbCar.TabIndex = 57;
            this.grbCar.TabStop = false;
            this.grbCar.Text = "Car";
            // 
            // skinPreviewImagePanel
            // 
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
            this.grbQuickRace.Controls.Add(this.lblTrack);
            this.grbQuickRace.Controls.Add(this.cbQuickRaceTrack);
            this.grbQuickRace.Controls.Add(this.lblNumberOfLapsValue);
            this.grbQuickRace.Controls.Add(this.lblNumberOfCarsValue);
            this.grbQuickRace.Controls.Add(this.lblNumberOfCars);
            this.grbQuickRace.Controls.Add(this.tkbNumberOfLaps);
            this.grbQuickRace.Controls.Add(this.tkbNumberOfCars);
            this.grbQuickRace.Controls.Add(this.lblNumberOfLaps);
            this.grbQuickRace.Location = new System.Drawing.Point(274, 60);
            this.grbQuickRace.Name = "grbQuickRace";
            this.grbQuickRace.Size = new System.Drawing.Size(206, 383);
            this.grbQuickRace.TabIndex = 58;
            this.grbQuickRace.TabStop = false;
            this.grbQuickRace.Text = "Quick Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "position";
            // 
            // lblStartPositionValue
            // 
            this.lblStartPositionValue.AutoSize = true;
            this.lblStartPositionValue.Location = new System.Drawing.Point(157, 161);
            this.lblStartPositionValue.Name = "lblStartPositionValue";
            this.lblStartPositionValue.Size = new System.Drawing.Size(16, 13);
            this.lblStartPositionValue.TabIndex = 50;
            this.lblStartPositionValue.Text = "2 ";
            // 
            // tkbStartPosition
            // 
            this.tkbStartPosition.Location = new System.Drawing.Point(51, 158);
            this.tkbStartPosition.Minimum = 2;
            this.tkbStartPosition.Name = "tkbStartPosition";
            this.tkbStartPosition.Size = new System.Drawing.Size(104, 45);
            this.tkbStartPosition.TabIndex = 49;
            this.tkbStartPosition.Value = 2;
            this.tkbStartPosition.Scroll += new System.EventHandler(this.tkbStartPosition_Scroll);
            // 
            // lblStartingPosition
            // 
            this.lblStartingPosition.AutoSize = true;
            this.lblStartingPosition.Location = new System.Drawing.Point(6, 159);
            this.lblStartingPosition.Name = "lblStartingPosition";
            this.lblStartingPosition.Size = new System.Drawing.Size(43, 13);
            this.lblStartingPosition.TabIndex = 48;
            this.lblStartingPosition.Text = "Starting";
            // 
            // grbOpponents
            // 
            this.grbOpponents.Controls.Add(this.lbOpponents);
            this.grbOpponents.Controls.Add(this.btnDeleteOpponent);
            this.grbOpponents.Controls.Add(this.btnEditOpponent);
            this.grbOpponents.Controls.Add(this.btnNewOpponent);
            this.grbOpponents.Location = new System.Drawing.Point(32, 209);
            this.grbOpponents.Name = "grbOpponents";
            this.grbOpponents.Size = new System.Drawing.Size(135, 148);
            this.grbOpponents.TabIndex = 47;
            this.grbOpponents.TabStop = false;
            this.grbOpponents.Text = "Opponents";
            // 
            // lbOpponents
            // 
            this.lbOpponents.FormattingEnabled = true;
            this.lbOpponents.Location = new System.Drawing.Point(6, 19);
            this.lbOpponents.Name = "lbOpponents";
            this.lbOpponents.Size = new System.Drawing.Size(123, 95);
            this.lbOpponents.TabIndex = 25;
            this.lbOpponents.SelectedIndexChanged += new System.EventHandler(this.lbOpponents_SelectedIndexChanged);
            // 
            // btnDeleteOpponent
            // 
            this.btnDeleteOpponent.Image = global::ACCG.Properties.Resources.Clearallrequests_8816;
            this.btnDeleteOpponent.Location = new System.Drawing.Point(92, 120);
            this.btnDeleteOpponent.Name = "btnDeleteOpponent";
            this.btnDeleteOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnDeleteOpponent.TabIndex = 29;
            this.btnDeleteOpponent.UseVisualStyleBackColor = true;
            this.btnDeleteOpponent.Click += new System.EventHandler(this.btnDeleteOpponent_Click);
            // 
            // btnEditOpponent
            // 
            this.btnEditOpponent.Image = global::ACCG.Properties.Resources.EditTitleString_357;
            this.btnEditOpponent.Location = new System.Drawing.Point(49, 120);
            this.btnEditOpponent.Name = "btnEditOpponent";
            this.btnEditOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnEditOpponent.TabIndex = 28;
            this.btnEditOpponent.UseVisualStyleBackColor = true;
            this.btnEditOpponent.Click += new System.EventHandler(this.btnEditOpponent_Click);
            // 
            // btnNewOpponent
            // 
            this.btnNewOpponent.Image = global::ACCG.Properties.Resources.NewFile_6276;
            this.btnNewOpponent.Location = new System.Drawing.Point(6, 120);
            this.btnNewOpponent.Name = "btnNewOpponent";
            this.btnNewOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnNewOpponent.TabIndex = 27;
            this.btnNewOpponent.UseVisualStyleBackColor = true;
            this.btnNewOpponent.Click += new System.EventHandler(this.btnNewOpponent_Click);
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(6, 24);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(35, 13);
            this.lblTrack.TabIndex = 17;
            this.lblTrack.Text = "Track";
            // 
            // cbQuickRaceTrack
            // 
            this.cbQuickRaceTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuickRaceTrack.FormattingEnabled = true;
            this.cbQuickRaceTrack.Location = new System.Drawing.Point(47, 21);
            this.cbQuickRaceTrack.Name = "cbQuickRaceTrack";
            this.cbQuickRaceTrack.Size = new System.Drawing.Size(145, 21);
            this.cbQuickRaceTrack.TabIndex = 18;
            // 
            // lblNumberOfLapsValue
            // 
            this.lblNumberOfLapsValue.AutoSize = true;
            this.lblNumberOfLapsValue.Location = new System.Drawing.Point(157, 110);
            this.lblNumberOfLapsValue.Name = "lblNumberOfLapsValue";
            this.lblNumberOfLapsValue.Size = new System.Drawing.Size(35, 13);
            this.lblNumberOfLapsValue.TabIndex = 36;
            this.lblNumberOfLapsValue.Text = "2 laps";
            // 
            // lblNumberOfCarsValue
            // 
            this.lblNumberOfCarsValue.AutoSize = true;
            this.lblNumberOfCarsValue.Location = new System.Drawing.Point(157, 59);
            this.lblNumberOfCarsValue.Name = "lblNumberOfCarsValue";
            this.lblNumberOfCarsValue.Size = new System.Drawing.Size(36, 13);
            this.lblNumberOfCarsValue.TabIndex = 35;
            this.lblNumberOfCarsValue.Text = "1 cars";
            // 
            // lblNumberOfCars
            // 
            this.lblNumberOfCars.AutoSize = true;
            this.lblNumberOfCars.Location = new System.Drawing.Point(6, 59);
            this.lblNumberOfCars.Name = "lblNumberOfCars";
            this.lblNumberOfCars.Size = new System.Drawing.Size(28, 13);
            this.lblNumberOfCars.TabIndex = 21;
            this.lblNumberOfCars.Text = "Cars";
            // 
            // tkbNumberOfLaps
            // 
            this.tkbNumberOfLaps.Location = new System.Drawing.Point(51, 107);
            this.tkbNumberOfLaps.Minimum = 2;
            this.tkbNumberOfLaps.Name = "tkbNumberOfLaps";
            this.tkbNumberOfLaps.Size = new System.Drawing.Size(104, 45);
            this.tkbNumberOfLaps.TabIndex = 26;
            this.tkbNumberOfLaps.Value = 2;
            this.tkbNumberOfLaps.Scroll += new System.EventHandler(this.tkbNumberOfLaps_Scroll);
            // 
            // tkbNumberOfCars
            // 
            this.tkbNumberOfCars.Location = new System.Drawing.Point(47, 56);
            this.tkbNumberOfCars.Maximum = 24;
            this.tkbNumberOfCars.Minimum = 1;
            this.tkbNumberOfCars.Name = "tkbNumberOfCars";
            this.tkbNumberOfCars.Size = new System.Drawing.Size(104, 45);
            this.tkbNumberOfCars.TabIndex = 22;
            this.tkbNumberOfCars.Value = 1;
            this.tkbNumberOfCars.Scroll += new System.EventHandler(this.tkbNumberOfCars_Scroll);
            // 
            // lblNumberOfLaps
            // 
            this.lblNumberOfLaps.AutoSize = true;
            this.lblNumberOfLaps.Location = new System.Drawing.Point(6, 110);
            this.lblNumberOfLaps.Name = "lblNumberOfLaps";
            this.lblNumberOfLaps.Size = new System.Drawing.Size(30, 13);
            this.lblNumberOfLaps.TabIndex = 25;
            this.lblNumberOfLaps.Text = "Laps";
            // 
            // btnRandom
            // 
            this.btnRandom.Enabled = false;
            this.btnRandom.Location = new System.Drawing.Point(496, 13);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(196, 41);
            this.btnRandom.TabIndex = 59;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // ACCGNewSingleEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 697);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.grbQuickRace);
            this.Controls.Add(this.grbCar);
            this.Controls.Add(this.grbEventGoals);
            this.Controls.Add(this.grbEventKind);
            this.Controls.Add(this.grbTimeAttack);
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
            ((System.ComponentModel.ISupportInitialize)(this.tkbCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTrackTemperature)).EndInit();
            this.grbAmbient.ResumeLayout(false);
            this.grbAmbient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAmbientTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTime)).EndInit();
            this.grbEvent.ResumeLayout(false);
            this.grbEvent.PerformLayout();
            this.grbTimeAttack.ResumeLayout(false);
            this.grbTimeAttack.PerformLayout();
            this.grbEventKind.ResumeLayout(false);
            this.grbEventKind.PerformLayout();
            this.grbEventGoals.ResumeLayout(false);
            this.grbEventGoals.PerformLayout();
            this.grbCar.ResumeLayout(false);
            this.grbCar.PerformLayout();
            this.grbQuickRace.ResumeLayout(false);
            this.grbQuickRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStartPosition)).EndInit();
            this.grbOpponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfLaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNumberOfCars)).EndInit();
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
        private System.Windows.Forms.TrackBar tkbCondition;
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
        private System.Windows.Forms.GroupBox grbTimeAttack;
        private System.Windows.Forms.GroupBox grbEventKind;
        private System.Windows.Forms.GroupBox grbEventGoals;
        private System.Windows.Forms.RadioButton rbQuickRace;
        private System.Windows.Forms.RadioButton rbTimeAttack;
        private System.Windows.Forms.GroupBox grbCar;
        private System.Windows.Forms.Panel skinPreviewImagePanel;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSkin;
        private System.Windows.Forms.ComboBox cbSkin;
        private System.Windows.Forms.GroupBox grbQuickRace;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.ComboBox cbQuickRaceTrack;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTimeAttackTrack;
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

        public static Event temp_event { get; set; }
        public static Car event_car { get; set; }
        public static Opponent current_selected_opponent { get; set; }
        
        public Bitmap skinPreviewImage { get; set; }

    }
}