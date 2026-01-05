
namespace LibraryMS2.UserControls
{
    partial class Review_Requests
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pbReviewReq = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReviewReq)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 59);
            this.panel2.TabIndex = 36;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTopSearchBarPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(391, 59);
            this.panel6.TabIndex = 12;
            // 
            // lblTopSearchBarPanel
            // 
            this.lblTopSearchBarPanel.AutoSize = true;
            this.lblTopSearchBarPanel.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.lblTopSearchBarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopSearchBarPanel.Location = new System.Drawing.Point(3, 12);
            this.lblTopSearchBarPanel.Name = "lblTopSearchBarPanel";
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(203, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Review Requests";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(769, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 59);
            this.panel7.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.btnNext);
            this.panel5.Controls.Add(this.btnPrev);
            this.panel5.Controls.Add(this.pbReviewReq);
            this.panel5.Location = new System.Drawing.Point(0, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1353, 679);
            this.panel5.TabIndex = 37;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button5.Location = new System.Drawing.Point(783, 570);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 36);
            this.button5.TabIndex = 14;
            this.button5.Text = "Decline";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button3.Location = new System.Drawing.Point(424, 570);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Accept";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNext.BackgroundImage = global::LibraryMS2.Properties.Resources.icons8_right_50;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNext.Location = new System.Drawing.Point(1042, 308);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 52);
            this.btnNext.TabIndex = 12;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrev.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrev.BackgroundImage = global::LibraryMS2.Properties.Resources.icons8_left_50;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPrev.Location = new System.Drawing.Point(261, 308);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(47, 52);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pbReviewReq
            // 
            this.pbReviewReq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbReviewReq.Location = new System.Drawing.Point(332, 73);
            this.pbReviewReq.Name = "pbReviewReq";
            this.pbReviewReq.Size = new System.Drawing.Size(680, 478);
            this.pbReviewReq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReviewReq.TabIndex = 0;
            this.pbReviewReq.TabStop = false;
            // 
            // Review_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Name = "Review_Requests";
            this.Size = new System.Drawing.Size(1353, 664);
            this.Load += new System.EventHandler(this.Review_Requests_Load);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReviewReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.PictureBox pbReviewReq;
    }
}
