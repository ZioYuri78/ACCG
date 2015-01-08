using System;
using System.Drawing;
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
            this.lbOpponents = new System.Windows.Forms.ListBox();
            this.tbGoalsPoints = new System.Windows.Forms.TextBox();
            this.lblGoalsPoints = new System.Windows.Forms.Label();
            this.cbSkin = new System.Windows.Forms.ComboBox();
            this.lblSkin = new System.Windows.Forms.Label();
            this.grbGoals = new System.Windows.Forms.GroupBox();
            this.rbRanking = new System.Windows.Forms.RadioButton();
            this.rbGoalsPoints = new System.Windows.Forms.RadioButton();
            this.tbRanking = new System.Windows.Forms.TextBox();
            this.lblRanking = new System.Windows.Forms.Label();
            this.tbGoldTier = new System.Windows.Forms.TextBox();
            this.tbSilverTier = new System.Windows.Forms.TextBox();
            this.tbBronzeTier = new System.Windows.Forms.TextBox();
            this.lblBronzeTier = new System.Windows.Forms.Label();
            this.lblSilverTier = new System.Windows.Forms.Label();
            this.lblGoldTier = new System.Windows.Forms.Label();
            this.lblPointsExample = new System.Windows.Forms.Label();
            this.grbSeries = new System.Windows.Forms.GroupBox();
            this.grbCar = new System.Windows.Forms.GroupBox();
            this.skinPreviewImagePanel = new System.Windows.Forms.Panel();
            this.grbEvents = new System.Windows.Forms.GroupBox();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.btnLoadEvent = new System.Windows.Forms.Button();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.grbOpponents = new System.Windows.Forms.GroupBox();
            this.btnSaveOpponents = new System.Windows.Forms.Button();
            this.btnLoadOpponents = new System.Windows.Forms.Button();
            this.btnDeleteOpponent = new System.Windows.Forms.Button();
            this.btnEditOpponent = new System.Windows.Forms.Button();
            this.btnNewOpponent = new System.Windows.Forms.Button();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.grbCheckButtons = new System.Windows.Forms.GroupBox();
            this.tltNewEventButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltEditEventButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltDeleteEventButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltNewOpponentButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltEditOpponentButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltDeleteOpponentButton = new System.Windows.Forms.ToolTip(this.components);
            this.grbImages = new System.Windows.Forms.GroupBox();
            this.btnOpenPreviewImage = new System.Windows.Forms.Button();
            this.btnOpenStartImage = new System.Windows.Forms.Button();
            this.lblPreviewImage = new System.Windows.Forms.Label();
            this.lblStartImage = new System.Windows.Forms.Label();
            this.previewImagePanel = new System.Windows.Forms.Panel();
            this.startImagePanel = new System.Windows.Forms.Panel();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tltLoadStartImage = new System.Windows.Forms.ToolTip(this.components);
            this.tltLoadPreviewImage = new System.Windows.Forms.ToolTip(this.components);
            this.openOpponentsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tltLoadOpponents = new System.Windows.Forms.ToolTip(this.components);
            this.tltSaveOpponents = new System.Windows.Forms.ToolTip(this.components);
            this.saveOpponentsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openEventFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tltLoadEvents = new System.Windows.Forms.ToolTip(this.components);
            this.tltSaveEvent = new System.Windows.Forms.ToolTip(this.components);
            this.saveEventFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grbGoals.SuspendLayout();
            this.grbSeries.SuspendLayout();
            this.grbCar.SuspendLayout();
            this.grbEvents.SuspendLayout();
            this.grbOpponents.SuspendLayout();
            this.grbButtons.SuspendLayout();
            this.grbCheckButtons.SuspendLayout();
            this.grbImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSingleEvents
            // 
            this.rbSingleEvents.AutoSize = true;
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
            this.lblRequires.Location = new System.Drawing.Point(6, 189);
            this.lblRequires.Name = "lblRequires";
            this.lblRequires.Size = new System.Drawing.Size(49, 13);
            this.lblRequires.TabIndex = 5;
            this.lblRequires.Text = "Requires";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(6, 220);
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
            this.tbCode.MaxLength = 4;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(33, 20);
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
            this.cbRequires.Location = new System.Drawing.Point(66, 186);
            this.cbRequires.Name = "cbRequires";
            this.cbRequires.Size = new System.Drawing.Size(130, 21);
            this.cbRequires.Sorted = true;
            this.cbRequires.TabIndex = 12;
            // 
            // tbPoints
            // 
            this.tbPoints.Enabled = false;
            this.tbPoints.Location = new System.Drawing.Point(66, 217);
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
            this.rtbEventsInfo.Location = new System.Drawing.Point(178, 19);
            this.rtbEventsInfo.Name = "rtbEventsInfo";
            this.rtbEventsInfo.ReadOnly = true;
            this.rtbEventsInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbEventsInfo.Size = new System.Drawing.Size(166, 150);
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
            this.rtbOpponentsInfo.Location = new System.Drawing.Point(178, 19);
            this.rtbOpponentsInfo.Name = "rtbOpponentsInfo";
            this.rtbOpponentsInfo.ReadOnly = true;
            this.rtbOpponentsInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbOpponentsInfo.Size = new System.Drawing.Size(166, 150);
            this.rtbOpponentsInfo.TabIndex = 26;
            this.rtbOpponentsInfo.Text = "";
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
            this.lblGoalsPoints.Location = new System.Drawing.Point(20, 22);
            this.lblGoalsPoints.Name = "lblGoalsPoints";
            this.lblGoalsPoints.Size = new System.Drawing.Size(36, 13);
            this.lblGoalsPoints.TabIndex = 35;
            this.lblGoalsPoints.Text = "Points";
            // 
            // cbSkin
            // 
            this.cbSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkin.FormattingEnabled = true;
            this.cbSkin.Location = new System.Drawing.Point(50, 52);
            this.cbSkin.Name = "cbSkin";
            this.cbSkin.Size = new System.Drawing.Size(146, 21);
            this.cbSkin.TabIndex = 15;
            this.cbSkin.SelectionChangeCommitted += new System.EventHandler(this.cbSkin_SelectionChangeCommitted);
            // 
            // lblSkin
            // 
            this.lblSkin.AutoSize = true;
            this.lblSkin.Location = new System.Drawing.Point(7, 57);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(28, 13);
            this.lblSkin.TabIndex = 37;
            this.lblSkin.Text = "Skin";
            // 
            // grbGoals
            // 
            this.grbGoals.Controls.Add(this.rbRanking);
            this.grbGoals.Controls.Add(this.rbGoalsPoints);
            this.grbGoals.Controls.Add(this.tbRanking);
            this.grbGoals.Controls.Add(this.lblRanking);
            this.grbGoals.Controls.Add(this.tbGoldTier);
            this.grbGoals.Controls.Add(this.tbSilverTier);
            this.grbGoals.Controls.Add(this.tbBronzeTier);
            this.grbGoals.Controls.Add(this.lblBronzeTier);
            this.grbGoals.Controls.Add(this.lblSilverTier);
            this.grbGoals.Controls.Add(this.lblGoldTier);
            this.grbGoals.Controls.Add(this.tbGoalsPoints);
            this.grbGoals.Controls.Add(this.lblGoalsPoints);
            this.grbGoals.Location = new System.Drawing.Point(12, 530);
            this.grbGoals.Name = "grbGoals";
            this.grbGoals.Size = new System.Drawing.Size(206, 129);
            this.grbGoals.TabIndex = 44;
            this.grbGoals.TabStop = false;
            this.grbGoals.Text = "Series Goals";
            // 
            // rbRanking
            // 
            this.rbRanking.AutoSize = true;
            this.rbRanking.Location = new System.Drawing.Point(105, 22);
            this.rbRanking.Name = "rbRanking";
            this.rbRanking.Size = new System.Drawing.Size(14, 13);
            this.rbRanking.TabIndex = 42;
            this.rbRanking.UseVisualStyleBackColor = true;
            this.rbRanking.CheckedChanged += new System.EventHandler(this.rbRanking_CheckedChanged);
            // 
            // rbGoalsPoints
            // 
            this.rbGoalsPoints.AutoSize = true;
            this.rbGoalsPoints.Checked = true;
            this.rbGoalsPoints.Location = new System.Drawing.Point(6, 22);
            this.rbGoalsPoints.Name = "rbGoalsPoints";
            this.rbGoalsPoints.Size = new System.Drawing.Size(14, 13);
            this.rbGoalsPoints.TabIndex = 41;
            this.rbGoalsPoints.TabStop = true;
            this.rbGoalsPoints.UseVisualStyleBackColor = true;
            this.rbGoalsPoints.CheckedChanged += new System.EventHandler(this.rbGoalsPoints_CheckedChanged);
            // 
            // tbRanking
            // 
            this.tbRanking.Location = new System.Drawing.Point(172, 19);
            this.tbRanking.MaxLength = 1;
            this.tbRanking.Name = "tbRanking";
            this.tbRanking.Size = new System.Drawing.Size(28, 20);
            this.tbRanking.TabIndex = 40;
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Location = new System.Drawing.Point(121, 22);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(47, 13);
            this.lblRanking.TabIndex = 39;
            this.lblRanking.Text = "Ranking";
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
            this.lblPointsExample.Location = new System.Drawing.Point(63, 240);
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
            this.grbCar.Controls.Add(this.skinPreviewImagePanel);
            this.grbCar.Controls.Add(this.cbCar);
            this.grbCar.Controls.Add(this.lblModel);
            this.grbCar.Controls.Add(this.lblSkin);
            this.grbCar.Controls.Add(this.cbSkin);
            this.grbCar.Location = new System.Drawing.Point(12, 330);
            this.grbCar.Name = "grbCar";
            this.grbCar.Size = new System.Drawing.Size(206, 194);
            this.grbCar.TabIndex = 43;
            this.grbCar.TabStop = false;
            this.grbCar.Text = "Car";
            // 
            // skinPreviewImagePanel
            // 
            this.skinPreviewImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinPreviewImagePanel.Location = new System.Drawing.Point(18, 87);
            this.skinPreviewImagePanel.Name = "skinPreviewImagePanel";
            this.skinPreviewImagePanel.Size = new System.Drawing.Size(170, 96);
            this.skinPreviewImagePanel.TabIndex = 38;
            this.skinPreviewImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.skinPreviewImagePanel_Paint);
            // 
            // grbEvents
            // 
            this.grbEvents.Controls.Add(this.btnSaveEvent);
            this.grbEvents.Controls.Add(this.btnLoadEvent);
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
            // btnSaveEvent
            // 
            this.btnSaveEvent.Enabled = false;
            this.btnSaveEvent.Image = global::ACCG.Properties.Resources.Save_6530;
            this.btnSaveEvent.Location = new System.Drawing.Point(135, 48);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(37, 23);
            this.btnSaveEvent.TabIndex = 32;
            this.tltSaveEvent.SetToolTip(this.btnSaveEvent, "Save Event");
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            this.btnSaveEvent.Visible = false;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // btnLoadEvent
            // 
            this.btnLoadEvent.Image = global::ACCG.Properties.Resources.Open_6529_24;
            this.btnLoadEvent.Location = new System.Drawing.Point(135, 19);
            this.btnLoadEvent.Name = "btnLoadEvent";
            this.btnLoadEvent.Size = new System.Drawing.Size(37, 23);
            this.btnLoadEvent.TabIndex = 31;
            this.tltLoadEvents.SetToolTip(this.btnLoadEvent, "Load Events");
            this.btnLoadEvent.UseVisualStyleBackColor = true;
            this.btnLoadEvent.Click += new System.EventHandler(this.btnLoadEvent_Click);
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
            this.grbOpponents.Controls.Add(this.btnSaveOpponents);
            this.grbOpponents.Controls.Add(this.btnLoadOpponents);
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
            // btnSaveOpponents
            // 
            this.btnSaveOpponents.Image = global::ACCG.Properties.Resources.Save_6530;
            this.btnSaveOpponents.Location = new System.Drawing.Point(136, 49);
            this.btnSaveOpponents.Name = "btnSaveOpponents";
            this.btnSaveOpponents.Size = new System.Drawing.Size(37, 23);
            this.btnSaveOpponents.TabIndex = 31;
            this.tltSaveOpponents.SetToolTip(this.btnSaveOpponents, "Save Opponents");
            this.btnSaveOpponents.UseVisualStyleBackColor = true;
            this.btnSaveOpponents.Click += new System.EventHandler(this.btnSaveOpponents_Click);
            // 
            // btnLoadOpponents
            // 
            this.btnLoadOpponents.Image = global::ACCG.Properties.Resources.Open_6529_24;
            this.btnLoadOpponents.Location = new System.Drawing.Point(135, 19);
            this.btnLoadOpponents.Name = "btnLoadOpponents";
            this.btnLoadOpponents.Size = new System.Drawing.Size(37, 23);
            this.btnLoadOpponents.TabIndex = 30;
            this.tltLoadOpponents.SetToolTip(this.btnLoadOpponents, "Load Opponents");
            this.btnLoadOpponents.UseVisualStyleBackColor = true;
            this.btnLoadOpponents.Click += new System.EventHandler(this.btnLoadOpponents_Click);
            // 
            // btnDeleteOpponent
            // 
            this.btnDeleteOpponent.Image = global::ACCG.Properties.Resources.Clearallrequests_8816;
            this.btnDeleteOpponent.Location = new System.Drawing.Point(92, 148);
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
            this.btnEditOpponent.Location = new System.Drawing.Point(49, 148);
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
            this.btnNewOpponent.Location = new System.Drawing.Point(6, 148);
            this.btnNewOpponent.Name = "btnNewOpponent";
            this.btnNewOpponent.Size = new System.Drawing.Size(37, 23);
            this.btnNewOpponent.TabIndex = 27;
            this.tltNewOpponentButton.SetToolTip(this.btnNewOpponent, "New Opponent");
            this.btnNewOpponent.UseVisualStyleBackColor = true;
            this.btnNewOpponent.Click += new System.EventHandler(this.btnNewOpponent_Click);
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnCancel);
            this.grbButtons.Controls.Add(this.btnOK);
            this.grbButtons.Location = new System.Drawing.Point(393, 610);
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
            // grbImages
            // 
            this.grbImages.Controls.Add(this.btnOpenPreviewImage);
            this.grbImages.Controls.Add(this.btnOpenStartImage);
            this.grbImages.Controls.Add(this.lblPreviewImage);
            this.grbImages.Controls.Add(this.lblStartImage);
            this.grbImages.Controls.Add(this.previewImagePanel);
            this.grbImages.Controls.Add(this.startImagePanel);
            this.grbImages.Location = new System.Drawing.Point(222, 425);
            this.grbImages.Name = "grbImages";
            this.grbImages.Size = new System.Drawing.Size(354, 179);
            this.grbImages.TabIndex = 48;
            this.grbImages.TabStop = false;
            this.grbImages.Text = "Images";
            // 
            // btnOpenPreviewImage
            // 
            this.btnOpenPreviewImage.Image = global::ACCG.Properties.Resources.Open_6529_24;
            this.btnOpenPreviewImage.Location = new System.Drawing.Point(247, 150);
            this.btnOpenPreviewImage.Name = "btnOpenPreviewImage";
            this.btnOpenPreviewImage.Size = new System.Drawing.Size(37, 23);
            this.btnOpenPreviewImage.TabIndex = 5;
            this.tltLoadPreviewImage.SetToolTip(this.btnOpenPreviewImage, "Load preview image");
            this.btnOpenPreviewImage.UseVisualStyleBackColor = true;
            this.btnOpenPreviewImage.Click += new System.EventHandler(this.btnOpenPreviewImage_Click);
            // 
            // btnOpenStartImage
            // 
            this.btnOpenStartImage.Image = global::ACCG.Properties.Resources.Open_6529_24;
            this.btnOpenStartImage.Location = new System.Drawing.Point(6, 150);
            this.btnOpenStartImage.Name = "btnOpenStartImage";
            this.btnOpenStartImage.Size = new System.Drawing.Size(37, 23);
            this.btnOpenStartImage.TabIndex = 4;
            this.tltLoadStartImage.SetToolTip(this.btnOpenStartImage, "Load start image");
            this.btnOpenStartImage.UseVisualStyleBackColor = true;
            this.btnOpenStartImage.Click += new System.EventHandler(this.btnOpenStartImage_Click);
            // 
            // lblPreviewImage
            // 
            this.lblPreviewImage.AutoSize = true;
            this.lblPreviewImage.Location = new System.Drawing.Point(244, 21);
            this.lblPreviewImage.Name = "lblPreviewImage";
            this.lblPreviewImage.Size = new System.Drawing.Size(45, 13);
            this.lblPreviewImage.TabIndex = 3;
            this.lblPreviewImage.Text = "Preview";
            // 
            // lblStartImage
            // 
            this.lblStartImage.AutoSize = true;
            this.lblStartImage.Location = new System.Drawing.Point(7, 21);
            this.lblStartImage.Name = "lblStartImage";
            this.lblStartImage.Size = new System.Drawing.Size(29, 13);
            this.lblStartImage.TabIndex = 2;
            this.lblStartImage.Text = "Start";
            // 
            // previewImagePanel
            // 
            this.previewImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewImagePanel.Location = new System.Drawing.Point(247, 44);
            this.previewImagePanel.Name = "previewImagePanel";
            this.previewImagePanel.Size = new System.Drawing.Size(100, 100);
            this.previewImagePanel.TabIndex = 1;
            this.previewImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.previewImagePanel_Paint);
            // 
            // startImagePanel
            // 
            this.startImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startImagePanel.Location = new System.Drawing.Point(6, 44);
            this.startImagePanel.Name = "startImagePanel";
            this.startImagePanel.Size = new System.Drawing.Size(235, 100);
            this.startImagePanel.TabIndex = 0;
            this.startImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.startImagePanel_Paint);
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = "png files (*.png)|*.png";
            // 
            // openOpponentsFileDialog
            // 
            this.openOpponentsFileDialog.Filter = "opponents files (*.ini)|*.ini|opponents files (*.txt)|*.txt";
            // 
            // saveOpponentsFileDialog
            // 
            this.saveOpponentsFileDialog.Filter = "opponents files (*.ini)|*.ini|opponents files (*.txt)|*.txt";
            // 
            // openEventFileDialog
            // 
            this.openEventFileDialog.Filter = "event files|event.ini";
            // 
            // saveEventFileDialog
            // 
            this.saveEventFileDialog.Filter = "event files|*.ini|event files|*.txt";
            // 
            // ACCGNewSeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 673);
            this.Controls.Add(this.grbImages);
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
            this.grbImages.ResumeLayout(false);
            this.grbImages.PerformLayout();
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
        private GroupBox grbImages;
        private Button btnOpenStartImage;
        private Label lblPreviewImage;
        private Label lblStartImage;
        private Panel previewImagePanel;
        private Panel startImagePanel;
        private OpenFileDialog openImageFileDialog;
        private Button btnOpenPreviewImage;
        private Panel skinPreviewImagePanel;
        private ToolTip tltLoadPreviewImage;
        private ToolTip tltLoadStartImage;
        private Label lblRanking;
        private RadioButton rbRanking;
        private RadioButton rbGoalsPoints;
        private TextBox tbRanking;
        private Button btnLoadOpponents;
        private OpenFileDialog openOpponentsFileDialog;
        private ToolTip tltLoadOpponents;
        private Button btnSaveOpponents;
        private ToolTip tltSaveOpponents;
        private SaveFileDialog saveOpponentsFileDialog;
        private Button btnLoadEvent;
        private ToolTip tltLoadEvents;
        private OpenFileDialog openEventFileDialog;
        private Button btnSaveEvent;
        private ToolTip tltSaveEvent;
        private SaveFileDialog saveEventFileDialog;

        public static Car champ_player_car {get; set;}
        public static Series temp_series { get; set; }        
        public static Event current_selected_event { get; set; }
        public static Opponent current_selected_opponent { get; set; }
        public Bitmap startThumbnailImage { get; set; }
        public Bitmap previewThumbnailImage { get; set; }
        public Bitmap skinPreviewImage { get; set; }
        
    }
}