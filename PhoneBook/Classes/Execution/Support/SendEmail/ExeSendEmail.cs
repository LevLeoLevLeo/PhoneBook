using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Controls;

namespace PhoneBook.Classes.Execution.Support
{
    /// <summary>
    /// Класс, отправляющий проверочный код на почту.
    /// </summary>
    public class ExeSendEmail
    {
        private string x;
        private TextBox TextBoxEmail { get; set; }
        private TextBox TextBoxLogin { get; set; }
        public ExeSendEmail(ref TextBox textBoxEmail, ref TextBox textBoxLogin)
        {
            TextBoxEmail = textBoxEmail;
            TextBoxLogin = textBoxLogin;
        }
        
        /// <summary>
        /// Отправляет сообщение с кодом подтверждения на почту.
        /// </summary>
        /// <returns></returns>
        public string Send()
        {
            try
            {

                Random RNDCheckEmail = new Random();

                x = RNDCheckEmail.Next(000000, 999999).ToString();

                MailAddress fromMailAddress = new MailAddress("testemailformailing@gmail.com", "PhoneBookSupport");
                MailAddress toMailAddress = new MailAddress(TextBoxEmail.Text, TextBoxLogin.Text);

                using (MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress))

                using (SmtpClient smtpClient = new SmtpClient())

                {

                    mailMessage.Subject = "Регистрация в PhoneBook";
                    mailMessage.Body = $"Здравствуйте, {TextBoxLogin.Text}!" +
                        "<p>Это Ваш код для завершения регистрации в PhoneBook!" +
                        $"<p><h5>{x}</h5>" + "<p>Он необходим для подтверждения, " +
                        "что владельцем электронной почты являетесь именно Вы." +
                        "<p>Никому не сообщайте Ваш код!" +
                        "<p>Если это были не Вы, просто проигнорируйте данное письмо.";
                    mailMessage.IsBodyHtml = true;

                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(
                        fromMailAddress.Address, "r6h-Emq-SMH-uCL"); //Please don't steal my email password.
                                                                     //This mail is for my study project
                                                                     //and there is nothing important on it,
                                                                     //but it is important for my project.
                                                                     //Peace to all!))

                    smtpClient.Send(mailMessage);
                    return x;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
