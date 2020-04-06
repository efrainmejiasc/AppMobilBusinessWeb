using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.Models
{
    public class TicketAcceso
    {
        public string access_token { get; set; }
        public string expire_token { get; set; }
        public string type_token { get; set; }
        public string refresh_token { get; set; }
        public string email { get; set; }
        public string user { get; set; }
        public string idCompany { get; set; }
        public string status { get; set; }
        public string idTypeUser { get; set; }
    }
}
