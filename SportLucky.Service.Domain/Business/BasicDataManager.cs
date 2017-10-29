using Dapper;
using Newtonsoft.Json;
using SportLucky.Service.Contract;
using SportLucky.Service.Domain.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SportLucky.Service.Domain.Business
{
    public class BasicDataManager : BaseManager<BasicDataManager>
    {
        public static BasicDataManager GetInstance()
        {
            if (self == null) self = new BasicDataManager();
            return self;
        }

        #region 场馆

        public AddGymDetailResponse AddGymDetail(AddGymDetailRequest request)
        {
            var result = base.CreateResponse<AddGymDetailResponse>("新建场馆");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_CityID", request.GymDetail.CityID, DbType.Int32);
                    parms.Add("P_DistrictID", request.GymDetail.DistrictID, DbType.Int32);
                    parms.Add("P_GymName", request.GymDetail.GymName, DbType.String);
                    parms.Add("P_GymAddress", request.GymDetail.GymAddress, DbType.String);
                    parms.Add("P_GymDesc", request.GymDetail.GymDesc, DbType.String);
                    parms.Add("P_Phone", request.GymDetail.Phone, DbType.String);
                    parms.Add("P_Longitude", request.GymDetail.Longitude, DbType.Decimal);
                    parms.Add("P_Latitude", request.GymDetail.Latitude, DbType.Decimal);
                    parms.Add("P_StarLevel", request.GymDetail.StarLevel, DbType.SByte);
                    parms.Add("P_Photos_Json", request.GymDetail.Photos != null && request.GymDetail.Photos.Count > 0 ? JsonConvert.SerializeObject(request.GymDetail.Photos) : string.Empty
                        , DbType.String);

                    result.GymID = con.ExecuteScalar<int>("sp_AddGymDetail"
                        , parms
                        , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }

            return result;
        }


        public GetGymDetailResponse GetGymDetail(GetGymDetailRequest request)
        {
            var result = base.CreateResponse<GetGymDetailResponse>("获取场馆信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_GymID", request.GymID, DbType.Int32);
                    result.GymDetail  = con.Query<GymDTO>("sp_GetGymDetail", parms, CommandType.StoredProcedure).Select(x=> {
                        if (x != null && !string.IsNullOrWhiteSpace(x.Photos_Json))
                        {
                            x.Photos = JsonConvert.DeserializeObject<List<PhotoDTO>>(x.Photos_Json);
                        }
                        return x;
                    }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }


        public SearchGymResponse SearchGym(SearchGymRequest request)
        {
            var result = base.CreateResponse<SearchGymResponse>("查找场馆信息");

            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("CityID", request.CityID, DbType.Int32);
                    parms.Add("DistrictID", request.DistrictID, DbType.Int32);
                    parms.Add("CourseTypeIDs", string.Join(",", request.Courses.Select<CourseTypeDTO,int>(o=> { return o.CourseTypeID; })), DbType.String);
                    result.Gyms = con.Query<BriefGymDTO>("sp_SearchGym", parms, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }

            return result;
        }

        public UpdateGymLocationResponse UpdateGymLocation(UpdateGymLocationRequest request)
        {
            var result = base.CreateResponse<UpdateGymLocationResponse>("更新场馆地图位置信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("GymID", request.GymID, DbType.Int32);
                    parms.Add("Longitude", request.Longitude, DbType.Decimal);
                    parms.Add("Latitude", request.Latitude, DbType.Decimal);

                    con.ExecuteNoneQuery("sp_UpdateGymLocation", parms, CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }

        public SubmitGymCorrectionResponse SubmitGymCorrection(SubmitGymCorrectionRequest request)
        {
            var result = base.CreateResponse<SubmitGymCorrectionResponse>("提交场馆纠错信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("GymID", request.GymID, DbType.Int32);
                    parms.Add("UserID", request.UserID, DbType.Double);
                    parms.Add("Content", request.Content, DbType.String);
                    parms.Add("P_Photos_Json", request.PhotoList!=null && request.PhotoList.Count>0 ? JsonConvert.SerializeObject(request.PhotoList) : string.Empty, DbType.String);

                    con.ExecuteNoneQuery("sp_SubmitGymCorrection", parms, CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }

        public RemoveGymPhotoResponse RemoveGymPhoto(RemoveGymPhotoRequest request)
        {
            var result = base.CreateResponse<RemoveGymPhotoResponse>("删除场馆信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("GymID", request.GymID, DbType.Int32);
                    parms.Add("PhotoID", request.PhotoID, DbType.Double);
                    result.Photos = con.Query<PhotoDTO>("sp_RemoveGymPhoto", parms, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }
      

        #endregion

        #region 教练

        public AddCoachDetailResponse AddCoachDetail(AddCoachDetailRequest request)
        {
            var result = base.CreateResponse<AddCoachDetailResponse>("新建教练信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("UserID", request.Coach.UserID, DbType.Int32);
                    parms.Add("Name", request.Coach.Name, DbType.String);
                    parms.Add("Level", request.Coach.Level, DbType.SByte);
                    parms.Add("IsFree", request.Coach.IsFree, DbType.Boolean);
                    parms.Add("PersonalSign", request.Coach.PersonalSign, DbType.String);
                    parms.Add("BriefIntroduction", request.Coach.BriefIntroduction, DbType.String);
                    parms.Add("HonorDesc", request.Coach.HonorDesc, DbType.String);
                    parms.Add("Certificates", request.Coach.Certificates, DbType.String);
                    parms.Add("CourseDesc", request.Coach.CourseDesc, DbType.String);
                    parms.Add("GymDesc", request.Coach.GymDesc, DbType.String);
                    parms.Add("AreaDesc", request.Coach.AreaDesc, DbType.String);
                    parms.Add("IsHomeRecommended", request.Coach.IsHomeRecommended, DbType.Boolean);
                    parms.Add("Photos", request.Coach.Photos != null && request.Coach.Photos.Count > 0 ? JsonConvert.SerializeObject(request.Coach.Photos) : string.Empty, DbType.String);
                    result.CoachID = con.ExecuteScalar<int>("sp_AddCoachDetail", parms, CommandType.StoredProcedure);
                    
                    foreach (var c in request.Coach.Courses)
                    {
                        parms = new DynamicParameters();
                        parms.Add("CourseTypeID", c.CourseTypeID, DbType.Int32);
                        parms.Add("CoachID", c.ChargeType, DbType.Int32);
                        result.CoachID = con.ExecuteScalar<int>("sp_AddCourseCoach", parms, CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }


        public GetCoachDetailResponse GetCoachDetail(GetCoachDetailRequest request)
        {
            var result = base.CreateResponse<GetCoachDetailResponse>("获取教练信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    result.Coach = con.Query<CoachDTO>("sp_GetCoachDetail", request, CommandType.StoredProcedure).Select(x => {
                        if (x != null && !string.IsNullOrWhiteSpace(x.Photos_Json))
                        {
                            x.Photos = JsonConvert.DeserializeObject<List<PhotoDTO>>(x.Photos_Json);
                        }
                        return x;

                    }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }


        public SearchCoachResponse SearchCoach(SearchCoachRequest request)
        {
            var result = base.CreateResponse<SearchCoachResponse>("查找教练信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    result.Coaches = con.Query<BriefCoachDTO>("sp_SearchCoach", request, CommandType.StoredProcedure).ToList();
                }

                //TODO 处理复杂对象查询
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }


        public SearchCoachAndGymResponse SearchCoachAndGym(SearchCoachAndGymRequest request)
        {
            var result = base.CreateResponse<SearchCoachAndGymResponse>("查找教练和场馆信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    result.CoachAndGymList = con.Query<BriefCoachAndGymDTO>("sp_SearchCoachAndGym", request, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }


        public GetHomeCoachListResponse GetHomeCoachList(GetHomeCoachListRequest request)
        {
            var result = base.CreateResponse<GetHomeCoachListResponse>("获取教练信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("BeginDate", request.BeginDate, DbType.DateTime);
                    parms.Add("EndDate", request.EndDate, DbType.DateTime);
                    result.Coaches = con.Query<BriefCoachDTO>("sp_GetHomeCoachList", parms, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }

        public RemoveCoachPhotoResponse RemoveCoachPhoto(RemoveCoachPhotoRequest request)
        {
            var result = base.CreateResponse<RemoveCoachPhotoResponse>("删除教练照片");
            result.CoachID = request.CoachID;
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    result.Photos = con.Query<PhotoDTO>("sp_RemoveCoachPhoto", request, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }
        #endregion

        #region 用户
        public GetUserDetailResponse GetUserDetail(GetUserDetailRequest request)
        {
            var result = base.CreateResponse<GetUserDetailResponse>("获取用户信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    result.User = con.Query<UserDTO>("sp_GetUserDetail", request, CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }

        public UpdateUserInfoResponse UpdateUserInfo(UpdateUserInfoRequest request)
        {
            var result = base.CreateResponse<UpdateUserInfoResponse>("更新用户信息");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("UserID", request.NewUserInfo.UserID, DbType.Int32);
                    parms.Add("Mobile", request.NewUserInfo.Mobile, DbType.String);
                    parms.Add("MobileInfo", request.NewUserInfo.MobileInfo, DbType.String);
                    parms.Add("UserType", request.NewUserInfo.UserType, DbType.SByte);
                    parms.Add("NickName", request.NewUserInfo.NickName, DbType.String);
                    parms.Add("Sex", request.NewUserInfo.Sex, DbType.String);
                    parms.Add("Age", request.NewUserInfo.Age, DbType.SByte);
                    parms.Add("PersonalSign", request.NewUserInfo.PersonalSign, DbType.String);
                    parms.Add("HeadPortraitUri", request.NewUserInfo.HeadPortraitUri, DbType.String);
                    parms.Add("Height", request.NewUserInfo.Height, DbType.Double);
                    parms.Add("Weight", request.NewUserInfo.MobileInfo, DbType.Double);
                    parms.Add("UserStatus", request.NewUserInfo.MobileInfo, DbType.SByte);
                    con.ExecuteNoneQuery("sp_UpdateUserInfo", parms, CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }

        #endregion

        #region 文章

        public GetHomeArticleListResponse GetHomeArticleList(GetHomeArticleListRequest request)
        {
            var result = base.CreateResponse<GetHomeArticleListResponse>("获取文章内容");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("BeginDate", request.BeginDate, DbType.DateTime);
                    parms.Add("EndDate", request.EndDate, DbType.DateTime);
                    result.Articles = con.Query<BriefArticleDTO>("sp_GetHomeArticleList", parms, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }

            return result;
        }

        #endregion

        #region 其他
        public GetCourseTypeListResponse GetCourseTypeList(GetCourseTypeListRequest request)
        {
            var result = base.CreateResponse<GetCourseTypeListResponse>("获取课程类型");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    result.CourseTypeList = con.Query<CourseTypeDTO>("sp_GetCourseTypeList", request, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }

        public GetDicItemListResponse GetDicItemList(GetDicItemListRequest request)
        {
            var result = base.CreateResponse<GetDicItemListResponse>("获取字典项列表");
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    result.DicItemList = con.Query<DictionaryItemDTO>("sp_GetDicItemList", request, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                base.HandleResponseException(ref result, ex);
            }
            return result;
        }
        #endregion
    }
}
