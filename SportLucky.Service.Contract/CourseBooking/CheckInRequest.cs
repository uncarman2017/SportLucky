using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 签到请求报文
    /// </summary>
    public class CheckInRequest
    {
        /// <summary>
        /// 签到者的用户ID
        /// </summary>
        public int UserID { get; set; }

    }
}
