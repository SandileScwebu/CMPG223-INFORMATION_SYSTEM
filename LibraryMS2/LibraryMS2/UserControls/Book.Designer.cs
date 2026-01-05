
namespace LibraryMS2.UserControls
{
    partial class Book
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
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label book_YearLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.btnDeleteBooksForm = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.aLLBOOKSNOIDSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLLBOOKSNOIDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryMS_DatabaseDataSet = new LibraryMS2.LibraryMS_DatabaseDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLastRecord = new System.Windows.Forms.Button();
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.btnScroll2BooksForm = new System.Windows.Forms.Button();
            this.btnScrollBooksForm = new System.Windows.Forms.Button();
            this.aLLBOOKSNOIDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveBooksForm = new System.Windows.Forms.Button();
            this.btnAddBooksForm = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBookTitle = new System.Windows.Forms.RadioButton();
            this.rbPrice = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbShowISBN = new System.Windows.Forms.RadioButton();
            this.rbHideISBN = new System.Windows.Forms.RadioButton();
            this.book_YearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.iSBNComboBox = new System.Windows.Forms.ComboBox();
            this.book_TitleComboBox = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLLBOOKSNOIDSTableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.ALLBOOKSNOIDSTableAdapter();
            this.tableAdapterManager = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager();
            book_TitleLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            book_YearLabel = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLLBOOKSNOIDSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLBOOKSNOIDSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLBOOKSNOIDSBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // book_TitleLabel
            // 
            book_TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            book_TitleLabel.AutoSize = true;
            book_TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            book_TitleLabel.Location = new System.Drawing.Point(464, 15);
            book_TitleLabel.Name = "book_TitleLabel";
            book_TitleLabel.Size = new System.Drawing.Size(86, 21);
            book_TitleLabel.TabIndex = 20;
            book_TitleLabel.Text = "Book Title:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            iSBNLabel.AutoSize = true;
            iSBNLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            iSBNLabel.Location = new System.Drawing.Point(464, 60);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(48, 21);
            iSBNLabel.TabIndex = 22;
            iSBNLabel.Text = "ISBN:";
            // 
            // priceLabel
            // 
            priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            priceLabel.Location = new System.Drawing.Point(464, 113);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(51, 21);
            priceLabel.TabIndex = 24;
            priceLabel.Text = "Price:";
            // 
            // book_YearLabel
            // 
            book_YearLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            book_YearLabel.AutoSize = true;
            book_YearLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            book_YearLabel.Location = new System.Drawing.Point(464, 164);
            book_YearLabel.Name = "book_YearLabel";
            book_YearLabel.Size = new System.Drawing.Size(92, 21);
            book_YearLabel.TabIndex = 26;
            book_YearLabel.Text = "Book Year:";
            // 
            // btnDeleteBooksForm
            // 
            this.btnDeleteBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteBooksForm.FlatAppearance.BorderSize = 0;
            this.btnDeleteBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDeleteBooksForm.Location = new System.Drawing.Point(870, 19);
            this.btnDeleteBooksForm.Name = "btnDeleteBooksForm";
            this.btnDeleteBooksForm.Size = new System.Drawing.Size(173, 36);
            this.btnDeleteBooksForm.TabIndex = 7;
            this.btnDeleteBooksForm.Text = "Delete ";
            this.btnDeleteBooksForm.UseVisualStyleBackColor = false;
            this.btnDeleteBooksForm.Click += new System.EventHandler(this.btnDeleteBooksForm_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 343);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1417, 42);
            this.panel5.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table of Books Information";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.aLLBOOKSNOIDSDataGridView);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnLastRecord);
            this.panel3.Controls.Add(this.btnFirstRecord);
            this.panel3.Controls.Add(this.btnScroll2BooksForm);
            this.panel3.Controls.Add(this.btnScrollBooksForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1417, 366);
            this.panel3.TabIndex = 30;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // aLLBOOKSNOIDSDataGridView
            // 
            this.aLLBOOKSNOIDSDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLLBOOKSNOIDSDataGridView.AutoGenerateColumns = false;
            this.aLLBOOKSNOIDSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aLLBOOKSNOIDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aLLBOOKSNOIDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.aLLBOOKSNOIDSDataGridView.DataSource = this.aLLBOOKSNOIDSBindingSource1;
            this.aLLBOOKSNOIDSDataGridView.Location = new System.Drawing.Point(139, 63);
            this.aLLBOOKSNOIDSDataGridView.MultiSelect = false;
            this.aLLBOOKSNOIDSDataGridView.Name = "aLLBOOKSNOIDSDataGridView";
            this.aLLBOOKSNOIDSDataGridView.Size = new System.Drawing.Size(1098, 220);
            this.aLLBOOKSNOIDSDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Book Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Book Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Book ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // aLLBOOKSNOIDSBindingSource1
            // 
            this.aLLBOOKSNOIDSBindingSource1.DataMember = "ALLBOOKSNOIDS";
            this.aLLBOOKSNOIDSBindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
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
            this.button2.Location = new System.Drawing.Point(1077, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 36);
            this.button2.TabIndex = 32;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLastRecord
            // 
            this.btnLastRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLastRecord.FlatAppearance.BorderSize = 0;
            this.btnLastRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastRecord.Location = new System.Drawing.Point(139, 309);
            this.btnLastRecord.Name = "btnLastRecord";
            this.btnLastRecord.Size = new System.Drawing.Size(23, 24);
            this.btnLastRecord.TabIndex = 31;
            this.btnLastRecord.UseVisualStyleBackColor = true;
            // 
            // btnFirstRecord
            // 
            this.btnFirstRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFirstRecord.FlatAppearance.BorderSize = 0;
            this.btnFirstRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstRecord.Location = new System.Drawing.Point(168, 309);
            this.btnFirstRecord.Name = "btnFirstRecord";
            this.btnFirstRecord.Size = new System.Drawing.Size(23, 24);
            this.btnFirstRecord.TabIndex = 30;
            this.btnFirstRecord.UseVisualStyleBackColor = true;
            // 
            // btnScroll2BooksForm
            // 
            this.btnScroll2BooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnScroll2BooksForm.FlatAppearance.BorderSize = 0;
            this.btnScroll2BooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScroll2BooksForm.Location = new System.Drawing.Point(227, 309);
            this.btnScroll2BooksForm.Name = "btnScroll2BooksForm";
            this.btnScroll2BooksForm.Size = new System.Drawing.Size(23, 24);
            this.btnScroll2BooksForm.TabIndex = 29;
            this.btnScroll2BooksForm.UseVisualStyleBackColor = true;
            // 
            // btnScrollBooksForm
            // 
            this.btnScrollBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnScrollBooksForm.FlatAppearance.BorderSize = 0;
            this.btnScrollBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrollBooksForm.Location = new System.Drawing.Point(198, 309);
            this.btnScrollBooksForm.Name = "btnScrollBooksForm";
            this.btnScrollBooksForm.Size = new System.Drawing.Size(23, 24);
            this.btnScrollBooksForm.TabIndex = 28;
            this.btnScrollBooksForm.UseVisualStyleBackColor = true;
            // 
            // aLLBOOKSNOIDSBindingSource
            // 
            this.aLLBOOKSNOIDSBindingSource.DataMember = "ALLBOOKSNOIDS";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveBooksForm);
            this.panel4.Controls.Add(this.btnDeleteBooksForm);
            this.panel4.Controls.Add(this.btnAddBooksForm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1417, 72);
            this.panel4.TabIndex = 31;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnSaveBooksForm
            // 
            this.btnSaveBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveBooksForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveBooksForm.FlatAppearance.BorderSize = 0;
            this.btnSaveBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBooksForm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSaveBooksForm.Location = new System.Drawing.Point(630, 19);
            this.btnSaveBooksForm.Name = "btnSaveBooksForm";
            this.btnSaveBooksForm.Size = new System.Drawing.Size(179, 36);
            this.btnSaveBooksForm.TabIndex = 8;
            this.btnSaveBooksForm.Text = "Update ";
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
            this.btnAddBooksForm.Location = new System.Drawing.Point(394, 19);
            this.btnAddBooksForm.Name = "btnAddBooksForm";
            this.btnAddBooksForm.Size = new System.Drawing.Size(158, 36);
            this.btnAddBooksForm.TabIndex = 6;
            this.btnAddBooksForm.Text = "Add ";
            this.btnAddBooksForm.UseVisualStyleBackColor = false;
            this.btnAddBooksForm.Click += new System.EventHandler(this.btnAddBooksForm_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.book_YearDateTimePicker);
            this.panel2.Controls.Add(this.priceTextBox);
            this.panel2.Controls.Add(this.iSBNComboBox);
            this.panel2.Controls.Add(this.book_TitleComboBox);
            this.panel2.Controls.Add(book_TitleLabel);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(iSBNLabel);
            this.panel2.Controls.Add(priceLabel);
            this.panel2.Controls.Add(book_YearLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1417, 223);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.rbBookTitle);
            this.groupBox2.Controls.Add(this.rbPrice);
            this.groupBox2.Location = new System.Drawing.Point(967, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 170);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort by:";
            // 
            // rbBookTitle
            // 
            this.rbBookTitle.AutoSize = true;
            this.rbBookTitle.Location = new System.Drawing.Point(29, 66);
            this.rbBookTitle.Name = "rbBookTitle";
            this.rbBookTitle.Size = new System.Drawing.Size(73, 17);
            this.rbBookTitle.TabIndex = 1;
            this.rbBookTitle.TabStop = true;
            this.rbBookTitle.Text = "Book Title";
            this.rbBookTitle.UseVisualStyleBackColor = true;
            this.rbBookTitle.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbPrice
            // 
            this.rbPrice.AutoSize = true;
            this.rbPrice.Location = new System.Drawing.Point(29, 30);
            this.rbPrice.Name = "rbPrice";
            this.rbPrice.Size = new System.Drawing.Size(49, 17);
            this.rbPrice.TabIndex = 0;
            this.rbPrice.TabStop = true;
            this.rbPrice.Text = "Price";
            this.rbPrice.UseVisualStyleBackColor = true;
            this.rbPrice.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rbShowISBN);
            this.groupBox1.Controls.Add(this.rbHideISBN);
            this.groupBox1.Location = new System.Drawing.Point(198, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter books table:";
            // 
            // rbShowISBN
            // 
            this.rbShowISBN.AutoSize = true;
            this.rbShowISBN.Location = new System.Drawing.Point(29, 66);
            this.rbShowISBN.Name = "rbShowISBN";
            this.rbShowISBN.Size = new System.Drawing.Size(80, 17);
            this.rbShowISBN.TabIndex = 1;
            this.rbShowISBN.TabStop = true;
            this.rbShowISBN.Text = "Show ISBN";
            this.rbShowISBN.UseVisualStyleBackColor = true;
            this.rbShowISBN.CheckedChanged += new System.EventHandler(this.rbShowISBN_CheckedChanged);
            // 
            // rbHideISBN
            // 
            this.rbHideISBN.AutoSize = true;
            this.rbHideISBN.Location = new System.Drawing.Point(29, 30);
            this.rbHideISBN.Name = "rbHideISBN";
            this.rbHideISBN.Size = new System.Drawing.Size(75, 17);
            this.rbHideISBN.TabIndex = 0;
            this.rbHideISBN.TabStop = true;
            this.rbHideISBN.Text = "Hide ISBN";
            this.rbHideISBN.UseVisualStyleBackColor = true;
            this.rbHideISBN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // book_YearDateTimePicker
            // 
            this.book_YearDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.book_YearDateTimePicker.Location = new System.Drawing.Point(628, 167);
            this.book_YearDateTimePicker.Name = "book_YearDateTimePicker";
            this.book_YearDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.book_YearDateTimePicker.TabIndex = 33;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceTextBox.Location = new System.Drawing.Point(628, 116);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 32;
            // 
            // iSBNComboBox
            // 
            this.iSBNComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iSBNComboBox.FormattingEnabled = true;
            this.iSBNComboBox.Location = new System.Drawing.Point(628, 60);
            this.iSBNComboBox.Name = "iSBNComboBox";
            this.iSBNComboBox.Size = new System.Drawing.Size(200, 21);
            this.iSBNComboBox.TabIndex = 31;
            this.iSBNComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // book_TitleComboBox
            // 
            this.book_TitleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.book_TitleComboBox.FormattingEnabled = true;
            this.book_TitleComboBox.Location = new System.Drawing.Point(628, 15);
            this.book_TitleComboBox.Name = "book_TitleComboBox";
            this.book_TitleComboBox.Size = new System.Drawing.Size(200, 21);
            this.book_TitleComboBox.TabIndex = 30;
            this.book_TitleComboBox.SelectedIndexChanged += new System.EventHandler(this.book_TitleComboBox_SelectedIndexChanged_1);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(760, 193);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1417, 48);
            this.panel1.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPrint);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btnRefreshTable);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(833, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 48);
            this.panel7.TabIndex = 14;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPrint.Location = new System.Drawing.Point(461, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 36);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(413, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 30);
            this.panel9.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(313, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 36);
            this.button4.TabIndex = 12;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(289, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 30);
            this.panel8.TabIndex = 11;
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.FlatAppearance.BorderSize = 0;
            this.btnRefreshTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTable.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRefreshTable.Location = new System.Drawing.Point(126, 10);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(157, 36);
            this.btnRefreshTable.TabIndex = 10;
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            this.btnRefreshTable.MouseHover += new System.EventHandler(this.btnRefreshTable_MouseHover);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTopSearchBarPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(391, 48);
            this.panel6.TabIndex = 12;
            // 
            // lblTopSearchBarPanel
            // 
            this.lblTopSearchBarPanel.AutoSize = true;
            this.lblTopSearchBarPanel.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.lblTopSearchBarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopSearchBarPanel.Location = new System.Drawing.Point(3, 12);
            this.lblTopSearchBarPanel.Name = "lblTopSearchBarPanel";
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(312, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Maintain Book Information";
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            // 
            // aLLBOOKSNOIDSTableAdapter
            // 
            this.aLLBOOKSNOIDSTableAdapter.ClearBeforeFill = true;
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
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Book";
            this.Size = new System.Drawing.Size(1417, 821);
            this.Load += new System.EventHandler(this.Book_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aLLBOOKSNOIDSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLBOOKSNOIDSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLBOOKSNOIDSBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteBooksForm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLastRecord;
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnScroll2BooksForm;
        private System.Windows.Forms.Button btnScrollBooksForm;
        private System.Windows.Forms.BindingSource aLLBOOKSNOIDSBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSaveBooksForm;
        private System.Windows.Forms.Button btnAddBooksForm;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.BindingSource aLLBOOKSNOIDSBindingSource1;
        private LibraryMS_DatabaseDataSet libraryMS_DatabaseDataSet;
        private LibraryMS_DatabaseDataSetTableAdapters.ALLBOOKSNOIDSTableAdapter aLLBOOKSNOIDSTableAdapter;
        private LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker book_YearDateTimePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox iSBNComboBox;
        private System.Windows.Forms.ComboBox book_TitleComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHideISBN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBookTitle;
        private System.Windows.Forms.RadioButton rbPrice;
        private System.Windows.Forms.RadioButton rbShowISBN;
        private System.Windows.Forms.DataGridView aLLBOOKSNOIDSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnRefreshTable;
    }
}
