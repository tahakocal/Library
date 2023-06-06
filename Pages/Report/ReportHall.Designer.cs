namespace LibraryAutomation.Pages.Report
{
    partial class ReportHall
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libraryDatabaseNewDataSet = new LibraryAutomation.LibraryDatabaseNewDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new LibraryAutomation.LibraryDatabaseNewDataSetTableAdapters.EmployeesTableAdapter();
            this.hallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallsTableAdapter = new LibraryAutomation.LibraryDatabaseNewDataSetTableAdapters.HallsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseNewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hallsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibraryAutomation.Report.Hall.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // libraryDatabaseNewDataSet
            // 
            this.libraryDatabaseNewDataSet.DataSetName = "LibraryDatabaseNewDataSet";
            this.libraryDatabaseNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.libraryDatabaseNewDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // hallsBindingSource
            // 
            this.hallsBindingSource.DataMember = "Halls";
            this.hallsBindingSource.DataSource = this.libraryDatabaseNewDataSet;
            // 
            // hallsTableAdapter
            // 
            this.hallsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportHall";
            this.Text = "ReportHall";
            this.Load += new System.EventHandler(this.ReportHall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseNewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LibraryDatabaseNewDataSet libraryDatabaseNewDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private LibraryDatabaseNewDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource hallsBindingSource;
        private LibraryDatabaseNewDataSetTableAdapters.HallsTableAdapter hallsTableAdapter;
    }
}