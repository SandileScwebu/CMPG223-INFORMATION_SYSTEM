
namespace LibraryMS2.UserControls
{
    partial class HomeSearch
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
            this.btnSearchHD = new System.Windows.Forms.Button();
            this.cmbDashboardSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchHD
            // 
            this.btnSearchHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchHD.FlatAppearance.BorderSize = 0;
            this.btnSearchHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchHD.Image = global::LibraryMS2.Properties.Resources.icons8_search_24;
            this.btnSearchHD.Location = new System.Drawing.Point(819, 406);
            this.btnSearchHD.Name = "btnSearchHD";
            this.btnSearchHD.Size = new System.Drawing.Size(32, 30);
            this.btnSearchHD.TabIndex = 14;
            this.btnSearchHD.UseVisualStyleBackColor = true;
            this.btnSearchHD.Click += new System.EventHandler(this.btnSearchHD_Click);
            // 
            // cmbDashboardSearch
            // 
            this.cmbDashboardSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDashboardSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDashboardSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDashboardSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbDashboardSearch.FormattingEnabled = true;
            this.cmbDashboardSearch.Location = new System.Drawing.Point(415, 412);
            this.cmbDashboardSearch.Name = "cmbDashboardSearch";
            this.cmbDashboardSearch.Size = new System.Drawing.Size(398, 21);
            this.cmbDashboardSearch.TabIndex = 13;
            this.cmbDashboardSearch.Text = "SEARCH AUTHOR, READER, EVENT OR BOOK";
            this.cmbDashboardSearch.MouseEnter += new System.EventHandler(this.cmbDashboardSearch_MouseEnter);
            this.cmbDashboardSearch.MouseLeave += new System.EventHandler(this.cmbDashboardSearch_MouseLeave);
            this.cmbDashboardSearch.MouseHover += new System.EventHandler(this.cmbDashboardSearch_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.label1.Location = new System.Drawing.Point(526, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "LibraryMS";
            // 
            // HomeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnSearchHD);
            this.Controls.Add(this.cmbDashboardSearch);
            this.Controls.Add(this.label1);
            this.Name = "HomeSearch";
            this.Size = new System.Drawing.Size(1354, 840);
            this.Load += new System.EventHandler(this.HomeSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchHD;
        private System.Windows.Forms.ComboBox cmbDashboardSearch;
        private System.Windows.Forms.Label label1;
    }
}
