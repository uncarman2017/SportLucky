using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 客人提交课程评论请求报文
    /// </summary>
    public class SubmitCourseCommentRequest
    {
        /// <summary>
        /// 客人的用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 预订记录ID
        /// </summary>
        public long CourseBookingID { get; set; }


        /// <summary>
        /// 课程评论
        /// </summary>
        public string Comment { get; set; }

    }
}
