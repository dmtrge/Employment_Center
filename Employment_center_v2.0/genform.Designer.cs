namespace Employment_center_v2._0
{
    partial class genform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacantiondbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobDatabaseDataSet = new Employment_center_v2._0.JobDatabaseDataSet();
            this.vacantiondbTableAdapter = new Employment_center_v2._0.JobDatabaseDataSetTableAdapters.vacantiondbTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacantiondbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDatabaseDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.profileDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.requirementsDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.expDataGridViewTextBoxColumn,
            this.graphDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.aboutDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.actualDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vacantiondbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1218, 520);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profileDataGridViewTextBoxColumn
            // 
            this.profileDataGridViewTextBoxColumn.DataPropertyName = "profile";
            this.profileDataGridViewTextBoxColumn.HeaderText = "profile";
            this.profileDataGridViewTextBoxColumn.Name = "profileDataGridViewTextBoxColumn";
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "speciality";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // requirementsDataGridViewTextBoxColumn
            // 
            this.requirementsDataGridViewTextBoxColumn.DataPropertyName = "requirements";
            this.requirementsDataGridViewTextBoxColumn.HeaderText = "requirements";
            this.requirementsDataGridViewTextBoxColumn.Name = "requirementsDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // expDataGridViewTextBoxColumn
            // 
            this.expDataGridViewTextBoxColumn.DataPropertyName = "exp";
            this.expDataGridViewTextBoxColumn.HeaderText = "exp";
            this.expDataGridViewTextBoxColumn.Name = "expDataGridViewTextBoxColumn";
            // 
            // graphDataGridViewTextBoxColumn
            // 
            this.graphDataGridViewTextBoxColumn.DataPropertyName = "graph";
            this.graphDataGridViewTextBoxColumn.HeaderText = "graph";
            this.graphDataGridViewTextBoxColumn.Name = "graphDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // aboutDataGridViewTextBoxColumn
            // 
            this.aboutDataGridViewTextBoxColumn.DataPropertyName = "about";
            this.aboutDataGridViewTextBoxColumn.HeaderText = "about";
            this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // actualDataGridViewTextBoxColumn
            // 
            this.actualDataGridViewTextBoxColumn.DataPropertyName = "actual";
            this.actualDataGridViewTextBoxColumn.HeaderText = "actual";
            this.actualDataGridViewTextBoxColumn.Name = "actualDataGridViewTextBoxColumn";
            // 
            // vacantiondbBindingSource
            // 
            this.vacantiondbBindingSource.DataMember = "vacantiondb";
            this.vacantiondbBindingSource.DataSource = this.jobDatabaseDataSet;
            // 
            // jobDatabaseDataSet
            // 
            this.jobDatabaseDataSet.DataSetName = "JobDatabaseDataSet";
            this.jobDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacantiondbTableAdapter
            // 
            this.vacantiondbTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.панельАдминистратораToolStripMenuItem,
            this.поискToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // панельАдминистратораToolStripMenuItem
            // 
            this.панельАдминистратораToolStripMenuItem.Name = "панельАдминистратораToolStripMenuItem";
            this.панельАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.панельАдминистратораToolStripMenuItem.Text = "Панель администратора";
            this.панельАдминистратораToolStripMenuItem.Click += new System.EventHandler(this.панельАдминистратораToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem1
            // 
            this.поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            this.поискToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.поискToolStripMenuItem1.Text = "Поиск";
            this.поискToolStripMenuItem1.Click += new System.EventHandler(this.поискToolStripMenuItem1_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // genform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "genform";
            this.Text = "genform";
            this.Load += new System.EventHandler(this.genform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacantiondbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDatabaseDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private JobDatabaseDataSet jobDatabaseDataSet;
        private System.Windows.Forms.BindingSource vacantiondbBindingSource;
        private JobDatabaseDataSetTableAdapters.vacantiondbTableAdapter vacantiondbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requirementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graphDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельАдминистратораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
    }
}