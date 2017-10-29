using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 用户登录请求
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }
        
        /// <summary>
        /// 口令
        /// </summary>
        public string Pwd { get; set; }


        
    
    }
}
