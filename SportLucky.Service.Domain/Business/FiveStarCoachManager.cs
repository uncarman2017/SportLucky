using MySql.Data.MySqlClient;
using SportLucky.Service.Domain.Utility;
using SportLucky.Service.Contract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Domain.Business
{
    public class FiveStarCoachManager
    {
        private static FiveStarCoachManager self = null;
        private const string dbName = "SportLuckyDB";
        private FiveStarCoachManager()
        {
        }

        public static FiveStarCoachManager GetInstance()
        {
            if (self == null) self = new FiveStarCoachManager();
            return self;
        }

        #region 用户相关
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public SendValidationCodeResponse SendValidationCode(string mobile)
        {
            var result = new SendValidationCodeResponse()
            {
                Result = true,
                ResultMessage = "发送验证码成功",
                Token = "123456"

            };

            try
            {
                //string validationCode = "123456";
                ////落地手机验证码历史记录
                //db.Database.ExecuteSqlCommand(TransactionalBehavior.EnsureTransaction, string.Format(@"UPDATE LoginHistory set IsValid=0,DataChange_LastTime=now() WHERE Mobile='{0}'", mobile));
                //db.loginhistories.Add(new loginhistory()
                //{
                //    Mobile = mobile,
                //    ValidationCode = validationCode,
                //    UserID = 0,
                //    IsValid = true,
                //    DataChange_CreateTime = DateTime.Now,
                //    DataChange_LastTime = DateTime.Now

                //});
                //db.SaveChanges();

                //TODO: 调用第三方发送手机验证码

            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "发送验证码异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RegisterResponse Register(RegisterRequest request)
        {
            var result = new RegisterResponse()
            {
                Result = true,
                ResultMessage = "用户注册成功",
                User = new UserDTO()
            };

            try
            {
                //string sql = "select * from loginhistory where Mobile=?Mobile and ValidationCode=?ValidationCode and IsValid=1 order by DataChange_CreateTime DESC";
                //var loginHistory = db.Database.SqlQuery<loginhistory>(sql, new MySqlParameter("Mobile", request.Mobile),
                //                                        new MySqlParameter("ValidationCode", request.ValidationCode));


                //if (loginHistory == null || loginHistory.Count() == 0)
                //{
                //    return new RegisterResponse()
                //    {
                //        Result = false,
                //        ResultMessage = "验证码无效"
                //    };
                //}

                ////判断手机号是否已注册
                //sql = "select * from user where Mobile=?Mobile";
                //var existedUserQuery = db.Database.SqlQuery<user>(sql, new MySqlParameter("Mobile", request.Mobile));
                //if (existedUserQuery != null && existedUserQuery.Count() > 0)
                //{
                //    var existedUser = existedUserQuery.ToList()[0];
                //    return new RegisterResponse()
                //    {
                //        Result = false,
                //        ResultMessage = "手机号已注册",
                //        User = new UserDTO()
                //        {
                //            UserID = existedUser.UserID,
                //            Mobile = existedUser.Mobile,
                //            MobileInfo = existedUser.MobileInfo,
                //            LoginPwd = existedUser.LoginPwd,
                //            UserType = existedUser.UserType,
                //            NickName = existedUser.NickName,
                //            TrueName = existedUser.TrueName,
                //            UserStatus = existedUser.UserStatus

                //        }
                //    };
                //}

                //落地用户信息
                //var user = db.users.Add(new user()
                //{
                //    Mobile = request.Mobile,
                //    MobileInfo = "",
                //    LoginPwd = EncryptHelper.AESEncrypt(request.Pwd),
                //    UserType = request.UserType,
                //    NickName = request.Mobile,
                //    TrueName = "",
                //    UserStatus = 0,
                //    DataChange_CreateTime = DateTime.Now,
                //    DataChange_LastTime = DateTime.Now
                //});

                //result.User.UserID = user.UserID;
                //result.User.Mobile = user.Mobile;
                //result.User.MobileInfo = user.MobileInfo;
                //result.User.LoginPwd = user.LoginPwd;
                //result.User.UserType = user.UserType;
                //result.User.NickName = user.NickName;
                //result.User.TrueName = user.TrueName;
                //result.User.UserStatus = user.UserStatus;


                ////更新登录历史记录
                //db.Database.ExecuteSqlCommand(TransactionalBehavior.EnsureTransaction, string.Format(@"UPDATE loginHistory set IsValid=0,DataChange_LastTime=now() WHERE Mobile='{0}'", request.Mobile));

                //if (user.UserType == 1) //教练
                //{
                //    db.coaches.Add(new coach()
                //    {
                //        CoachNumber = "C" + user.UserID.ToString().PadLeft(6, '0'),
                //        UserID = user.UserID,
                //        Level = 0,
                //        PersonalSign = "",
                //        BriefIntroduction = "",
                //        GymID = 0,
                //        HonorDesc = "",
                //        CourseDesc = "",
                //        ContactInfo = "",
                //        HeadPortraitUri = "",
                //        IsActive = true,
                //        DataChange_CreateTime = DateTime.Now,
                //        DataChange_LastTime = DateTime.Now
                //    });


                //}
                //db.SaveChanges();

                //trans.Commit();

            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "用户注册异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public LoginResponse Login(LoginRequest request)
        {
            var result = new LoginResponse()
            {
                Result = true,
                ResultMessage = "用户登录成功",
                User = new UserDTO()

            };

            try
            {
                //string encryptedPwd = EncryptHelper.AESEncrypt(request.Pwd);
                //var userList = db.users.Where(p => p.Mobile == request.Mobile && p.LoginPwd == encryptedPwd);
                //if (userList != null && userList.ToList().Count > 0)
                //{
                //    var user = userList.First();
                //    result.User.UserID = user.UserID;
                //    result.User.Mobile = user.Mobile;
                //    result.User.UserType = user.UserType;
                //    result.User.NickName = user.NickName;
                //    result.User.TrueName = user.TrueName;
                //    result.User.UserStatus = user.UserStatus;
                //    result.User.MobileInfo = user.MobileInfo;
                //    result.User.HeadPortraitUri = user.HeadPortraitUri;
                //    result.User.PersonalSign = user.PersonalSign;
                //    result.User.AreaInfo = user.AreaInfo;

                //    if (user.UserType == 1) //教练
                //    {
                //        var coachList = db.coaches.Where(p => p.UserID == user.UserID);
                //        result.Coach = new CoachInfoDTO();
                //        if (coachList != null && coachList.ToList().Count > 0)
                //        {
                //            var coach = coachList.First();
                //            result.Coach.CoachNumber = coach.CoachNumber;
                //            result.Coach.GymAddress = coach.gym.Address;
                //            result.Coach.GymName = coach.gym.GymName;
                //            result.Coach.HeadPortraitUri = coach.HeadPortraitUri;
                //            result.Coach.Level = coach.Level ?? 0;

                //        }

                //    }
                //}
                //else
                //{
                //    result.Result = false;
                //    result.ResultMessage = "账号无效";
                //}
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "用户登录异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 更新口令
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdatePwdResponse UpdatePwd(UpdatePwdRequest request)
        {
            var result = new UpdatePwdResponse()
            {
                Result = true,
                ResultMessage = "更新口令成功"
            };

            try
            {
                //string sql = "select * from loginhistory where Mobile=?Mobile and ValidationCode=?ValidationCode and IsValid=1 order by DataChange_CreateTime DESC";
                //var loginHistory = db.Database.SqlQuery<loginhistory>(sql, new MySqlParameter("Mobile", request.Mobile),
                //                                        new MySqlParameter("ValidationCode", request.ValidationCode));


                //if (loginHistory == null || loginHistory.Count() == 0)
                //{
                //    return new UpdatePwdResponse()
                //    {
                //        Result = false,
                //        ResultMessage = "验证码无效"
                //    };
                //}

                ////更新用户口令
                //db.Database.ExecuteSqlCommand(TransactionalBehavior.EnsureTransaction, string.Format(@"UPDATE user set LoginPwd='{0}' WHERE UserID={1}", EncryptHelper.AESEncrypt(request.NewPwd), request.UserID));

                ////更新登录历史记录
                //db.Database.ExecuteSqlCommand(TransactionalBehavior.EnsureTransaction, string.Format(@"UPDATE loginHistory set IsValid=0,DataChange_LastTime=now() WHERE Mobile='{0}'", request.Mobile));
                //db.SaveChanges();

            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "更新口令异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 查找教练
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SearchCoachResponse SearchCoach(SearchCoachRequest request)
        {
            var result = new SearchCoachResponse()
            {
                Result = true,
                ResultMessage = "查找教练成功",
                Coaches = new List<CoachDTO>()
            };

            try
            {
//                StringBuilder strBuilder = new StringBuilder();
//                strBuilder.Append(@"SELECT DISTINCT A.CoachNumber,C.UserID,C.UserType,A.Level,C.IsInterested,C.NickName,C.PersonalSign,
//                                B.GymName,B.Address AS GymAddress,A.HeadPortraitUri FROM Coach A LEFT JOIN Gym B ON A.GymID=B.GymID 
//                                INNER JOIN User C ON A.UserID=C.UserID LEFT JOIN CourseCoach D ON A.CoachNumber=D.CoachNumber LEFT JOIN Course E ON D.CourseNumber=E.CourseNumber");
//                strBuilder.Append(" WHERE 1=1");
//                if (!string.IsNullOrEmpty(request.Keyword)) strBuilder.Append(string.Format(" AND (Lower(C.NickName) Like '%{0}%' or C.Mobile='{0}')", request.Keyword));
//                if (!string.IsNullOrEmpty(request.CourseName)) strBuilder.Append(string.Format(" AND E.CourseName like '%{0}%'", request.CourseName));

//                var ds = MySqlHelper.ExecuteDataset(ConfigurationManager.ConnectionStrings[dbName].ConnectionString, strBuilder.ToString());
//                if (ds != null && ds.Tables.Count > 0)
//                {
//                    var dt = ds.Tables[0];
//                    foreach (DataRow row in dt.Rows)
//                    {
//                        var coachInfo = new CoachInfoDTO()
//                        {
//                            CoachNumber = row["CoachNumber"].ToString(),
//                            UserID = Convert.ToInt32(row["UserID"]),
//                            UserType = Convert.ToSByte(row["UserType"]),
//                            Level = Convert.ToSByte(row["Level"]),
//                            IsInterested = Convert.ToBoolean(row["IsInterested"]),
//                            NickName = Convert.ToString(row["NickName"]),
//                            PersonalSign = Convert.ToString(row["PersonalSign"]),
//                            GymName = row["GymName"].ToString(),
//                            GymAddress = row["GymAddress"].ToString(),
//                            HeadPortraitUri = row["HeadPortraitUri"].ToString()

//                        };
//                        result.Coaches.Add(coachInfo);
//                        //搜索Coach对应的课程信息
//                        string sql = string.Format(@"select B.CourseNumber,B.CourseName,B.CourseType FROM CourseCoach A inner join 
//                                            Course B on A.CourseNumber=B.CourseNumber where A.CoachNumber='{0}'",row["CoachNumber"].ToString());
//                        var ds2 = MySqlHelper.ExecuteDataset(ConfigurationManager.ConnectionStrings[dbName].ConnectionString,sql);
//                        if (ds2 != null && ds2.Tables.Count > 0)
//                        {
//                            var dt2 = ds2.Tables[0];
//                            foreach (DataRow row2 in dt2.Rows)
//                            {
//                                coachInfo.CourseDesc.Add(new CourseInfoDTO() { 
//                                    CourseNumber = row2["CourseNumber"].ToString(),
//                                    CourseName = row2["CourseName"].ToString(),
//                                    CourseType = Convert.ToInt16(row2["CourseType"])
//                                });
//                            }//foreach
//                        }//if
//                    }//foreach
//                }
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "查找教练异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 获取教练详情
        /// </summary>
        /// <param name="coachNumber"></param>
        /// <returns></returns>
        public GetCoachDetailResponse GetCoachDetail(string coachNumber)
        {
            var result = new GetCoachDetailResponse()
            {
                Result = true,
                ResultMessage = "找到了教练信息"
            };

            try
            {
//                string sql = @"select A.CoachNumber,A.BriefIntroduction,A.ContactInfo,A.CourseDesc,B.Address,B.GymName,A.HeadPortraitUri,A.HonorDesc,A.Level,A.PersonalSign FROM 
//                                Coach A inner join gym B on A.GymID=B.GymID where A.CoachNumber=?CoachNumber";
//                var dr = MySqlHelper.ExecuteDataRow(ConfigurationManager.ConnectionStrings[dbName].ConnectionString, sql, new MySqlParameter() { ParameterName = "CoachNumber", DbType = DbType.String, Value = coachNumber });
//                if (dr == null)
//                {
//                    result.Result = false;
//                    result.ResultMessage = "找不到教练信息";
//                    return result;
//                }

//                result.BriefIntroduction = dr["BriefIntroduction"].ToString();
//                result.CoachNumber = dr["CoachNumber"].ToString();
//                result.ContactInfo = dr["ContactInfo"].ToString();
//                result.CourseDesc = dr["CourseDesc"].ToString();
//                result.GymAddress = dr["Address"].ToString();
//                result.GymName = dr["GymName"].ToString();
//                result.HeadPortraitUri = dr["HeadPortraitUri"].ToString();
//                result.HonorDesc = dr["HonorDesc"].ToString();
//                result.Level = Convert.ToSByte(dr["Level"]);
//                result.PersonalSign = dr["PersonalSign"].ToString();
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "获取教练详情异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 更新教练详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateCoachDetailResponse UpdateCoachDetail(UpdateCoachDetailRequest request)
        {
            var result = new UpdateCoachDetailResponse()
            {
                Result = true,
                ResultMessage = "更新教练详情成功"
            };

            try
            {
            
                string sql = @"select CoachNumber from Coach where CoachNumber=?CoachNumber";
                var dr = MySqlHelper.ExecuteDataRow(ConfigurationManager.ConnectionStrings[dbName].ConnectionString, sql, new MySqlParameter { ParameterName = "CoachNumber", DbType = DbType.String, Value = request.CoachNumber });
                if (dr == null)
                {
                    result.Result = false;
                    result.ResultMessage = "找不到教练信息";
                    return result;
                }

                sql = @"update coach set BriefIntroduction=?BriefIntroduction,ContactInfo=?ContactInfo,CourseDesc=?CourseDesc,GymID=?GymID,HeadPortraitUri=?HeadPortraitUri,
                            HonorDesc=?HonorDesc,Level=?Level,PersonalSign=?PersonalSign where CoachNumber=?CoachNumber";
                int res = MySqlHelper.ExecuteNonQuery(ConfigurationManager.ConnectionStrings[dbName].ConnectionString, sql,
                        new MySqlParameter()
                        {
                            ParameterName = "BriefIntroduction",
                            Value = request.BriefIntroduction,
                            DbType = DbType.String
                        },
                        new MySqlParameter()
                        {
                            ParameterName = "ContactInfo",
                            Value = request.ContactInfo,
                            DbType = DbType.String
                        },
                        new MySqlParameter()
                        {
                            ParameterName = "CourseDesc",
                            Value = request.CourseDesc,
                            DbType = DbType.String
                        },
                        new MySqlParameter()
                        {
                            ParameterName = "GymID",
                            Value = request.GymID,
                            DbType = DbType.Int32
                        },
                        new MySqlParameter()
                        {
                            ParameterName = "HeadPortraitUri",
                            Value = request.HeadPortraitUri,
                            DbType = DbType.String
                        },
                        new MySqlParameter()
                        {
                            ParameterName = "HonorDesc",
                            Value = request.HonorDesc,
                            DbType = DbType.String
                        },
                        new MySqlParameter()
                        {
                            ParameterName = "Level",
                            Value = request.Level,
                            DbType = DbType.SByte
                        },
                        new MySqlParameter()
                        {
                            ParameterName = "PersonalSign",
                            Value = request.PersonalSign,
                            DbType = DbType.String
                        },
                        new MySqlParameter()
                        {
                            ParameterName = "CoachNumber",
                            Value = request.CoachNumber,
                            DbType = DbType.String
                        });

                if (res <= 0)
                {
                    result.Result = false;
                    result.ResultMessage = "更新教练详情失败";

                }
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "更新教练详情异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 检索客人信息
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public SearchGuestResponse SearchGuest(string mobile)
        {
            var result = new SearchGuestResponse()
            {
                Result = true,
                ResultMessage = "检索客人信息成功",
                User = new UserDTO()
            };

            try
            {
                //var user = db.users.SingleOrDefault(p => p.Mobile == mobile && p.UserType == 2);
                //if (user == null)
                //{
                //    result.Result = false;
                //    result.ResultMessage = "找不到客人信息";
                //    return result;
                //}

                //result.User.Mobile = user.Mobile;
                //result.User.NickName = user.NickName;
                //result.User.TrueName = user.TrueName;
                //result.User.UserID = user.UserID;
                //result.User.UserStatus = user.UserStatus;
                //result.User.MobileInfo = user.MobileInfo;
                //result.User.UserType = user.UserType;
                //result.User.HeadPortraitUri = user.HeadPortraitUri;
                //result.User.PersonalSign = user.PersonalSign;
                //result.User.AreaInfo = user.AreaInfo;

            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "检索客人信息异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateUserInfoResponse UpdateUserInfo(UpdateUserInfoRequest request)
        {
            var result = new UpdateUserInfoResponse()
            {
                Result = true,
                ResultMessage = "更新用户信息成功"
            };

            try
            {
                //var user = db.users.SingleOrDefault(p => p.UserID == request.UserID);
                //if (user == null)
                //{
                //    result.Result = false;
                //    result.ResultMessage = "找不到用户信息";
                //    return result;
                //}

                //user.Mobile = request.Mobile;
                //user.NickName = request.NickName;
                //user.TrueName = request.TrueName;
                //user.AreaInfo = request.AreaInfo;
                //user.PersonalSign = request.PersonalSign;
                //user.DataChange_LastTime = DateTime.Now;
                
                //db.SaveChanges();
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "更新用户信息异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 提交用户照片
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SubmitUserPhotoResponse SubmitUserPhoto(SubmitUserPhotoRequest request)
        {
            var result = new SubmitUserPhotoResponse()
            {
                Result = true,
                ResultMessage = "提交用户照片成功"
            };

            try
            {
                ////落地用户相片信息
                //db.userphotoes.Add(new userphoto()
                //{
                //    UserID = request.UserID,
                //    PhotoDesc = request.PhotoDesc,
                //    PhotoUrl = request.PhotoUrl,
                //    DataChange_CreateTime = DateTime.Now,
                //    DataChange_LastTime = DateTime.Now
                //});
                //db.SaveChanges();

            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "提交用户照片异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 移除用户照片记录
        /// </summary>
        /// <param name="userPhotoID"></param>
        /// <returns></returns>
        public RemoveUserPhotoResponse RemoveUserPhoto(long userPhotoID)
        {
            var result = new RemoveUserPhotoResponse()
            {
                Result = true,
                ResultMessage = "移除用户照片成功"
            };

            try
            {
                //string sql = string.Format("DELETE FROM userphoto where UserPhotoID={0}", userPhotoID);
                //db.Database.ExecuteSqlCommand(sql);


            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "移除用户照片异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        public FocusUserResponse FocusUser(FocusUserRequest request)
        {
           var result = new FocusUserResponse()
            {
                Result = true,
                ResultMessage = request.IsInterested ? "关注用户成功" : "取消关注用户成功"
            };
           try
           {
               string sql = "UPDATE User set IsInterested=?IsInterested where UserID=?UserID";
               int res = MySqlHelper.ExecuteNonQuery(ConfigurationManager.ConnectionStrings[dbName].ConnectionString, sql,
                   new MySqlParameter() { ParameterName = "IsInterested", DbType = DbType.Boolean, Value = request.IsInterested },
                   new MySqlParameter() { ParameterName = "UserID", DbType = DbType.Int64, Value = request.UserID });

               if (res <= 0)
               {
                   result.Result = false;
                   result.ResultMessage = request.IsInterested ? "关注用户失败" : "取消关注用户失败";

               }
           }
           catch (Exception ex)
           {
               result.Result = false;
               result.ResultMessage = request.IsInterested ? "关注用户失败" : "取消关注用户失败";
               result.Errors.Add(ex.Message);
           }

           return result;

        }

        public GetUserDetailResponse GetUserDetail(GetUserDetailRequest request)
        {
            var result = new GetUserDetailResponse()
            {
                Result = true,
                ResultMessage = "获取用户明细信息成功",
                User = new UserDTO()

            };

            try
            {
                //var userList = db.users.Where(p => p.UserID == request.UserID).ToList();
                //if (userList != null && userList.Count > 0)
                //{
                //    var user = userList.First();
                //    result.User.UserID = user.UserID;
                //    result.User.Mobile = user.Mobile;
                //    result.User.UserType = user.UserType;
                //    result.User.NickName = user.NickName;
                //    result.User.TrueName = user.TrueName;
                //    result.User.UserStatus = user.UserStatus;
                //    result.User.MobileInfo = user.MobileInfo;
                //    result.User.HeadPortraitUri = user.HeadPortraitUri;
                //    result.User.PersonalSign = user.PersonalSign;
                //    result.User.AreaInfo = user.AreaInfo;

                //    if (user.UserType == 1) //教练
                //    {
                //        var coachList = db.coaches.Where(p => p.UserID == user.UserID).ToList();
                //        result.Coach = new CoachInfoDTO();
                //        if (coachList != null && coachList.Count > 0)
                //        {
                //            var coach = coachList.First();
                //            result.Coach.CoachNumber = coach.CoachNumber;
                //            result.Coach.GymAddress = coach.gym.Address;
                //            result.Coach.GymName = coach.gym.GymName;
                //            result.Coach.PersonalSign = coach.PersonalSign;
                //            result.Coach.IsInterested = user.IsInterested;
                //            result.Coach.BriefIntroduction = coach.BriefIntroduction;
                //            result.Coach.HonorDesc = coach.HonorDesc;
                //            result.Coach.HeadPortraitUri = coach.HeadPortraitUri;
                //            result.Coach.Level = coach.Level ?? 0;

                //        }

                //    }//if
                //}
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "获取用户明细信息异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }


        #endregion

        #region 课程相关

        /// <summary>
        /// 预订课程
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BookingCourseResponse BookingCourse(BookingCourseRequest request)
        {
            var result = new BookingCourseResponse()
            {
                Result = true,
                ResultMessage = "预订课程成功"
            };

            try
            {
                //var courseBooking = new coursebooking()
                //{
                //    UserID = request.UserID,
                //    CourseNumber = request.CourseNumber,
                //    CoachNumber = request.CoachNumber,
                //    BookingTime = DateTime.Now,
                //    CourseTime = request.CourseTime,
                //    Hours = request.Hours,
                //    IsDelegated = request.IsDelegated,
                //    IsNotified = true,
                //    BookingStatus = 0,
                //    DataChange_CreateTime = DateTime.Now,
                //    DataChange_LastTime = DateTime.Now
                //};

                //db.coursebookings.Add(courseBooking);

                //var courseUser = db.courseusers.Where(p => p.UserID == request.UserID && p.CourseNumber == request.CourseNumber).ToList();
                //if (courseUser == null || courseUser.Count == 0)
                //{
                //    db.courseusers.Add(new courseuser()
                //    {
                //        CourseNumber = request.CourseNumber,
                //        UserID = request.UserID,
                //        CoachNumber = request.CoachNumber,
                //        DataChange_CreateTime = DateTime.Now,
                //        DataChange_LastTime = DateTime.Now
                //    });
                //}

                //db.SaveChanges();

            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "预订课程异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }


        /// <summary>
        /// 获取会员的课程提醒列表
        /// </summary>
        /// <param name="userID">用户ID</param>
        /// <returns></returns>
        public GetCourseNotificationResponse GetCourseNotification(long userID)
        {

            var result = new GetCourseNotificationResponse()
            {
                Result = true,
                ResultMessage = "获取会员的课程提醒列表成功",
                Courses = new List<CourseBookingDTO>()
            };

            int week = DateTimeHelper.WeekOfYear(DateTime.Today);
            try
            {
                string sql = string.Format(@"SELECT A.CourseBookingID,A.CourseTime,TimestampDiff(day,now(),A.BookingTime) AS RemainDays,B.CourseIconUri,B.CourseName,A.Hours,A.CoachNumber,
                           D.NickName AS CoachName,B.IsPublic,A.BookingStatus FROM CourseBooking A INNER JOIN Course B ON A.CourseNumber=B.CourseNumber 
                            INNER JOIN Coach C ON A.CoachNumber=C.CoachNumber INNER JOIN User D ON C.UserID=D.UserID WHERE A.IsNotified=1 AND A.UserID={0} 
                            AND Week(A.BookingTime,2)={1}
                            ORDER BY A.BookingTime", userID, week);
                //var query = db.Database.SqlQuery<CourseBookingDTO>(sql);
                //if (query == null || query.Count() == 0)
                var ds = MySqlHelper.ExecuteDataset(ConfigurationManager.ConnectionStrings[dbName].ConnectionString, sql);
                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    result.ResultMessage = "没有需要提醒的课程";
                    result.Result = false;
                    return result;
                }

                var dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    result.Courses.Add(new CourseBookingDTO()
                    {
                        CourseTime = Convert.ToDateTime(dr["CourseTime"]),
                        BookingStatus = Convert.ToInt16(dr["BookingStatus"]),
                        CoachName = dr["CoachName"].ToString(),
                        CoachNumber = dr["CoachNumber"].ToString(),
                        CourseBookingID = Convert.ToInt64(dr["CourseBookingID"]),
                        CourseIconUri = dr["CourseIconUri"].ToString(),
                        CourseName = dr["CourseName"].ToString(),
                        Hours = Convert.ToInt32(dr["Hours"]),
                        IsPublic = Convert.ToBoolean(dr["IsPublic"]),
                        RemainDays = Convert.ToInt32(dr["RemainDays"])
                    });
                }

            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "获取会员的课程提醒列表异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 更新课程预订信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateCourseBookingResponse UpdateCourseBooking(UpdateCourseBookingRequest request)
        {
            var result = new UpdateCourseBookingResponse()
            {
                Result = true,
                ResultMessage = "更新课程预订信息成功"
            };

            try
            {
                //string sql = string.Format(@"UPDATE CourseBooking SET BookingTime='{0}',Hours={1},CourseTime='{2}',IsNotified=1 WHERE CourseBookingID={3}",
                //                request.BookingTime.ToString("yyyy-MM-dd HH:mm:ss"), 
                //                request.Hours, 
                //                request.CourseTime.ToString("yyyy-MM-dd HH:mm:ss"),
                //                request.CourseBookingID);
                //int res = db.Database.ExecuteSqlCommand(sql);
                //if (res == 0)
                //{
                //    return new UpdateCourseBookingResponse()
                //    {
                //        Result = false,
                //        ResultMessage = "更新课程预订信息失败"
                //    };
                //}
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "更新课程预订信息异常";
                result.Errors.Add(ex.Message);
            }

            return result;

        }

        /// <summary>
        /// 取消课程预订
        /// </summary>
        /// <param name="courseBookingID"></param>
        /// <returns></returns>
        public CancelCourseBookingResponse CancelCourseBooking(long courseBookingID)
        {
            var result = new CancelCourseBookingResponse()
            {
                Result = true,
                ResultMessage = "取消课程预订成功"
            };

            try
            {
                //string sql = string.Format(@"UPDATE CourseBooking SET BookingStatus=2,IsNotified=0 WHERE CourseBookingID={0}", courseBookingID);
                //int res = db.Database.ExecuteSqlCommand(sql);
                //if (res == 0) return new CancelCourseBookingResponse()
                //  {
                //      Result = false,
                //      ResultMessage = "取消课程预订失败"
                //  };
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "取消课程预订异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 获取我的未完成预订课程列表
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public GetMyUncompletedBookingInfoResponse GetMyUncompletedBookingInfo(long userID)
        {
            var result = new GetMyUncompletedBookingInfoResponse()
            {
                Result = true,
                ResultMessage = "获取我的未完成的课程列表成功"
            };

            try
            {
//                string sql = string.Format(@"SELECT A.CourseBookingID,TimestampDiff(day,now(),A.BookingTime) AS RemainDays,B.CourseIconUri,B.CourseName,A.Hours,A.CoachNumber,
//                           D.NickName AS CoachName,B.IsPublic,A.BookingStatus FROM CourseBooking A INNER JOIN Course B ON A.CourseNumber=B.CourseNumber 
//                            INNER JOIN Coach C ON A.CoachNumber=C.CoachNumber INNER JOIN User D ON C.UserID=D.UserID WHERE A.UserID={0} AND A.BookingStatus=0
//                            ORDER BY A.BookingTime", userID);
//                var query = db.Database.SqlQuery<CourseBookingDTO>(sql);
//                if (query == null || query.Count() == 0)
//                {
//                    result.ResultMessage = "没有未完成的课程列表";
//                    result.Courses = new List<CourseBookingDTO>();
//                    return result;
//                }

//                result.Courses = query.ToList();
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "获取我的未完成的课程列表异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 获取我的已完成的课程评论列表
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public GetMyCompletedBookingInfoResponse GetMyCompletedBookingInfo(long userID)
        {
            var result = new GetMyCompletedBookingInfoResponse()
            {
                Result = true,
                ResultMessage = "获取我的已完成的课程评论列表成功"
            };

            try
            {
//                string sql = string.Format(@"SELECT A.CourseNumber,A.CoachNumber,B.NickName AS CoachName,C.CourseTime,C.Hours,A.CoachComment,A.CommentDate 
//                            FROM CourseComment A INNER JOIN User B ON A.UserID=B.UserID 
//                            INNER JOIN CourseBooking C ON A.CourseBookingID=C.CourseBookingID WHERE A.UserID={0} AND C.BookingStatus=1
//                            ORDER BY C.BookingTime", userID);
//                var query = db.Database.SqlQuery<CourseCommentDTO>(sql);
//                if (query == null || query.Count() == 0)
//                {
//                    result.ResultMessage = "没有已完成的课程评论信息";
//                    result.CourseComments = new List<CourseCommentDTO>();
//                    return result;
//                }

//                result.CourseComments = query.ToList();
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "获取我的已完成的课程评论列表异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 获取我的教练列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetMyCoachListResponse GetMyCoachList(GetMyCoachListRequest request)
        {
            var result = new GetMyCoachListResponse()
            {
                Result = true,
                ResultMessage = "获取我的教练列表成功"
            };

            try
            {
//                string sql = string.Format(@"SELECT DISTINCT A.CoachNumber,B.UserID,B.UserType,A.Level,B.IsInterested,B.NickName,A.PersonalSign,
//                            E.GymName,E.Address as GymAddress,A.HeadPortraitUri 
//                            FROM Coach A INNER JOIN User B ON A.UserID=B.UserID 
//                            inner join CourseCoach C ON A.CoachNumber=C.CoachNumber
//                            INNER JOIN CourseUser D ON C.CourseNumber=D.CourseNumber 
//                            LEFT JOIN Gym E ON A.GymID=E.GymID WHERE D.UserID={0}
//                            ORDER BY A.CoachNumber", request.UserID);
//                var query = db.Database.SqlQuery<CoachInfoDTO>(sql).ToList();
//                if (query == null || query.Count == 0)
//                {
//                    result.ResultMessage = "没有找到我的教练信息";
//                    result.Coaches = new List<CoachInfoDTO>();
//                    return result;
//                }

//                result.Coaches = query;
//                foreach (var coachInfo in query)
//                {
//                    //搜索Coach对应的课程信息
//                    string sql2 = string.Format(@"select B.CourseNumber,B.CourseName,B.CourseType FROM CourseCoach A inner join 
//                                            Course B on A.CourseNumber=B.CourseNumber where A.CoachNumber='{0}'", coachInfo.CoachNumber);
//                    var ds2 = MySqlHelper.ExecuteDataset(ConfigurationManager.ConnectionStrings[dbName].ConnectionString, sql2);
//                    if (ds2 != null && ds2.Tables.Count > 0)
//                    {
//                        var dt2 = ds2.Tables[0];
//                        foreach (DataRow row2 in dt2.Rows)
//                        {
//                            coachInfo.CourseDesc.Add(new CourseInfoDTO()
//                            {
//                                CourseNumber = row2["CourseNumber"].ToString(),
//                                CourseName = row2["CourseName"].ToString(),
//                                CourseType = Convert.ToInt16(row2["CourseType"])
//                            });
//                        }//foreach
//                    }//if
//                }
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "获取我的教练列表异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 获取我订购的课程列表(简短信息)
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public GetMyCourseNameListResponse GetMyCourseNameList(long userID)
        {
            var result = new GetMyCourseNameListResponse()
            {
                Result = true,
                ResultMessage = "获取我的课程列表成功"
            };

            try
            {
//                string sql = string.Format(@"SELECT A.CourseNumber,B.CourseName
//                            FROM CourseUser A INNER JOIN Course B ON A.CourseNumber=B.CourseNumber 
//                            WHERE A.UserID={0} AND B.IsActive=1
//                            ORDER BY A.CourseNumber", userID);
//                var query = db.Database.SqlQuery<MyCourseNameDTO>(sql);
//                if (query == null || query.Count() == 0)
//                {
//                    result.ResultMessage = "没有找到我的课程信息";
//                    result.MyCourses = new List<MyCourseNameDTO>();
//                    return result;
//                }

//                result.MyCourses = query.ToList();
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "获取我的课程列表异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }


        /// <summary>
        /// 提交课程评论
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SubmitCourseCommentResponse SubmitCourseComment(SubmitCourseCommentRequest request)
        {
            var result = new SubmitCourseCommentResponse()
            {
                Result = true,
                ResultMessage = "提交课程评论成功"
            };

            try
            {
                //var courseComment = new coursecomment()
                //{
                //    UserID = request.UserID,
                //    CourseNumber = request.CourseNumber,
                //    CourseBookingID = request.CourseBookingID,
                //    CoachNumber = request.CoachNumber,
                //    CoachComment = request.CoachComment,
                //    CommentDate = DateTime.Now,
                //    DataChange_CreateTime = DateTime.Now,
                //    DataChange_LastTime = DateTime.Now
                //};

                //db.coursecomments.Add(courseComment);
                //db.SaveChanges();
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "提交课程评论异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 获取我的课程列表(课程维护列表)
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public GetMyCourseListResponse GetMyCourseList(long userID)
        {
            var result = new GetMyCourseListResponse()
            {
                Result = true,
                ResultMessage = "获取我的课程列表成功"
            };

            try
            {
//                string sql = string.Format(@"SELECT A.CourseNumber,B.CourseName,B.CourseIconUri,D.GymName,D.Address AS GymAddress,B.IsPublic
//                            FROM CourseUser A INNER JOIN Course B ON A.CourseNumber=B.CourseNumber 
//                            INNER JOIN Coach C ON A.CoachNumber=C.CoachNumber
//                            INNER JOIN Gym D ON C.GymID=D.GymID
//                            WHERE A.UserID={0} AND B.IsActive=1
//                            ORDER BY A.CourseNumber", userID);
//                var query = db.Database.SqlQuery<MyCourseInfoDTO>(sql);
//                if (query == null || query.Count() == 0)
//                {
//                    result.ResultMessage = "没有找到我的课程信息";
//                    result.MyCourses = new List<MyCourseInfoDTO>();
//                    return result;
//                }

//                result.MyCourses = query.ToList();
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.ResultMessage = "获取我的课程列表异常";
                result.Errors.Add(ex.Message);
            }

            return result;
        }
        #endregion

     
    }
}
