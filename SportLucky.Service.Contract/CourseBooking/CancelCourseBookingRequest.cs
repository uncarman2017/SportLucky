using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 取消
    /// </summary>
    public class CancelCourseBookingRequest
    {
        /// <summary>
        /// 预订记录ID
        /// </summary>
        public long CourseBookingID { get; set; }
    }
}
