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
    public class AdminManager : BaseManager<AdminManager>
    {
        public static AdminManager GetInstance()
        {
            if (self == null) self = new AdminManager();
            return self;
        }

        /// <summary>
        /// 审核教练
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ApproveCoachResponse ApproveCoach(ApproveCoachRequest request)
        {
            var result = new ApproveCoachResponse()
            {
                ResultMessage = "审核教练成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_CoachApprovalID", request.CoachApprovalID, DbType.Int32);
                    parms.Add("P_ApproveStatus", request.ApproveStatus, DbType.Int32);
                    parms.Add("P_ApproverUserID", 1, DbType.Int32);//TODO

                    result.CoachID = con.ExecuteScalar<int>("sp_ApproveCoach"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "审核教练异常";
                result.Result = ResultCode.Error;
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

        /// <summary>
        /// 审核场馆
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ApproveGymResponse ApproveGym(ApproveGymRequest request)
        {
            var result = new ApproveGymResponse()
            {
                ResultMessage = "审核场馆成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_GymApprovalID", request.GymApprovalID, DbType.Int32);
                    parms.Add("P_ApproveStatus", request.ApproveStatus, DbType.Int32);
                    parms.Add("P_ApproverUserID", 1, DbType.Int32);//TODO

                    result.GymID = con.ExecuteScalar<int>("sp_ApproveGym"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "审核场馆异常";
                result.Result = ResultCode.Error;
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }

        /// <summary>
        /// 提交用户反馈
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
       
        public SubmitUserFeedbackResponse SubmitUserFeedback(SubmitUserFeedbackRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateGymDetailResponse UpdateGymDetail(UpdateGymDetailRequest request)
        {
            throw new NotImplementedException();
        }


        public UpdateCoachDetailResponse UpdateCoachDetail(UpdateCoachDetailRequest request)
        {
            throw new NotImplementedException();
        }

    }
}
