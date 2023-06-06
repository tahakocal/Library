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
    public partial class ReportBook : Form
    {
        public ReportBook()
        {
            InitializeComponent();
        }

        private void ReportBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseNewDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDatabaseNewDataSet.Books);

            this.reportViewer1.RefreshReport();
        }
    }
}
