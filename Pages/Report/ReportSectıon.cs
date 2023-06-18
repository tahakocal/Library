using System;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Report
{
    public partial class ReportSectıon : Form
    {
        public ReportSectıon()
        {
            InitializeComponent();
        }

        private void ReportSectıon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.Sections' table. You can move, or remove it, as needed.
            this.sectionsTableAdapter.Fill(this.libraryDatabaseNewDataSet.Sections);

            this.reportViewer1.RefreshReport();
        }
    }
}
