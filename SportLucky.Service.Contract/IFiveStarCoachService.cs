using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace SportLucky.Service.Contract
{
    [ServiceContract]
    public interface IFiveStarCoachService
    {
        #region 用户相关
        SendValidationCodeResponse SendValidationCode(string mobile);
        
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        //[WebGet(UriTemplate = "/User/Register/{mobile}",  ResponseFormat = WebMessageFormat.Json)]
        RegisterResponse Register(RegisterRequest request);

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //[WebInvoke(Method = "POST", UriTemplate = "/User/Login",  BodyStyle=WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        LoginResponse Login(LoginRequest request);

        /// <summary>
        /// 更新口令
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdatePwdResponse UpdatePwd(UpdatePwdRequest request);

        

        /// <summary>
        /// 搜索教练
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //[WebInvoke(Method = "POST", UriTemplate = "/User/SearchCoach", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        SearchCoachResponse SearchCoach(SearchCoachRequest request);

        /// <summary>
        /// 获取教练详情
        /// </summary>
        /// <param name="coachNumber"></param>
        /// <returns></returns>
        GetCoachDetailResponse GetCoachDetail(string coachNumber);

        /// <summary>
        /// 更新教练详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateCoachDetailResponse UpdateCoachDetail(UpdateCoachDetailRequest request);
        /// <summary>
        /// 搜索客人
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        //[WebGet(UriTemplate = "/User/SeachGuest/{mobile}",  ResponseFormat = WebMessageFormat.Json)]
        SearchGuestResponse SearchGuest(string mobile);

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateUserInfoResponse UpdateUserInfo(UpdateUserInfoRequest request);

        /// <summary>
        /// 提交照片
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        SubmitUserPhotoResponse SubmitUserPhoto(SubmitUserPhotoRequest request);

        /// <summary>
        /// 移除照片
        /// </summary>
        /// <param name="userPhotoID"></param>
        /// <returns></returns>
        RemoveUserPhotoResponse RemoveUserPhoto(long userPhotoID);

        FocusUserResponse FocusUser(FocusUserRequest request);

        GetUserDetailResponse GetUserDetail(GetUserDetailRequest request);
        #endregion


        #region 课程相关

        /// <summary>
        /// 获取课程提醒信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        GetCourseNotificationResponse GetCourseNotification(long userID);

        /// <summary>
        /// 更新课程预订
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateCourseBookingResponse UpdateCourseBooking(UpdateCourseBookingRequest request);

        /// <summary>
        /// 取消课程预订
        /// </summary>
        /// <param name="courseBookingID"></param>
        /// <returns></returns>
        CancelCourseBookingResponse CancelCourseBooking(long courseBookingID);
        
        /// <summary>
        /// 获取我的未上课程列表信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        //[WebGet(UriTemplate = "/Course/GetMyCourseInfo/{userID}", ResponseFormat = WebMessageFormat.Json)]
        GetMyUncompletedBookingInfoResponse GetMyUncompletedBookingInfo(long userID);

        /// <summary>
        /// 获取我的已上课程列表信息
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="courseNumber"></param>
        /// <returns></returns>
        //[WebGet(UriTemplate = "/Course/GetCourseComments/{userID}", ResponseFormat = WebMessageFormat.Json)]
        GetMyCompletedBookingInfoResponse GetMyCompletedBookingInfo(long userID);

        /// <summary>
        /// 获取我的教练列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetMyCoachListResponse GetMyCoachList(GetMyCoachListRequest request);

        /// <summary>
        /// 获取我购买的课程名称列表
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        GetMyCourseNameListResponse GetMyCourseNameList(long userID);
        /// <summary>
        /// 预订课程
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
       // [WebInvoke(Method = "POST", UriTemplate = "/Course/BookingCourse", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        BookingCourseResponse BookingCourse(BookingCourseRequest request);

        /// <summary>
        /// 提交课程评论
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        SubmitCourseCommentResponse SubmitCourseComment(SubmitCourseCommentRequest request);

        /// <summary>
        /// 获取我购买的课程列表
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        GetMyCourseListResponse GetMyCourseList(long userID);

        #endregion

     
    }



}
