using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 签到响应报文
    /// </summary>
    public class CheckInResponse : BaseResponse
    {
        /// <summary>
        /// 获得的肌点
        /// </summary>
        public int Points { get; set; }
    }
}
