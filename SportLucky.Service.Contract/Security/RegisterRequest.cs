using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 注册用户请求报文
    /// </summary>
    public class RegisterRequest
    {
        /// <summary>
        /// 新注册的用户
        /// </summary>
        public UserDTO NewUser { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string ValidationCode { get; set; }
    }
}
