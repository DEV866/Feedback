using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback
{
    public partial class ApplicantDGV : Form
    {
        public ApplicantDGV()
        {
            InitializeComponent();
        }

        private void d_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataSet ds = DBConnection.getInsatanceOfDBConnection().getDataSet(Constants.SELECTALLApplicants);

            dgvApplicant.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
