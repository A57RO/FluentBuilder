using System.Net.Mail;

namespace FluentBuilder
{
    public class EmailBuilder
    {
        private Email email;

        public EmailBuilder(string recipientAddress)
        {
            email = new Email {To = new MailAddress(recipientAddress)};
        }

        public EmailBuilder From(string fromAddress)
        {
            email.From = new MailAddress(fromAddress);

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

        public Email GetResultMessage(string content)
        {
            email.Content = content;

            return email;
        }
    }
}
