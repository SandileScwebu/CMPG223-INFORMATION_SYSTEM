
namespace LibraryMS2.UserControls
{
    partial class AuthorBook
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
            System.Windows.Forms.Label number_Of_BooksLabel;
            System.Windows.Forms.Label book_TitleLabel;
            System.Windows.Forms.Label author_NameLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLastRecord = new System.Windows.Forms.Button();
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.btnScroll2BooksForm = new System.Windows.Forms.Button();
            this.aUTHORSBOOKSDataGridView = new System.Windows.Forms.DataGridView();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfBooksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceperBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORSBOOKSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryMS_DatabaseDataSet = new LibraryMS2.LibraryMS_DatabaseDataSet();
            this.btnScrollBooksForm = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.number_Of_BooksNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.book_TitleComboBox = new System.Windows.Forms.ComboBox();
            this.author_NameComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.aUTHORSBOOKSTableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.AUTHORSBOOKSTableAdapter();
            this.tableAdapterManager = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.aUTHORSBOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            number_Of_BooksLabel = new System.Windows.Forms.Label();
            book_TitleLabel = new System.Windows.Forms.Label();
            author_NameLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBOOKSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBOOKSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_Of_BooksNumericUpDown)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBOOKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // number_Of_BooksLabel
            // 
            number_Of_BooksLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            number_Of_BooksLabel.AutoSize = true;
            number_Of_BooksLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            number_Of_BooksLabel.Location = new System.Drawing.Point(474, 104);
            number_Of_BooksLabel.Name = "number_Of_BooksLabel";
            number_Of_BooksLabel.Size = new System.Drawing.Size(183, 21);
            number_Of_BooksLabel.TabIndex = 6;
            number_Of_BooksLabel.Text = "Number Of Books Sold:";
            // 
            // book_TitleLabel
            // 
            book_TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            book_TitleLabel.AutoSize = true;
            book_TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            book_TitleLabel.Location = new System.Drawing.Point(474, 67);
            book_TitleLabel.Name = "book_TitleLabel";
            book_TitleLabel.Size = new System.Drawing.Size(86, 21);
            book_TitleLabel.TabIndex = 4;
            book_TitleLabel.Text = "Book Title:";
            // 
            // author_NameLabel
            // 
            author_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            author_NameLabel.AutoSize = true;
            author_NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            author_NameLabel.Location = new System.Drawing.Point(474, 29);
            author_NameLabel.Name = "author_NameLabel";
            author_NameLabel.Size = new System.Drawing.Size(121, 21);
            author_NameLabel.TabIndex = 2;
            author_NameLabel.Text = "Author Name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnLastRecord);
            this.panel3.Controls.Add(this.btnFirstRecord);
            this.panel3.Controls.Add(this.btnScroll2BooksForm);
            this.panel3.Controls.Add(this.aUTHORSBOOKSDataGridView);
            this.panel3.Controls.Add(this.btnScrollBooksForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1466, 385);
            this.panel3.TabIndex = 33;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(1119, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 36);
            this.button2.TabIndex = 37;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLastRecord
            // 
            this.btnLastRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLastRecord.FlatAppearance.BorderSize = 0;
            this.btnLastRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastRecord.Location = new System.Drawing.Point(208, 311);
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
            this.btnFirstRecord.Location = new System.Drawing.Point(179, 311);
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
            this.btnScroll2BooksForm.Location = new System.Drawing.Point(266, 311);
            this.btnScroll2BooksForm.Name = "btnScroll2BooksForm";
            this.btnScroll2BooksForm.Size = new System.Drawing.Size(23, 24);
            this.btnScroll2BooksForm.TabIndex = 33;
            this.btnScroll2BooksForm.UseVisualStyleBackColor = true;
            // 
            // aUTHORSBOOKSDataGridView
            // 
            this.aUTHORSBOOKSDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aUTHORSBOOKSDataGridView.AutoGenerateColumns = false;
            this.aUTHORSBOOKSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aUTHORSBOOKSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aUTHORSBOOKSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.numberOfBooksDataGridViewTextBoxColumn,
            this.priceperBookDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.aUTHORSBOOKSDataGridView.DataSource = this.aUTHORSBOOKSBindingSource1;
            this.aUTHORSBOOKSDataGridView.Location = new System.Drawing.Point(179, 39);
            this.aUTHORSBOOKSDataGridView.Name = "aUTHORSBOOKSDataGridView";
            this.aUTHORSBOOKSDataGridView.Size = new System.Drawing.Size(1100, 266);
            this.aUTHORSBOOKSDataGridView.TabIndex = 1;
            this.aUTHORSBOOKSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aUTHORSBOOKSDataGridView_CellContentClick);
            this.aUTHORSBOOKSDataGridView.SelectionChanged += new System.EventHandler(this.aUTHORSBOOKSDataGridView_SelectionChanged);
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "Author_ID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "Author_ID";
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "Author_Name";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author_Name";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "Book_Title";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "Book_Title";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            // 
            // numberOfBooksDataGridViewTextBoxColumn
            // 
            this.numberOfBooksDataGridViewTextBoxColumn.DataPropertyName = "Number_Of_Books";
            this.numberOfBooksDataGridViewTextBoxColumn.HeaderText = "Number_Of_Books";
            this.numberOfBooksDataGridViewTextBoxColumn.Name = "numberOfBooksDataGridViewTextBoxColumn";
            // 
            // priceperBookDataGridViewTextBoxColumn
            // 
            this.priceperBookDataGridViewTextBoxColumn.DataPropertyName = "Price_per_Book";
            this.priceperBookDataGridViewTextBoxColumn.HeaderText = "Price_per_Book";
            this.priceperBookDataGridViewTextBoxColumn.Name = "priceperBookDataGridViewTextBoxColumn";
            this.priceperBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Price";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Unit_Price";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aUTHORSBOOKSBindingSource1
            // 
            this.aUTHORSBOOKSBindingSource1.DataMember = "AUTHORSBOOKS";
            this.aUTHORSBOOKSBindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
            // 
            // libraryMS_DatabaseDataSet
            // 
            this.libraryMS_DatabaseDataSet.DataSetName = "LibraryMS_DatabaseDataSet";
            this.libraryMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnScrollBooksForm
            // 
            this.btnScrollBooksForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnScrollBooksForm.FlatAppearance.BorderSize = 0;
            this.btnScrollBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrollBooksForm.Location = new System.Drawing.Point(237, 311);
            this.btnScrollBooksForm.Name = "btnScrollBooksForm";
            this.btnScrollBooksForm.Size = new System.Drawing.Size(23, 24);
            this.btnScrollBooksForm.TabIndex = 32;
            this.btnScrollBooksForm.UseVisualStyleBackColor = true;
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAssign.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAssign.Location = new System.Drawing.Point(434, 31);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(189, 36);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAssign);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1466, 98);
            this.panel4.TabIndex = 34;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(657, 31);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(189, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRemove.Location = new System.Drawing.Point(873, 31);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(189, 36);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1466, 59);
            this.panel1.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnRefreshTable);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(882, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 59);
            this.panel7.TabIndex = 15;
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
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(148, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Author Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table of Author\'s Books";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.number_Of_BooksNumericUpDown);
            this.panel2.Controls.Add(this.book_TitleComboBox);
            this.panel2.Controls.Add(this.author_NameComboBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(number_Of_BooksLabel);
            this.panel2.Controls.Add(book_TitleLabel);
            this.panel2.Controls.Add(author_NameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1466, 175);
            this.panel2.TabIndex = 32;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // number_Of_BooksNumericUpDown
            // 
            this.number_Of_BooksNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.number_Of_BooksNumericUpDown.Location = new System.Drawing.Point(662, 108);
            this.number_Of_BooksNumericUpDown.Name = "number_Of_BooksNumericUpDown";
            this.number_Of_BooksNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.number_Of_BooksNumericUpDown.TabIndex = 15;
            // 
            // book_TitleComboBox
            // 
            this.book_TitleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.book_TitleComboBox.FormattingEnabled = true;
            this.book_TitleComboBox.Location = new System.Drawing.Point(662, 67);
            this.book_TitleComboBox.Name = "book_TitleComboBox";
            this.book_TitleComboBox.Size = new System.Drawing.Size(241, 21);
            this.book_TitleComboBox.TabIndex = 14;
            // 
            // author_NameComboBox
            // 
            this.author_NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.author_NameComboBox.FormattingEnabled = true;
            this.author_NameComboBox.Location = new System.Drawing.Point(662, 29);
            this.author_NameComboBox.Name = "author_NameComboBox";
            this.author_NameComboBox.Size = new System.Drawing.Size(241, 21);
            this.author_NameComboBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(849, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 332);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1466, 54);
            this.panel5.TabIndex = 36;
            // 
            // aUTHORSBOOKSTableAdapter
            // 
            this.aUTHORSBOOKSTableAdapter.ClearBeforeFill = true;
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
            // aUTHORSBOOKSBindingSource
            // 
            this.aUTHORSBOOKSBindingSource.DataMember = "AUTHORSBOOKS";
            // 
            // AuthorBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AuthorBook";
            this.Size = new System.Drawing.Size(1466, 878);
            this.Load += new System.EventHandler(this.AuthorBook_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBOOKSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBOOKSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_Of_BooksNumericUpDown)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBOOKSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLastRecord;
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnScroll2BooksForm;
        private System.Windows.Forms.DataGridView aUTHORSBOOKSDataGridView;
        private System.Windows.Forms.BindingSource aUTHORSBOOKSBindingSource;
        private System.Windows.Forms.Button btnScrollBooksForm;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfBooksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aUTHORSBOOKSBindingSource1;
        private LibraryMS_DatabaseDataSet libraryMS_DatabaseDataSet;
        private LibraryMS_DatabaseDataSetTableAdapters.AUTHORSBOOKSTableAdapter aUTHORSBOOKSTableAdapter;
        private LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NumericUpDown number_Of_BooksNumericUpDown;
        private System.Windows.Forms.ComboBox book_TitleComboBox;
        private System.Windows.Forms.ComboBox author_NameComboBox;
    }
}
