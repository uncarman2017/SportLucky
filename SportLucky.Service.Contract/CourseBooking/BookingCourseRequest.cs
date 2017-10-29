using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 课程预约请求报文
    /// </summary>
    public class BookingCourseRequest
    {
        /// <summary>
        /// 预约信息
        /// </summary>
        public CourseBookingDTO BookingInfo { get; set; }
        
    }
}
