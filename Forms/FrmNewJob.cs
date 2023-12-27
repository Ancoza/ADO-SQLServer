using HR_ADO_SQLServer.Data;
using System;
using System.Windows.Forms;

namespace HR_ADO_SQLServer.Forms
{
    public partial class FrmNewJob : Form
    {
        public FrmNewJob()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DBHR db = new DBHR();
            try
            {
                db.NewJob(txt_title.Text, decimal.Parse(txt_sal_min.Text), decimal.Parse(txt_sal_max.Text));
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
