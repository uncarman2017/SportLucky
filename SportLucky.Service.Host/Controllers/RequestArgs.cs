using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportLucky.Service.Host.Controllers
{
    public class RequestArgs
    {

        public string client_id { get; set; }

        public string redirect_uri { get; set; }

        public string response_type { get; set; }

    }
}