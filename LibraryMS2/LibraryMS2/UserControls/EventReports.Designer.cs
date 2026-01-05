
namespace LibraryMS2.UserControls
{
    partial class EventReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartEvents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTopSearchBarPanel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tOP10EVENTSDataGridView = new System.Windows.Forms.DataGridView();
            this.eventTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOP10EVENTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryMS_DatabaseDataSet = new LibraryMS2.LibraryMS_DatabaseDataSet();
            this.tOP10EVENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tOP10EVENTSTableAdapter = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TOP10EVENTSTableAdapter();
            this.tableAdapterManager = new LibraryMS2.LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvents)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10EVENTSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10EVENTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10EVENTSBindingSource)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(1141, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 36);
            this.button2.TabIndex = 35;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table of Top 10 Events";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 547);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1454, 42);
            this.panel3.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartEvents);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1454, 499);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // chartEvents
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEvents.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEvents.Legends.Add(legend1);
            this.chartEvents.Location = new System.Drawing.Point(128, 45);
            this.chartEvents.Name = "chartEvents";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEvents.Series.Add(series1);
            this.chartEvents.Size = new System.Drawing.Size(1223, 412);
            this.chartEvents.TabIndex = 0;
            this.chartEvents.Text = "chart1";
            this.chartEvents.Click += new System.EventHandler(this.chartEvents_Click);
            // 
            // lblTopSearchBarPanel
            // 
            this.lblTopSearchBarPanel.AutoSize = true;
            this.lblTopSearchBarPanel.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.lblTopSearchBarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopSearchBarPanel.Location = new System.Drawing.Point(3, 12);
            this.lblTopSearchBarPanel.Name = "lblTopSearchBarPanel";
            this.lblTopSearchBarPanel.Size = new System.Drawing.Size(403, 27);
            this.lblTopSearchBarPanel.TabIndex = 25;
            this.lblTopSearchBarPanel.Text = "Top 10 Events Report : Radar Chart";
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
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.tOP10EVENTSDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 589);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1454, 325);
            this.panel4.TabIndex = 37;
            // 
            // tOP10EVENTSDataGridView
            // 
            this.tOP10EVENTSDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tOP10EVENTSDataGridView.AutoGenerateColumns = false;
            this.tOP10EVENTSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tOP10EVENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tOP10EVENTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventTitleDataGridViewTextBoxColumn,
            this.attendeesDataGridViewTextBoxColumn});
            this.tOP10EVENTSDataGridView.DataSource = this.tOP10EVENTSBindingSource1;
            this.tOP10EVENTSDataGridView.Location = new System.Drawing.Point(201, 32);
            this.tOP10EVENTSDataGridView.Name = "tOP10EVENTSDataGridView";
            this.tOP10EVENTSDataGridView.Size = new System.Drawing.Size(1100, 210);
            this.tOP10EVENTSDataGridView.TabIndex = 1;
            // 
            // eventTitleDataGridViewTextBoxColumn
            // 
            this.eventTitleDataGridViewTextBoxColumn.DataPropertyName = "Event Title";
            this.eventTitleDataGridViewTextBoxColumn.HeaderText = "Event Title";
            this.eventTitleDataGridViewTextBoxColumn.Name = "eventTitleDataGridViewTextBoxColumn";
            // 
            // attendeesDataGridViewTextBoxColumn
            // 
            this.attendeesDataGridViewTextBoxColumn.DataPropertyName = "Attendees";
            this.attendeesDataGridViewTextBoxColumn.HeaderText = "Attendees";
            this.attendeesDataGridViewTextBoxColumn.Name = "attendeesDataGridViewTextBoxColumn";
            this.attendeesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOP10EVENTSBindingSource1
            // 
            this.tOP10EVENTSBindingSource1.DataMember = "TOP10EVENTS";
            this.tOP10EVENTSBindingSource1.DataSource = this.libraryMS_DatabaseDataSet;
            // 
            // libraryMS_DatabaseDataSet
            // 
            this.libraryMS_DatabaseDataSet.DataSetName = "LibraryMS_DatabaseDataSet";
            this.libraryMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOP10EVENTSBindingSource
            // 
            this.tOP10EVENTSBindingSource.DataMember = "TOP10EVENTS";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnRefreshTable);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(870, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 48);
            this.panel7.TabIndex = 14;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1454, 48);
            this.panel1.TabIndex = 34;
            // 
            // tOP10EVENTSTableAdapter
            // 
            this.tOP10EVENTSTableAdapter.ClearBeforeFill = true;
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
            // EventReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EventReports";
            this.Size = new System.Drawing.Size(1454, 935);
            this.Load += new System.EventHandler(this.EventReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEvents)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tOP10EVENTSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10EVENTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryMS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP10EVENTSBindingSource)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTopSearchBarPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tOP10EVENTSDataGridView;
        private System.Windows.Forms.BindingSource tOP10EVENTSBindingSource;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tOP10EVENTSBindingSource1;
        private LibraryMS_DatabaseDataSet libraryMS_DatabaseDataSet;
        private LibraryMS_DatabaseDataSetTableAdapters.TOP10EVENTSTableAdapter tOP10EVENTSTableAdapter;
        private LibraryMS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
