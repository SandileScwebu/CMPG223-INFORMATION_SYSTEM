
namespace LibraryMS2.UserControls
{
    partial class AuthorReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartTopAuthor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tOP10AUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOP10AUTHORTOTALBOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tOP10AUTHORTOTALBOOKSDataGridView = new System.Windows.Forms.DataGridView();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfBooksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOP10AUTHORTOTALBOOKSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryMS_DatabaseDataSet = new LibraryMS2.LibraryMS_DatabaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tOP10AUTHORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tOP10AUTHORTableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TOP10AUTHORTableAdapter();
            this.tableAdapterManager = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tOP10AUTHORTOTALBOOKSTableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TOP10AUTHORTOTALBOOKSTableAdapter();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORTOTALBOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORTOTALBOOKSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORTOTALBOOKSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table of Top 10 Authors";
            // 
            // lblTopSearchBarPanel
            // 
            this.lblTopSearchBarPanel.AutoSize = true;
            this.lblTopSearchBarPanel.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.lblTopSearchBarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopSearchBarPanel.Location = new System.Drawing.Point(3, 12);
            this.lblTopSearchBarPanel.Name = "lblTopSearchBarPanel";
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(384, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Top 10 Authors Report: Bar Graph";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTopSearchBarPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(433, 48);
            this.panel6.TabIndex = 12;
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
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnRefreshTable);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(788, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 48);
            this.panel7.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartTopAuthor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1372, 427);
            this.panel3.TabIndex = 33;
            // 
            // chartTopAuthor
            // 
            this.chartTopAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea2.Name = "ChartArea1";
            this.chartTopAuthor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTopAuthor.Legends.Add(legend2);
            this.chartTopAuthor.Location = new System.Drawing.Point(31, 27);
            this.chartTopAuthor.Name = "chartTopAuthor";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopAuthor.Series.Add(series2);
            this.chartTopAuthor.Size = new System.Drawing.Size(1277, 371);
            this.chartTopAuthor.TabIndex = 0;
            this.chartTopAuthor.Text = "chart1";
            // 
            // tOP10AUTHORBindingSource
            // 
            this.tOP10AUTHORBindingSource.DataMember = "TOP10AUTHOR";
            // 
            // tOP10AUTHORTOTALBOOKSBindingSource
            // 
            this.tOP10AUTHORTOTALBOOKSBindingSource.DataMember = "TOP10AUTHORTOTALBOOKS";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(1065, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 36);
            this.button2.TabIndex = 33;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tOP10AUTHORTOTALBOOKSDataGridView
            // 
            this.tOP10AUTHORTOTALBOOKSDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tOP10AUTHORTOTALBOOKSDataGridView.AutoGenerateColumns = false;
            this.tOP10AUTHORTOTALBOOKSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tOP10AUTHORTOTALBOOKSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tOP10AUTHORTOTALBOOKSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorNameDataGridViewTextBoxColumn,
            this.numberOfBooksDataGridViewTextBoxColumn});
            this.tOP10AUTHORTOTALBOOKSDataGridView.DataSource = this.tOP10AUTHORTOTALBOOKSBindingSource1;
            this.tOP10AUTHORTOTALBOOKSDataGridView.Location = new System.Drawing.Point(125, 41);
            this.tOP10AUTHORTOTALBOOKSDataGridView.Name = "tOP10AUTHORTOTALBOOKSDataGridView";
            this.tOP10AUTHORTOTALBOOKSDataGridView.Size = new System.Drawing.Size(1100, 266);
            this.tOP10AUTHORTOTALBOOKSDataGridView.TabIndex = 0;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "Author Name";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author Name";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfBooksDataGridViewTextBoxColumn
            // 
            this.numberOfBooksDataGridViewTextBoxColumn.DataPropertyName = "Number Of Books";
            this.numberOfBooksDataGridViewTextBoxColumn.HeaderText = "Number Of Books";
            this.numberOfBooksDataGridViewTextBoxColumn.Name = "numberOfBooksDataGridViewTextBoxColumn";
            this.numberOfBooksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOP10AUTHORTOTALBOOKSBindingSource1
            // 
            this.tOP10AUTHORTOTALBOOKSBindingSource1.DataMember = "TOP10AUTHORTOTALBOOKS";
            this.tOP10AUTHORTOTALBOOKSBindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
            // 
            // libraryMS_DatabaseDataSet
            // 
            this.libraryMS_DatabaseDataSet.DataSetName = "LibraryMS_DatabaseDataSet";
            this.libraryMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tOP10AUTHORTOTALBOOKSDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 391);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 475);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1372, 42);
            this.panel5.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 48);
            this.panel2.TabIndex = 31;
            // 
            // tOP10AUTHORBindingSource1
            // 
            this.tOP10AUTHORBindingSource1.DataMember = "TOP10AUTHOR";
            this.tOP10AUTHORBindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
            // 
            // tOP10AUTHORTableAdapter
            // 
            this.tOP10AUTHORTableAdapter.ClearBeforeFill = true;
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
            // tOP10AUTHORTOTALBOOKSTableAdapter
            // 
            this.tOP10AUTHORTOTALBOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // AuthorReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AuthorReports";
            this.Size = new System.Drawing.Size(1372, 933);
            this.Load += new System.EventHandler(this.AuthorReports_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORTOTALBOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORTOTALBOOKSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORTOTALBOOKSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tOP10AUTHORBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource tOP10AUTHORBindingSource;
        private System.Windows.Forms.BindingSource tOP10AUTHORTOTALBOOKSBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tOP10AUTHORTOTALBOOKSDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopAuthor;
        private System.Windows.Forms.BindingSource tOP10AUTHORBindingSource1;
        private LibraryMS_DatabaseDataSet libraryMS_DatabaseDataSet;
        private LibraryMS_DatabaseDataSetTableAdapters.TOP10AUTHORTableAdapter tOP10AUTHORTableAdapter;
        private LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfBooksDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tOP10AUTHORTOTALBOOKSBindingSource1;
        private LibraryMS_DatabaseDataSetTableAdapters.TOP10AUTHORTOTALBOOKSTableAdapter tOP10AUTHORTOTALBOOKSTableAdapter;
    }
}
