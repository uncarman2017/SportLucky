using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 课程预订服务接口
    /// </summary>
    [ServiceContract]
    public interface ICourseBookingService
    {
        BookingCourseResponse BookingCourse(BookingCourseRequest request);

        CancelBookingByCoachResponse CancelBookingByCoach(CancelBookingByCoachRequest request);

        CancelBookingByCustomerResponse CancelBookingByCustomer(CancelBookingByCustomerRequest request);


        CheckInResponse CheckIn(CheckInRequest request);

        ConfirmBookingByCoachResponse ConfirmBookingByCoach(ConfirmBookingByCoachRequest request);


        GetCourseBookingDetailResponse GetCourseBookingDetail(GetCourseBookingDetailRequest request);

        GetMyBookingListResponse GetMyBookingList(GetMyBookingListRequest request);

        GetMyCollectionResponse GetMyCollection(GetMyCollectionRequest request);

        GetMySiteLetterResponse GetMySiteLetter(GetMySiteLetterRequest request);

     
        SubmitCollectionResponse SubmitCollection(SubmitCollectionRequest request);

        SubmitCourseCommentResponse SubmitCourseComment(SubmitCourseCommentRequest request);

        UpdateCourseBookingResponse UpdateCourseBooking(UpdateCourseBookingRequest request);

    }
}
