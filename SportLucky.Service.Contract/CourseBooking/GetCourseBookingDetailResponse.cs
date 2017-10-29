using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取课程预订详情响应报文
    /// </summary>
    public class GetCourseBookingDetailResponse : BaseResponse
    {
        /// <summary>
        /// 预约信息
        /// </summary>
        public CourseBookingDTO BookingInfo { get; set; }
    }
}
