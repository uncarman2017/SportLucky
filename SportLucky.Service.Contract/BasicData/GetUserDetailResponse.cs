using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取用户详情(个人主页详情)响应报文
    /// </summary>
    public class GetUserDetailResponse : BaseResponse
    {
        /// <summary>
        /// 用户详情信息
        /// </summary>
        [DataMember]
        public UserDTO User { get; set; }

      
    }
}
