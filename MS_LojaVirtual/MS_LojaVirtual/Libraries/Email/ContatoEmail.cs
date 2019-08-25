using MS_LojaVirtual.Models;
using System.Net;
using System.Net.Mail;

namespace MS_LojaVirtual.Libraries.Email
{
     public class ContatoEmail
     {
          public static void EnviarContatoPorEmail(Contato contato)
          {
               /*
                * SMTP -> Servidor que vai enviar a mensagem.
                */
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); 
            
               smtp.UseDefaultCredentials = false;
               smtp.Credentials = new NetworkCredential("msena2210@gmail.com", "informe a senha do email");
               smtp.EnableSsl = true;

               string corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>" +
                   "<b>Nome: </b> {0} <br />" +
                   "<b>E-mail: </b> {1} <br />" +
                   "<b>Texto: </b> {2} <br />" +
                   "<br /> E-mail enviado automaticamente do site LojaVirtual.",
                   contato.Nome,
                   contato.Email,
                   contato.Texto
               );


               /*
                * MailMessage -> Construir a mensagem
                */
               MailMessage mensagem = new MailMessage();
               mensagem.From = new MailAddress("msena2210@gmail.com");
               mensagem.To.Add("msena2210@gmail.com");
               mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
               mensagem.Body = corpoMsg;
               mensagem.IsBodyHtml = true;

               //Enviar Mensagem via SMTP
               //No google só funcionou quando ativamos a opção : Acesso a app menos seguro --> Ativada 
               smtp.Send(mensagem);
          }
     }
}