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
    public partial class CreateTemplate : Form
    {
        public CreateTemplate()
        {
            InitializeComponent();
        }

        private void CreateTemplate_Load(object sender, EventArgs e)
        {

        }

        private void chkEducation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEducation.Checked)
            {
                txtTemplate.Text = txtTemplate.Text  + "education" + Environment.NewLine + Environment.NewLine;
            }
            if (chkEducation.Checked != true)
            {
               // txtTemplate.Text = txtTemplate.Text.Remove(txtTemplate.Text.LastIndexOf(Environment.NewLine));
                // txtTemplate.Text = txtTemplate.Text.Remove(txtTemplate.Text.LastIndexOf(Environment.NewLine));
                // txtTemplate.Text.Remove();
                txtTemplate.Text = txtTemplate.Text.Replace("education", null);
               // txtTemplate.Text=  txtTemplate.Text.Replace("education", null);
            }
        }

        private void chkPersonalProfile_CheckedChanged(object sender, EventArgs e)
        {

            if (chkPersonalProfile.Checked)
            {
                txtTemplate.Text = txtTemplate.Text  + "PersonalProfile" + Environment.NewLine + Environment.NewLine;
            }
            if (chkPersonalProfile.Checked != true)
            {
               // txtTemplate.Text = txtTemplate.Text.Remove(txtTemplate.Text.IndexOf(Environment.NewLine)+1);
               // txtTemplate.Text = txtTemplate.Text.Remove(txtTemplate.Text.LastIndexOf(Environment.NewLine));
                // txtTemplate.Text.Remove();
                txtTemplate.Text = txtTemplate.Text.Replace("PersonalProfile" , null);
            }

        }

        private void chkSkills_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSkills.Checked)
            {
                txtTemplate.Text = txtTemplate.Text  + "Skills" + Environment.NewLine + Environment.NewLine;
            }
            if (chkSkills.Checked != true)
            {
                txtTemplate.Text = txtTemplate.Text.Replace("Skills", null);
            }
        }

        private void chkExperience_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExperience.Checked)
            {
                txtTemplate.Text = txtTemplate.Text  + "Experience" + Environment.NewLine + Environment.NewLine;
            }
            if (chkExperience.Checked != true)
            {
                txtTemplate.Text = txtTemplate.Text.Replace("Experience", null);
            }
        }

        private void chkReferences_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReferences.Checked)
            {
               // txtTemplate.Text = txtTemplate.Text + Environment.NewLine;
                
                txtTemplate.Text = txtTemplate.Text  + "References" + Environment.NewLine + Environment.NewLine;

                
            }
            if (chkReferences.Checked != true)
            {

                txtTemplate.Text = txtTemplate.Text.Replace("References", null);
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHeader.Checked)
            {
                txtTemplate.Text = txtTemplate.Text + "Name:" + Environment.NewLine +"Job replied for:"+ Environment.NewLine+"Date:";
            }
            if (chkHeader.Checked != true)
            {
                // txtTemplate.Text = txtTemplate.Text.Remove(txtTemplate.Text.IndexOf(Environment.NewLine)+1);
                // txtTemplate.Text = txtTemplate.Text.Remove(txtTemplate.Text.LastIndexOf(Environment.NewLine));
                // txtTemplate.Text.Remove();
              //  txtTemplate.Text = txtTemplate.Text.Replace("Name:" + Environment.NewLine + "Job replied for:" + Environment.NewLine + "Date:" , null);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            //string template = txtTemplate.Text;
            DBConnection.getInsatanceOfDBConnection().saveToDBTemplate(Constants.INSERTTEMPLATE, txtTemplate.Text, txtTemplate.Text);
            MessageBox.Show("Template saved.");
           // Form2 f2 = new Form2();
         //   f2.lstTemplate.Items.Add(txtTemplateName.Text);
          //  f2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TemplateDGV t = new TemplateDGV();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TemplateDGV c = new TemplateDGV();
            c.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }
    }
}
