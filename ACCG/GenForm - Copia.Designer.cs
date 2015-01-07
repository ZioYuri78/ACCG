namespace ACCG
{
    partial class GenForm
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
            this.tbLogArea = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLogArea
            // 
            this.tbLogArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogArea.Location = new System.Drawing.Point(0, 0);
            this.tbLogArea.Multiline = true;
            this.tbLogArea.Name = "tbLogArea";
            this.tbLogArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLogArea.Size = new System.Drawing.Size(417, 191);
            this.tbLogArea.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOk.Location = new System.Drawing.Point(0, 197);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(417, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 220);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbLogArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbLogArea;
        public System.Windows.Forms.Button btnOk;
        delegate void SetTextCallback(string _text);

        
    }
}