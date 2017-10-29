using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 提交社交圈帖子请求报文
    /// </summary>
    public class SubmitCmuNoteCommentRequest
    {
        /// <summary>
        /// 帖子ID
        /// </summary>
        public long NoteID { get; set; }

        /// <summary>
        /// 提交者的用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 帖子内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否点赞
        /// </summary>
        public bool IsAgreed { get; set; }
    }
}
