using System;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Report
{
    public partial class ReportCategory : Form
    {
        public ReportCategory()
        {
            InitializeComponent();
        }

        private void ReportCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.libraryDatabaseNewDataSet.Categories);

            this.reportViewer1.RefreshReport();
        }
    }
}
