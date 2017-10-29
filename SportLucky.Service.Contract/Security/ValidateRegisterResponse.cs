using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{    
    /// <summary>
    /// 验证用户信息响应
    /// </summary>
    public class ValidateRegisterResponse: BaseResponse
    {
        public bool UserExist { get; set; }
    }
}
