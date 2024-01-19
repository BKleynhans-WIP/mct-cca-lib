using System.Collections.Generic;

using MCT.CCAlib.Interfaces.config;

namespace MCT.CCAlib.Models.Config
{
    public class EmailConfig : IEmailConfig
    {
        public string SmtpServer { get; set; }
        public string From { get; set; }
        public List<string> To { get; set; }
        public List<string> Cc { get; set; }
        public List<string> Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
