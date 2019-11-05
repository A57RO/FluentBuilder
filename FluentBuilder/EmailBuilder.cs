using System.Net.Mail;

namespace FluentBuilder
{
    public class EmailBuilder
    {
        private Email email;

        public EmailBuilder()
        {
            email = new Email();
        }

        public EmailBuilder From(string fromAddress)
        {
            email.From = new MailAddress(fromAddress);

            return this;
        }

        public EmailBuilder To(string toAddress)
        {
            email.To = new MailAddress(toAddress);

            return this;
        }
        
        public EmailBuilder Cc(string copyAddress)
        {
            email.CC.Add(new MailAddress(copyAddress));

            return this;
        }

        public EmailBuilder Subject(string subject)
        {
            email.Subject = subject;

            return this;
        }

        public EmailBuilder Content(string content)
        {
            email.Content = content;

            return this;
        }

        public Email Result => email;
    }
}
