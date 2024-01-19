using System.Collections.Generic;

namespace MCT.CCAlib.Interfaces.config
{
    public interface IEmailConfig
    {
        List<string> Bcc { get; set; }
        string Body { get; set; }
        List<string> Cc { get; set; }
        string From { get; set; }
        string SmtpServer { get; set; }
        string Subject { get; set; }
        List<string> To { get; set; }
    }
}