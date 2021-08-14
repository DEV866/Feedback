using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback
{
    class DBConnection
    {
        int c = 0;
        string address = null, name = null, job = null, emailbody = null;
        string templatename, templatetext;

        public string userid, pass;
        //private object of class itself
        private static DBConnection _instance;

        //Connection String
        private string connStr;

        //Connection to DB
        private SqlConnection connToDB;

        private DBConnection()
        {
            connStr = Properties.Settings.Default.ConnStr;
        }


        //a static method creates and return instance of class itself only if not created previously
        public static DBConnection getInsatanceOfDBConnection()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        //Return dataset built based on query
        public DataSet getDataSet(string sqlQuery)
        {
            //creates an empty dataset
            DataSet dataset = new DataSet();

            using (connToDB = new SqlConnection(connStr))
            {
                //open connection
                connToDB.Open();

                //create the data-adapter object to send query to DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connStr);

                //fill in dataset
                dataAdapter.Fill(dataset);
            }


            return dataset;
        }
        public DataTable getDataTable(string sqlQuery)
        {
            //creates an empty dataset
            DataTable datatable = new DataTable();

            using (connToDB = new SqlConnection(connStr))
            {
                //open connection
                connToDB.Open();

                //create the data-adapter object to send query to DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connStr);

                //fill in dataset
                dataAdapter.Fill(datatable);
            }


            return datatable;
        }


        //save data to database
        public void saveToDBApplicant(string sqlQuery, string name, string emailaddress, string job, string emailbody)
        {


            using (SqlConnection connToDB = new SqlConnection(connStr))
            {

                //open connection
                connToDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                //set the sqlCommand's type to text
                sqlCommand.CommandType = CommandType.Text;

                //add parameter to sqlCommand
                sqlCommand.Parameters.Add(new SqlParameter("Name", name));
                sqlCommand.Parameters.Add(new SqlParameter("EmailAddress", emailaddress));
                sqlCommand.Parameters.Add(new SqlParameter("Job", job));
                sqlCommand.Parameters.Add(new SqlParameter("EmailBody", emailbody));




                //execute the command
                sqlCommand.ExecuteNonQuery();


            }
        }

        public void saveToDBTemplate(string sqlQuery, string templatename, string templatetext)
        {


            using (SqlConnection connToDB = new SqlConnection(connStr))
            {

                //open connection
                connToDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                //set the sqlCommand's type to text
                sqlCommand.CommandType = CommandType.Text;

                //add parameter to sqlCommand
                sqlCommand.Parameters.Add(new SqlParameter("TemplateName", templatename));

                sqlCommand.Parameters.Add(new SqlParameter("TemplateText", templatetext));




                //execute the command
                sqlCommand.ExecuteNonQuery();


            }
        }

        public void saveToDBUser(string sqlQuery, string name, string email)
        {


            using (SqlConnection connToDB = new SqlConnection(connStr))
            {

                //open connection
                connToDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                //set the sqlCommand's type to text
                sqlCommand.CommandType = CommandType.Text;

                //add parameter to sqlCommand

                sqlCommand.Parameters.Add(new SqlParameter("EmailAddress", email));
                sqlCommand.Parameters.Add(new SqlParameter("Name", name));




                //execute the command
                sqlCommand.ExecuteNonQuery();


            }

        }




        public int Count(string sqlQuery)
        {

            SqlCommand cmd;
            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                try
                {

                    connToDB.Open();
                    //    label1.ForeColor = Color.Green;
                    //  label1.Text = "Database Sucessfully Connected!!";

                    cmd = new SqlCommand(sqlQuery, connToDB);

                    //read from db
                    Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                    connToDB.Close();

                    //Display data on the page
                    c = rows_count;
                    //   return rows_count;
                    return c;


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return 0;
                }
                finally
                {
                    if (connToDB.State == ConnectionState.Open)
                    {
                        connToDB.Close();

                    }

                }
            }


        }
        public void ClearDB(string sqlQuery)
        {
            // SqlCommand cmd;
            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                try
                {

                    connToDB.Open();
                    //    label1.ForeColor = Color.Green;
                    //  label1.Text = "Database Sucessfully Connected!!";
                    SqlCommand command = new SqlCommand(sqlQuery, connToDB);
                    //  cmd = new SqlCommand(sqlQuery, connToDB);
                    SqlDataReader sdr = command.ExecuteReader();

                    //read from db
                    //cmd.ExecuteNonQuery();
                    command.Dispose();
                    // connToDB.Close();

                    //Display data on the page
                    //c = rows_count;
                    //   return rows_count;


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (connToDB.State == ConnectionState.Open)
                    {
                        connToDB.Close();

                    }

                }
            }
        }

        public int sendall()
        {
            DBConnection.getInsatanceOfDBConnection().Count(Constants.CountApplicants);

            CreateFeedback f2 = new CreateFeedback();
            f2.c = c;

            if (c > 0)
            {

                for (int i = 1; i <= c; i++)
                {
                    //Add html line tags to email body string
                //   string email = emailbody.Replace("\n", "<br/>");
                   // emailbody = email;


                    DBConnection.getInsatanceOfDBConnection().retrieve(i, null, Constants.RETRIEVEApplicantsBYid);
                    Broadcast se = new Broadcast(/*txtPort.Text,*/ userid, pass, "smtp.gmail.com", address, null, emailbody, job, name);
                    f2.s = i;

                }
            }
            return c;
        }
        public string ReturnTemplateItemName(int i)
        {
            DBConnection.getInsatanceOfDBConnection().Count(Constants.CountTemplates);

            //Form2 f2 = new Form2();
            //f2.c = c;


            //for (int i = 1; i <= c; i++)
            //{

            DBConnection.getInsatanceOfDBConnection().retrieve(i, null, Constants.RETRIEVETemplatesBYid);
            return templatename;
            //f2.lstTemplate.Items.Add(templatename);




            //}
            //return "error";
        }


        public void First()
        {



        }

        public void retrieve(int id, string n, string sqlQuery)
        {
            // if(sqlQuery==)
            if (sqlQuery == "SELECT * FROM [Applicant] WHERE Id=")
            {
                sqlQuery = sqlQuery + id;
                using (SqlConnection connToDB = new SqlConnection(connStr))
                {


                    connToDB.Open();
                    // MessageBox.Show("DB Connected");
                    string Query = "SELECT * FROM [applicant] WHERE Id= " + id;
                    SqlCommand command = new SqlCommand(Query, connToDB);
                    SqlDataReader sd = command.ExecuteReader();


                    // Form2 f2 = new Form2();
                    if (sd.Read())
                    {
                        address = sd["EmailAddress"].ToString();
                        name = sd["Name"].ToString();
                        job = sd["Job"].ToString();
                        emailbody = sd["EmailBody"].ToString();

                        //  f2.txtJob.Text = sd["Job"].ToString();
                        //  f2.txte.Text= sd["EmailAddress"].ToString();

                    }
                }
            }





                //}

                if (sqlQuery == "SELECT * FROM [Template] WHERE Id=")
            {
                using (SqlConnection connToDB = new SqlConnection(connStr))
                {


                    connToDB.Open();
                    // MessageBox.Show("DB Connected");
                    //   string Query = "SELECT * FROM [applicant] WHERE Id=" + id;



                    sqlQuery = sqlQuery + id;

                    SqlCommand command1 = new SqlCommand(sqlQuery, connToDB);
                    SqlDataReader sd1 = command1.ExecuteReader();

                    // Form2 f2 = new Form2();

                    if (sd1.Read())
                    {



                        if (sqlQuery == "SELECT * FROM [Template] WHERE Id=" + id)
                        {
                            templatename = sd1["TemplateName"].ToString();
                            //   templatetext = sd["TemplateText"].ToString();

                        }

                    }







                    // return sd;
                    // Broadcast f2 = new Broadcast("divyanshusharma866@gmail.com", "Dev866@$1", "smtp.gmail.com", address, null, name, null, null);
                    // f2.Show();

                    // Broadcast se = new Broadcast(/*txtPort.Text,*/ "divyanshusharma866@gmail.com", "Dev866@$1", "smtp.gmail.com", f2.email.Text, null, f2.name.Text, null, null);
                    // string u, string p, string smtp, string to, string cc, string message, string subject, string header)


                }
            }

            if (sqlQuery == "SELECT * FROM Template WHERE TemplateName LIKE ")
            {
                using (SqlConnection connToDB = new SqlConnection(connStr))
                {


                    connToDB.Open();
                    // MessageBox.Show("DB Connected");
                    //   string Query = "SELECT * FROM [applicant] WHERE Id=" + id;



                    sqlQuery = sqlQuery + "'%" + n + "%'";

                    SqlCommand command1 = new SqlCommand(sqlQuery, connToDB);
                    SqlDataReader sd1 = command1.ExecuteReader();

                     CreateFeedback f2 = new CreateFeedback();

                    if (sd1.Read())
                    {

                        
                        // templatename = sd1["TemplateName"].ToString();
                        templatetext = sd1["TemplateText"].ToString();
                        f2.templatetext = this.templatetext;
                        f2.Show();

                        //  f2.txtJob.Text = sd["Job"].ToString();
                        //  f2.txte.Text= sd["EmailAddress"].ToString();

                    }
                }

            }
        }
    }
}

            
            
        
    


           




        
                
            






    


/*
//private object of the class itself
private static DBConnection _instance;

//connection string
private string connStr;

//connection to the DB
private SqlConnection connToDB;

/// <summary>
/// constructor
/// </summary>
private DBConnection()
{
    connStr = Properties.Settings.Default.ApplicantDBConnStr;

}

///
///methods
///
/
 // a static method that creates an unique object of the class itself
 
public static DBConnection getInstanceOfDBConnection()
{
    if (_instance == null)
        _instance = new DBConnection();
    return _instance;
}


 // Returns a data set built based on the query sent as parameter

public DataSet getDataSet(string sqlQuery)
{
    //create an empty dataset
    DataSet dataSet = new DataSet();

    using (connToDB = new SqlConnection(connStr))
    {
        //open the connection
        connToDB.Open();

        //create teh object dataAdapter to send a query to the DB
        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

        //fill in the dataset
        dataAdapter.Fill(dataSet);

    }

    return dataSet;

}
*/