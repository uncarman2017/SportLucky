using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
      /// <summary>
    /// 提交社区帖子响应报文
    /// </summary>
    public class SubmitCmuNoteResponse : BaseResponse
    {
        /// <summary>
        /// 帖子ID
        /// </summary>
        [DataMember]
        public long NoteID { get; set; }
    }
}
