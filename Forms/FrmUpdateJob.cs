using HR_ADO_SQLServer.Data;
using System;
using System.Windows.Forms;

namespace HR_ADO_SQLServer.Forms
{
    public partial class FrmUpdateJob : Form
    {
        private int job_id;
        public FrmUpdateJob(int job_id)
        {
            InitializeComponent();
            this.job_id = job_id;
            LoadData();
        }

        private void LoadData()
        {
            DBHR db = new DBHR();
            Job job = db.GetJob(job_id);
            txt_title.Text = job.job_title;
            txt_sal_min.Text = job.min_salary.ToString();
            txt_sal_max.Text = job.max_salary.ToString();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DBHR db = new DBHR();
            try
            {
                db.EditJob(txt_title.Text, decimal.Parse(txt_sal_min.Text), decimal.Parse(txt_sal_max.Text), job_id);
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
