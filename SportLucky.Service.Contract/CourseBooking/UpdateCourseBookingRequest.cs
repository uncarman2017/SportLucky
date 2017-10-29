using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 修改课程预约信息请求报文
    /// </summary>
    public class UpdateCourseBookingRequest
    {
        /// <summary>
        /// 课程预订记录ID
        /// </summary>
        public long CourseBookingID { get; set; }

        /// <summary>
        /// 上课时间,格式HH:mm
        /// </summary>
        public DateTime CourseBeginTime { get; set; }

        /// <summary>
        /// 下课时间,格式HH:mm
        /// </summary>
        public DateTime CourseEndTime { get; set; }

        /// <summary>
        /// 更换的教练ID
        /// </summary>
        public int CoachID { get; set; }

        /// <summary>
        /// 课时
        /// </summary>
        public int Hours { get; set; }


    }
}
