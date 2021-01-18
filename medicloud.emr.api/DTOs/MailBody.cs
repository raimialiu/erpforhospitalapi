using MimeKit;
using System;
using MailKit.Net.Smtp;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using se = System.Net.Mail;
using System.Net;

namespace medicloud.emr.api.DTOs
{
    public class EmailMessage
    {
        public MailboxAddress Sender { get; set; }
        public MailboxAddress Reciever { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }


    }

    public class EmailMessageHelper
    {
        private EmailConfiguration _emailConfig;
        private static EmailMessageHelper _helper;
        private static object _lock= new object();
        private se.SmtpClient _smtpClient;

        public static EmailMessageHelper instance(EmailConfiguration config)
        {
            lock(_lock)
            {
                if(_helper == null)
                {
                    return new EmailMessageHelper(config);
                }

                return _helper;
            }
        }

        private EmailMessageHelper(EmailConfiguration _config)
        {
            this._emailConfig = _config;
            _smtpClient = new se.SmtpClient();
        }


        public async Task<bool> sendMailMailMessageAsync(MailBodyDTO mailBodyDTO)
        {
            MailMessage message = new MailMessage();
            //SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(_emailConfig.From);
            message.To.Add(new MailAddress(mailBodyDTO.to[0]));
            message.Subject = mailBodyDTO.subject;
            message.IsBodyHtml = false; //to make message body as html  
            message.Body = mailBodyDTO.messageBody;
            _smtpClient.Port = 587;
            _smtpClient.Host = _emailConfig.SmtpServer; //for gmail host  
            _smtpClient.EnableSsl = false;
            _smtpClient.UseDefaultCredentials = false;
            _smtpClient.Credentials = new NetworkCredential(_emailConfig.Username, _emailConfig.Password);
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            _smtpClient.Send(message);
            //EmailMessage _message = new EmailMessage()
            //{
            //    Content = message.messageBody,
            //    Reciever = new MailboxAddress(message.to[0]),
            //    Subject = message.subject
            //  //  Sender = new MailboxAddress(_emailConfig.Username)
            //};

            //var mimeMessage = CreateMimeMessageFromEmailMessage(_message);
            //using (MailKit.Net.Smtp.SmtpClient smtpClient = new MailKit.Net.Smtp.SmtpClient())
            //{
            //    await smtpClient.ConnectAsync(_emailConfig.SmtpServer,
            //    _emailConfig.Port, false);
            //    await smtpClient.AuthenticateAsync(_emailConfig.Username,
            //    _emailConfig.Password);
            //    smtpClient.Send(mimeMessage);
            //    smtpClient.Disconnect(true);
            //}
            return true;
        }

        public bool sendMailMailMessage(MailBodyDTO message)
        {
            EmailMessage _message = new EmailMessage()
            {
                 Content = message.messageBody,
                 Reciever = new MailboxAddress(message.to[1]),
                 Subject = message.subject,
                 Sender = new MailboxAddress(message.from)
            };
          
            var mimeMessage = CreateMimeMessageFromEmailMessage(_message);
            using (MailKit.Net.Smtp.SmtpClient smtpClient = new MailKit.Net.Smtp.SmtpClient())
            {
                smtpClient.Connect(_emailConfig.SmtpServer,
                _emailConfig.Port, true);
                smtpClient.Authenticate(_emailConfig.Username,
                _emailConfig.Password);
                smtpClient.Send(mimeMessage);
                smtpClient.Disconnect(true);
            }
            return true;
        }

        private MimeMessage CreateMimeMessageFromEmailMessage(EmailMessage message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(message.Sender);
            mimeMessage.To.Add(message.Reciever);
            mimeMessage.Subject = message.Subject;
            mimeMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            { Text = message.Content };
            return mimeMessage;
        }
    }
    public class MailBodyDTO
    {
        public List<string> to { get; set; }
        public List<string> cc { get; set; }
        public List<string> bcc { get; set; }
        public bool isHtml { get; set; } = false;
        public string subject { get; set; }
        public string from { get; set; }
        public string messageBody { get; set; }
    }
}
