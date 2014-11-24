using System.Drawing;
namespace ACCG
{
    partial class ACCGNewOpponentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCGNewOpponentForm));
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.cbSkin = new System.Windows.Forms.ComboBox();
            this.lblSkin = new System.Windows.Forms.Label();
            this.cbSetup = new System.Windows.Forms.ComboBox();
            this.lblSetup = new System.Windows.Forms.Label();
            this.tkbAIlevel = new System.Windows.Forms.TrackBar();
            this.lblAIlevelValue = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbDriver = new System.Windows.Forms.GroupBox();
            this.grbCar = new System.Windows.Forms.GroupBox();
            this.grbAILevel = new System.Windows.Forms.GroupBox();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.skinPreviewImagePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAIlevel)).BeginInit();
            this.grbDriver.SuspendLayout();
            this.grbCar.SuspendLayout();
            this.grbAILevel.SuspendLayout();
            this.grbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(68, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(145, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(68, 39);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(145, 20);
            this.tbNationality.TabIndex = 4;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(6, 42);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(56, 13);
            this.lblNationality.TabIndex = 3;
            this.lblNationality.Text = "Nationality";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(6, 16);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            // 
            // cbCar
            // 
            this.cbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(68, 13);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(145, 21);
            this.cbCar.TabIndex = 6;
            this.cbCar.SelectionChangeCommitted += new System.EventHandler(this.cbCar_SelectionChangeCommitted);
            // 
            // cbSkin
            // 
            this.cbSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkin.FormattingEnabled = true;
            this.cbSkin.Location = new System.Drawing.Point(68, 40);
            this.cbSkin.Name = "cbSkin";
            this.cbSkin.Size = new System.Drawing.Size(145, 21);
            this.cbSkin.TabIndex = 8;
            this.cbSkin.SelectionChangeCommitted += new System.EventHandler(this.cbSkin_SelectionChangeCommitted);
            // 
            // lblSkin
            // 
            this.lblSkin.AutoSize = true;
            this.lblSkin.Location = new System.Drawing.Point(6, 43);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(28, 13);
            this.lblSkin.TabIndex = 7;
            this.lblSkin.Text = "Skin";
            // 
            // cbSetup
            // 
            this.cbSetup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetup.Enabled = false;
            this.cbSetup.FormattingEnabled = true;
            this.cbSetup.Location = new System.Drawing.Point(68, 179);
            this.cbSetup.Name = "cbSetup";
            this.cbSetup.Size = new System.Drawing.Size(145, 21);
            this.cbSetup.TabIndex = 10;
            // 
            // lblSetup
            // 
            this.lblSetup.AutoSize = true;
            this.lblSetup.Location = new System.Drawing.Point(6, 182);
            this.lblSetup.Name = "lblSetup";
            this.lblSetup.Size = new System.Drawing.Size(35, 13);
            this.lblSetup.TabIndex = 9;
            this.lblSetup.Text = "Setup";
            // 
            // tkbAIlevel
            // 
            this.tkbAIlevel.Location = new System.Drawing.Point(6, 19);
            this.tkbAIlevel.Maximum = 100;
            this.tkbAIlevel.Minimum = 80;
            this.tkbAIlevel.Name = "tkbAIlevel";
            this.tkbAIlevel.Size = new System.Drawing.Size(182, 45);
            this.tkbAIlevel.TabIndex = 12;
            this.tkbAIlevel.Value = 80;
            this.tkbAIlevel.Scroll += new System.EventHandler(this.tkbAIlevel_Scroll);
            // 
            // lblAIlevelValue
            // 
            this.lblAIlevelValue.AutoSize = true;
            this.lblAIlevelValue.Location = new System.Drawing.Point(194, 19);
            this.lblAIlevelValue.Name = "lblAIlevelValue";
            this.lblAIlevelValue.Size = new System.Drawing.Size(19, 13);
            this.lblAIlevelValue.TabIndex = 13;
            this.lblAIlevelValue.Text = "80";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(34, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(115, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbDriver
            // 
            this.grbDriver.Controls.Add(this.tbName);
            this.grbDriver.Controls.Add(this.lblName);
            this.grbDriver.Controls.Add(this.lblNationality);
            this.grbDriver.Controls.Add(this.tbNationality);
            this.grbDriver.Location = new System.Drawing.Point(12, 12);
            this.grbDriver.Name = "grbDriver";
            this.grbDriver.Size = new System.Drawing.Size(221, 69);
            this.grbDriver.TabIndex = 16;
            this.grbDriver.TabStop = false;
            this.grbDriver.Text = "Driver";
            // 
            // grbCar
            // 
            this.grbCar.Controls.Add(this.skinPreviewImagePanel);
            this.grbCar.Controls.Add(this.cbCar);
            this.grbCar.Controls.Add(this.lblModel);
            this.grbCar.Controls.Add(this.lblSkin);
            this.grbCar.Controls.Add(this.cbSkin);
            this.grbCar.Controls.Add(this.lblSetup);
            this.grbCar.Controls.Add(this.cbSetup);
            this.grbCar.Location = new System.Drawing.Point(12, 87);
            this.grbCar.Name = "grbCar";
            this.grbCar.Size = new System.Drawing.Size(221, 209);
            this.grbCar.TabIndex = 17;
            this.grbCar.TabStop = false;
            this.grbCar.Text = "Car";
            // 
            // grbAILevel
            // 
            this.grbAILevel.Controls.Add(this.tkbAIlevel);
            this.grbAILevel.Controls.Add(this.lblAIlevelValue);
            this.grbAILevel.Location = new System.Drawing.Point(12, 302);
            this.grbAILevel.Name = "grbAILevel";
            this.grbAILevel.Size = new System.Drawing.Size(221, 70);
            this.grbAILevel.TabIndex = 18;
            this.grbAILevel.TabStop = false;
            this.grbAILevel.Text = "AI Level";
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnOK);
            this.grbButtons.Controls.Add(this.btnCancel);
            this.grbButtons.Location = new System.Drawing.Point(12, 378);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(221, 54);
            this.grbButtons.TabIndex = 19;
            this.grbButtons.TabStop = false;
            // 
            // skinPreviewImagePanel
            // 
            this.skinPreviewImagePanel.Location = new System.Drawing.Point(26, 71);
            this.skinPreviewImagePanel.Name = "skinPreviewImagePanel";
            this.skinPreviewImagePanel.Size = new System.Drawing.Size(170, 96);
            this.skinPreviewImagePanel.TabIndex = 39;
            this.skinPreviewImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.skinPreviewImagePanel_Paint);
            // 
            // ACCGNewOpponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 443);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.grbAILevel);
            this.Controls.Add(this.grbCar);
            this.Controls.Add(this.grbDriver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ACCGNewOpponentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Opponent";
            this.Load += new System.EventHandler(this.ACCGNewOpponentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbAIlevel)).EndInit();
            this.grbDriver.ResumeLayout(false);
            this.grbDriver.PerformLayout();
            this.grbCar.ResumeLayout(false);
            this.grbCar.PerformLayout();
            this.grbAILevel.ResumeLayout(false);
            this.grbAILevel.PerformLayout();
            this.grbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.ComboBox cbSkin;
        private System.Windows.Forms.Label lblSkin;
        private System.Windows.Forms.ComboBox cbSetup;
        private System.Windows.Forms.Label lblSetup;
        private System.Windows.Forms.TrackBar tkbAIlevel;
        private System.Windows.Forms.Label lblAIlevelValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbDriver;
        private System.Windows.Forms.GroupBox grbCar;
        private System.Windows.Forms.GroupBox grbAILevel;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.Panel skinPreviewImagePanel;

        public static Car opponent_car { get; set; }
        public Bitmap skinPreviewImage { get; set; }
    }
}