using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 审核场馆响应报文
    /// </summary>
    public class ApproveGymResponse : BaseResponse
    {
        /// <summary>
        /// 场馆ID
        /// </summary>
        public int GymID { get; set; }
    }
}
