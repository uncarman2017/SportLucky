using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取我的站内信请求报文
    /// </summary>
    
    public class GetMySiteLetterRequest
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; } 
    }
}
