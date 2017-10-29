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
    public class CourseBookingController : ApiController, ICourseBookingService
    {
        /// <summary>
        /// 预订课程
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/BookingCourse")]
        public BookingCourseResponse BookingCourse(BookingCourseRequest request)
        {
            return CourseBookingManager.GetInstance().BookingCourse(request);
        }

        [HttpPost]
        [Route("api/CancelBookingByCoach")]
        public CancelBookingByCoachResponse CancelBookingByCoach(CancelBookingByCoachRequest request)
        {
            return CourseBookingManager.GetInstance().CancelBookingByCoach(request);
        }


        [HttpPost]
        [Route("api/CancelBookingByCustomer")]
        public CancelBookingByCustomerResponse CancelBookingByCustomer(CancelBookingByCustomerRequest request)
        {
            return CourseBookingManager.GetInstance().CancelBookingByCustomer(request);
        }


        [HttpPost]
        [Route("api/ConfirmBookingByCoach")]
        public ConfirmBookingByCoachResponse ConfirmBookingByCoach(ConfirmBookingByCoachRequest request)
        {
            return CourseBookingManager.GetInstance().ConfirmBookingByCoach(request);
        }

        /// <summary>
        /// 签到
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/CheckIn")]
        public CheckInResponse CheckIn(CheckInRequest request)
        {
            return CourseBookingManager.GetInstance().CheckIn(request);
        }

        /// <summary>
        /// 获取课程预订明细信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetCourseBookingDetail")]
        public GetCourseBookingDetailResponse GetCourseBookingDetail(GetCourseBookingDetailRequest request)
        {
            return CourseBookingManager.GetInstance().GetCourseBookingDetail(request);
        }

        /// <summary>
        /// 获取我的预订列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetMyBookingList")]
        public GetMyBookingListResponse GetMyBookingList(GetMyBookingListRequest request)
        {
            return CourseBookingManager.GetInstance().GetMyBookingList(request);
        }

        /// <summary>
        /// 获取我的收藏信息列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetMyCollection")]
        public GetMyCollectionResponse GetMyCollection(GetMyCollectionRequest request)
        {
            return CourseBookingManager.GetInstance().GetMyCollection(request);
        }

        /// <summary>
        /// 获取我的站内信列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetMySiteLetter")]
        public GetMySiteLetterResponse GetMySiteLetter(GetMySiteLetterRequest request)
        {
            return CourseBookingManager.GetInstance().GetMySiteLetter(request);
        }

        /// <summary>
        /// 移除场馆图片
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/RemoveGymPhotoRequest")]
        public RemoveGymPhotoResponse RemoveGymPhoto(RemoveGymPhotoRequest request)
        {
            return BasicDataManager.GetInstance().RemoveGymPhoto(request);
        }

        /// <summary>
        /// 提交收藏
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SubmitCollection")]
        public SubmitCollectionResponse SubmitCollection(SubmitCollectionRequest request)
        {
            return CourseBookingManager.GetInstance().SubmitCollection(request);
        }

        /// <summary>
        /// 提交课程评论
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SubmitCourseComment")]
        public SubmitCourseCommentResponse SubmitCourseComment(SubmitCourseCommentRequest request)
        {
            return CourseBookingManager.GetInstance().SubmitCourseComment(request);
        }

       

        /// <summary>
        /// 更新课程预订信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdateCourseBooking")]
        public UpdateCourseBookingResponse UpdateCourseBooking(UpdateCourseBookingRequest request)
        {
            return CourseBookingManager.GetInstance().UpdateCourseBooking(request);
        }



    }
}