using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
namespace ACCG
{
    partial class ACCGMainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCGMainForm));
            this.lbSeries = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbSeriesInfo = new System.Windows.Forms.RichTextBox();
            this.lblCurrentSeries = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grbSeries = new System.Windows.Forms.GroupBox();
            this.btnLoadSeries = new System.Windows.Forms.Button();
            this.btnNewSeries = new System.Windows.Forms.Button();
            this.btnEditSeries = new System.Windows.Forms.Button();
            this.btnDeleteSeries = new System.Windows.Forms.Button();
            this.tltNewSeriesButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltEditSeriesButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltDeleteSeriesButton = new System.Windows.Forms.ToolTip(this.components);
            this.tltLoadSeries = new System.Windows.Forms.ToolTip(this.components);
            this.openSeriesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bgWorkerSync = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.grbSeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSeries
            // 
            this.lbSeries.FormattingEnabled = true;
            this.lbSeries.Location = new System.Drawing.Point(6, 19);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(123, 134);
            this.lbSeries.TabIndex = 3;
            this.lbSeries.SelectedIndexChanged += new System.EventHandler(this.lbSeries_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // modsToolStripMenuItem
            // 
            this.modsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncToolStripMenuItem});
            this.modsToolStripMenuItem.Name = "modsToolStripMenuItem";
            this.modsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.modsToolStripMenuItem.Text = "Mods";
            // 
            // syncToolStripMenuItem
            // 
            this.syncToolStripMenuItem.Name = "syncToolStripMenuItem";
            this.syncToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.syncToolStripMenuItem.Text = "Sync";
            this.syncToolStripMenuItem.Click += new System.EventHandler(this.syncToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // rtbSeriesInfo
            // 
            this.rtbSeriesInfo.Location = new System.Drawing.Point(178, 19);
            this.rtbSeriesInfo.Name = "rtbSeriesInfo";
            this.rtbSeriesInfo.ReadOnly = true;
            this.rtbSeriesInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSeriesInfo.Size = new System.Drawing.Size(219, 163);
            this.rtbSeriesInfo.TabIndex = 16;
            this.rtbSeriesInfo.Text = "";
            // 
            // lblCurrentSeries
            // 
            this.lblCurrentSeries.AutoSize = true;
            this.lblCurrentSeries.Location = new System.Drawing.Point(9, 220);
            this.lblCurrentSeries.Name = "lblCurrentSeries";
            this.lblCurrentSeries.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentSeries.TabIndex = 18;
            this.lblCurrentSeries.Text = "Current series:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 236);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(403, 75);
            this.btnGenerate.TabIndex = 19;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grbSeries
            // 
            this.grbSeries.Controls.Add(this.btnLoadSeries);
            this.grbSeries.Controls.Add(this.lbSeries);
            this.grbSeries.Controls.Add(this.btnNewSeries);
            this.grbSeries.Controls.Add(this.btnEditSeries);
            this.grbSeries.Controls.Add(this.rtbSeriesInfo);
            this.grbSeries.Controls.Add(this.btnDeleteSeries);
            this.grbSeries.Location = new System.Drawing.Point(12, 27);
            this.grbSeries.Name = "grbSeries";
            this.grbSeries.Size = new System.Drawing.Size(403, 188);
            this.grbSeries.TabIndex = 20;
            this.grbSeries.TabStop = false;
            this.grbSeries.Text = "Series";
            // 
            // btnLoadSeries
            // 
            this.btnLoadSeries.Image = global::ACCG.Properties.Resources.Open_6529_24;
            this.btnLoadSeries.Location = new System.Drawing.Point(135, 19);
            this.btnLoadSeries.Name = "btnLoadSeries";
            this.btnLoadSeries.Size = new System.Drawing.Size(37, 23);
            this.btnLoadSeries.TabIndex = 17;
            this.tltNewSeriesButton.SetToolTip(this.btnLoadSeries, "New Series");
            this.tltLoadSeries.SetToolTip(this.btnLoadSeries, "Load Series");
            this.btnLoadSeries.UseVisualStyleBackColor = true;
            this.btnLoadSeries.Click += new System.EventHandler(this.btnLoadSeries_Click);
            // 
            // btnNewSeries
            // 
            this.btnNewSeries.Image = global::ACCG.Properties.Resources.NewFile_6276;
            this.btnNewSeries.Location = new System.Drawing.Point(6, 159);
            this.btnNewSeries.Name = "btnNewSeries";
            this.btnNewSeries.Size = new System.Drawing.Size(37, 23);
            this.btnNewSeries.TabIndex = 6;
            this.tltNewSeriesButton.SetToolTip(this.btnNewSeries, "New Series");
            this.btnNewSeries.UseVisualStyleBackColor = true;
            this.btnNewSeries.Click += new System.EventHandler(this.btnNewSeries_Click);
            // 
            // btnEditSeries
            // 
            this.btnEditSeries.Image = global::ACCG.Properties.Resources.EditTitleString_357;
            this.btnEditSeries.Location = new System.Drawing.Point(49, 159);
            this.btnEditSeries.Name = "btnEditSeries";
            this.btnEditSeries.Size = new System.Drawing.Size(37, 23);
            this.btnEditSeries.TabIndex = 7;
            this.tltEditSeriesButton.SetToolTip(this.btnEditSeries, "Edit Series");
            this.btnEditSeries.UseVisualStyleBackColor = true;
            this.btnEditSeries.Click += new System.EventHandler(this.btnEditSeries_Click);
            // 
            // btnDeleteSeries
            // 
            this.btnDeleteSeries.Image = global::ACCG.Properties.Resources.Clearallrequests_8816;
            this.btnDeleteSeries.Location = new System.Drawing.Point(92, 159);
            this.btnDeleteSeries.Name = "btnDeleteSeries";
            this.btnDeleteSeries.Size = new System.Drawing.Size(37, 23);
            this.btnDeleteSeries.TabIndex = 8;
            this.tltDeleteSeriesButton.SetToolTip(this.btnDeleteSeries, "Delete Series");
            this.btnDeleteSeries.UseVisualStyleBackColor = true;
            this.btnDeleteSeries.Click += new System.EventHandler(this.btnDeleteSeries_Click);
            // 
            // openSeriesFileDialog
            // 
            this.openSeriesFileDialog.Filter = "Series files (series.ini)|series.ini";
            // 
            // bgWorkerSync
            // 
            this.bgWorkerSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerSync_DoWork);
            this.bgWorkerSync.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerSync_ProgressChanged);
            this.bgWorkerSync.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerSync_RunWorkerCompleted);
            // 
            // ACCGMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 322);
            this.Controls.Add(this.grbSeries);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblCurrentSeries);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ACCGMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCG - Assetto Corsa Career Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ACCGMainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ACCGMainForm_FormClosed);
            this.Load += new System.EventHandler(this.ACCGMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbSeries.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ShowData()
        {
            // Series listbox data source
            bs_series_datasource.DataSource = accg_series_list;
            
            lbSeries.DisplayMember = "Name";
            lbSeries.ValueMember = "ID";

            lbSeries.DataSource = bs_series_datasource;
                      
        }

        #endregion

        private Button btnNewSeries;
        private Button btnEditSeries;
        private Button btnDeleteSeries;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private ToolStripMenuItem modsToolStripMenuItem;
        private ToolStripMenuItem syncToolStripMenuItem;
        private RichTextBox rtbSeriesInfo;
        public ListBox lbSeries;
        private Label lblCurrentSeries;
        private Button btnGenerate;

        public static BindingSource bs_series_datasource = new BindingSource();
        private GroupBox grbSeries;
        private ToolTip tltNewSeriesButton;
        private ToolTip tltEditSeriesButton;
        private ToolTip tltDeleteSeriesButton;
       
        public static string ac_path { get; set; }
        public static List<Series> accg_series_list { get; set; }
        public static Series current_selected_series { get; set; }        
        public static List<Car> ac_cars_list { get; set; }        
        public static List<string> ac_tracks_list { get; set; }
        public static Dictionary<string, int> time_table { get; set; }

        public static ACCGGenerator accg_generator;

        public static ACCGResourceManager accg_resource;

        public static ACCGLogManager accg_log;

        public static SyncForm sync_form;

        public const string accg_settings_file_name = @"cfg\settings.ini";
        public const string accg_series_file_name = @"data\accg_series_list.dat";
        public const string accg_cars_file_name = @"data\cars.txt";
        public const string accg_tracks_file_name = @"data\tracks.txt";
        public const string accg_manual_file_name = "http://steamcommunity.com/sharedfiles/filedetails/?id=351184865";
        private Button btnLoadSeries;
        private ToolTip tltLoadSeries;
        private OpenFileDialog openSeriesFileDialog;
        private BackgroundWorker bgWorkerSync;

        
    }
}

