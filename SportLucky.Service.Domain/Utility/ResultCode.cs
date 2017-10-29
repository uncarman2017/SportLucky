using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Domain.Utility
{
    public class ResultCode
    {
        public static string Success { get { return "0000"; } }
        public static string Error { get { return "0001"; } }
    }
}
