
namespace LibraryMS2.UserControls
{
    partial class HelpBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRER = new System.Windows.Forms.Label();
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRER
            // 
            this.lblRER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRER.AutoSize = true;
            this.lblRER.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblRER.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRER.Location = new System.Drawing.Point(146, 299);
            this.lblRER.Name = "lblRER";
            this.lblRER.Size = new System.Drawing.Size(837, 24);
            this.lblRER.TabIndex = 28;
            this.lblRER.Text = "Click on the button written CLEAR  + Then enter book details + Lastly click on AD" +
    "D";
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Font = new System.Drawing.Font("Century Gothic", 34F);
            this.lblEventTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.lblEventTitle.Location = new System.Drawing.Point(140, 243);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(531, 56);
            this.lblEventTitle.TabIndex = 29;
            this.lblEventTitle.Text = "How to ADD new book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::LibraryMS2.Properties.Resources.ADD;
            this.pictureBox1.Location = new System.Drawing.Point(149, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1160, 375);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // HelpBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEventTitle);
            this.Controls.Add(this.lblRER);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HelpBooks";
            this.Size = new System.Drawing.Size(1448, 967);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRER;
        private System.Windows.Forms.Label lblEventTitle;
    }
}
