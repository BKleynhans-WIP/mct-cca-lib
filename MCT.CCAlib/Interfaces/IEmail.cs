using System.Collections.Generic;

using MCT.CCAlib.Interfaces.config;

namespace MCT.CCAlib.Interfaces
{
    public interface IEmail
    {
        IEmailConfig DefaultEmailConfig { get; set; }
        IEmailConfig VendorSpecificEmailConfig { get; set; }

        bool SendEmail(List<string> recipients, List<string> ccRecipients, List<string> bccRecipients, string subject, string body);
        bool SendEmail(List<string> recipients, List<string> ccRecipients, List<string> bccRecipients, string subject, string body, byte[] attachmentBytes, string attachmentName);
        bool SendEmail(List<string> recipients, string subject, string body);
    }
}
