using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_theater.Services.Mail
{
    public class SendGridAuthOptions
    {
        public string KeyName { get; set; }
        public string ApiKey { get; set; }
    }
}
