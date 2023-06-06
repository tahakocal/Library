using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Report
{
    public partial class ReportShelve : Form
    {
        public ReportShelve()
        {
            InitializeComponent();
        }

        private void ReportShelve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.Shelves' table. You can move, or remove it, as needed.
            this.shelvesTableAdapter.Fill(this.libraryDatabaseNewDataSet.Shelves);

            this.reportViewer1.RefreshReport();
        }
    }
}
