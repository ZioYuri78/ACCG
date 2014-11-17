using System.Windows.Forms;
namespace ACCG
{
    partial class ACCGNewSeriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCGNewSeriesForm));
            this.rbSingleEvents = new System.Windows.Forms.RadioButton();
            this.rbChampionship = new System.Windows.Forms.RadioButton();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRequires = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbRequires = new System.Windows.Forms.ComboBox();
            this.tbPoints = new System.Windows.Forms.TextBox();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtbEventsInfo = new System.Windows.Forms.RichTextBox();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.rtbOpponentsInfo = new System.Windows.Forms.RichTextBox();
            this.btnDeleteOpponent = new System.Windows.Forms.Button();
            this.btnEditOpponent = new System.Windows.Forms.Button();
            this.btnNewOpponent = new System.Windows.Forms.Button();
            this.lbOpponents = new System.Windows.Forms.ListBox();
            this.tbGoalsPoints = new System.Windows.Forms.TextBox();
            this.lblGoalsPoints = new System.Windows.Forms.Label();
            this.cbSkin = new System.Windows.Forms.ComboBox();
            this.lblSkin = new System.Windows.Forms.Label();
            this.lblDontuseseries0 = new System.Windows.Forms.Label();
            this.grbGoals = new System.Windows.Forms.GroupBox();
            this.tbGoldTier = new System.Windows.Forms.TextBox();
            this.tbSilverTier = new System.Windows.Forms.TextBox();
            this.tbBronzeTier = new System.Windows.Forms.TextBox();
            this.lblBronzeTier = new System.Windows.Forms.Label();
            this.lblSilverTier = new System.Windows.Forms.Label();
            this.lblGoldTier = new System.Windows.Forms.Label();
            this.lblPointsExample = new System.Windows.Forms.Label();
            this.grbSeries = new System.Windows.Forms.GroupBox();
            this.grbCar = new System.Windows.Forms.GroupBox();
            this.grbEvents = new System.Windows.Forms.GroupBox();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.grbOpponents = new System.Windows.Forms.GroupBox();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.grbCheckButtons = new System.Windows.Forms.GroupBox();
            this.tltNewEventButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltEditEventButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltDeleteEventButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltNewOpponentButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltEditOpponentButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltDeleteOpponentButton = new System.Windows.Forms.ToolTip(this.components);
            this.grbGoals.SuspendLayout();
            this.grbSeries.SuspendLayout();
            this.grbCar.SuspendLayout();
            this.grbEvents.SuspendLayout();
            this.grbOpponents.SuspendLayout();
            this.grbButtons.SuspendLayout();
            this.grbCheckButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSingleEvents
            // 
            this.rbSingleEvents.AutoSize = true;
            this.rbSingleEvents.Enabled = false;
            this.rbSingleEvents.Location = new System.Drawing.Point(6, 19);
            this.rbSingleEvents.Name = "rbSingleEvents";
            this.rbSingleEvents.Size = new System.Drawing.Size(89, 17);
            this.rbSingleEvents.TabIndex = 0;
            this.rbSingleEvents.Text = "Single events";
            this.rbSingleEvents.UseVisualStyleBackColor = true;
            this.rbSingleEvents.CheckedChanged += new System.EventHandler(this.rbSingleEvents_CheckedChanged);
            // 
            // rbChampionship
            // 
            this.rbChampionship.AutoSize = true;
            this.rbChampionship.Checked = true;
            this.rbChampionship.Location = new System.Drawing.Point(101, 19);
            this.rbChampionship.Name = "rbChampionship";
            this.rbChampionship.Size = new System.Drawing.Size(91, 17);
            this.rbChampionship.TabIndex = 1;
            this.rbChampionship.TabStop = true;
            this.rbChampionship.Text = "Championship";
            this.rbChampionship.UseVisualStyleBackColor = true;
            this.rbChampionship.CheckedChanged += new System.EventHandler(this.rbChampionship_CheckedChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 22);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblRequires
            // 
            this.lblRequires.AutoSize = true;
            this.lblRequires.Location = new System.Drawing.Point(6, 186);
            this.lblRequires.Name = "lblRequires";
            this.lblRequires.Size = new System.Drawing.Size(49, 13);
            this.lblRequires.TabIndex = 5;
            this.lblRequires.Text = "Requires";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(6, 226);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 6;
            this.lblPoints.Text = "Points";
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
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(66, 19);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(130, 20);
            this.tbCode.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(66, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(130, 20);
            this.tbName.TabIndex = 10;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(66, 72);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(130, 105);
            this.tbDescription.TabIndex = 11;
            // 
            // cbRequires
            // 
            this.cbRequires.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRequires.FormattingEnabled = true;
            this.cbRequires.Location = new System.Drawing.Point(66, 183);
            this.cbRequires.Name = "cbRequires";
            this.cbRequires.Size = new System.Drawing.Size(130, 21);
            this.cbRequires.Sorted = true;
            this.cbRequires.TabIndex = 12;
            // 
            // tbPoints
            // 
            this.tbPoints.Enabled = false;
            this.tbPoints.Location = new System.Drawing.Point(66, 223);
            this.tbPoints.Name = "tbPoints";
            this.tbPoints.Size = new System.Drawing.Size(130, 20);
            this.tbPoints.TabIndex = 13;
            // 
            // cbCar
            // 
            this.cbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCar.Enabled = false;
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(50, 22);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(146, 21);
            this.cbCar.TabIndex = 14;
            this.cbCar.SelectionChangeCommitted += new System.EventHandler(this.cbCar_SelectionChangeCommitted);
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
            // rtbEventsInfo
            // 
            this.rtbEventsInfo.Location = new System.Drawing.Point(135, 19);
            this.rtbEventsInfo.Name = "rtbEventsInfo";
            this.rtbEventsInfo.ReadOnly = true;
            this.rtbEventsInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbEventsInfo.Size = new System.Drawing.Size(209, 150);
            this.rtbEventsInfo.TabIndex = 21;
            this.rtbEventsInfo.Text = "";
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.Location = new System.Drawing.Point(6, 19);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(123, 121);
            this.lbEvents.TabIndex = 20;
            this.lbEvents.SelectedIndexChanged += new System.EventHandler(this.lbEvents_SelectedIndexChanged);
            // 
            // rtbOpponentsInfo
            // 
            this.rtbOpponentsInfo.Location = new System.Drawing.Point(135, 19);
            this.rtbOpponentsInfo.Name = "rtbOpponentsInfo";
            this.rtbOpponentsInfo.ReadOnly = true;
            this.rtbOpponentsInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbOpponentsInfo.Size = new System.Drawing.Size(209, 150);
            this.rtbOpponentsInfo.TabIndex = 26;
            this.rtbOpponentsInfo.Text = "";
            // 
            // btnDeleteOpponent
            // 
            this.btnDeleteOpponent.Image = global::ACCG.Properties.Resources.Clearallrequests_8816;
            this.btnDeleteOpponent.Location = new System.Drawing.Point(92, 146);
            this.btnDeleteOpponent.Name = "btnDeleteOpponent";
            this.btnDeleteOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnDeleteOpponent.TabIndex = 29;
            this.tltDeleteOpponentButton.SetToolTip(this.btnDeleteOpponent, "Delete Opponent");
            this.btnDeleteOpponent.UseVisualStyleBackColor = true;
            this.btnDeleteOpponent.Click += new System.EventHandler(this.btnDeleteOpponent_Click);
            // 
            // btnEditOpponent
            // 
            this.btnEditOpponent.Image = global::ACCG.Properties.Resources.EditTitleString_357;
            this.btnEditOpponent.Location = new System.Drawing.Point(49, 146);
            this.btnEditOpponent.Name = "btnEditOpponent";
            this.btnEditOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnEditOpponent.TabIndex = 28;
            this.tltEditOpponentButton.SetToolTip(this.btnEditOpponent, "Edit Opponent");
            this.btnEditOpponent.UseVisualStyleBackColor = true;
            this.btnEditOpponent.Click += new System.EventHandler(this.btnEditOpponent_Click);
            // 
            // btnNewOpponent
            // 
            this.btnNewOpponent.Image = global::ACCG.Properties.Resources.NewFile_6276;
            this.btnNewOpponent.Location = new System.Drawing.Point(6, 146);
            this.btnNewOpponent.Name = "btnNewOpponent";
            this.btnNewOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnNewOpponent.TabIndex = 27;
            this.tltNewOpponentButton.SetToolTip(this.btnNewOpponent, "New Opponent");
            this.btnNewOpponent.UseVisualStyleBackColor = true;
            this.btnNewOpponent.Click += new System.EventHandler(this.btnNewOpponent_Click);
            // 
            // lbOpponents
            // 
            this.lbOpponents.FormattingEnabled = true;
            this.lbOpponents.Location = new System.Drawing.Point(6, 19);
            this.lbOpponents.Name = "lbOpponents";
            this.lbOpponents.Size = new System.Drawing.Size(123, 121);
            this.lbOpponents.TabIndex = 25;
            this.lbOpponents.SelectedIndexChanged += new System.EventHandler(this.lbOpponents_SelectedIndexChanged);
            // 
            // tbGoalsPoints
            // 
            this.tbGoalsPoints.Location = new System.Drawing.Point(62, 19);
            this.tbGoalsPoints.MaxLength = 3;
            this.tbGoalsPoints.Name = "tbGoalsPoints";
            this.tbGoalsPoints.Size = new System.Drawing.Size(25, 20);
            this.tbGoalsPoints.TabIndex = 16;
            // 
            // lblGoalsPoints
            // 
            this.lblGoalsPoints.AutoSize = true;
            this.lblGoalsPoints.Location = new System.Drawing.Point(6, 22);
            this.lblGoalsPoints.Name = "lblGoalsPoints";
            this.lblGoalsPoints.Size = new System.Drawing.Size(36, 13);
            this.lblGoalsPoints.TabIndex = 35;
            this.lblGoalsPoints.Text = "Points";
            // 
            // cbSkin
            // 
            this.cbSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkin.FormattingEnabled = true;
            this.cbSkin.Location = new System.Drawing.Point(51, 57);
            this.cbSkin.Name = "cbSkin";
            this.cbSkin.Size = new System.Drawing.Size(145, 21);
            this.cbSkin.TabIndex = 15;
            // 
            // lblSkin
            // 
            this.lblSkin.AutoSize = true;
            this.lblSkin.Location = new System.Drawing.Point(7, 62);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(28, 13);
            this.lblSkin.TabIndex = 37;
            this.lblSkin.Text = "Skin";
            // 
            // lblDontuseseries0
            // 
            this.lblDontuseseries0.AutoSize = true;
            this.lblDontuseseries0.Location = new System.Drawing.Point(63, 207);
            this.lblDontuseseries0.Name = "lblDontuseseries0";
            this.lblDontuseseries0.Size = new System.Drawing.Size(91, 13);
            this.lblDontuseseries0.TabIndex = 39;
            this.lblDontuseseries0.Text = "Don\'t use series0!";
            // 
            // grbGoals
            // 
            this.grbGoals.Controls.Add(this.tbGoldTier);
            this.grbGoals.Controls.Add(this.tbSilverTier);
            this.grbGoals.Controls.Add(this.tbBronzeTier);
            this.grbGoals.Controls.Add(this.lblBronzeTier);
            this.grbGoals.Controls.Add(this.lblSilverTier);
            this.grbGoals.Controls.Add(this.lblGoldTier);
            this.grbGoals.Controls.Add(this.tbGoalsPoints);
            this.grbGoals.Controls.Add(this.lblGoalsPoints);
            this.grbGoals.Location = new System.Drawing.Point(12, 427);
            this.grbGoals.Name = "grbGoals";
            this.grbGoals.Size = new System.Drawing.Size(94, 129);
            this.grbGoals.TabIndex = 44;
            this.grbGoals.TabStop = false;
            this.grbGoals.Text = "Series Goals";
            // 
            // tbGoldTier
            // 
            this.tbGoldTier.Location = new System.Drawing.Point(62, 45);
            this.tbGoldTier.MaxLength = 1;
            this.tbGoldTier.Name = "tbGoldTier";
            this.tbGoldTier.Size = new System.Drawing.Size(25, 20);
            this.tbGoldTier.TabIndex = 17;
            // 
            // tbSilverTier
            // 
            this.tbSilverTier.Location = new System.Drawing.Point(62, 71);
            this.tbSilverTier.MaxLength = 1;
            this.tbSilverTier.Name = "tbSilverTier";
            this.tbSilverTier.Size = new System.Drawing.Size(25, 20);
            this.tbSilverTier.TabIndex = 18;
            // 
            // tbBronzeTier
            // 
            this.tbBronzeTier.Location = new System.Drawing.Point(62, 97);
            this.tbBronzeTier.MaxLength = 1;
            this.tbBronzeTier.Name = "tbBronzeTier";
            this.tbBronzeTier.Size = new System.Drawing.Size(25, 20);
            this.tbBronzeTier.TabIndex = 19;
            // 
            // lblBronzeTier
            // 
            this.lblBronzeTier.AutoSize = true;
            this.lblBronzeTier.Location = new System.Drawing.Point(6, 100);
            this.lblBronzeTier.Name = "lblBronzeTier";
            this.lblBronzeTier.Size = new System.Drawing.Size(50, 13);
            this.lblBronzeTier.TabIndex = 38;
            this.lblBronzeTier.Text = "Bronze X";
            // 
            // lblSilverTier
            // 
            this.lblSilverTier.AutoSize = true;
            this.lblSilverTier.Location = new System.Drawing.Point(6, 74);
            this.lblSilverTier.Name = "lblSilverTier";
            this.lblSilverTier.Size = new System.Drawing.Size(49, 13);
            this.lblSilverTier.TabIndex = 37;
            this.lblSilverTier.Text = "Silver   X";
            // 
            // lblGoldTier
            // 
            this.lblGoldTier.AutoSize = true;
            this.lblGoldTier.Location = new System.Drawing.Point(7, 48);
            this.lblGoldTier.Name = "lblGoldTier";
            this.lblGoldTier.Size = new System.Drawing.Size(48, 13);
            this.lblGoldTier.TabIndex = 36;
            this.lblGoldTier.Text = "Gold    X";
            // 
            // lblPointsExample
            // 
            this.lblPointsExample.AutoSize = true;
            this.lblPointsExample.Location = new System.Drawing.Point(63, 246);
            this.lblPointsExample.Name = "lblPointsExample";
            this.lblPointsExample.Size = new System.Drawing.Size(49, 13);
            this.lblPointsExample.TabIndex = 40;
            this.lblPointsExample.Text = "n,n,n,..,n";
            // 
            // grbSeries
            // 
            this.grbSeries.Controls.Add(this.lblCode);
            this.grbSeries.Controls.Add(this.lblPointsExample);
            this.grbSeries.Controls.Add(this.lblName);
            this.grbSeries.Controls.Add(this.lblDescription);
            this.grbSeries.Controls.Add(this.lblDontuseseries0);
            this.grbSeries.Controls.Add(this.lblRequires);
            this.grbSeries.Controls.Add(this.lblPoints);
            this.grbSeries.Controls.Add(this.tbCode);
            this.grbSeries.Controls.Add(this.tbName);
            this.grbSeries.Controls.Add(this.tbDescription);
            this.grbSeries.Controls.Add(this.cbRequires);
            this.grbSeries.Controls.Add(this.tbPoints);
            this.grbSeries.Location = new System.Drawing.Point(12, 59);
            this.grbSeries.Name = "grbSeries";
            this.grbSeries.Size = new System.Drawing.Size(206, 265);
            this.grbSeries.TabIndex = 42;
            this.grbSeries.TabStop = false;
            this.grbSeries.Text = "Series";
            // 
            // grbCar
            // 
            this.grbCar.Controls.Add(this.cbCar);
            this.grbCar.Controls.Add(this.lblModel);
            this.grbCar.Controls.Add(this.lblSkin);
            this.grbCar.Controls.Add(this.cbSkin);
            this.grbCar.Location = new System.Drawing.Point(12, 330);
            this.grbCar.Name = "grbCar";
            this.grbCar.Size = new System.Drawing.Size(206, 91);
            this.grbCar.TabIndex = 43;
            this.grbCar.TabStop = false;
            this.grbCar.Text = "Car";
            // 
            // grbEvents
            // 
            this.grbEvents.Controls.Add(this.lbEvents);
            this.grbEvents.Controls.Add(this.btnNewEvent);
            this.grbEvents.Controls.Add(this.btnEditEvent);
            this.grbEvents.Controls.Add(this.btnDeleteEvent);
            this.grbEvents.Controls.Add(this.rtbEventsInfo);
            this.grbEvents.Location = new System.Drawing.Point(224, 59);
            this.grbEvents.Name = "grbEvents";
            this.grbEvents.Size = new System.Drawing.Size(352, 177);
            this.grbEvents.TabIndex = 45;
            this.grbEvents.TabStop = false;
            this.grbEvents.Text = "Events";
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Image = global::ACCG.Properties.Resources.NewFile_6276;
            this.btnNewEvent.Location = new System.Drawing.Point(6, 146);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(37, 23);
            this.btnNewEvent.TabIndex = 22;
            this.tltNewEventButton.SetToolTip(this.btnNewEvent, "New Event");
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Image = global::ACCG.Properties.Resources.EditTitleString_357;
            this.btnEditEvent.Location = new System.Drawing.Point(49, 146);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(37, 23);
            this.btnEditEvent.TabIndex = 23;
            this.tltEditEventButton.SetToolTip(this.btnEditEvent, "Edit Event");
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Image = global::ACCG.Properties.Resources.Clearallrequests_8816;
            this.btnDeleteEvent.Location = new System.Drawing.Point(92, 146);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(37, 23);
            this.btnDeleteEvent.TabIndex = 24;
            this.tltDeleteEventButton.SetToolTip(this.btnDeleteEvent, "Delete Event");
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // grbOpponents
            // 
            this.grbOpponents.Controls.Add(this.lbOpponents);
            this.grbOpponents.Controls.Add(this.btnDeleteOpponent);
            this.grbOpponents.Controls.Add(this.rtbOpponentsInfo);
            this.grbOpponents.Controls.Add(this.btnEditOpponent);
            this.grbOpponents.Controls.Add(this.btnNewOpponent);
            this.grbOpponents.Location = new System.Drawing.Point(224, 242);
            this.grbOpponents.Name = "grbOpponents";
            this.grbOpponents.Size = new System.Drawing.Size(352, 177);
            this.grbOpponents.TabIndex = 46;
            this.grbOpponents.TabStop = false;
            this.grbOpponents.Text = "Opponents";
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnCancel);
            this.grbButtons.Controls.Add(this.btnOK);
            this.grbButtons.Location = new System.Drawing.Point(395, 505);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(183, 54);
            this.grbButtons.TabIndex = 47;
            this.grbButtons.TabStop = false;
            // 
            // grbCheckButtons
            // 
            this.grbCheckButtons.Controls.Add(this.rbChampionship);
            this.grbCheckButtons.Controls.Add(this.rbSingleEvents);
            this.grbCheckButtons.Location = new System.Drawing.Point(12, 5);
            this.grbCheckButtons.Name = "grbCheckButtons";
            this.grbCheckButtons.Size = new System.Drawing.Size(196, 48);
            this.grbCheckButtons.TabIndex = 41;
            this.grbCheckButtons.TabStop = false;
            // 
            // ACCGNewSeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 566);
            this.Controls.Add(this.grbCheckButtons);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.grbEvents);
            this.Controls.Add(this.grbOpponents);
            this.Controls.Add(this.grbCar);
            this.Controls.Add(this.grbSeries);
            this.Controls.Add(this.grbGoals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ACCGNewSeriesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Series";
            this.Load += new System.EventHandler(this.NewSeriesForm_Load);
            this.grbGoals.ResumeLayout(false);
            this.grbGoals.PerformLayout();
            this.grbSeries.ResumeLayout(false);
            this.grbSeries.PerformLayout();
            this.grbCar.ResumeLayout(false);
            this.grbCar.PerformLayout();
            this.grbEvents.ResumeLayout(false);
            this.grbOpponents.ResumeLayout(false);
            this.grbButtons.ResumeLayout(false);
            this.grbCheckButtons.ResumeLayout(false);
            this.grbCheckButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        private void ShowData()
        {
            // Events listbox data source
            bs_events_datasource.DataSource = temp_series.events_list;

            lbEvents.DisplayMember = "Name";
            lbEvents.ValueMember = "ID";

            lbEvents.DataSource = bs_events_datasource;

            // Opponents listbox data source
            bs_opponents_datasource.DataSource = temp_series.opponents_list;

            lbOpponents.DisplayMember = "Name";
            lbOpponents.ValueMember = "ID";

            lbOpponents.DataSource = bs_opponents_datasource;
        }
        #endregion

        private RadioButton rbSingleEvents;
        private RadioButton rbChampionship;
        private Label lblCode;
        private Label lblName;
        private Label lblDescription;
        private Label lblRequires;
        private Label lblPoints;
        private Label lblModel;
        private TextBox tbCode;
        private TextBox tbName;
        private TextBox tbDescription;
        private ComboBox cbRequires;
        private TextBox tbPoints;
        private ComboBox cbCar;
        private Button btnOK;
        private Button btnCancel;
        private RichTextBox rtbEventsInfo;
        private Button btnDeleteEvent;
        private Button btnEditEvent;
        private Button btnNewEvent;
        private ListBox lbEvents;

        private string[] ac_series_path;
        private RichTextBox rtbOpponentsInfo;
        private Button btnDeleteOpponent;
        private Button btnEditOpponent;
        private Button btnNewOpponent;
        private ListBox lbOpponents;
        private TextBox tbGoalsPoints;
        private Label lblGoalsPoints;
        private ComboBox cbSkin;
        private Label lblSkin;

        public static BindingSource bs_events_datasource = new BindingSource();
        public static BindingSource bs_opponents_datasource = new BindingSource();
        private Label lblDontuseseries0;
        private GroupBox grbGoals;
        private Label lblBronzeTier;
        private Label lblSilverTier;
        private Label lblGoldTier;
        private TextBox tbGoldTier;
        private TextBox tbSilverTier;
        private TextBox tbBronzeTier;
        private Label lblPointsExample;
        private GroupBox grbSeries;
        private GroupBox grbCar;
        private GroupBox grbEvents;
        private GroupBox grbOpponents;
        private GroupBox grbButtons;
        private GroupBox grbCheckButtons;
        private ToolTip tltNewEventButton;
        private ToolTip tltEditEventButton;
        private ToolTip tltDeleteOpponentButton;
        private ToolTip tltEditOpponentButton;
        private ToolTip tltNewOpponentButton;
        private ToolTip tltDeleteEventButton;

        public static Car champ_player_car {get; set;}
        public static Series temp_series { get; set; }
        //public static int events_global_ID { get; set; }
        //public static int opponents_global_ID { get; set; }
        public static Event current_selected_event { get; set; }
        public static Opponent current_selected_opponent { get; set; }
        
    }
}