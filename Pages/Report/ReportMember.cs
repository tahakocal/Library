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
    public partial class ReportMember : Form
    {
        public ReportMember()
        {
            InitializeComponent();
        }

        private void ReportMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.libraryDatabaseNewDataSet.Members);

            this.reportViewer1.RefreshReport();
        }
    }
}
