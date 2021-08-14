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
    public partial class TemplateDGV : Form
    {
        public TemplateDGV()
        {
            InitializeComponent();
        }

        private void TemplateDGV_Load(object sender, EventArgs e)
        {

            DataSet d = DBConnection.getInsatanceOfDBConnection().getDataSet(Constants.SELECTALLTEMPLATE);
            dgvTemplate.DataSource = d.Tables[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet d = DBConnection.getInsatanceOfDBConnection().getDataSet(Constants.SELECTALLTEMPLATE);
            dgvTemplate.DataSource = d.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBConnection.getInsatanceOfDBConnection().ClearDB(Constants.TRUNCATETemplate);
        }
    }
}
