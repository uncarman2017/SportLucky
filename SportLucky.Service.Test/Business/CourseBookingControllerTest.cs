using SportLucky.Service.Domain.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using SportLucky.Service.Domain.Utility;

namespace SportLucky.Service.Domain.Business.Tests
{
    /// <summary>
    /// CourseBookingControllerTest 的摘要说明
    /// </summary>
    [TestClass]
    public class CourseBookingControllerTest
    {
        public CourseBookingControllerTest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void BookingCourseTest()
        {
            var response = CourseBookingManager.GetInstance().BookingCourse(new Contract.BookingCourseRequest
            {
                BookingInfo = new Contract.CourseBookingDTO
                {
                    UserID = 1,
                    CourseTypeID = 1,
                    CoachID = 1,
                    CourseDate = DateTime.Now.AddDays(1),
                    Hours = 2,
                    GymAddress = "测试地址",
                    Remark = "测试备注"
                }
            });
            response.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
            response.CourseBookingID.Should().BeGreaterThan(0);
        }

        [TestMethod()]
        public void GetCourseBookingDetail()
        {
            var response = CourseBookingManager.GetInstance().GetCourseBookingDetail(new Contract.GetCourseBookingDetailRequest
            {
                CourseBookingID = 1
            });
            response.Should().NotBeNull();
            response.BookingInfo.Should().NotBeNull();
        }

        [TestMethod()]
        public void UpdateGymLocation()
        {
            var response = CourseBookingManager.GetInstance().CancelBookingByCoach(new Contract.CancelBookingByCoachRequest
            {
                CourseBookingID = 1,
                CancelReason = "取消课程测试"
            });
            response.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
        }

        [TestMethod()]
        public void CancelBookingByCustomer()
        {
            var response = CourseBookingManager.GetInstance().CancelBookingByCustomer(new Contract.CancelBookingByCustomerRequest
            {
                CourseBookingID = 1,
                CancelReason = "取消课程测试"
            });
            response.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
        }

        [TestMethod()]
        public void ConfirmBookingByCoach()
        {
            var response = CourseBookingManager.GetInstance().ConfirmBookingByCoach(new Contract.ConfirmBookingByCoachRequest
            {
                CourseBookingID = 1,
                IsCoachMobilePublic = true
            });
            response.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
        }


        //[TestMethod()]
        //public void CheckIn()
        //{
        //    var response = CourseBookingManager.GetInstance().CheckIn(new Contract.CheckInRequest
        //    {
        //        UserID = 1
        //    });
        //    response.Should().NotBeNull();
        //    response.Result.Should().Be(ResultCode.Success);
        //}

        [TestMethod()]
        public void UpdateCourseBooking()
        {
            var response = CourseBookingManager.GetInstance().UpdateCourseBooking(new Contract.UpdateCourseBookingRequest
            {
                CoachID = 1,
                CourseBookingID = 1,
                CourseBeginTime = DateTime.Now.AddDays(2),
                CourseEndTime = DateTime.Now.AddDays(2).AddHours(2),
                Hours = 2
            });
            response.Should().NotBeNull();
            response.Errors.Should().BeNull();
        }

        [TestMethod()]
        public void SubmitCollection()
        {
            var response = CourseBookingManager.GetInstance().SubmitCollection(new Contract.SubmitCollectionRequest
            {
                UserID = 1,
                CollectionType = 1,
                ObjectID = 1
            });
            response.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
            response.CollectionID.Should().BeGreaterThan(0);
        }

        [TestMethod()]
        public void GetMyBookingList()
        {
            var response = CourseBookingManager.GetInstance().GetMyBookingList(new Contract.GetMyBookingListRequest
            {
                UserID = 1,
                BeginDate = DateTime.Now.AddDays(-100),
                EndDate = DateTime.Now.AddDays(100)
            });
            response.MyBookingList.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
            response.MyBookingList.Count.Should().BeGreaterThan(0);
        }

        [TestMethod()]
        public void SubmitCourseComment()
        {
            var response = CourseBookingManager.GetInstance().SubmitCourseComment(new Contract.SubmitCourseCommentRequest
            {
                UserID = 1,
                CourseBookingID = 1,
                Comment = "测试"
            });
            response.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
            response.CommentID.Should().BeGreaterThan(0);
        }


        [TestMethod()]
        public void GetMyCollection()
        {
            var response = CourseBookingManager.GetInstance().GetMyCollection(new Contract.GetMyCollectionRequest
            {
                UserID = 1
            });
            response.MyCollections.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
            response.MyCollections.Count.Should().BeGreaterThan(0);
        }

        [TestMethod()]
        public void GetMySiteLetter()
        {
            var response = CourseBookingManager.GetInstance().GetMySiteLetter(new Contract.GetMySiteLetterRequest
            {
                UserID = 1
            });
            response.SiteLetterList.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
        }
        
    }
}
