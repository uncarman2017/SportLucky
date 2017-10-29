using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{

    /// <summary>
    /// 注册用户响应报文
    /// </summary>
    public class RegisterResponse : BaseResponse
    {
        /// <summary>
        /// 新注册的用户ID
        /// </summary>
        [DataMember]
        public long UserID { get; set; }

      
    }
}
