using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 更新教练详情信息请求报文
    /// </summary>
    public class UpdateCoachDetailRequest
    {
        /// <summary>
        /// 教练详情
        /// </summary>
        public CoachDTO Coach { get; set; }
    }
}
