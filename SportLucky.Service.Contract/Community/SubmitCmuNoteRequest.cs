using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 提交社区帖子请求报文
    /// </summary>
    public class SubmitCmuNoteRequest
    {
        /// <summary>
        /// 提交者的用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 帖子内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 帖子附图列表
        /// </summary>
        public List<PhotoDTO> Imgs { get; set; }
    }
}
