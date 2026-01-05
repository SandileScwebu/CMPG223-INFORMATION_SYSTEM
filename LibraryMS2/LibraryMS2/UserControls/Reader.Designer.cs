
namespace LibraryMS2.UserControls
{
    partial class Reader
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.aLLREADERSNOIDSDataGridView = new System.Windows.Forms.DataGridView();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLREADERSNOIDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryMS_DatabaseDataSet = new LibraryMS2.LibraryMS_DatabaseDataSet();
            this.btnLastRecord = new System.Windows.Forms.Button();
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.btnScroll2BooksForm = new System.Windows.Forms.Button();
            this.btnScrollBooksForm = new System.Windows.Forms.Button();
            this.aLLREADERSNOIDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddBooksForm = new System.Windows.Forms.Button();
            this.btnDeleteBooksForm = new System.Windows.Forms.Button();
            this.btnSaveBooksForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderRadioButton2 = new System.Windows.Forms.RadioButton();
            this.genderRadioButton = new System.Windows.Forms.RadioButton();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lNameComboBox = new System.Windows.Forms.ComboBox();
            this.fNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.aLLREADERSNOIDSTableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.ALLREADERSNOIDSTableAdapter();
            this.tableAdapterManager = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager();
            emailLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLLREADERSNOIDSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLREADERSNOIDSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLREADERSNOIDSBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            emailLabel.Location = new System.Drawing.Point(530, 82);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 21);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            genderLabel.Location = new System.Drawing.Point(530, 110);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(74, 21);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Gender:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            date_of_BirthLabel.Location = new System.Drawing.Point(530, 176);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(111, 21);
            date_of_BirthLabel.TabIndex = 6;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // fNameLabel
            // 
            fNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            fNameLabel.AutoSize = true;
            fNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            fNameLabel.Location = new System.Drawing.Point(530, 14);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(58, 21);
            fNameLabel.TabIndex = 8;
            fNameLabel.Text = "Name";
            // 
            // lNameLabel
            // 
            lNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lNameLabel.AutoSize = true;
            lNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            lNameLabel.Location = new System.Drawing.Point(530, 46);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(79, 21);
            lNameLabel.TabIndex = 10;
            lNameLabel.Text = "Surname";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.aLLREADERSNOIDSDataGridView);
            this.panel3.Controls.Add(this.btnLastRecord);
            this.panel3.Controls.Add(this.btnFirstRecord);
            this.panel3.Controls.Add(this.btnScroll2BooksForm);
            this.panel3.Controls.Add(this.btnScrollBooksForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1450, 358);
            this.panel3.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(1126, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aLLREADERSNOIDSDataGridView
            // 
            this.aLLREADERSNOIDSDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLLREADERSNOIDSDataGridView.AutoGenerateColumns = false;
            this.aLLREADERSNOIDSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aLLREADERSNOIDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aLLREADERSNOIDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.readerNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.aLLREADERSNOIDSDataGridView.DataSource = this.aLLREADERSNOIDSBindingSource1;
            this.aLLREADERSNOIDSDataGridView.Location = new System.Drawing.Point(186, 20);
            this.aLLREADERSNOIDSDataGridView.Name = "aLLREADERSNOIDSDataGridView";
            this.aLLREADERSNOIDSDataGridView.Size = new System.Drawing.Size(1100, 266);
            this.aLLREADERSNOIDSDataGridView.TabIndex = 35;
            this.aLLREADERSNOIDSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aLLREADERSNOIDSDataGridView_CellContentClick);
            this.aLLREADERSNOIDSDataGridView.SelectionChanged += new System.EventHandler(this.aLLREADERSNOIDSDataGridView_SelectionChanged);
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // readerNameDataGridViewTextBoxColumn
            // 
            this.readerNameDataGridViewTextBoxColumn.DataPropertyName = "Reader Name";
            this.readerNameDataGridViewTextBoxColumn.HeaderText = "Reader Name";
            this.readerNameDataGridViewTextBoxColumn.Name = "readerNameDataGridViewTextBoxColumn";
            this.readerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // aLLREADERSNOIDSBindingSource1
            // 
            this.aLLREADERSNOIDSBindingSource1.DataMember = "ALLREADERSNOIDS";
            this.aLLREADERSNOIDSBindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
            // 
            // libraryMS_DatabaseDataSet
            // 
            this.libraryMS_DatabaseDataSet.DataSetName = "LibraryMS_DatabaseDataSet";
            this.libraryMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLastRecord
            // 
            this.btnLastRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLastRecord.FlatAppearance.BorderSize = 0;
            this.btnLastRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastRecord.Location = new System.Drawing.Point(194, 289);
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
            this.btnFirstRecord.Location = new System.Drawing.Point(223, 289);
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
            this.btnScroll2BooksForm.Location = new System.Drawing.Point(285, 289);
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
            this.btnScrollBooksForm.Location = new System.Drawing.Point(256, 289);
            this.btnScrollBooksForm.Name = "btnScrollBooksForm";
            this.btnScrollBooksForm.Size = new System.Drawing.Size(23, 24);
            this.btnScrollBooksForm.TabIndex = 32;
            this.btnScrollBooksForm.UseVisualStyleBackColor = true;
            // 
            // aLLREADERSNOIDSBindingSource
            // 
            this.aLLREADERSNOIDSBindingSource.DataMember = "ALLREADERSNOIDS";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 374);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1450, 54);
            this.panel5.TabIndex = 31;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table of Readers Information";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddBooksForm);
            this.panel4.Controls.Add(this.btnDeleteBooksForm);
            this.panel4.Controls.Add(this.btnSaveBooksForm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1450, 72);
            this.panel4.TabIndex = 30;
            // 
            // btnAddBooksForm
            // 
            this.btnAddBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddBooksForm.FlatAppearance.BorderSize = 0;
            this.btnAddBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAddBooksForm.Location = new System.Drawing.Point(466, 20);
            this.btnAddBooksForm.Name = "btnAddBooksForm";
            this.btnAddBooksForm.Size = new System.Drawing.Size(168, 36);
            this.btnAddBooksForm.TabIndex = 6;
            this.btnAddBooksForm.Text = "Add ";
            this.btnAddBooksForm.UseVisualStyleBackColor = false;
            this.btnAddBooksForm.Click += new System.EventHandler(this.btnAddBooksForm_Click);
            // 
            // btnDeleteBooksForm
            // 
            this.btnDeleteBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteBooksForm.FlatAppearance.BorderSize = 0;
            this.btnDeleteBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDeleteBooksForm.Location = new System.Drawing.Point(969, 20);
            this.btnDeleteBooksForm.Name = "btnDeleteBooksForm";
            this.btnDeleteBooksForm.Size = new System.Drawing.Size(160, 36);
            this.btnDeleteBooksForm.TabIndex = 7;
            this.btnDeleteBooksForm.Text = "Delete ";
            this.btnDeleteBooksForm.UseVisualStyleBackColor = false;
            this.btnDeleteBooksForm.Click += new System.EventHandler(this.btnDeleteBooksForm_Click);
            // 
            // btnSaveBooksForm
            // 
            this.btnSaveBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveBooksForm.FlatAppearance.BorderSize = 0;
            this.btnSaveBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSaveBooksForm.Location = new System.Drawing.Point(714, 20);
            this.btnSaveBooksForm.Name = "btnSaveBooksForm";
            this.btnSaveBooksForm.Size = new System.Drawing.Size(162, 36);
            this.btnSaveBooksForm.TabIndex = 8;
            this.btnSaveBooksForm.Text = "Update ";
            this.btnSaveBooksForm.UseVisualStyleBackColor = false;
            this.btnSaveBooksForm.Click += new System.EventHandler(this.btnSaveBooksForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.date_of_BirthDateTimePicker);
            this.panel2.Controls.Add(this.genderRadioButton2);
            this.panel2.Controls.Add(this.genderRadioButton);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.lNameComboBox);
            this.panel2.Controls.Add(this.fNameComboBox);
            this.panel2.Controls.Add(emailLabel);
            this.panel2.Controls.Add(genderLabel);
            this.panel2.Controls.Add(date_of_BirthLabel);
            this.panel2.Controls.Add(fNameLabel);
            this.panel2.Controls.Add(lNameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1450, 248);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(860, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(714, 176);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 24;
            this.date_of_BirthDateTimePicker.ValueChanged += new System.EventHandler(this.date_of_BirthDateTimePicker_ValueChanged);
            // 
            // genderRadioButton2
            // 
            this.genderRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.genderRadioButton2.AutoSize = true;
            this.genderRadioButton2.Location = new System.Drawing.Point(714, 142);
            this.genderRadioButton2.Name = "genderRadioButton2";
            this.genderRadioButton2.Size = new System.Drawing.Size(59, 17);
            this.genderRadioButton2.TabIndex = 23;
            this.genderRadioButton2.TabStop = true;
            this.genderRadioButton2.Text = "Female";
            this.genderRadioButton2.UseVisualStyleBackColor = true;
            // 
            // genderRadioButton
            // 
            this.genderRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.genderRadioButton.AutoSize = true;
            this.genderRadioButton.Location = new System.Drawing.Point(714, 119);
            this.genderRadioButton.Name = "genderRadioButton";
            this.genderRadioButton.Size = new System.Drawing.Size(48, 17);
            this.genderRadioButton.TabIndex = 22;
            this.genderRadioButton.TabStop = true;
            this.genderRadioButton.Text = "Male";
            this.genderRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTextBox.Location = new System.Drawing.Point(714, 85);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 21;
            // 
            // lNameComboBox
            // 
            this.lNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lNameComboBox.FormattingEnabled = true;
            this.lNameComboBox.Location = new System.Drawing.Point(714, 49);
            this.lNameComboBox.Name = "lNameComboBox";
            this.lNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.lNameComboBox.TabIndex = 20;
            this.lNameComboBox.SelectedIndexChanged += new System.EventHandler(this.lNameComboBox_SelectedIndexChanged_1);
            // 
            // fNameComboBox
            // 
            this.fNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fNameComboBox.FormattingEnabled = true;
            this.fNameComboBox.Location = new System.Drawing.Point(714, 17);
            this.fNameComboBox.Name = "fNameComboBox";
            this.fNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.fNameComboBox.TabIndex = 19;
            this.fNameComboBox.SelectedIndexChanged += new System.EventHandler(this.fNameComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 54);
            this.panel1.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(866, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 54);
            this.panel7.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTopSearchBarPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(391, 54);
            this.panel6.TabIndex = 11;
            // 
            // lblTopSearchBarPanel
            // 
            this.lblTopSearchBarPanel.AutoSize = true;
            this.lblTopSearchBarPanel.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.lblTopSearchBarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopSearchBarPanel.Location = new System.Drawing.Point(3, 12);
            this.lblTopSearchBarPanel.Name = "lblTopSearchBarPanel";
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(340, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Maintain Reader Information";
            // 
            // aLLREADERSNOIDSTableAdapter
            // 
            this.aLLREADERSNOIDSTableAdapter.ClearBeforeFill = true;
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
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Reader";
            this.Size = new System.Drawing.Size(1450, 855);
            this.Load += new System.EventHandler(this.Reader_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aLLREADERSNOIDSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLREADERSNOIDSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLREADERSNOIDSBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView aLLREADERSNOIDSDataGridView;
        private System.Windows.Forms.BindingSource aLLREADERSNOIDSBindingSource;
        private System.Windows.Forms.Button btnLastRecord;
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnScroll2BooksForm;
        private System.Windows.Forms.Button btnScrollBooksForm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddBooksForm;
        private System.Windows.Forms.Button btnDeleteBooksForm;
        private System.Windows.Forms.Button btnSaveBooksForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aLLREADERSNOIDSBindingSource1;
        private LibraryMS_DatabaseDataSet libraryMS_DatabaseDataSet;
        private LibraryMS_DatabaseDataSetTableAdapters.ALLREADERSNOIDSTableAdapter aLLREADERSNOIDSTableAdapter;
        private LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.RadioButton genderRadioButton2;
        private System.Windows.Forms.RadioButton genderRadioButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox lNameComboBox;
        private System.Windows.Forms.ComboBox fNameComboBox;
        private System.Windows.Forms.Button button1;
    }
}
