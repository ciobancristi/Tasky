using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace Tasky.Services
{
    public static class MailHelper
    {
        private static readonly string Username = ConfigurationManager.AppSettings["EmailFrom"];
        private static readonly string Password = ConfigurationManager.AppSettings["PasswordEmailFrom"];

        public static void SendMail(string to, string subject, string body)
        {
            Thread t = new Thread(
             delegate ()
             {
                 try
                 {
                     using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
                     {
                         client.Port = 587;
                         client.Credentials = new NetworkCredential(Username, Password);
                         client.EnableSsl = true;
                         MailMessage mess = new MailMessage(Username, to, subject, body);
                         mess.IsBodyHtml = true;
                         mess.From = new MailAddress(Username, "Timesheet administrator");
                         client.Send(mess);
                     }
                 }
                 catch (Exception ex)
                 {
                     // TODO: use a logging service 
                     // this is a form of logging on local disk logging 
                     string path = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
                     using (StreamWriter writer = new StreamWriter(path, true))
                     {
                         writer.WriteLine(ex.InnerException.Message);
                     }
                 }
             }
                 );
            t.Start();
        }
    }
}
