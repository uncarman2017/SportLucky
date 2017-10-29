using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 客人提交课程评论响应报文
    /// </summary>
    public class SubmitCourseCommentResponse : BaseResponse
    {
        /// <summary>
        /// 新建的评论记录ID
        /// </summary>
        public long CommentID { get; set; }
    }
}
