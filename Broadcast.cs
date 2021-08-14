using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net;
namespace Feedback
{
    class Broadcast
    {

        private string txtTo;
        private string txtSmtp;
        private string txtCC;
        private string txtMessage;
        private string txtSubject;
        private string txtHeader;

        NetworkCredential login;
        SmtpClient Client;
        MailMessage msg;



        public Broadcast(/*string port,*/ string u, string p, string smtp, string to, string cc, string message, string subject, string header)
        {
  


            //Add html line tags to email body string
            message = message.Replace("\n", "<br/>");

            txtTo = to;

            txtSmtp = smtp;

            txtCC = cc;
            txtMessage = message;
            txtSubject = subject;
            txtHeader = header;






            login = new NetworkCredential(u, p); //(txtUser, txtPass);
            Client = new SmtpClient(txtSmtp);
            Client.Port = 587;                                                              //Convert.ToInt32(txtPort);
            Client.EnableSsl = true;                                             // chkSSL.Checked;
            Client.Credentials = login;
            try
            {


                msg = new MailMessage { From = new MailAddress(u, "DEV", Encoding.ASCII) };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect email or password!");
                
            }

            try
            {


                msg.To.Add(new MailAddress(txtTo));
               
            }
            catch(Exception a)
            {
                MessageBox.Show("Invalid recipient Email" + txtTo);
               
            }

                if (!string.IsNullOrEmpty(txtCC))
                    msg.To.Add(new MailAddress(txtCC));

                msg.Subject = txtSubject;
                msg.Body = txtHeader + "<br/>" + System.Environment.NewLine + txtMessage;



                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
              //  Client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";
            try
            {


                Client.SendAsync(msg, userstate);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Recipient email not available");
            }
            




            
        }
           private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
           {
            CreateFeedback f2 = new CreateFeedback();
            int i = 1;
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send cancled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                //f2.lb1.Text = ++i + "Sent";
           // f2.Show();
                    MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }

        public void Broad(string t, string m)
        {
            int i=0;
            while (true)
            {

                ++i;
                DBConnection.getInsatanceOfDBConnection().retrieve(1,null,Constants.RETRIEVEApplicantsBYid);
                //Broadcast("divyanshusharma866@gmail.com", "Dev866@$1", "smtp.gmail.com",  t, "", m, null, null);



            }
        }

    }
            
}

