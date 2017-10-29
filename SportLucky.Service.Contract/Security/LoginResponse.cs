using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    
    /// <summary>
    /// 用户登录响应
    /// </summary>
    public class LoginResponse : BaseResponse
    {
        /// <summary>
        /// 登录后的用户信息
        /// </summary>
        [DataMember]
        public UserDTO User { get; set; }

       
    }
}
