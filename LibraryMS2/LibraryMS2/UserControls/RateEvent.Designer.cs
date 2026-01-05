
namespace LibraryMS2.UserControls
{
    partial class RateEvent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label reader_NameLabel;
            System.Windows.Forms.Label event_TitleLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRating = new System.Windows.Forms.Label();
            this.ratingTrackBar = new System.Windows.Forms.TrackBar();
            this.reader_NameComboBox = new System.Windows.Forms.ComboBox();
            this.event_TitleComboBox = new System.Windows.Forms.ComboBox();
            this.rEADERATEVENTASCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.rEADERATEVENTASCDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEADERATEVENTASCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryMS_DatabaseDataSet = new LibraryMS2.LibraryMS_DatabaseDataSet();
            this.btnCloseRateEvent = new System.Windows.Forms.Button();
            this.rEADERATEVENTASCTableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.READERATEVENTASCTableAdapter();
            this.tableAdapterManager = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager();
            ratingLabel = new System.Windows.Forms.Label();
            reader_NameLabel = new System.Windows.Forms.Label();
            event_TitleLabel = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADERATEVENTASCBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rEADERATEVENTASCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADERATEVENTASCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingLabel
            // 
            ratingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            ratingLabel.Location = new System.Drawing.Point(448, 165);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(66, 21);
            ratingLabel.TabIndex = 4;
            ratingLabel.Text = "Rating:";
            ratingLabel.Click += new System.EventHandler(this.ratingLabel_Click);
            // 
            // reader_NameLabel
            // 
            reader_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            reader_NameLabel.AutoSize = true;
            reader_NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            reader_NameLabel.Location = new System.Drawing.Point(448, 108);
            reader_NameLabel.Name = "reader_NameLabel";
            reader_NameLabel.Size = new System.Drawing.Size(123, 21);
            reader_NameLabel.TabIndex = 2;
            reader_NameLabel.Text = "Reader Name:";
            // 
            // event_TitleLabel
            // 
            event_TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            event_TitleLabel.AutoSize = true;
            event_TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            event_TitleLabel.Location = new System.Drawing.Point(448, 61);
            event_TitleLabel.Name = "event_TitleLabel";
            event_TitleLabel.Size = new System.Drawing.Size(95, 21);
            event_TitleLabel.TabIndex = 0;
            event_TitleLabel.Text = "Event Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table of Event Ratings";
            // 
            // lblTopSearchBarPanel
            // 
            this.lblTopSearchBarPanel.AutoSize = true;
            this.lblTopSearchBarPanel.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.lblTopSearchBarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopSearchBarPanel.Location = new System.Drawing.Point(3, 12);
            this.lblTopSearchBarPanel.Name = "lblTopSearchBarPanel";
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(135, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Rate Event";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTopSearchBarPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(391, 54);
            this.panel6.TabIndex = 12;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPrint.Location = new System.Drawing.Point(435, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 36);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPrint);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(801, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 54);
            this.panel7.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1385, 54);
            this.panel4.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 391);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1385, 54);
            this.panel5.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdd.Location = new System.Drawing.Point(627, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Rating";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblRating);
            this.panel3.Controls.Add(this.ratingTrackBar);
            this.panel3.Controls.Add(this.reader_NameComboBox);
            this.panel3.Controls.Add(this.event_TitleComboBox);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(ratingLabel);
            this.panel3.Controls.Add(reader_NameLabel);
            this.panel3.Controls.Add(event_TitleLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1385, 337);
            this.panel3.TabIndex = 32;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblRating
            // 
            this.lblRating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(829, 171);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(13, 13);
            this.lblRating.TabIndex = 12;
            this.lblRating.Text = "0";
            this.lblRating.Click += new System.EventHandler(this.lblRating_Click);
            // 
            // ratingTrackBar
            // 
            this.ratingTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ratingTrackBar.LargeChange = 1;
            this.ratingTrackBar.Location = new System.Drawing.Point(627, 163);
            this.ratingTrackBar.Maximum = 5;
            this.ratingTrackBar.Name = "ratingTrackBar";
            this.ratingTrackBar.Size = new System.Drawing.Size(162, 45);
            this.ratingTrackBar.TabIndex = 11;
            this.ratingTrackBar.Scroll += new System.EventHandler(this.ratingTrackBar_Scroll_1);
            // 
            // reader_NameComboBox
            // 
            this.reader_NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reader_NameComboBox.FormattingEnabled = true;
            this.reader_NameComboBox.Location = new System.Drawing.Point(627, 113);
            this.reader_NameComboBox.Name = "reader_NameComboBox";
            this.reader_NameComboBox.Size = new System.Drawing.Size(270, 21);
            this.reader_NameComboBox.TabIndex = 10;
            // 
            // event_TitleComboBox
            // 
            this.event_TitleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.event_TitleComboBox.FormattingEnabled = true;
            this.event_TitleComboBox.Location = new System.Drawing.Point(627, 59);
            this.event_TitleComboBox.Name = "event_TitleComboBox";
            this.event_TitleComboBox.Size = new System.Drawing.Size(270, 21);
            this.event_TitleComboBox.TabIndex = 9;
            this.event_TitleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rEADERATEVENTASCBindingSource
            // 
            this.rEADERATEVENTASCBindingSource.DataMember = "READERATEVENTASC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rEADERATEVENTASCDataGridView);
            this.panel2.Controls.Add(this.btnCloseRateEvent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1385, 361);
            this.panel2.TabIndex = 31;
            // 
            // rEADERATEVENTASCDataGridView
            // 
            this.rEADERATEVENTASCDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rEADERATEVENTASCDataGridView.AutoGenerateColumns = false;
            this.rEADERATEVENTASCDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rEADERATEVENTASCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rEADERATEVENTASCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.rEADERATEVENTASCDataGridView.DataSource = this.rEADERATEVENTASCBindingSource1;
            this.rEADERATEVENTASCDataGridView.Location = new System.Drawing.Point(107, 30);
            this.rEADERATEVENTASCDataGridView.Name = "rEADERATEVENTASCDataGridView";
            this.rEADERATEVENTASCDataGridView.Size = new System.Drawing.Size(1149, 257);
            this.rEADERATEVENTASCDataGridView.TabIndex = 37;
            this.rEADERATEVENTASCDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rEADERATEVENTASCDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Event Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Event Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Reader_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Reader_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // rEADERATEVENTASCBindingSource1
            // 
            this.rEADERATEVENTASCBindingSource1.DataMember = "READERATEVENTASC";
            this.rEADERATEVENTASCBindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
            // 
            // libraryMS_DatabaseDataSet
            // 
            this.libraryMS_DatabaseDataSet.DataSetName = "LibraryMS_DatabaseDataSet";
            this.libraryMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCloseRateEvent
            // 
            this.btnCloseRateEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCloseRateEvent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseRateEvent.FlatAppearance.BorderSize = 0;
            this.btnCloseRateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseRateEvent.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCloseRateEvent.Location = new System.Drawing.Point(1096, 305);
            this.btnCloseRateEvent.Name = "btnCloseRateEvent";
            this.btnCloseRateEvent.Size = new System.Drawing.Size(160, 36);
            this.btnCloseRateEvent.TabIndex = 37;
            this.btnCloseRateEvent.Text = "Close";
            this.btnCloseRateEvent.UseVisualStyleBackColor = false;
            this.btnCloseRateEvent.Click += new System.EventHandler(this.btnCloseRateEvent_Click);
            // 
            // rEADERATEVENTASCTableAdapter
            // 
            this.rEADERATEVENTASCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTHORBOOKTableAdapter = null;
            this.tableAdapterManager.AUTHORTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EVENTREADERTableAdapter = null;
            this.tableAdapterManager.EVENTSTableAdapter = null;
            this.tableAdapterManager.READERTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // RateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "RateEvent";
            this.Size = new System.Drawing.Size(1385, 827);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADERATEVENTASCBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rEADERATEVENTASCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADERATEVENTASCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource rEADERATEVENTASCBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCloseRateEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rEADERATEVENTASCBindingSource1;
        private LibraryMS_DatabaseDataSet libraryMS_DatabaseDataSet;
        private LibraryMS_DatabaseDataSetTableAdapters.READERATEVENTASCTableAdapter rEADERATEVENTASCTableAdapter;
        private LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox reader_NameComboBox;
        private System.Windows.Forms.ComboBox event_TitleComboBox;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TrackBar ratingTrackBar;
        private System.Windows.Forms.DataGridView rEADERATEVENTASCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
