using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 客人取消预订信息请求报文
    /// </summary>
    public class CancelBookingByCustomerRequest
    {
        /// <summary>
        /// 预订记录ID
        /// </summary>
        public long CourseBookingID { get; set; }

        /// <summary>
        /// 取消原因
        /// </summary>
        public string CancelReason { get; set; }
    }
}
