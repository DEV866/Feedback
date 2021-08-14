using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback
{
    public partial class DB : Form
    {
        public TextBox email, name, job, emailbody;
        public DB()
        {
            //InitializeComponent();
            //email = txtEmail;
            //name = txtName;
            //job = txtJob;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            loadDataGridView();

        }


        //populate data grid when form loads
        private void DB_Load(object sender, EventArgs e)
        {

            loadDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {


           // SqlDataReader s = new SqlDataReader();
           // DBConnection.getInsatanceOfDBConnection().retrieve(int.Parse(txtId.Text),null,Constants.RETRIEVEApplicantsBYid);
              //txtName.Text = name.Text;
           //   txtEmail.Text = email.Text;
             // txtJob.Text = job.Text;
           // txte.Text = email.Text;
         //     DB db = new DB();
              this.Hide();
            Broadcast b;
            //b.Broad(txtName.Text,txtEmail.Text);

            
                                                               
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //get values from 
         //   DBConnection.getInsatanceOfDBConnection().saveToDBApplicant(Constants.INSERTApplicant, txtName.Text, txtEmail.Text, txtJob.Text);

            loadDataGridView();

        }
        
        //Load data Grid
        private void loadDataGridView()
        {


            // Display data from DB
            //Get Dataset from DB and assign it to dgvApplicant's 
            DataSet ds = DBConnection.getInsatanceOfDBConnection().getDataSet(Constants.SELECTALLApplicants);

            dgvApplicant.DataSource = ds.Tables[0];
            //DataTable dt = DBConnection.getInsatanceOfDBConnection().getDataTable(Constants.SELECTALLTEMPLATE);
            //c1.DataSource = dt;
          
            
           
           
        }
    }
}
