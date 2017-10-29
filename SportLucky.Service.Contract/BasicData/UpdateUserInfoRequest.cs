using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 更新用户信息请求报文
    /// </summary>
    public class UpdateUserInfoRequest
    {
        public UserDTO NewUserInfo { get; set; }
    }
}
