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
    public partial class ReportEmployee : Form
    {
        public ReportEmployee()
        {
            InitializeComponent();
        }

        private void ReportEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.libraryDatabaseNewDataSet.Employees);

            this.reportViewer1.RefreshReport();
        }
    }
}
