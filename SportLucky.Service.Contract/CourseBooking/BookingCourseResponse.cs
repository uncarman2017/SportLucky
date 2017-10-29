using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 课程预约响应报文
    /// </summary>
    public class BookingCourseResponse : BaseResponse
    {
        /// <summary>
        /// 新的预约记录ID
        /// </summary>
        public long CourseBookingID { get; set; }
    }
}
