
namespace LibraryMS2.UserControls
{
    partial class AttendEvent
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
            System.Windows.Forms.Label event_TitleLabel;
            System.Windows.Forms.Label readerLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.getEventReader02DataGridView = new System.Windows.Forms.DataGridView();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.getEventReader02BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryMS_DatabaseDataSet = new LibraryMS2.LibraryMS_DatabaseDataSet();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.readerComboBox = new System.Windows.Forms.ComboBox();
            this.event_TitleComboBox = new System.Windows.Forms.ComboBox();
            this.btnAttendEvent = new System.Windows.Forms.Button();
            this.btnWontAttend = new System.Windows.Forms.Button();
            this.getEventReader02TableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.GetEventReader02TableAdapter();
            this.tableAdapterManager = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.getEventReader02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            event_TitleLabel = new System.Windows.Forms.Label();
            readerLabel = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getEventReader02DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEventReader02BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getEventReader02BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // event_TitleLabel
            // 
            event_TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            event_TitleLabel.AutoSize = true;
            event_TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            event_TitleLabel.Location = new System.Drawing.Point(475, 43);
            event_TitleLabel.Name = "event_TitleLabel";
            event_TitleLabel.Size = new System.Drawing.Size(95, 21);
            event_TitleLabel.TabIndex = 4;
            event_TitleLabel.Text = "Event Title:";
            // 
            // readerLabel
            // 
            readerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            readerLabel.AutoSize = true;
            readerLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            readerLabel.Location = new System.Drawing.Point(475, 102);
            readerLabel.Name = "readerLabel";
            readerLabel.Size = new System.Drawing.Size(71, 21);
            readerLabel.TabIndex = 5;
            readerLabel.Text = "Reader:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table of Events Attendees";
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefreshTable.FlatAppearance.BorderSize = 0;
            this.btnRefreshTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTable.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRefreshTable.Location = new System.Drawing.Point(112, 10);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(171, 36);
            this.btnRefreshTable.TabIndex = 10;
            this.btnRefreshTable.UseVisualStyleBackColor = false;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnRefreshTable);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(872, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 59);
            this.panel7.TabIndex = 15;
            // 
            // lblTopSearchBarPanel
            // 
            this.lblTopSearchBarPanel.AutoSize = true;
            this.lblTopSearchBarPanel.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.lblTopSearchBarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopSearchBarPanel.Location = new System.Drawing.Point(3, 12);
            this.lblTopSearchBarPanel.Name = "lblTopSearchBarPanel";
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(160, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Attend Event";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1456, 59);
            this.panel2.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(1097, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 36);
            this.button2.TabIndex = 37;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.getEventReader02DataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 369);
            this.panel1.TabIndex = 34;
            // 
            // getEventReader02DataGridView
            // 
            this.getEventReader02DataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.getEventReader02DataGridView.AutoGenerateColumns = false;
            this.getEventReader02DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getEventReader02DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getEventReader02DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIDDataGridViewTextBoxColumn,
            this.eventTitleDataGridViewTextBoxColumn,
            this.readerIDDataGridViewTextBoxColumn,
            this.readerDataGridViewTextBoxColumn,
            this.attendedDataGridViewCheckBoxColumn});
            this.getEventReader02DataGridView.DataSource = this.getEventReader02BindingSource1;
            this.getEventReader02DataGridView.Location = new System.Drawing.Point(157, 29);
            this.getEventReader02DataGridView.Name = "getEventReader02DataGridView";
            this.getEventReader02DataGridView.Size = new System.Drawing.Size(1100, 266);
            this.getEventReader02DataGridView.TabIndex = 3;
            this.getEventReader02DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getEventReader02DataGridView_CellContentClick);
            this.getEventReader02DataGridView.SelectionChanged += new System.EventHandler(this.getEventReader02DataGridView_SelectionChanged);
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "Event_ID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "Event_ID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            // 
            // eventTitleDataGridViewTextBoxColumn
            // 
            this.eventTitleDataGridViewTextBoxColumn.DataPropertyName = "Event Title";
            this.eventTitleDataGridViewTextBoxColumn.HeaderText = "Event Title";
            this.eventTitleDataGridViewTextBoxColumn.Name = "eventTitleDataGridViewTextBoxColumn";
            // 
            // readerIDDataGridViewTextBoxColumn
            // 
            this.readerIDDataGridViewTextBoxColumn.DataPropertyName = "Reader_ID";
            this.readerIDDataGridViewTextBoxColumn.HeaderText = "Reader_ID";
            this.readerIDDataGridViewTextBoxColumn.Name = "readerIDDataGridViewTextBoxColumn";
            // 
            // readerDataGridViewTextBoxColumn
            // 
            this.readerDataGridViewTextBoxColumn.DataPropertyName = "Reader";
            this.readerDataGridViewTextBoxColumn.HeaderText = "Reader";
            this.readerDataGridViewTextBoxColumn.Name = "readerDataGridViewTextBoxColumn";
            this.readerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendedDataGridViewCheckBoxColumn
            // 
            this.attendedDataGridViewCheckBoxColumn.DataPropertyName = "Attended";
            this.attendedDataGridViewCheckBoxColumn.HeaderText = "Attended";
            this.attendedDataGridViewCheckBoxColumn.Name = "attendedDataGridViewCheckBoxColumn";
            // 
            // getEventReader02BindingSource1
            // 
            this.getEventReader02BindingSource1.DataMember = "GetEventReader02";
            this.getEventReader02BindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
            // 
            // libraryMS_DatabaseDataSet
            // 
            this.libraryMS_DatabaseDataSet.DataSetName = "LibraryMS_DatabaseDataSet";
            this.libraryMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 306);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1456, 54);
            this.panel5.TabIndex = 37;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.readerComboBox);
            this.panel3.Controls.Add(this.event_TitleComboBox);
            this.panel3.Controls.Add(event_TitleLabel);
            this.panel3.Controls.Add(this.btnAttendEvent);
            this.panel3.Controls.Add(readerLabel);
            this.panel3.Controls.Add(this.btnWontAttend);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1456, 247);
            this.panel3.TabIndex = 36;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // readerComboBox
            // 
            this.readerComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.readerComboBox.FormattingEnabled = true;
            this.readerComboBox.Location = new System.Drawing.Point(624, 105);
            this.readerComboBox.Name = "readerComboBox";
            this.readerComboBox.Size = new System.Drawing.Size(274, 21);
            this.readerComboBox.TabIndex = 8;
            // 
            // event_TitleComboBox
            // 
            this.event_TitleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.event_TitleComboBox.FormattingEnabled = true;
            this.event_TitleComboBox.Location = new System.Drawing.Point(624, 34);
            this.event_TitleComboBox.Name = "event_TitleComboBox";
            this.event_TitleComboBox.Size = new System.Drawing.Size(274, 21);
            this.event_TitleComboBox.TabIndex = 7;
            this.event_TitleComboBox.SelectedIndexChanged += new System.EventHandler(this.event_TitleComboBox_SelectedIndexChanged);
            // 
            // btnAttendEvent
            // 
            this.btnAttendEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAttendEvent.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAttendEvent.Location = new System.Drawing.Point(427, 181);
            this.btnAttendEvent.Name = "btnAttendEvent";
            this.btnAttendEvent.Size = new System.Drawing.Size(189, 36);
            this.btnAttendEvent.TabIndex = 0;
            this.btnAttendEvent.Text = "ACCEPT";
            this.btnAttendEvent.UseVisualStyleBackColor = true;
            this.btnAttendEvent.Click += new System.EventHandler(this.btnAttendEvent_Click);
            // 
            // btnWontAttend
            // 
            this.btnWontAttend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWontAttend.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnWontAttend.Location = new System.Drawing.Point(868, 181);
            this.btnWontAttend.Name = "btnWontAttend";
            this.btnWontAttend.Size = new System.Drawing.Size(189, 36);
            this.btnWontAttend.TabIndex = 1;
            this.btnWontAttend.Text = "DECLINE";
            this.btnWontAttend.UseVisualStyleBackColor = true;
            this.btnWontAttend.Click += new System.EventHandler(this.btnWontAttend_Click);
            // 
            // getEventReader02TableAdapter
            // 
            this.getEventReader02TableAdapter.ClearBeforeFill = true;
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
            // getEventReader02BindingSource
            // 
            this.getEventReader02BindingSource.DataMember = "GetEventReader02";
            // 
            // AttendEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AttendEvent";
            this.Size = new System.Drawing.Size(1456, 879);
            this.Load += new System.EventHandler(this.AttendEvent_Load);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getEventReader02DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEventReader02BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getEventReader02BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView getEventReader02DataGridView;
        private System.Windows.Forms.BindingSource getEventReader02BindingSource;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn attendedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource getEventReader02BindingSource1;
        private LibraryMS_DatabaseDataSet libraryMS_DatabaseDataSet;
        private LibraryMS_DatabaseDataSetTableAdapters.GetEventReader02TableAdapter getEventReader02TableAdapter;
        private LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnAttendEvent;
        private System.Windows.Forms.Button btnWontAttend;
        private System.Windows.Forms.ComboBox event_TitleComboBox;
        private System.Windows.Forms.ComboBox readerComboBox;
    }
}
