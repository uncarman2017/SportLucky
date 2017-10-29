using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取我的站内信响应报文
    /// </summary>
    public class GetMySiteLetterResponse : BaseResponse
    {
        /// <summary>
        /// 站内信列表
        /// </summary>
        public List<SiteLetterDTO> SiteLetterList { get; set; }
    }
}
