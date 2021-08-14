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
    public partial class SenderInfo : Form
    {
      
        public SenderInfo()
        {
            InitializeComponent();
            
            lbl_email.Show();
            lbl_password.Show();
            lbeEmail.Hide();
            lbePassword.Hide();
            
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            

            if ((txtUsername.Text == "") && (txtPassword.Text != ""))
            {
                lbl_email.Hide();
                lbeEmail.Show();
                lbl_password.Show();
                lbePassword.Hide();
            }
            if ((txtUsername.Text != "") && (txtPassword.Text == ""))
            {
                lbl_password.Hide();
                lbePassword.Show();
                lbl_email.Show();
                lbeEmail.Hide();
            }
            if ((txtUsername.Text == "") && (txtPassword.Text == ""))
            {
                lbl_email.Hide();
                lbeEmail.Show();

                lbl_password.Hide();
                lbePassword.Show();
            }

            if ((txtUsername.Text != "") && (txtPassword.Text != ""))
            {

                DBConnection db = DBConnection.getInsatanceOfDBConnection();

                db.userid = txtUsername.Text;
                db.pass = txtPassword.Text;

                CreateFeedback ct = new CreateFeedback();
                ct.Show();
                this.Hide();











                //Add user to database
                //  DBConnection.getInsatanceOfDBConnection().saveToDBUser(Constants.INSERTUser, txtUsername.Text, txtPassword.Text);
                // DB d = new DB();

                // DataSet ds = DBConnection.getInsatanceOfDBConnection().getDataSet(Constants.SELECTALLUsers);


                // f2.dgvU.DataSource= ds.Tables[0];
                // dgvApplica.DataSource = 







            }



        
           
                

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         //   DB db = new DB();
          //  db.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateTemplate ct = new CreateTemplate();
            ct.Show();
        }
    }
}
