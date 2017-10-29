using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 发送验证码至手机请求报文
    /// </summary>
    public class SendValidationCodeRequest
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }
    }
}
