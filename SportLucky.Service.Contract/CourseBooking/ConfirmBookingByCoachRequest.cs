using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 教练确认预约请求报文
    /// </summary>
    public class ConfirmBookingByCoachRequest
    {
        /// <summary>
        /// 预订记录ID
        /// </summary>
        public long CourseBookingID { get; set; }

        /// <summary>
        /// 是否公开手机号码给客人
        /// </summary>
        public bool IsCoachMobilePublic { get; set; }
    }
}
