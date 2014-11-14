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
            this.lblCar = new System.Windows.Forms.Label();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.cbSkin = new System.Windows.Forms.ComboBox();
            this.lblSkin = new System.Windows.Forms.Label();
            this.cbSetup = new System.Windows.Forms.ComboBox();
            this.lblSetup = new System.Windows.Forms.Label();
            this.lblAIlevel = new System.Windows.Forms.Label();
            this.tkbAIlevel = new System.Windows.Forms.TrackBar();
            this.lblAIlevelValue = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAIlevel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(78, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(78, 39);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(100, 20);
            this.tbNationality.TabIndex = 4;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(16, 42);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(56, 13);
            this.lblNationality.TabIndex = 3;
            this.lblNationality.Text = "Nationality";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(16, 69);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(23, 13);
            this.lblCar.TabIndex = 5;
            this.lblCar.Text = "Car";
            // 
            // cbCar
            // 
            this.cbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(78, 66);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(100, 21);
            this.cbCar.TabIndex = 6;
            this.cbCar.SelectionChangeCommitted += new System.EventHandler(this.cbCar_SelectionChangeCommitted);
            // 
            // cbSkin
            // 
            this.cbSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkin.FormattingEnabled = true;
            this.cbSkin.Location = new System.Drawing.Point(78, 93);
            this.cbSkin.Name = "cbSkin";
            this.cbSkin.Size = new System.Drawing.Size(100, 21);
            this.cbSkin.TabIndex = 8;
            // 
            // lblSkin
            // 
            this.lblSkin.AutoSize = true;
            this.lblSkin.Location = new System.Drawing.Point(16, 96);
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
            this.cbSetup.Location = new System.Drawing.Point(78, 120);
            this.cbSetup.Name = "cbSetup";
            this.cbSetup.Size = new System.Drawing.Size(100, 21);
            this.cbSetup.TabIndex = 10;
            // 
            // lblSetup
            // 
            this.lblSetup.AutoSize = true;
            this.lblSetup.Location = new System.Drawing.Point(16, 123);
            this.lblSetup.Name = "lblSetup";
            this.lblSetup.Size = new System.Drawing.Size(35, 13);
            this.lblSetup.TabIndex = 9;
            this.lblSetup.Text = "Setup";
            // 
            // lblAIlevel
            // 
            this.lblAIlevel.AutoSize = true;
            this.lblAIlevel.Location = new System.Drawing.Point(16, 150);
            this.lblAIlevel.Name = "lblAIlevel";
            this.lblAIlevel.Size = new System.Drawing.Size(46, 13);
            this.lblAIlevel.TabIndex = 11;
            this.lblAIlevel.Text = "AI Level";
            // 
            // tkbAIlevel
            // 
            this.tkbAIlevel.Location = new System.Drawing.Point(78, 147);
            this.tkbAIlevel.Maximum = 100;
            this.tkbAIlevel.Minimum = 80;
            this.tkbAIlevel.Name = "tkbAIlevel";
            this.tkbAIlevel.Size = new System.Drawing.Size(104, 45);
            this.tkbAIlevel.TabIndex = 12;
            this.tkbAIlevel.Value = 80;
            this.tkbAIlevel.Scroll += new System.EventHandler(this.tkbAIlevel_Scroll);
            // 
            // lblAIlevelValue
            // 
            this.lblAIlevelValue.AutoSize = true;
            this.lblAIlevelValue.Location = new System.Drawing.Point(189, 150);
            this.lblAIlevelValue.Name = "lblAIlevelValue";
            this.lblAIlevelValue.Size = new System.Drawing.Size(19, 13);
            this.lblAIlevelValue.TabIndex = 13;
            this.lblAIlevelValue.Text = "80";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ACCGNewOpponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAIlevelValue);
            this.Controls.Add(this.tkbAIlevel);
            this.Controls.Add(this.lblAIlevel);
            this.Controls.Add(this.cbSetup);
            this.Controls.Add(this.lblSetup);
            this.Controls.Add(this.cbSkin);
            this.Controls.Add(this.lblSkin);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.tbNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ACCGNewOpponentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Opponent";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ACCGNewOpponentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbAIlevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.ComboBox cbSkin;
        private System.Windows.Forms.Label lblSkin;
        private System.Windows.Forms.ComboBox cbSetup;
        private System.Windows.Forms.Label lblSetup;
        private System.Windows.Forms.Label lblAIlevel;
        private System.Windows.Forms.TrackBar tkbAIlevel;
        private System.Windows.Forms.Label lblAIlevelValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        public static Car opponent_car { get; set; }
    }
}