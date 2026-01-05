
namespace LibraryMS2.UserControls
{
    partial class HelpEvents
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
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.lblRER = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Font = new System.Drawing.Font("Century Gothic", 34F);
            this.lblEventTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.lblEventTitle.Location = new System.Drawing.Point(134, 260);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(564, 56);
            this.lblEventTitle.TabIndex = 32;
            this.lblEventTitle.Text = "How to ADD new events";
            // 
            // lblRER
            // 
            this.lblRER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRER.AutoSize = true;
            this.lblRER.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblRER.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRER.Location = new System.Drawing.Point(140, 316);
            this.lblRER.Name = "lblRER";
            this.lblRER.Size = new System.Drawing.Size(845, 24);
            this.lblRER.TabIndex = 31;
            this.lblRER.Text = "Click on the button written CLEAR  + Then enter event details + Lastly click on A" +
    "DD";
            this.lblRER.Click += new System.EventHandler(this.lblRER_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::LibraryMS2.Properties.Resources.ADD;
            this.pictureBox1.Location = new System.Drawing.Point(144, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1160, 375);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // HelpEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEventTitle);
            this.Controls.Add(this.lblRER);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HelpEvents";
            this.Size = new System.Drawing.Size(1448, 967);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.Label lblRER;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
