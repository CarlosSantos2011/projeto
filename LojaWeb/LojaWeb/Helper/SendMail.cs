using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace LojaWeb.Helper
{
    public class SendMail
    {
        public string From { get; set; }
        public string CC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }        
        public string Password { get; set; }
        public string SmtpServerAddress { get; set; }
        public int SmtpServerPort { get; set; }
        public bool UseSsl { get; set; }


        public bool Send()
        {
            try
            {
                // Estancia da Classe de Mensagem
                MailMessage _mailMessage = new MailMessage();
                // Remetente
                _mailMessage.From = new MailAddress(From);

                // Destinatario seta no metodo abaixo

                //Contrói o MailMessage
                _mailMessage.CC.Add(CC);
                _mailMessage.Subject = (Subject);
                _mailMessage.IsBodyHtml = (IsBodyHtml);
                _mailMessage.Body = (Body);

                //CONFIGURAÇÃO COM PORTA
                SmtpClient _smtpClient = new SmtpClient(SmtpServerAddress,SmtpServerPort);

                //CONFIGURAÇÃO SEM PORTA
                // SmtpClient _smtpClient = new SmtpClient(UtilRsource.ConfigSmtp);

                // Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação)
                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential(From, Password);
                _smtpClient.EnableSsl = UseSsl;

                _smtpClient.Send(_mailMessage);

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }



        }
    }
}