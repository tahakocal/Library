using System;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Report
{
    public partial class ReportRentBook : Form
    {
        public ReportRentBook()
        {
            InitializeComponent();
        }

        private void ReportRentBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.RentBooks' table. You can move, or remove it, as needed.
            this.rentBooksTableAdapter.Fill(this.libraryDatabaseNewDataSet.RentBooks);

            this.reportViewer1.RefreshReport();
        }
    }
}
