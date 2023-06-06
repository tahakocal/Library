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
    public partial class ReportCabinet : Form
    {
        public ReportCabinet()
        {
            InitializeComponent();
        }

        private void ReportCabinet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.Cabinets' table. You can move, or remove it, as needed.
            this.cabinetsTableAdapter.Fill(this.libraryDatabaseNewDataSet.Cabinets);

            this.reportViewer1.RefreshReport();
        }
    }
}
