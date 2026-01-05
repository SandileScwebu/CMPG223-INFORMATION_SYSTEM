
namespace LibraryMS2.UserControls
{
    partial class Author
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveBooksForm = new System.Windows.Forms.Button();
            this.btnAddBooksForm = new System.Windows.Forms.Button();
            this.btnDeleteBooksForm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLastRecord = new System.Windows.Forms.Button();
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.btnScroll2BooksForm = new System.Windows.Forms.Button();
            this.btnScrollBooksForm = new System.Windows.Forms.Button();
            this.aLLAUTHORNOIDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLLAUTHORNOIDSDataGridView = new System.Windows.Forms.DataGridView();
            this.aNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLAUTHORNOIDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryMS_DatabaseDataSet = new LibraryMS2.LibraryMS_DatabaseDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.aLLAUTHORNOIDSTableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.ALLAUTHORNOIDSTableAdapter();
            this.tableAdapterManager = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.genderRadioButton = new System.Windows.Forms.RadioButton();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.aLNameComboBox = new System.Windows.Forms.ComboBox();
            this.aNameComboBox = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLLAUTHORNOIDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLAUTHORNOIDSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLAUTHORNOIDSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            label7.Location = new System.Drawing.Point(459, 137);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 21);
            label7.TabIndex = 15;
            label7.Text = "Gender:";
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            label8.Location = new System.Drawing.Point(459, 189);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(111, 21);
            label8.TabIndex = 14;
            label8.Text = "Date of Birth:";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            label9.Location = new System.Drawing.Point(459, 97);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(55, 21);
            label9.TabIndex = 13;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            label10.Location = new System.Drawing.Point(459, 59);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(79, 21);
            label10.TabIndex = 12;
            label10.Text = "Surname";
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            label11.Location = new System.Drawing.Point(459, 20);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(62, 21);
            label11.TabIndex = 11;
            label11.Text = "Name:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveBooksForm);
            this.panel4.Controls.Add(this.btnAddBooksForm);
            this.panel4.Controls.Add(this.btnDeleteBooksForm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1471, 108);
            this.panel4.TabIndex = 37;
            // 
            // btnSaveBooksForm
            // 
            this.btnSaveBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveBooksForm.FlatAppearance.BorderSize = 0;
            this.btnSaveBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSaveBooksForm.Location = new System.Drawing.Point(702, 32);
            this.btnSaveBooksForm.Name = "btnSaveBooksForm";
            this.btnSaveBooksForm.Size = new System.Drawing.Size(138, 36);
            this.btnSaveBooksForm.TabIndex = 8;
            this.btnSaveBooksForm.Text = "Update";
            this.btnSaveBooksForm.UseVisualStyleBackColor = false;
            this.btnSaveBooksForm.Click += new System.EventHandler(this.btnSaveBooksForm_Click);
            // 
            // btnAddBooksForm
            // 
            this.btnAddBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddBooksForm.FlatAppearance.BorderSize = 0;
            this.btnAddBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAddBooksForm.Location = new System.Drawing.Point(439, 32);
            this.btnAddBooksForm.Name = "btnAddBooksForm";
            this.btnAddBooksForm.Size = new System.Drawing.Size(152, 36);
            this.btnAddBooksForm.TabIndex = 6;
            this.btnAddBooksForm.Text = "Add";
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
            this.btnDeleteBooksForm.Location = new System.Drawing.Point(934, 32);
            this.btnDeleteBooksForm.Name = "btnDeleteBooksForm";
            this.btnDeleteBooksForm.Size = new System.Drawing.Size(152, 36);
            this.btnDeleteBooksForm.TabIndex = 7;
            this.btnDeleteBooksForm.Text = "Delete";
            this.btnDeleteBooksForm.UseVisualStyleBackColor = false;
            this.btnDeleteBooksForm.Click += new System.EventHandler(this.btnDeleteBooksForm_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(1128, 316);
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
            this.btnLastRecord.Location = new System.Drawing.Point(188, 297);
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
            this.btnFirstRecord.Location = new System.Drawing.Point(217, 297);
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
            this.btnScroll2BooksForm.Location = new System.Drawing.Point(298, 297);
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
            this.btnScrollBooksForm.Location = new System.Drawing.Point(269, 297);
            this.btnScrollBooksForm.Name = "btnScrollBooksForm";
            this.btnScrollBooksForm.Size = new System.Drawing.Size(23, 24);
            this.btnScrollBooksForm.TabIndex = 32;
            this.btnScrollBooksForm.UseVisualStyleBackColor = true;
            // 
            // aLLAUTHORNOIDSBindingSource
            // 
            this.aLLAUTHORNOIDSBindingSource.DataMember = "ALLAUTHORNOIDS";
            // 
            // aLLAUTHORNOIDSDataGridView
            // 
            this.aLLAUTHORNOIDSDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLLAUTHORNOIDSDataGridView.AutoGenerateColumns = false;
            this.aLLAUTHORNOIDSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aLLAUTHORNOIDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aLLAUTHORNOIDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aNameDataGridViewTextBoxColumn,
            this.aLNameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.aLLAUTHORNOIDSDataGridView.DataSource = this.aLLAUTHORNOIDSBindingSource1;
            this.aLLAUTHORNOIDSDataGridView.Location = new System.Drawing.Point(188, 44);
            this.aLLAUTHORNOIDSDataGridView.Name = "aLLAUTHORNOIDSDataGridView";
            this.aLLAUTHORNOIDSDataGridView.Size = new System.Drawing.Size(1100, 266);
            this.aLLAUTHORNOIDSDataGridView.TabIndex = 35;
            this.aLLAUTHORNOIDSDataGridView.SelectionChanged += new System.EventHandler(this.aLLAUTHORNOIDSDataGridView_SelectionChanged);
            // 
            // aNameDataGridViewTextBoxColumn
            // 
            this.aNameDataGridViewTextBoxColumn.DataPropertyName = "AName";
            this.aNameDataGridViewTextBoxColumn.HeaderText = "AName";
            this.aNameDataGridViewTextBoxColumn.Name = "aNameDataGridViewTextBoxColumn";
            // 
            // aLNameDataGridViewTextBoxColumn
            // 
            this.aLNameDataGridViewTextBoxColumn.DataPropertyName = "ALName";
            this.aLNameDataGridViewTextBoxColumn.HeaderText = "ALName";
            this.aLNameDataGridViewTextBoxColumn.Name = "aLNameDataGridViewTextBoxColumn";
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "Author Name";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author Name";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // aLLAUTHORNOIDSBindingSource1
            // 
            this.aLLAUTHORNOIDSBindingSource1.DataMember = "ALLAUTHORNOIDS";
            this.aLLAUTHORNOIDSBindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
            // 
            // libraryMS_DatabaseDataSet
            // 
            this.libraryMS_DatabaseDataSet.DataSetName = "LibraryMS_DatabaseDataSet";
            this.libraryMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.aLLAUTHORNOIDSDataGridView);
            this.panel3.Controls.Add(this.btnLastRecord);
            this.panel3.Controls.Add(this.btnFirstRecord);
            this.panel3.Controls.Add(this.btnScroll2BooksForm);
            this.panel3.Controls.Add(this.btnScrollBooksForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1471, 386);
            this.panel3.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table of Authors Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 54);
            this.panel1.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(887, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 54);
            this.panel7.TabIndex = 17;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(112, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 36);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(332, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Maintain Author Information";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1471, 54);
            this.panel5.TabIndex = 38;
            // 
            // aLLAUTHORNOIDSTableAdapter
            // 
            this.aLLAUTHORNOIDSTableAdapter.ClearBeforeFill = true;
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
            // panel10
            // 
            this.panel10.Controls.Add(this.button1);
            this.panel10.Controls.Add(label7);
            this.panel10.Controls.Add(this.date_of_BirthDateTimePicker);
            this.panel10.Controls.Add(label8);
            this.panel10.Controls.Add(this.radioButton1);
            this.panel10.Controls.Add(label9);
            this.panel10.Controls.Add(label10);
            this.panel10.Controls.Add(this.genderRadioButton);
            this.panel10.Controls.Add(label11);
            this.panel10.Controls.Add(this.emailTextBox);
            this.panel10.Controls.Add(this.aLNameComboBox);
            this.panel10.Controls.Add(this.aNameComboBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 54);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1471, 247);
            this.panel10.TabIndex = 20;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(857, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(711, 195);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(711, 161);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Feamale";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // genderRadioButton
            // 
            this.genderRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.genderRadioButton.AutoSize = true;
            this.genderRadioButton.Location = new System.Drawing.Point(713, 130);
            this.genderRadioButton.Name = "genderRadioButton";
            this.genderRadioButton.Size = new System.Drawing.Size(48, 17);
            this.genderRadioButton.TabIndex = 8;
            this.genderRadioButton.TabStop = true;
            this.genderRadioButton.Text = "Male";
            this.genderRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTextBox.Location = new System.Drawing.Point(711, 97);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // aLNameComboBox
            // 
            this.aLNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLNameComboBox.FormattingEnabled = true;
            this.aLNameComboBox.Location = new System.Drawing.Point(711, 54);
            this.aLNameComboBox.Name = "aLNameComboBox";
            this.aLNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.aLNameComboBox.TabIndex = 6;
            // 
            // aNameComboBox
            // 
            this.aNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aNameComboBox.FormattingEnabled = true;
            this.aNameComboBox.Location = new System.Drawing.Point(711, 20);
            this.aNameComboBox.Name = "aNameComboBox";
            this.aNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.aNameComboBox.TabIndex = 5;
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Name = "Author";
            this.Size = new System.Drawing.Size(1471, 931);
            this.Load += new System.EventHandler(this.Author_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aLLAUTHORNOIDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLAUTHORNOIDSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLAUTHORNOIDSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSaveBooksForm;
        private System.Windows.Forms.Button btnAddBooksForm;
        private System.Windows.Forms.Button btnDeleteBooksForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLastRecord;
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnScroll2BooksForm;
        private System.Windows.Forms.Button btnScrollBooksForm;
        private System.Windows.Forms.BindingSource aLLAUTHORNOIDSBindingSource;
        private System.Windows.Forms.DataGridView aLLAUTHORNOIDSDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aLLAUTHORNOIDSBindingSource1;
        private LibraryMS_DatabaseDataSet libraryMS_DatabaseDataSet;
        private LibraryMS_DatabaseDataSetTableAdapters.ALLAUTHORNOIDSTableAdapter aLLAUTHORNOIDSTableAdapter;
        private LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton genderRadioButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox aLNameComboBox;
        private System.Windows.Forms.ComboBox aNameComboBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}
