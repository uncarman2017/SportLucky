using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取课程预订详情请求报文
    /// </summary>
    public class GetCourseBookingDetailRequest
    {
        /// <summary>
        /// 预约记录ID
        /// </summary>
        public long CourseBookingID { get; set; }
    }
}
