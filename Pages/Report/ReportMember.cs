using System;
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
