using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    
    /// <summary>
    /// 获取用户详情(个人主页详情)请求报文
    /// </summary>
    public class GetUserDetailRequest
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }
    }
}
