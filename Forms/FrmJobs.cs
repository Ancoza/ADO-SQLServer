using HR_ADO_SQLServer.Data;
using System;
using System.Windows.Forms;

namespace HR_ADO_SQLServer.Forms
{
    public partial class FrmJobs : Form
    {
        public FrmJobs()
        {
            InitializeComponent();
        }

        private void frm_jobs_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            FrmNewJob new_Job = new FrmNewJob();
            new_Job.ShowDialog();
            refresh();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int job_id = GetId();
            FrmUpdateJob new_Job = new FrmUpdateJob(job_id);
            new_Job.ShowDialog();
            refresh();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int job_id = GetId();
            try
            {
                DBHR db = new DBHR();
                db.DeleteJobs(job_id);
                refresh();
            }
            catch (Exception) 
            {
                MessageBox.Show("Ocurrio un mensaje al eliminar");
            }
        }

        private void refresh()
        {
            DBHR db = new DBHR();
            dgv_jobs.DataSource = db.GetJobs();
        }

        #region Helper
        private int GetId()
        {
            try
            {
                return int.Parse(dgv_jobs.Rows[dgv_jobs.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
