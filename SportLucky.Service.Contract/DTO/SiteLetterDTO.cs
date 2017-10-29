using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 站内信信息
    /// </summary>
    public class SiteLetterDTO
    {
        /// <summary>
        /// 站内信ID
        /// </summary>
        public long LetterID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 信件标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 信件内容
        /// </summary>

        public string Content { get; set; }
    }
}
