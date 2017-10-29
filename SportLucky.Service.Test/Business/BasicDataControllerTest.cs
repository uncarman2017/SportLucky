using SportLucky.Service.Domain.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportLucky.Service.Domain.Business.Tests
{
    [TestClass()]
    public class BasicDataControllerTest : Test.BaseControllerTest
    {
        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }

        #endregion

        [TestMethod()]
        public void AddGymDetailTest()
        {
            var response = BasicDataManager.GetInstance().AddGymDetail( new Contract.AddGymDetailRequest {
                GymDetail =new Contract.GymDTO {
                     CityID=1
                     , GymName="test"
                     , GymAddress="test address"
                     , GymDesc="test desc"
                }
            });

            Assert.IsNotNull(response, "没有返回结果。");
            Assert.IsFalse(response != null && response.Errors != null && response.Errors.Count > 0, string.Format("返回结果错误信息:{0}", response.Errors != null ? string.Join(";", response.Errors) : string.Empty));
            Assert.IsTrue(response.GymID>0, "数据写入不成功。");
        }

        [TestMethod]
        public void GetGymDetailTest()
        {
            var response = BasicDataManager.GetInstance().GetGymDetail(new Contract.GetGymDetailRequest { GymID = 1 });
            Assert.IsNotNull(response, "没有返回结果。");
            Assert.IsFalse(response != null && response.Errors != null && response.Errors.Count > 0, string.Format("返回结果错误信息:{0}", response.Errors != null ? string.Join(";", response.Errors) : string.Empty));
            Assert.IsNotNull(response.GymDetail, response.ResultMessage);
            Assert.IsTrue(!string.IsNullOrEmpty(response.GymDetail.GymName), "Gym信息不合法。");
        }

        [TestMethod()]
        public void SearchGymTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateGymLocationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SubmitGymCorrectionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoveGymPhotoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddCoachDetailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCoachDetailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchCoachTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchCoachAndGymTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetHomeCoachListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoveCoachPhotoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUserDetailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateUserInfoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetHomeArticleListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCourseTypeListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDicItemListTest()
        {
            Assert.Fail();
        }
    }
}