using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback
{
    public partial class CreateFeedback : Form
    {
        public string userid;
        public string pass;
        public DataGridView dgvU;
        
        public string address;
        public string name;
        public string job;
        public string emailbody;

        public string TemplateName;

        public string templatetext;
        public int s;
        public int c;
        public CreateFeedback()
        {
            InitializeComponent();
           // dgvU = dgvUser;
        }

        private void form_Click(object sender, EventArgs e)
        {

           

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

           
            // get number of entries in "Applicant" table 
              int n = DBConnection.getInsatanceOfDBConnection().Count(Constants.CountApplicants);
            if (n != 0)
            {
                int c = DBConnection.getInsatanceOfDBConnection().sendall();
                if (c > 0)
                {
                    MessageBox.Show(c + " emails sent!");
                }
            
            }
            else
            {
                MessageBox.Show("No emails to send in database."+ Environment.NewLine+"Please add emails to the database by clicking on the (Add email) button to send emails");
            }

            //// Info i = new Info();
            //// password = "Dev866@$1";
            //// userid = "divyanshusharma866@gmail.com";
            //int c = DBConnection.getInsatanceOfDBConnection().Count(Constants.Count);
            //int i = 0;

            //for (i = 0; i <= c; i++)
            //{
            //    ++i;
            //    DBConnection.getInsatanceOfDBConnection().retrieve(i);
            //  //  Broadcast se = new Broadcast(/*txtPort.Text,*/ userid, pass, txtSmtp.Text, address, null, emailbody, job, name);
            //}
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //txtTo
           
           int c= DBConnection.getInsatanceOfDBConnection().Count(Constants.CountTemplates);
            for (int i=1; i <= c; i++)
            {

                DBConnection.getInsatanceOfDBConnection().retrieve(i,null, Constants.RETRIEVETemplatesBYid);
                string n = DBConnection.getInsatanceOfDBConnection().ReturnTemplateItemName(i);
                lstTemplate.Items.Add(n);
            }
            txtMessage.Text = templatetext;
            templatetext = null;
            
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void txtSmtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChkPassed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFailed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtTo.Text != "") && (txtJob.Text != "") && (txtName.Text!=""))
            {
                DBConnection.getInsatanceOfDBConnection().saveToDBApplicant(Constants.INSERTApplicant, txtName.Text.Trim(), txtTo.Text.Trim(), txtJob.Text.Trim(), txtMessage.Text.Trim());
                txtTo.Text = null;
                txtJob.Text = null;
                txtName.Text = null;
                txtMessage.Clear();
                txtSubject.Clear();

                MessageBox.Show("Data added to Database");




                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = false })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        //        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());


                        //        try
                        //        {
                        // Document doc = new Document();

                        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());


                        PdfWriter.GetInstance(doc, new FileStream("C:/Users/divya/Documents/Applicants/a.pdf", FileMode.Create));
                        MessageBox.Show("");
                        doc.Open();

                        Paragraph p1 = new Paragraph(txtMessage.Text.Trim());

                        doc.Add(p1);
                        doc.Close();

                        //  doc.Add(new iTextSharp.text.Paragraph(txtMessage.Text.Trim()));


                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    }
                        //    finally
                        //    {

                        //    }
                        //}
                    }
                }
            }










            
            else
            {
                MessageBox.Show("Enter necessary credentials(*)");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            d db = new d();
            db.Show();
           // this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnection.getInsatanceOfDBConnection().ClearDB(Constants.TRUNCATEApplicant);
        }

        private void lstTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
           string i =lstTemplate.SelectedItem.ToString();
            //lb1.Text = i;
            i.Trim();
            DBConnection.getInsatanceOfDBConnection().retrieve(0, i, Constants.RETRIEVETemplatesBYname);
            txtMessage.Text = txtMessage.Text + templatetext;
            templatetext = null;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateTemplate c = new CreateTemplate();
            c.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
