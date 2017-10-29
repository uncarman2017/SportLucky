using SportLucky.Service.Domain.Business;
using SportLucky.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SportLucky.Service.Host.Controllers
{
    //[EnableCors("*", "Content-Type,Accept", "GET, POST, PUT, DELETE, OPTIONS")]
    //[EnableCors("*", "*", "*")]
    public class FiveStarCoachController : ApiController, IFiveStarCoachService
    {
        //public HttpResponseMessage Post(RequestArgs args)
        //{

        //    string client_id = args.client_id;

        //    string redirect_uri = args.redirect_uri;

        //    string response_type = args.response_type;

        //    return Request.CreateResponse(HttpStatusCode.OK, "I have received your message. Client_id = " + client_id + ", RedirectUri = " + redirect_uri + "response_type = " + response_type);

        //}

        public string Options()
        {

            return null; // HTTP 200 response with empty body

        }

        #region 用户相关

        /// <summary>
        /// 1.发送验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/SendValidationCode/mobile/{mobile}")]
        public SendValidationCodeResponse SendValidationCode(string mobile)
        {
            //return new SendValidationCodeResponse { Result=true, ResultMessage ="ok" };
            return FiveStarCoachManager.GetInstance().SendValidationCode(mobile);
        }

        /// <summary>
        /// 2.注册
        /// </summary>
        /// <param name="mobile">手机号码</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Register")]
        public RegisterResponse Register(RegisterRequest request)
        {
            return FiveStarCoachManager.GetInstance().Register(request);
        }

        /// <summary>
        /// 3.用户登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Login")]
        public LoginResponse Login(LoginRequest request)
        {
            return FiveStarCoachManager.GetInstance().Login(request);

        }

        /// <summary>
        /// 4.更新密码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdatePwd")]
        public UpdatePwdResponse UpdatePwd(UpdatePwdRequest request)
        {
            return FiveStarCoachManager.GetInstance().UpdatePwd(request);
        }

        /// <summary>
        /// 5.搜索教练
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SearchCoach")]
        public SearchCoachResponse SearchCoach(SearchCoachRequest request)
        {
            return FiveStarCoachManager.GetInstance().SearchCoach(request);
        }

        /// <summary>
        /// 6.获取教练详情
        /// </summary>
        /// <param name="coachNumber"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetCoachDetail/CoachNumber/{coachNumber}")]
        public GetCoachDetailResponse GetCoachDetail(string coachNumber)
        {
            return FiveStarCoachManager.GetInstance().GetCoachDetail(coachNumber);
        }

        /// <summary>
        /// 7.更新教练详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdateCoachDetail")]
        public UpdateCoachDetailResponse UpdateCoachDetail(UpdateCoachDetailRequest request)
        {
            return FiveStarCoachManager.GetInstance().UpdateCoachDetail(request);
        }

        /// <summary>
        /// 8.搜索会员
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/searchguest/mobile/{mobile}")]
        public SearchGuestResponse SearchGuest(string mobile)
        {
            return FiveStarCoachManager.GetInstance().SearchGuest(mobile);
        }

        /// <summary>
        /// 9.更新用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdateUserInfo")]
        public UpdateUserInfoResponse UpdateUserInfo(UpdateUserInfoRequest request)
        {
            return FiveStarCoachManager.GetInstance().UpdateUserInfo(request);
        }

        /// <summary>
        /// 10.提交用户照片
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SubmitUserPhoto")]
        public SubmitUserPhotoResponse SubmitUserPhoto(SubmitUserPhotoRequest request)
        {
            return FiveStarCoachManager.GetInstance().SubmitUserPhoto(request);
        }

        /// <summary>
        /// 11.移除用户照片
        /// </summary>
        /// <param name="userPhotoID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/RemoveUserPhoto/UserPhotoID/{userPhotoID}")]
        public RemoveUserPhotoResponse RemoveUserPhoto(long userPhotoID)
        {
            return FiveStarCoachManager.GetInstance().RemoveUserPhoto(userPhotoID);
        }

        [HttpPost]
        [Route("api/FocusUser")]
        public FocusUserResponse FocusUser(FocusUserRequest request)
        {
            return FiveStarCoachManager.GetInstance().FocusUser(request);
        }


        [HttpPost]
        [Route("api/GetUserDetail")]
        public GetUserDetailResponse GetUserDetail(GetUserDetailRequest request)
        {
            return FiveStarCoachManager.GetInstance().GetUserDetail(request);
        }
        #endregion

        #region 课程相关
        /// <summary>
        /// 12.获取课程提醒列表
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetCourseNotification/userID/{userID}")]
        public GetCourseNotificationResponse GetCourseNotification(long userID)
        {
            return FiveStarCoachManager.GetInstance().GetCourseNotification(userID);
        }

        /// <summary>
        /// 13.更新课程预订 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdateCourseBooking")]
        public UpdateCourseBookingResponse UpdateCourseBooking(UpdateCourseBookingRequest request)
        {
            return FiveStarCoachManager.GetInstance().UpdateCourseBooking(request);
        }

        /// <summary>
        /// 14.取消课程预订
        /// </summary>
        /// <param name="courseBookingID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/CancelCourseBooking/CourseBookingID/{courseBookingID}")]
        public CancelCourseBookingResponse CancelCourseBooking(long courseBookingID)
        {
            return FiveStarCoachManager.GetInstance().CancelCourseBooking(courseBookingID);
        }

        /// <summary>
        /// 15.获取我的未上课程信息
        /// </summary>
        /// <param name="userID">会员的用户ID</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetMyUncompletedBookingInfo/userid/{userID}")]
        public GetMyUncompletedBookingInfoResponse GetMyUncompletedBookingInfo(long userID)
        {
            return FiveStarCoachManager.GetInstance().GetMyUncompletedBookingInfo(userID);
        }

        /// <summary>
        /// 16.获取我的已上课程信息
        /// </summary>
        /// <param name="userID">用户ID</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetMyCompletedBookingInfo/userid/{userID}")]
        public GetMyCompletedBookingInfoResponse GetMyCompletedBookingInfo(long userID)
        {
            return FiveStarCoachManager.GetInstance().GetMyCompletedBookingInfo(userID);
        }

        /// <summary>
        /// 17.获取我购买的课程列表
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetMyCourseList/userid/{userID}")]
        public GetMyCourseListResponse GetMyCourseList(long userID)
        {
            return FiveStarCoachManager.GetInstance().GetMyCourseList(userID);
        }

        /// <summary>
        /// 18.获取我的教练列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetMyCoachList")]
        public GetMyCoachListResponse GetMyCoachList(GetMyCoachListRequest request)
        {
            return FiveStarCoachManager.GetInstance().GetMyCoachList(request);
        }

        /// <summary>
        /// 19.获取我购买的课程名称列表
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetMyCourseNameList/UserID/{userID}")]
        public GetMyCourseNameListResponse GetMyCourseNameList(long userID)
        {
            return FiveStarCoachManager.GetInstance().GetMyCourseNameList(userID);
        }

        /// <summary>
        /// 20.预订课程
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/BookingCourse")]
        public BookingCourseResponse BookingCourse(BookingCourseRequest request)
        {
            return FiveStarCoachManager.GetInstance().BookingCourse(request);
        }

        /// <summary>
        /// 21.提交课程评论(日记)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SubmitCourseComment")]
        public SubmitCourseCommentResponse SubmitCourseComment(SubmitCourseCommentRequest request)
        {
            return FiveStarCoachManager.GetInstance().SubmitCourseComment(request);
        }


        #endregion

        #region 推荐
        /// <summary>
        /// 获取最新推荐信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetLatestRecommendation")]
        public GetLatestRecommendationResponse GetLatestRecommendation(GetLatestRecommendationRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 对推荐信息点赞
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/AgreeRecommendation")]
        public AgreeRecommendationResponse AgreeRecommendation(AgreeRecommendationRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 收藏推荐信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/CollectRecommendation")]
        public CollectRecommendationResponse CollectRecommendation(CollectRecommendationRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 推荐推荐信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SubmitRecommendation")]
        public SubmitRecommendationResponse SubmitRecommendation(SubmitRecommendationRequest request)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 免费咨询
        /// <summary>
        /// 获取免费咨询问题列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetFreeQuestion")]
        public GetFreeQuestionResponse GetFreeQuestion(GetFreeQuestionRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 答复问题
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/ReplyQuestion")]
        public ReplyQuestionResponse ReplyQuestion(ReplyQuestionRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 提交免费咨询问题
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SubmitQuestion")]
        public SubmitQuestionResponse SubmitQuestion(SubmitQuestionRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 对免费咨询问题点赞
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/AgreeQuestion")]
        public AgreeQuestionResponse AgreeQuestion(AgreeQuestionRequest request)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}