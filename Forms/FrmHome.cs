using HR_ADO_SQLServer.Data;
using HR_ADO_SQLServer.Forms;
using System;
using System.Windows.Forms;

namespace HR_ADO_SQLServer
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            DBHR db = new DBHR();
            dgv_employees.DataSource = db.GetEmployees();
        }

        private void btn_jobs_Click(object sender, EventArgs e)
        {
            FrmJobs frm_jobs = new FrmJobs();
            frm_jobs.ShowDialog();
        }
    }
}
