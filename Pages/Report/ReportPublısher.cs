using System;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Report
{
    public partial class ReportPublısher : Form
    {
        public ReportPublısher()
        {
            InitializeComponent();
        }

        private void ReportPublısher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.libraryDatabaseNewDataSet.Publishers);

            this.reportViewer1.RefreshReport();
        }
    }
}
