namespace LibraryAutomation.Pages.Report
{
    partial class ReportRentBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportRentBook));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libraryDatabaseNewDataSet = new LibraryAutomation.LibraryDatabaseNewDataSet();
            this.rentBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentBooksTableAdapter = new LibraryAutomation.LibraryDatabaseNewDataSetTableAdapters.RentBooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseNewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rentBooksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibraryAutomation.Report.RentBook.rdlc";
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
            // rentBooksBindingSource
            // 
            this.rentBooksBindingSource.DataMember = "RentBooks";
            this.rentBooksBindingSource.DataSource = this.libraryDatabaseNewDataSet;
            // 
            // rentBooksTableAdapter
            // 
            this.rentBooksTableAdapter.ClearBeforeFill = true;
            // 
            // ReportRentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportRentBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Verilen Kitap Raporla";
            this.Load += new System.EventHandler(this.ReportRentBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseNewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBooksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LibraryDatabaseNewDataSet libraryDatabaseNewDataSet;
        private System.Windows.Forms.BindingSource rentBooksBindingSource;
        private LibraryDatabaseNewDataSetTableAdapters.RentBooksTableAdapter rentBooksTableAdapter;
    }
}