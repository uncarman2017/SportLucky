using Dapper;
using SportLucky.Service.Contract;
using SportLucky.Service.Domain.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Domain.Business
{
    public class SecurityManager : BaseManager<SecurityManager>
    {
        public static SecurityManager GetInstance()
        {
            if (self == null) self = new SecurityManager();
            return self;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public LoginResponse Login(LoginRequest request)
        {
            var result = base.CreateResponse<LoginResponse>("用户登录"); 
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_Mobile", request.Mobile, DbType.String);
                    parms.Add("P_Pwd", Utility.EncryptHelper.AESEncrypt(request.Pwd), DbType.String);
                    result.User = con.Query<UserDTO>("sp_Login", parms, CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }

        /// <summary>
        /// 验证注册信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ValidateRegisterResponse ValidateRegister(ValidateRegisterRequest request)
        {
            var result = base.CreateResponse<ValidateRegisterResponse>("验证注册信息");

            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_Mobile", request.Mobile, DbType.String);
                    var count = con.ExecuteScalar<int>("sp_ValidateRegisterUser", parms, CommandType.StoredProcedure);

                    if (count > 0)
                    {
                        result.UserExist = true;
                        result.ResultMessage = "用户已存在";
                    }
                    else
                    {
                        result.UserExist = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "验证用户信息异常";
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RegisterResponse Register(RegisterRequest request)
        {
            var result = base.CreateResponse<RegisterResponse>("用户注册");
            try
            {
                if (this.ConsumeValidationCode(request.NewUser.Mobile) == request.ValidationCode)
                {
                    var validateResult = this.ValidateRegister(new ValidateRegisterRequest() { Mobile= request.NewUser.Mobile });

                    if (validateResult != null && !validateResult.UserExist)
                    {
                        using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                        {
                            var parms = new DynamicParameters();
                            parms.Add("P_Mobile", request.NewUser.Mobile, DbType.String);
                            parms.Add("P_LoginPwd", Utility.EncryptHelper.AESEncrypt(request.NewUser.LoginPwd), DbType.String);
                            parms.Add("P_MobileInfo", request.NewUser.MobileInfo, DbType.String);
                            parms.Add("P_Age", request.NewUser.Age, DbType.SByte);
                            parms.Add("P_UserType", request.NewUser.UserType, DbType.SByte);
                            parms.Add("P_NickName", request.NewUser.NickName, DbType.String);
                            parms.Add("P_Sex", request.NewUser.Sex, DbType.SByte);
                            parms.Add("P_PersonalSign", request.NewUser.PersonalSign, DbType.String);
                            parms.Add("P_HeadPortraitUri", request.NewUser.HeadPortraitUri, DbType.String);
                            parms.Add("P_Height", request.NewUser.Height, DbType.Double);
                            parms.Add("P_Weight", request.NewUser.Weight, DbType.Double);
                            parms.Add("P_UserStatus", request.NewUser.UserStatus, DbType.SByte);

                            result.UserID = con.ExecuteScalar<int>("sp_Register", parms, CommandType.StoredProcedure);
                        }
                    }
                    else
                    {
                        result.ResultMessage = validateResult.ResultMessage;
                    }
                }
                else
                {
                    result.ResultMessage = "验证码错误";
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }

            return result;
        }

        /// <summary>
        /// 获取当前验证码，测试专用
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public String GetValidationCode(string mobile)
        {
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_Mobile", mobile, DbType.String);
                    return con.ExecuteScalar<string>("sp_GetSmsValidationCode", parms, CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog(ex);
            }

            return string.Empty;
        }

        /// <summary>
        /// 使用验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        private String ConsumeValidationCode(string mobile)
        {
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_Mobile", mobile, DbType.String);
                    return con.ExecuteScalar<string>("sp_ConsumeSmsValidationCode", parms, CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog(ex);
            }
            return string.Empty;
        }

        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public SendValidationCodeResponse SendValidationCode(string mobile)
        {
            var result = base.CreateResponse<SendValidationCodeResponse>("发送验证码");
            try
            {
                var validationCode = Utility.SmsValidationHelper.SendValidationCode(mobile);

                //缓存验证码
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_Mobile", mobile, DbType.String);
                    parms.Add("P_ValidationCode", validationCode, DbType.String);
                    parms.Add("P_ExpireTime", DateTime.Now.AddHours(1), DbType.DateTime);
                    con.ExecuteNoneQuery("sp_AddSmsValidationCode", parms, CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }

        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdatePwdResponse UpdatePwd(UpdatePwdRequest request)
        {
            var result = base.CreateResponse<UpdatePwdResponse>("更新用户密码");
            try
            {
                if (this.ConsumeValidationCode(request.Mobile) == request.ValidationCode)
                {
                    using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                    {
                        var parms = new DynamicParameters();
                        parms.Add("P_NewPwd", Utility.EncryptHelper.AESEncrypt(request.NewPwd), DbType.String);
                        parms.Add("P_UserID", request.UserID, DbType.Double);

                        con.ExecuteNoneQuery("sp_UpdatePwd", parms, CommandType.StoredProcedure);
                    }
                }
                else
                {
                    result.ResultMessage = "验证码错误";
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }

            return result;
        }
    }
}
