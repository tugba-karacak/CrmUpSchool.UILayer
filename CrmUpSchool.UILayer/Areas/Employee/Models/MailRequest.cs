using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Areas.Employee.Models
{
    public class MailRequest
    {
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string EmailSubject { get; set; }
        public string EmailContent { get; set; }
    }
}
