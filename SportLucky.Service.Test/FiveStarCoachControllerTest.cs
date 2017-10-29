using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportLucky.Service.Host.Controllers;
using SportLucky.Service.Contract;

namespace SportLucky.Service.Test
{
    [TestClass]
    public class FiveStarCoachControllerTest
    {
        [TestMethod]
        public void SendValidationCode_Test()
        {
            var controller = new FiveStarCoachController();
            var response = controller.SendValidationCode("18939748695");
            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void Register_Test()
        {
            var controller = new FiveStarCoachController();
            var request = new RegisterRequest()
            {
                Mobile = "15902147760",
                Pwd = "redmaple",
                UserName = "Max Yu",
                UserType = 2,
                ValidationCode = "1234"

            };

            string requestStr = Newtonsoft.Json.JsonConvert.SerializeObject(request, Newtonsoft.Json.Formatting.Indented);
            var response = controller.Register(request);
            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void Login_Test()
        {
            var controller = new FiveStarCoachController();
            var response = controller.Login(new LoginRequest()
            {
                Mobile = "15000429206",
                Pwd = "redmaple"
                
            });
            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void UpdatePwd_Test()
        {
            var controller = new FiveStarCoachController();
            var response = controller.UpdatePwd(new UpdatePwdRequest()
            {
                Mobile = "15821130654",
                NewPwd = "P@ssw0rd",
                UserID = 2,
                ValidationCode = "123456"
            });
            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void SearchCoach_Test()
        {
            var controller = new FiveStarCoachController();
            var response = controller.SearchCoach(new SearchCoachRequest()
            {
                Keyword = "Kale",
                CourseName = "普拉提"
            });
            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void GetCoachDetail_Test()
        {
            var controller = new FiveStarCoachController();
            var response = controller.GetCoachDetail("C000001");
            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void UpdateCoachDetail_Test()
        {
            var controller = new FiveStarCoachController();
            var response = controller.GetCoachDetail("C000001");

            var response2 = controller.UpdateCoachDetail(
                new UpdateCoachDetailRequest()
                {
                    CoachNumber = response.CoachNumber,
                    BriefIntroduction = response.BriefIntroduction,
                    ContactInfo = response.ContactInfo,
                    CourseDesc = response.CourseDesc,
                    GymID = 1,
                    HeadPortraitUri = response.HeadPortraitUri,
                    HonorDesc = "五星私人教练，无氧专家",
                    Level = 5,
                    PersonalSign = "我爱五星私人教练App"

                });
            Assert.IsTrue(response2.Result);

        }

        [TestMethod]
        public void SearchGuest_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.SearchGuest("18939748695");
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void UpdateUserInfo_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.UpdateUserInfo(new UpdateUserInfoRequest()
            {
                Mobile = "18939748695",
                NickName = "麦麦Max",
                TrueName = "俞佳玮",
                UserID = 3
            });
            Assert.IsTrue(result.Result);
        }


        [TestMethod]
        public void SubmitUserPhoto_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.SubmitUserPhoto(new SubmitUserPhotoRequest()
            {
                UserID = 2,
                PhotoUrl = "http://localhost:60444/UserPhoto",
                PhotoDesc = "Test"
            });

            Assert.IsTrue(result.Result);

        }

        [TestMethod]
        public void RemoveUserPhoto_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.RemoveUserPhoto(1);
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void GetCourseNotification_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.GetCourseNotification(2);
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void BookingCourse_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.BookingCourse(new BookingCourseRequest()
            {
                CoachNumber = "C000001",
                CourseNumber = "N0001",
                CourseTime = DateTime.Now,
                Hours = 3,
                IsDelegated = false,
                UserID = 3
            });
            Assert.IsTrue(result.Result);
        }


        [TestMethod]
        public void UpdateCourseBooking_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.UpdateCourseBooking(
                new UpdateCourseBookingRequest() { CourseBookingID = 1, BookingTime = DateTime.Now, Hours = 2 });
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void GetMyUncompletedBookingInfo_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.GetMyUncompletedBookingInfo(2);
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void CancelCourseBooking_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.CancelCourseBooking(1);
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void SubmitCourseComment_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.SubmitCourseComment(new SubmitCourseCommentRequest()
            {
                UserID = 2,
                CoachComment = "课程结束，效果不错，学员比较努力",
                CourseBookingID = 1,
                CourseNumber = "N0001",
                CoachNumber = "C000001"
            });

            Assert.IsTrue(result.Result);
        }


        [TestMethod]
        public void GetMyCompletedBookingInfo_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.GetMyCompletedBookingInfo(2);
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void GetMyCourseList_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.GetMyCourseList(2);
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void GetMyCoachList_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.GetMyCoachList(new GetMyCoachListRequest() { 
                UserID = 2,
                CourseNumber = "N0001"
            });
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void GetMyCourseNameList_Test()
        {
            var controller = new FiveStarCoachController();
            var result = controller.GetMyCourseNameList(2);
            
            Assert.IsTrue(result.Result);
        }

       
    }
}
