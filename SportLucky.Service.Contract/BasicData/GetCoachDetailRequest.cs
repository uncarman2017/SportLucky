using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取教练详情响应报文
    /// </summary>
    public class GetCoachDetailRequest
    {
        /// <summary>
        /// 教练ID
        /// </summary>
        public int CoachID { get; set; } 
    }
}
