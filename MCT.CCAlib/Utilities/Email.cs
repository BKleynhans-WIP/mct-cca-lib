using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;

using MCT.CCAlib.Interfaces;
using MCT.CCAlib.Interfaces.config;
using MCT.CCAlib.Models.Config;

namespace MCT.CCAlib.Utilities
{
    public class Email : IEmail
    {
        private readonly ILogger<Email> _logger;
        private readonly IConfiguration _config;
        private readonly ITools _tools;

        public IEmailConfig DefaultEmailConfig { get; set; }
        public IEmailConfig VendorSpecificEmailConfig { get; set; }
        
        public Email(ILogger<Email> logger, IConfiguration config, ITools tools)
        {
            _logger = logger;
            _config = config;
            _tools = tools;

            DefaultEmailConfig = _config.GetSection("Email").Get<EmailConfig>();
        }

        /// <summary>
        /// Send email to To recipients (recipient list separated by semi-colon)
        /// </summary>
        /// <param name="recipients"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public bool SendEmail(List<string> recipients, string subject, string body)
        {
            return SendEmail(recipients, null, null, subject, body, null, string.Empty);
        }

        /// <summary>
        /// Sends email to recipients including CC and BCC (recipient list separated by semi-colon)
        /// </summary>
        /// <param name="recipients"></param>
        /// <param name="ccRecipients"></param>
        /// <param name="bccRecipients"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public bool SendEmail(List<string> recipients, List<string> ccRecipients, List<string> bccRecipients, string subject, string body)
        {
            return SendEmail(recipients, ccRecipients, bccRecipients, subject, body, null, string.Empty);
        }

        /// <summary>
        /// Sends email to recipients (recipient list separated by semi-colon) with attachment
        /// </summary>
        /// <param name="recipients"></param>
        /// <param name="ccRecipients"></param>
        /// <param name="ccRecipients"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="attachmentBytes"></param>
        /// <param name="attachmentName"></param>
        /// <returns></returns>
        public bool SendEmail(List<string> recipients, List<string> ccRecipients, List<string> bccRecipients, string subject, string body, byte[] attachmentBytes, string attachmentName)
        {
            bool isSent = false;

            if (_tools.ListIsNullOrEmpty(recipients) && _tools.ListIsNullOrEmpty(ccRecipients) && _tools.ListIsNullOrEmpty(bccRecipients))
            {
                _logger.LogInformation($" Email recipients were not provided");
                return isSent;
            }

            try
            {
                MailMessage mailMessage = new()
                {
                    From = new MailAddress(DefaultEmailConfig.From),
                    Subject = subject,
                    Body = body
                };

                AddRecipientsToMailMessage(recipients, ccRecipients, bccRecipients, mailMessage);
                AddAttachmentToMailMessage(attachmentBytes, attachmentName, mailMessage);

                isSent = SendMailMessage(mailMessage);

            }
            catch (Exception)
            {
                throw;
            }

            return isSent;
        }

        /// <summary>
        /// Checks recipient list and add to message when the recipient is provided
        /// </summary>
        /// <param name="recipients"></param>
        /// <param name="ccRecipients"></param>
        /// <param name="bccRecipients"></param>
        /// <param name="mailMessage"></param>
        private void AddRecipientsToMailMessage(List<string> recipients, List<string> ccRecipients, List<string> bccRecipients, MailMessage mailMessage)
        {
            AddRecipientToAddressCollectionItem(recipients, mailMessage.To);
            AddRecipientToAddressCollectionItem(ccRecipients, mailMessage.CC);
            AddRecipientToAddressCollectionItem(bccRecipients, mailMessage.Bcc);
        }

        /// <summary>
        /// Checks list for addresses, splits list into individual addresses while removing white space and empty items
        /// Adds email address to collection item (To, CC, BCC)
        /// </summary>
        /// <param name="recipients"></param>
        /// <param name="mailAddressesCollection"></param>
        private void AddRecipientToAddressCollectionItem(List<string> recipients, MailAddressCollection mailAddressesCollection)
        {
            if (!(_tools.ListIsNullOrEmpty(recipients)) && (recipients[0] != ""))
            {
                foreach (var address in recipients)
                {
                    mailAddressesCollection.Add(address);
                }
            }
        }

        /// <summary>
        /// Checks that attachment is not null and a name is provided, then adds the attachment to message
        /// </summary>
        /// <param name="attachmentBytes"></param>
        /// <param name="attachmentName"></param>
        /// <param name="mailMessage"></param>
        private void AddAttachmentToMailMessage(byte[] attachmentBytes, string attachmentName, MailMessage mailMessage)
        {
            try
            {
                if (attachmentBytes != null && !string.IsNullOrEmpty(attachmentName))
                {
                    Attachment attachment = new(new MemoryStream(attachmentBytes), attachmentName);
                    mailMessage.Attachments.Add(attachment);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Creates the SMTP client and calls the send method to send the email
        /// </summary>
        /// <param name="mailMessage"></param>
        /// <returns></returns>
        private bool SendMailMessage(MailMessage mailMessage)
        {
            bool isSent = false;

            try
            {
                SmtpClient smtpClient = new(DefaultEmailConfig.SmtpServer, 25);
                smtpClient.Send(mailMessage);
                isSent = true;
            }
            catch (Exception)
            {
                throw;
            }

            return isSent;
        }
    }
}
