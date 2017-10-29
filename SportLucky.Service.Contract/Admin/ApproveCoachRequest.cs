using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 审核教练请求报文
    /// </summary>
    public class ApproveCoachRequest
    {
        /// <summary>
        /// 教练审批记录ID
        /// </summary>
        public int CoachApprovalID { get; set; }

        /// <summary>
        /// 审批状态
        /// </summary>
        public int ApproveStatus { get; set; }
        
    }
}
