using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 审核场馆请求报文
    /// </summary>
    public class ApproveGymRequest
    {
        /// <summary>
        /// 场馆审批记录ID
        /// </summary>
        public int GymApprovalID { get; set; } 
        
        /// <summary>
        /// 审批状态
        /// </summary>
        public int ApproveStatus { get; set; }
    }
}
