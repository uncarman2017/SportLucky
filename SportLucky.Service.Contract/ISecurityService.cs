using SportLucky.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 安全服务接口
    /// </summary>
    [ServiceContract]
    public interface ISecurityService
    {
        LoginResponse Login(LoginRequest request);
        RegisterResponse Register(RegisterRequest request);

        SendValidationCodeResponse SendValidationCode(string mobile);

        UpdatePwdResponse UpdatePwd(UpdatePwdRequest request);


    }
}
