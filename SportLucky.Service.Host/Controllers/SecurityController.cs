using SportLucky.Service.Contract;
using SportLucky.Service.Domain.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportLucky.Service.Host.Controllers
{
    public class SecurityController : ApiController, ISecurityService
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Login")]
        public LoginResponse Login(LoginRequest request)
        {
            return SecurityManager.GetInstance().Login(request);
        }

        /// <summary>
        /// 验证注册信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/ValidateRegister")]
        public ValidateRegisterResponse ValidateRegister(ValidateRegisterRequest request)
        {
            return SecurityManager.GetInstance().ValidateRegister(request);
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Register")]
        public RegisterResponse Register(RegisterRequest request)
        {
            return SecurityManager.GetInstance().Register(request);
        }

        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/SendValidationCode/mobile/{mobile}")]
        public SendValidationCodeResponse SendValidationCode(string mobile)
        {
            return SecurityManager.GetInstance().SendValidationCode(mobile);
        }

        [HttpPost]
        [Route("api/UpdatePwd")]
        public UpdatePwdResponse UpdatePwd(UpdatePwdRequest request)
        {
            return SecurityManager.GetInstance().UpdatePwd(request);
        }
    }
}