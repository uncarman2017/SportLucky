using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 私教入驻请求报文
    /// </summary>
    public class AddCoachDetailRequest
    {
        public AddCoachDetailRequest()
        {
            Coach = new CoachDTO();
        }

        public CoachDTO Coach { get; set; }
    }
}
