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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCGNewSeriesForm));
            this.rbSingleEvents = new System.Windows.Forms.RadioButton();
            this.rbChampionship = new System.Windows.Forms.RadioButton();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRequires = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbRequires = new System.Windows.Forms.ComboBox();
            this.tbPoints = new System.Windows.Forms.TextBox();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEventsInfo = new System.Windows.Forms.Label();
            this.rtbEventsInfo = new System.Windows.Forms.RichTextBox();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblOpponentsInfo = new System.Windows.Forms.Label();
            this.rtbOpponentsInfo = new System.Windows.Forms.RichTextBox();
            this.btnDeleteOpponent = new System.Windows.Forms.Button();
            this.btnEditOpponent = new System.Windows.Forms.Button();
            this.btnNewOpponent = new System.Windows.Forms.Button();
            this.lbOpponents = new System.Windows.Forms.ListBox();
            this.lblOpponents = new System.Windows.Forms.Label();
            this.tbGoalsPoints = new System.Windows.Forms.TextBox();
            this.lblGoalsPoints = new System.Windows.Forms.Label();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.cbSkin = new System.Windows.Forms.ComboBox();
            this.lblSkin = new System.Windows.Forms.Label();
            this.lblDontuseseries0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbSingleEvents
            // 
            this.rbSingleEvents.AutoSize = true;
            this.rbSingleEvents.Enabled = false;
            this.rbSingleEvents.Location = new System.Drawing.Point(13, 13);
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
            this.rbChampionship.Location = new System.Drawing.Point(108, 13);
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
            this.lblCode.Location = new System.Drawing.Point(10, 56);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(10, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblRequires
            // 
            this.lblRequires.AutoSize = true;
            this.lblRequires.Location = new System.Drawing.Point(10, 136);
            this.lblRequires.Name = "lblRequires";
            this.lblRequires.Size = new System.Drawing.Size(49, 13);
            this.lblRequires.TabIndex = 5;
            this.lblRequires.Text = "Requires";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(10, 164);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 6;
            this.lblPoints.Text = "Points";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(10, 191);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(23, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Car";
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.Location = new System.Drawing.Point(12, 272);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(34, 13);
            this.lblGoals.TabIndex = 8;
            this.lblGoals.Text = "Goals";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(99, 53);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(159, 20);
            this.tbCode.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(99, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(159, 20);
            this.tbName.TabIndex = 10;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(99, 106);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(159, 20);
            this.tbDescription.TabIndex = 11;
            // 
            // cbRequires
            // 
            this.cbRequires.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRequires.FormattingEnabled = true;
            this.cbRequires.Location = new System.Drawing.Point(99, 133);
            this.cbRequires.Name = "cbRequires";
            this.cbRequires.Size = new System.Drawing.Size(159, 21);
            this.cbRequires.Sorted = true;
            this.cbRequires.TabIndex = 12;
            // 
            // tbPoints
            // 
            this.tbPoints.Enabled = false;
            this.tbPoints.Location = new System.Drawing.Point(99, 161);
            this.tbPoints.Name = "tbPoints";
            this.tbPoints.Size = new System.Drawing.Size(159, 20);
            this.tbPoints.TabIndex = 13;
            // 
            // cbCar
            // 
            this.cbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCar.Enabled = false;
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(99, 188);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(159, 21);
            this.cbCar.TabIndex = 14;
            this.cbCar.SelectionChangeCommitted += new System.EventHandler(this.cbCar_SelectionChangeCommitted);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(554, 354);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 27;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(635, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEventsInfo
            // 
            this.lblEventsInfo.AutoSize = true;
            this.lblEventsInfo.Location = new System.Drawing.Point(501, 35);
            this.lblEventsInfo.Name = "lblEventsInfo";
            this.lblEventsInfo.Size = new System.Drawing.Size(25, 13);
            this.lblEventsInfo.TabIndex = 26;
            this.lblEventsInfo.Text = "Info";
            // 
            // rtbEventsInfo
            // 
            this.rtbEventsInfo.Location = new System.Drawing.Point(501, 56);
            this.rtbEventsInfo.Name = "rtbEventsInfo";
            this.rtbEventsInfo.ReadOnly = true;
            this.rtbEventsInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbEventsInfo.Size = new System.Drawing.Size(209, 121);
            this.rtbEventsInfo.TabIndex = 21;
            this.rtbEventsInfo.Text = "";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(407, 111);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEvent.TabIndex = 20;
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Enabled = false;
            this.btnEditEvent.Location = new System.Drawing.Point(406, 82);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(76, 23);
            this.btnEditEvent.TabIndex = 19;
            this.btnEditEvent.Text = "Edit";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Location = new System.Drawing.Point(407, 53);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(75, 23);
            this.btnNewEvent.TabIndex = 18;
            this.btnNewEvent.Text = "New";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.Location = new System.Drawing.Point(280, 53);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(120, 82);
            this.lbEvents.TabIndex = 17;
            this.lbEvents.SelectedIndexChanged += new System.EventHandler(this.lbEvents_SelectedIndexChanged);
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(277, 35);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(40, 13);
            this.lblEvents.TabIndex = 20;
            this.lblEvents.Text = "Events";
            // 
            // lblOpponentsInfo
            // 
            this.lblOpponentsInfo.AutoSize = true;
            this.lblOpponentsInfo.Location = new System.Drawing.Point(501, 187);
            this.lblOpponentsInfo.Name = "lblOpponentsInfo";
            this.lblOpponentsInfo.Size = new System.Drawing.Size(25, 13);
            this.lblOpponentsInfo.TabIndex = 33;
            this.lblOpponentsInfo.Text = "Info";
            // 
            // rtbOpponentsInfo
            // 
            this.rtbOpponentsInfo.Location = new System.Drawing.Point(501, 203);
            this.rtbOpponentsInfo.Name = "rtbOpponentsInfo";
            this.rtbOpponentsInfo.ReadOnly = true;
            this.rtbOpponentsInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbOpponentsInfo.Size = new System.Drawing.Size(209, 121);
            this.rtbOpponentsInfo.TabIndex = 26;
            this.rtbOpponentsInfo.Text = "";
            // 
            // btnDeleteOpponent
            // 
            this.btnDeleteOpponent.Location = new System.Drawing.Point(407, 265);
            this.btnDeleteOpponent.Name = "btnDeleteOpponent";
            this.btnDeleteOpponent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOpponent.TabIndex = 25;
            this.btnDeleteOpponent.Text = "Delete";
            this.btnDeleteOpponent.UseVisualStyleBackColor = true;
            this.btnDeleteOpponent.Click += new System.EventHandler(this.btnDeleteOpponent_Click);
            // 
            // btnEditOpponent
            // 
            this.btnEditOpponent.Enabled = false;
            this.btnEditOpponent.Location = new System.Drawing.Point(407, 236);
            this.btnEditOpponent.Name = "btnEditOpponent";
            this.btnEditOpponent.Size = new System.Drawing.Size(75, 23);
            this.btnEditOpponent.TabIndex = 24;
            this.btnEditOpponent.Text = "Edit";
            this.btnEditOpponent.UseVisualStyleBackColor = true;
            // 
            // btnNewOpponent
            // 
            this.btnNewOpponent.Location = new System.Drawing.Point(407, 206);
            this.btnNewOpponent.Name = "btnNewOpponent";
            this.btnNewOpponent.Size = new System.Drawing.Size(75, 23);
            this.btnNewOpponent.TabIndex = 23;
            this.btnNewOpponent.Text = "New";
            this.btnNewOpponent.UseVisualStyleBackColor = true;
            this.btnNewOpponent.Click += new System.EventHandler(this.btnNewOpponent_Click);
            // 
            // lbOpponents
            // 
            this.lbOpponents.FormattingEnabled = true;
            this.lbOpponents.Location = new System.Drawing.Point(280, 206);
            this.lbOpponents.Name = "lbOpponents";
            this.lbOpponents.Size = new System.Drawing.Size(120, 82);
            this.lbOpponents.TabIndex = 22;
            this.lbOpponents.SelectedIndexChanged += new System.EventHandler(this.lbOpponents_SelectedIndexChanged);
            // 
            // lblOpponents
            // 
            this.lblOpponents.AutoSize = true;
            this.lblOpponents.Location = new System.Drawing.Point(277, 188);
            this.lblOpponents.Name = "lblOpponents";
            this.lblOpponents.Size = new System.Drawing.Size(59, 13);
            this.lblOpponents.TabIndex = 27;
            this.lblOpponents.Text = "Opponents";
            // 
            // tbGoalsPoints
            // 
            this.tbGoalsPoints.Location = new System.Drawing.Point(99, 268);
            this.tbGoalsPoints.Name = "tbGoalsPoints";
            this.tbGoalsPoints.Size = new System.Drawing.Size(100, 20);
            this.tbGoalsPoints.TabIndex = 16;
            // 
            // lblGoalsPoints
            // 
            this.lblGoalsPoints.AutoSize = true;
            this.lblGoalsPoints.Location = new System.Drawing.Point(206, 271);
            this.lblGoalsPoints.Name = "lblGoalsPoints";
            this.lblGoalsPoints.Size = new System.Drawing.Size(36, 13);
            this.lblGoalsPoints.TabIndex = 35;
            this.lblGoalsPoints.Text = "Points";
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.Location = new System.Drawing.Point(99, 295);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(68, 13);
            this.lblPlaceholder.TabIndex = 36;
            this.lblPlaceholder.Text = "(placeholder)";
            // 
            // cbSkin
            // 
            this.cbSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkin.FormattingEnabled = true;
            this.cbSkin.Location = new System.Drawing.Point(99, 223);
            this.cbSkin.Name = "cbSkin";
            this.cbSkin.Size = new System.Drawing.Size(159, 21);
            this.cbSkin.TabIndex = 15;
            // 
            // lblSkin
            // 
            this.lblSkin.AutoSize = true;
            this.lblSkin.Location = new System.Drawing.Point(10, 228);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(28, 13);
            this.lblSkin.TabIndex = 37;
            this.lblSkin.Text = "Skin";
            // 
            // lblDontuseseries0
            // 
            this.lblDontuseseries0.AutoSize = true;
            this.lblDontuseseries0.Location = new System.Drawing.Point(265, 140);
            this.lblDontuseseries0.Name = "lblDontuseseries0";
            this.lblDontuseseries0.Size = new System.Drawing.Size(91, 13);
            this.lblDontuseseries0.TabIndex = 39;
            this.lblDontuseseries0.Text = "Don\'t use series0!";
            // 
            // ACCGNewSeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 386);
            this.Controls.Add(this.lblDontuseseries0);
            this.Controls.Add(this.cbSkin);
            this.Controls.Add(this.lblSkin);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.lblGoalsPoints);
            this.Controls.Add(this.tbGoalsPoints);
            this.Controls.Add(this.lblOpponentsInfo);
            this.Controls.Add(this.rtbOpponentsInfo);
            this.Controls.Add(this.btnDeleteOpponent);
            this.Controls.Add(this.btnEditOpponent);
            this.Controls.Add(this.btnNewOpponent);
            this.Controls.Add(this.lbOpponents);
            this.Controls.Add(this.lblOpponents);
            this.Controls.Add(this.lblEventsInfo);
            this.Controls.Add(this.rtbEventsInfo);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.btnNewEvent);
            this.Controls.Add(this.lbEvents);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.tbPoints);
            this.Controls.Add(this.cbRequires);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lblGoals);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblRequires);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.rbChampionship);
            this.Controls.Add(this.rbSingleEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ACCGNewSeriesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Series";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewSeriesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label lblGoals;
        private TextBox tbCode;
        private TextBox tbName;
        private TextBox tbDescription;
        private ComboBox cbRequires;
        private TextBox tbPoints;
        private ComboBox cbCar;
        private Button btnOK;
        private Button btnCancel;        
        private Label lblEventsInfo;
        private RichTextBox rtbEventsInfo;
        private Button btnDeleteEvent;
        private Button btnEditEvent;
        private Button btnNewEvent;
        private ListBox lbEvents;
        private Label lblEvents;

        private string[] ac_series_path;
        private Label lblOpponentsInfo;
        private RichTextBox rtbOpponentsInfo;
        private Button btnDeleteOpponent;
        private Button btnEditOpponent;
        private Button btnNewOpponent;
        private ListBox lbOpponents;
        private Label lblOpponents;
        private TextBox tbGoalsPoints;
        private Label lblGoalsPoints;
        private Label lblPlaceholder;
        private ComboBox cbSkin;
        private Label lblSkin;

        public static BindingSource bs_events_datasource = new BindingSource();
        public static BindingSource bs_opponents_datasource = new BindingSource();
        private Label lblDontuseseries0;

        public static Car champ_player_car {get; set;}
        public static Series temp_series { get; set; }
        public static int events_global_ID { get; set; }
        public static int opponents_global_ID { get; set; }
        public static Event current_selected_event { get; set; }
        public static Opponent current_selected_opponent { get; set; }
        
    }
}