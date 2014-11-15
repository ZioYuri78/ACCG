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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCGMainForm));
            this.lblSeries = new System.Windows.Forms.Label();
            this.lbSeries = new System.Windows.Forms.ListBox();
            this.btnNewSeries = new System.Windows.Forms.Button();
            this.btnEditSeries = new System.Windows.Forms.Button();
            this.btnDeleteSeries = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbSeriesInfo = new System.Windows.Forms.RichTextBox();
            this.lblSeriesInfo = new System.Windows.Forms.Label();
            this.lblCurrentSeries = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(12, 36);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(36, 13);
            this.lblSeries.TabIndex = 0;
            this.lblSeries.Text = "Series";
            // 
            // lbSeries
            // 
            this.lbSeries.FormattingEnabled = true;
            this.lbSeries.Location = new System.Drawing.Point(15, 53);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(120, 82);
            this.lbSeries.TabIndex = 3;
            this.lbSeries.SelectedIndexChanged += new System.EventHandler(this.lbSeries_SelectedIndexChanged);
            // 
            // btnNewSeries
            // 
            this.btnNewSeries.Location = new System.Drawing.Point(142, 53);
            this.btnNewSeries.Name = "btnNewSeries";
            this.btnNewSeries.Size = new System.Drawing.Size(75, 23);
            this.btnNewSeries.TabIndex = 6;
            this.btnNewSeries.Text = "New";
            this.btnNewSeries.UseVisualStyleBackColor = true;
            this.btnNewSeries.Click += new System.EventHandler(this.btnNewSeries_Click);
            // 
            // btnEditSeries
            // 
            this.btnEditSeries.Location = new System.Drawing.Point(142, 83);
            this.btnEditSeries.Name = "btnEditSeries";
            this.btnEditSeries.Size = new System.Drawing.Size(75, 23);
            this.btnEditSeries.TabIndex = 7;
            this.btnEditSeries.Text = "Edit";
            this.btnEditSeries.UseVisualStyleBackColor = true;
            this.btnEditSeries.Click += new System.EventHandler(this.btnEditSeries_Click);
            // 
            // btnDeleteSeries
            // 
            this.btnDeleteSeries.Location = new System.Drawing.Point(142, 113);
            this.btnDeleteSeries.Name = "btnDeleteSeries";
            this.btnDeleteSeries.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSeries.TabIndex = 8;
            this.btnDeleteSeries.Text = "Delete";
            this.btnDeleteSeries.UseVisualStyleBackColor = true;
            this.btnDeleteSeries.Click += new System.EventHandler(this.btnDeleteSeries_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
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
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.helpToolStripMenuItem.Text = "Help";
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
            this.rtbSeriesInfo.Location = new System.Drawing.Point(227, 52);
            this.rtbSeriesInfo.Name = "rtbSeriesInfo";
            this.rtbSeriesInfo.ReadOnly = true;
            this.rtbSeriesInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSeriesInfo.Size = new System.Drawing.Size(262, 164);
            this.rtbSeriesInfo.TabIndex = 16;
            this.rtbSeriesInfo.Text = "";
            // 
            // lblSeriesInfo
            // 
            this.lblSeriesInfo.AutoSize = true;
            this.lblSeriesInfo.Location = new System.Drawing.Point(224, 36);
            this.lblSeriesInfo.Name = "lblSeriesInfo";
            this.lblSeriesInfo.Size = new System.Drawing.Size(25, 13);
            this.lblSeriesInfo.TabIndex = 17;
            this.lblSeriesInfo.Text = "Info";
            // 
            // lblCurrentSeries
            // 
            this.lblCurrentSeries.AutoSize = true;
            this.lblCurrentSeries.Location = new System.Drawing.Point(12, 224);
            this.lblCurrentSeries.Name = "lblCurrentSeries";
            this.lblCurrentSeries.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentSeries.TabIndex = 18;
            this.lblCurrentSeries.Text = "Current series:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 240);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(474, 75);
            this.btnGenerate.TabIndex = 19;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // ACCGMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 330);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblCurrentSeries);
            this.Controls.Add(this.lblSeriesInfo);
            this.Controls.Add(this.rtbSeriesInfo);
            this.Controls.Add(this.btnDeleteSeries);
            this.Controls.Add(this.btnEditSeries);
            this.Controls.Add(this.btnNewSeries);
            this.Controls.Add(this.lbSeries);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ACCGMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCG - Assetto Corsa Career Generator";
            this.Load += new System.EventHandler(this.ACCGMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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

        private Label lblSeries;        
        private Button btnNewSeries;
        private Button btnEditSeries;
        private Button btnDeleteSeries;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private RichTextBox rtbSeriesInfo;
        private Label lblSeriesInfo;
        public ListBox lbSeries;
        private Label lblCurrentSeries;
        private Button btnGenerate;

        public static BindingSource bs_series_datasource = new BindingSource();
       
        public static string ac_path { get; set; }
        public static List<Series> accg_series_list { get; set; }
        public static Series current_selected_series { get; set; }
        public static int series_global_ID { get; set; }
        public static List<Car> ac_cars_list { get; set; }        
        public static List<string> ac_tracks_list { get; set; }
        public static Dictionary<string, int> time_table { get; set; }
        


        
    }
}

