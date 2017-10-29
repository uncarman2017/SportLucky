using SportLucky.Service.Domain.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportLucky.Service.Domain.Business.Tests
{
    [TestClass()]
    public class SecuityControllerTest: Test.BaseControllerTest
    {
        [TestInitialize()]
        public void TestInitialize()
        {
            base.TestContext.Properties["Mobile"] = "13700000000";
            base.TestContext.Properties["Pwd"] = "Test";
            base.TestContext.Properties["NewPwd"] = "Test_New";
        }

        [TestCleanup()]
        public void TestCleanup()
        {
            base.TestContext.Properties.Clear();
        }

        [TestMethod()]
        public void LoginTest()
        {
            var response = new SecurityManager().Login(new Contract.LoginRequest() {
                Mobile = this.TestContext.Properties["Mobile"].ToString(),
                Pwd = this.TestContext.Properties["Pwd"].ToString() });

            Assert.IsNotNull(response, "没有返回结果。");
            Assert.IsFalse(response != null && response.Errors != null && response.Errors.Count > 0, string.Format("返回结果错误信息:{0}", response.Errors != null ? string.Join(";", response.Errors) : string.Empty));
            Assert.IsNotNull(response.User, response.ResultMessage);
            Assert.IsTrue(!string.IsNullOrEmpty(response.User.Mobile), "用户信息不合法。");
        }

        [TestMethod()]
        public void RegisterTest()
        {
            var mobile = base.TestContext.Properties["Mobile"].ToString();

            var securityManager = new SecurityManager();
            securityManager.SendValidationCode(mobile);
            var validationCode = securityManager.GetValidationCode(mobile);

            var response = new SecurityManager().Register(new Contract.RegisterRequest() {  ValidationCode= validationCode
                , NewUser= new Contract.UserDTO() {
                     Age=25,
                    HeadPortraitUri ="",
                    Height =190,
                    Mobile = mobile,
                    MobileInfo ="",
                    NickName ="Test User",
                    PersonalSign ="",
                    Sex =1,
                    UserStatus =0,
                    UserType =1,
                    Weight =80,
                    LoginPwd = this.TestContext.Properties["Pwd"].ToString()
                } });
            Assert.IsNotNull(response, "没有返回结果。");
            Assert.IsFalse(response!= null && response.Errors != null && response.Errors.Count > 0, 
                string.Format("返回结果错误信息:{0}", response.Errors!=null? string.Join(";", response.Errors) : string.Empty));
            Assert.IsTrue(response.UserID > 0, response.ResultMessage);
        }

        [TestMethod()]
        public void SendValidationCodeTest()
        {
            var mobile = base.TestContext.Properties["Mobile"].ToString();

            var securityManager = new SecurityManager();
            var response = securityManager.SendValidationCode(mobile);

            Assert.IsNotNull(response, "没有返回结果。");
            Assert.IsFalse(response != null && response.Errors != null && response.Errors.Count > 0, 
                string.Format("返回结果错误信息:{0}", response.Errors != null ? string.Join(";", response.Errors) : string.Empty));

            var validationCode = securityManager.GetValidationCode(mobile);
            Assert.IsNotNull(validationCode, "未找到验证码");
        }

        [TestMethod()]
        public void UpdatePwdTest()
        {
            var mobile = base.TestContext.Properties["Mobile"].ToString();

            var securityManager = new SecurityManager();
            securityManager.SendValidationCode(mobile);
            var validationCode = securityManager.GetValidationCode(mobile);

            var response = securityManager.UpdatePwd(new Contract.UpdatePwdRequest() {
                Mobile = mobile,
                ValidationCode = validationCode,
                NewPwd = this.TestContext.Properties["NewPwd"].ToString(),
                UserID =1 });
            Assert.IsNotNull(response, "没有返回结果。");
            Assert.IsFalse(response != null && response.Errors != null && response.Errors.Count > 0, 
                string.Format("返回结果错误信息:{0}", response.Errors != null ? string.Join(";", response.Errors) : string.Empty));
        }
    }
}