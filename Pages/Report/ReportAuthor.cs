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
    public partial class ReportAuthor : Form
    {
        public ReportAuthor()
        {
            InitializeComponent();
        }

        private void ReportAuthor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.libraryDatabaseNewDataSet.Authors);

            this.reportViewer1.RefreshReport();
        }
    }
}
