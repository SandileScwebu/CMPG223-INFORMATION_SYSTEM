
namespace LibraryMS2.UserControls
{
    partial class Event
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
            System.Windows.Forms.Label book_TitleLabel;
            System.Windows.Forms.Label event_TitleLabel;
            System.Windows.Forms.Label available_SeatsLabel;
            System.Windows.Forms.Label event_DetailsLabel;
            System.Windows.Forms.Label event_DateLabel;
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveBooksForm = new System.Windows.Forms.Button();
            this.btnDeleteBooksForm = new System.Windows.Forms.Button();
            this.btnAddBooksForm = new System.Windows.Forms.Button();
            this.aLLEVENSNOIDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.aLLEVENSNOIDSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLEVENSNOIDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryMS_DatabaseDataSet = new LibraryMS2.LibraryMS_DatabaseDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLastRecord = new System.Windows.Forms.Button();
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.btnScroll2BooksForm = new System.Windows.Forms.Button();
            this.btnScrollBooksForm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.event_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.available_SeatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.book_TitleComboBox = new System.Windows.Forms.ComboBox();
            this.event_DetailsTextBox = new System.Windows.Forms.TextBox();
            this.event_TitleComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.aLLEVENSNOIDSTableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.ALLEVENSNOIDSTableAdapter();
            this.tableAdapterManager = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager();
            book_TitleLabel = new System.Windows.Forms.Label();
            event_TitleLabel = new System.Windows.Forms.Label();
            available_SeatsLabel = new System.Windows.Forms.Label();
            event_DetailsLabel = new System.Windows.Forms.Label();
            event_DateLabel = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLLEVENSNOIDSBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLLEVENSNOIDSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLEVENSNOIDSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.available_SeatsNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // book_TitleLabel
            // 
            book_TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            book_TitleLabel.AutoSize = true;
            book_TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            book_TitleLabel.Location = new System.Drawing.Point(498, 167);
            book_TitleLabel.Name = "book_TitleLabel";
            book_TitleLabel.Size = new System.Drawing.Size(86, 21);
            book_TitleLabel.TabIndex = 9;
            book_TitleLabel.Text = "Book Title:";
            // 
            // event_TitleLabel
            // 
            event_TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            event_TitleLabel.AutoSize = true;
            event_TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            event_TitleLabel.Location = new System.Drawing.Point(498, 27);
            event_TitleLabel.Name = "event_TitleLabel";
            event_TitleLabel.Size = new System.Drawing.Size(45, 21);
            event_TitleLabel.TabIndex = 1;
            event_TitleLabel.Text = "Title:";
            // 
            // available_SeatsLabel
            // 
            available_SeatsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            available_SeatsLabel.AutoSize = true;
            available_SeatsLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            available_SeatsLabel.Location = new System.Drawing.Point(498, 134);
            available_SeatsLabel.Name = "available_SeatsLabel";
            available_SeatsLabel.Size = new System.Drawing.Size(135, 21);
            available_SeatsLabel.TabIndex = 7;
            available_SeatsLabel.Text = "Available Seats:";
            // 
            // event_DetailsLabel
            // 
            event_DetailsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            event_DetailsLabel.AutoSize = true;
            event_DetailsLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            event_DetailsLabel.Location = new System.Drawing.Point(498, 60);
            event_DetailsLabel.Name = "event_DetailsLabel";
            event_DetailsLabel.Size = new System.Drawing.Size(66, 21);
            event_DetailsLabel.TabIndex = 3;
            event_DetailsLabel.Text = "Details:";
            // 
            // event_DateLabel
            // 
            event_DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            event_DateLabel.AutoSize = true;
            event_DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            event_DateLabel.Location = new System.Drawing.Point(498, 97);
            event_DateLabel.Name = "event_DateLabel";
            event_DateLabel.Size = new System.Drawing.Size(54, 21);
            event_DateLabel.TabIndex = 5;
            event_DateLabel.Text = "Date:";
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
            // lblTopSearchBarPanel
            // 
            this.lblTopSearchBarPanel.AutoSize = true;
            this.lblTopSearchBarPanel.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.lblTopSearchBarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopSearchBarPanel.Location = new System.Drawing.Point(3, 12);
            this.lblTopSearchBarPanel.Name = "lblTopSearchBarPanel";
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(321, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Maintain Event Information";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(843, 194);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveBooksForm
            // 
            this.btnSaveBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveBooksForm.FlatAppearance.BorderSize = 0;
            this.btnSaveBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSaveBooksForm.Location = new System.Drawing.Point(715, 39);
            this.btnSaveBooksForm.Name = "btnSaveBooksForm";
            this.btnSaveBooksForm.Size = new System.Drawing.Size(182, 36);
            this.btnSaveBooksForm.TabIndex = 8;
            this.btnSaveBooksForm.Text = "Update";
            this.btnSaveBooksForm.UseVisualStyleBackColor = false;
            this.btnSaveBooksForm.Click += new System.EventHandler(this.btnSaveBooksForm_Click);
            // 
            // btnDeleteBooksForm
            // 
            this.btnDeleteBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteBooksForm.FlatAppearance.BorderSize = 0;
            this.btnDeleteBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDeleteBooksForm.Location = new System.Drawing.Point(966, 39);
            this.btnDeleteBooksForm.Name = "btnDeleteBooksForm";
            this.btnDeleteBooksForm.Size = new System.Drawing.Size(196, 36);
            this.btnDeleteBooksForm.TabIndex = 7;
            this.btnDeleteBooksForm.Text = "Delete";
            this.btnDeleteBooksForm.UseVisualStyleBackColor = false;
            this.btnDeleteBooksForm.Click += new System.EventHandler(this.btnDeleteBooksForm_Click);
            // 
            // btnAddBooksForm
            // 
            this.btnAddBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddBooksForm.FlatAppearance.BorderSize = 0;
            this.btnAddBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAddBooksForm.Location = new System.Drawing.Point(408, 39);
            this.btnAddBooksForm.Name = "btnAddBooksForm";
            this.btnAddBooksForm.Size = new System.Drawing.Size(189, 36);
            this.btnAddBooksForm.TabIndex = 6;
            this.btnAddBooksForm.Text = "Add ";
            this.btnAddBooksForm.UseVisualStyleBackColor = false;
            this.btnAddBooksForm.Click += new System.EventHandler(this.btnAddBooksForm_Click);
            // 
            // aLLEVENSNOIDSBindingSource
            // 
            this.aLLEVENSNOIDSBindingSource.DataMember = "ALLEVENSNOIDS";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.aLLEVENSNOIDSDataGridView);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnLastRecord);
            this.panel3.Controls.Add(this.btnFirstRecord);
            this.panel3.Controls.Add(this.btnScroll2BooksForm);
            this.panel3.Controls.Add(this.btnScrollBooksForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 443);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1448, 362);
            this.panel3.TabIndex = 30;
            // 
            // aLLEVENSNOIDSDataGridView
            // 
            this.aLLEVENSNOIDSDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLLEVENSNOIDSDataGridView.AutoGenerateColumns = false;
            this.aLLEVENSNOIDSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aLLEVENSNOIDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aLLEVENSNOIDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.aLLEVENSNOIDSDataGridView.DataSource = this.aLLEVENSNOIDSBindingSource1;
            this.aLLEVENSNOIDSDataGridView.Location = new System.Drawing.Point(131, 66);
            this.aLLEVENSNOIDSDataGridView.MultiSelect = false;
            this.aLLEVENSNOIDSDataGridView.Name = "aLLEVENSNOIDSDataGridView";
            this.aLLEVENSNOIDSDataGridView.Size = new System.Drawing.Size(1151, 220);
            this.aLLEVENSNOIDSDataGridView.TabIndex = 36;
            this.aLLEVENSNOIDSDataGridView.SelectionChanged += new System.EventHandler(this.aLLEVENSNOIDSDataGridView_SelectionChanged_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Event Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Event Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Event Details";
            this.dataGridViewTextBoxColumn2.HeaderText = "Event Details";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Event Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Event Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Available Seats";
            this.dataGridViewTextBoxColumn4.HeaderText = "Available Seats";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Book Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "Book Title";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // aLLEVENSNOIDSBindingSource1
            // 
            this.aLLEVENSNOIDSBindingSource1.DataMember = "ALLEVENSNOIDS";
            this.aLLEVENSNOIDSBindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
            // 
            // libraryMS_DatabaseDataSet
            // 
            this.libraryMS_DatabaseDataSet.DataSetName = "LibraryMS_DatabaseDataSet";
            this.libraryMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(1122, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 36);
            this.button2.TabIndex = 36;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLastRecord
            // 
            this.btnLastRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLastRecord.FlatAppearance.BorderSize = 0;
            this.btnLastRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastRecord.Location = new System.Drawing.Point(210, 297);
            this.btnLastRecord.Name = "btnLastRecord";
            this.btnLastRecord.Size = new System.Drawing.Size(23, 24);
            this.btnLastRecord.TabIndex = 35;
            this.btnLastRecord.UseVisualStyleBackColor = true;
            // 
            // btnFirstRecord
            // 
            this.btnFirstRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFirstRecord.FlatAppearance.BorderSize = 0;
            this.btnFirstRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstRecord.Location = new System.Drawing.Point(181, 297);
            this.btnFirstRecord.Name = "btnFirstRecord";
            this.btnFirstRecord.Size = new System.Drawing.Size(23, 24);
            this.btnFirstRecord.TabIndex = 34;
            this.btnFirstRecord.UseVisualStyleBackColor = true;
            // 
            // btnScroll2BooksForm
            // 
            this.btnScroll2BooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnScroll2BooksForm.FlatAppearance.BorderSize = 0;
            this.btnScroll2BooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScroll2BooksForm.Location = new System.Drawing.Point(267, 297);
            this.btnScroll2BooksForm.Name = "btnScroll2BooksForm";
            this.btnScroll2BooksForm.Size = new System.Drawing.Size(23, 24);
            this.btnScroll2BooksForm.TabIndex = 33;
            this.btnScroll2BooksForm.UseVisualStyleBackColor = true;
            // 
            // btnScrollBooksForm
            // 
            this.btnScrollBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnScrollBooksForm.FlatAppearance.BorderSize = 0;
            this.btnScrollBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrollBooksForm.Location = new System.Drawing.Point(239, 297);
            this.btnScrollBooksForm.Name = "btnScrollBooksForm";
            this.btnScrollBooksForm.Size = new System.Drawing.Size(23, 24);
            this.btnScrollBooksForm.TabIndex = 32;
            this.btnScrollBooksForm.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveBooksForm);
            this.panel4.Controls.Add(this.btnDeleteBooksForm);
            this.panel4.Controls.Add(this.btnAddBooksForm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1448, 102);
            this.panel4.TabIndex = 31;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table of Events Information";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(456, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 36);
            this.button4.TabIndex = 12;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.event_DateDateTimePicker);
            this.panel2.Controls.Add(this.available_SeatsNumericUpDown);
            this.panel2.Controls.Add(this.book_TitleComboBox);
            this.panel2.Controls.Add(this.event_DetailsTextBox);
            this.panel2.Controls.Add(this.event_TitleComboBox);
            this.panel2.Controls.Add(book_TitleLabel);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(event_TitleLabel);
            this.panel2.Controls.Add(available_SeatsLabel);
            this.panel2.Controls.Add(event_DetailsLabel);
            this.panel2.Controls.Add(event_DateLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1448, 233);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // event_DateDateTimePicker
            // 
            this.event_DateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.event_DateDateTimePicker.Location = new System.Drawing.Point(715, 97);
            this.event_DateDateTimePicker.Name = "event_DateDateTimePicker";
            this.event_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.event_DateDateTimePicker.TabIndex = 15;
            // 
            // available_SeatsNumericUpDown
            // 
            this.available_SeatsNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.available_SeatsNumericUpDown.Location = new System.Drawing.Point(715, 134);
            this.available_SeatsNumericUpDown.Name = "available_SeatsNumericUpDown";
            this.available_SeatsNumericUpDown.Size = new System.Drawing.Size(98, 20);
            this.available_SeatsNumericUpDown.TabIndex = 14;
            // 
            // book_TitleComboBox
            // 
            this.book_TitleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.book_TitleComboBox.FormattingEnabled = true;
            this.book_TitleComboBox.Location = new System.Drawing.Point(715, 167);
            this.book_TitleComboBox.Name = "book_TitleComboBox";
            this.book_TitleComboBox.Size = new System.Drawing.Size(182, 21);
            this.book_TitleComboBox.TabIndex = 13;
            // 
            // event_DetailsTextBox
            // 
            this.event_DetailsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.event_DetailsTextBox.Location = new System.Drawing.Point(713, 63);
            this.event_DetailsTextBox.Name = "event_DetailsTextBox";
            this.event_DetailsTextBox.Size = new System.Drawing.Size(202, 20);
            this.event_DetailsTextBox.TabIndex = 12;
            // 
            // event_TitleComboBox
            // 
            this.event_TitleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.event_TitleComboBox.FormattingEnabled = true;
            this.event_TitleComboBox.Location = new System.Drawing.Point(713, 27);
            this.event_TitleComboBox.Name = "event_TitleComboBox";
            this.event_TitleComboBox.Size = new System.Drawing.Size(202, 21);
            this.event_TitleComboBox.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 54);
            this.panel1.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnRefreshTable);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(864, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 54);
            this.panel7.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 389);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1448, 54);
            this.panel5.TabIndex = 32;
            // 
            // aLLEVENSNOIDSTableAdapter
            // 
            this.aLLEVENSNOIDSTableAdapter.ClearBeforeFill = true;
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
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Event";
            this.Size = new System.Drawing.Size(1448, 967);
            this.Load += new System.EventHandler(this.Event_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLLEVENSNOIDSBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aLLEVENSNOIDSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLEVENSNOIDSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.available_SeatsNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveBooksForm;
        private System.Windows.Forms.Button btnDeleteBooksForm;
        private System.Windows.Forms.Button btnAddBooksForm;
        private System.Windows.Forms.BindingSource aLLEVENSNOIDSBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLastRecord;
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnScroll2BooksForm;
        private System.Windows.Forms.Button btnScrollBooksForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.BindingSource aLLEVENSNOIDSBindingSource1;
        private LibraryMS_DatabaseDataSet libraryMS_DatabaseDataSet;
        private LibraryMS_DatabaseDataSetTableAdapters.ALLEVENSNOIDSTableAdapter aLLEVENSNOIDSTableAdapter;
        private LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker event_DateDateTimePicker;
        private System.Windows.Forms.NumericUpDown available_SeatsNumericUpDown;
        private System.Windows.Forms.ComboBox book_TitleComboBox;
        private System.Windows.Forms.TextBox event_DetailsTextBox;
        private System.Windows.Forms.ComboBox event_TitleComboBox;
        private System.Windows.Forms.DataGridView aLLEVENSNOIDSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
