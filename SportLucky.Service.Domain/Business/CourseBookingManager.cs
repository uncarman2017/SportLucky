using Dapper;
using SportLucky.Service.Contract;
using SportLucky.Service.Domain.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Domain.Business
{
    public class CourseBookingManager : BaseManager<CourseBookingManager>
    {
        public static CourseBookingManager GetInstance()
        {
            if (self == null) self = new CourseBookingManager();
            return self;
        }

        public BookingCourseResponse BookingCourse(BookingCourseRequest request)
        {
            var result = new BookingCourseResponse()
            {
                ResultMessage = "预约公益课成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_UserID", request.BookingInfo.UserID, DbType.Int32);
                    parms.Add("P_CourseTypeID", request.BookingInfo.CourseTypeID, DbType.Int32);
                    parms.Add("P_CoachID", request.BookingInfo.CoachID, DbType.Int32);
                    parms.Add("P_CourseDate", request.BookingInfo.CourseDate, DbType.DateTime);
                    parms.Add("P_Hours", request.BookingInfo.Hours, DbType.Int32);
                    parms.Add("P_GymAddress", request.BookingInfo.GymAddress, DbType.String);
                    parms.Add("P_Remark", request.BookingInfo.Remark, DbType.String);

                    result.CourseBookingID = con.ExecuteScalar<int>("sp_BookingCourse"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "预约公益课异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }


        public CancelBookingByCoachResponse CancelBookingByCoach(CancelBookingByCoachRequest request)
        {
            var result = new CancelBookingByCoachResponse()
            {
                ResultMessage = "取消公益课成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_CourseBookingID", request.CourseBookingID, DbType.Int32);
                    parms.Add("P_CancelReason", request.CancelReason, DbType.String);

                    con.ExecuteNoneQuery("sp_CancelBookingByCoach"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "取消公益课异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }


        public CancelBookingByCustomerResponse CancelBookingByCustomer(CancelBookingByCustomerRequest request)
        {
            var result = new CancelBookingByCustomerResponse()
            {
                ResultMessage = "取消公益课成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_CourseBookingID", request.CourseBookingID, DbType.Int32);
                    parms.Add("P_CancelReason", request.CancelReason, DbType.String);

                    con.ExecuteNoneQuery("sp_CancelBookingByCustomer"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "取消公益课异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

        public ConfirmBookingByCoachResponse ConfirmBookingByCoach(ConfirmBookingByCoachRequest request)
        {
            var result = new ConfirmBookingByCoachResponse()
            {
                ResultMessage = "确认公益课成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_CourseBookingID", request.CourseBookingID, DbType.Int32);
                    parms.Add("P_IsCoachMobilePublic", request.IsCoachMobilePublic, DbType.Boolean);

                    con.ExecuteNoneQuery("sp_ConfirmBookingByCoach"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "确认公益课异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

        public CheckInResponse CheckIn(CheckInRequest request)
        {
            var result = new CheckInResponse()
            {
                ResultMessage = "签到成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_UserID", request.UserID, DbType.Int32);

                    con.ExecuteNoneQuery("sp_CheckIn"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "签到异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;

        }

        public GetCourseBookingDetailResponse GetCourseBookingDetail(GetCourseBookingDetailRequest request)
        {
            var result = new GetCourseBookingDetailResponse()
            {
                ResultMessage = "获取课程预订明细成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_CourseBookingID", request.CourseBookingID, DbType.Int32);
                    result.BookingInfo = con.Query<CourseBookingDTO>("sp_GetCourseBookingDetail"
                       , parms
                       , CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "获取课程预订明细异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

        public UpdateCourseBookingResponse UpdateCourseBooking(UpdateCourseBookingRequest request)
        {
            var result = new UpdateCourseBookingResponse()
            {
                ResultMessage = "更新公益课信息成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_CourseBookingID", request.CourseBookingID, DbType.Int32);
                    parms.Add("P_CourseBeginTime", request.CourseBeginTime, DbType.DateTime);
                    parms.Add("P_CourseEndTime", request.CourseEndTime, DbType.DateTime);
                    parms.Add("P_CoachID", request.CoachID, DbType.Int32);
                    parms.Add("P_Hours", request.Hours, DbType.Int32);

                    con.ExecuteNoneQuery("sp_UpdateCourseBooking"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "更新公益课信息异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

        public GetMyBookingListResponse GetMyBookingList(GetMyBookingListRequest request)
        {
            var result = new GetMyBookingListResponse()
            {
                ResultMessage = "获取我的公益课程列表成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_UserID", request.UserID, DbType.Int32);
                    parms.Add("P_BeginDate", request.BeginDate, DbType.DateTime);
                    parms.Add("P_EndDate", request.EndDate, DbType.DateTime);

                    result.MyBookingList = con.Query<CourseBookingDTO>("sp_GetMyBookingList"
                       , parms
                       , CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "获取我的公益课程列表异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }
        public SubmitCourseCommentResponse SubmitCourseComment(SubmitCourseCommentRequest request)
        {
            var result = new SubmitCourseCommentResponse()
            {
                ResultMessage = "提交课程评论成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_UserID", request.UserID, DbType.Int32);
                    parms.Add("P_CourseBookingID", request.CourseBookingID, DbType.Int32);
                    parms.Add("P_Comment", request.Comment, DbType.String);

                    result.CommentID = con.ExecuteScalar<int>("sp_SubmitCourseComment"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "提交课程评论异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }
        public SubmitCollectionResponse SubmitCollection(SubmitCollectionRequest request)
        {
            var result = new SubmitCollectionResponse()
            {
                ResultMessage = "添加收藏成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_UserID", request.UserID, DbType.Int32);
                    parms.Add("P_CollectionType", request.CollectionType, DbType.Int32);
                    parms.Add("P_ObjectID", request.ObjectID, DbType.Int32);

                    result.CollectionID = con.ExecuteScalar<int>("sp_SubmitCollection"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "添加收藏异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

        public GetMyCollectionResponse GetMyCollection(GetMyCollectionRequest request)
        {
            var result = new GetMyCollectionResponse()
            {
                ResultMessage = "获取我的收藏列表成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_UserID", request.UserID, DbType.Int32);

                    result.MyCollections = con.Query<CollectionDTO>("sp_GetMyCollection"
                       , parms
                       , CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "获取我的收藏列表异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

        public GetMySiteLetterResponse GetMySiteLetter(GetMySiteLetterRequest request)
        {
            var result = new GetMySiteLetterResponse()
            {
                ResultMessage = "获取我的站内信列表成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_UserID", request.UserID, DbType.Int32);

                    result.SiteLetterList = con.Query<SiteLetterDTO>("sp_GetMySiteLetter"
                       , parms
                       , CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "获取我的站内信列表异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

    }
}
