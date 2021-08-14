using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback
{
    class Constants
    {
        //sql Queries
        public static string SELECTALLApplicants = "SELECT* FROM [Applicant]";
        public static string SELECTALLUsers = "SELECT* FROM [Data]";
        public static string SELECTALLTEMPLATE = "SELECT* FROM [TEMPLATE]";
        public static string CountApplicants = "SELECT COUNT(Id) FROM Applicant";
        public static string CountTemplates = "SELECT COUNT(Id) FROM Template";

        public static string RETRIEVEApplicantsBYid = "SELECT * FROM [Applicant] WHERE Id=";   // +id
        public static string RETRIEVETemplatesBYid = "SELECT * FROM [Template] WHERE Id=";   // +id
        public static string RETRIEVETemplatesBYname = "SELECT * FROM Template WHERE TemplateName LIKE ";   // +id
        public static string INSERTApplicant = "INSERT INTO APPLICANT(Name,Job,EmailAddress, EmailBody) VALUES(@Name, @Job, @EmailAddress, @EmailBody)";
        public static string INSERTUser = "INSERT INTO [USER] (Email, Pass) VALUES(@Email, @Pass)";
        public static string INSERTTEMPLATE = "INSERT INTO [Template] (TemplateName, TemplateText) VALUES(@TemplateName, @TemplateText)";
        public static string TRUNCATEApplicant = "TRUNCATE TABLE [Applicant]";
        public static string TRUNCATETemplate = "TRUNCATE TABLE [Template]";


        // "SELECT * FROM applicant WHERE Id = 1"
        //  public static string r = 
    }
}
