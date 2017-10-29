using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 审核教练响应报文
    /// </summary>
    public class ApproveCoachResponse : BaseResponse
    {
        /// <summary>
        /// 教练ID
        /// </summary>
        public int CoachID { get; set; }
    }
}
