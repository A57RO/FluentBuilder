using System.Collections.Generic;
using System.Net.Mail;

namespace FluentBuilder
{
    public class Email
    {
        public static EmailBuilder SendTo(string address) => new EmailBuilder(address);
        public MailAddress From { get; set; }
        public MailAddress To { get; set; }
        public List<MailAddress> CC { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}