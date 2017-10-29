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
    public class CommunityManager : BaseManager<CommunityManager>
    {
        public static CommunityManager GetInstance()
        {
            if (self == null) self = new CommunityManager();
            return self;
        }

        public SubmitCmuNoteResponse SubmitCmuNote(SubmitCmuNoteRequest request)
        {
            var result = new SubmitCmuNoteResponse()
            {
                ResultMessage = "提交肌友圈帖子成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();
                    parms.Add("P_UserID", request.UserID, DbType.Int32);
                    parms.Add("P_Content", request.Content, DbType.String);
                    //parms.Add("P_Imgs", request.Imgs, DbType.String);
                    //TODO 处理图片对象数组
                    result.NoteID = con.ExecuteScalar<int>("sp_SubmitCmuNote"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "提交肌友圈帖子异常";
                result.Result = ResultCode.Error;
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }
        
        public SubmitCmuNoteCommentResponse SubmitCmuNoteComment(SubmitCmuNoteCommentRequest request)
        {
            var result = new SubmitCmuNoteCommentResponse()
            {
                ResultMessage = "肌友圈帖子评论成功",
                Result = ResultCode.Success
            };
            try
            {
                using (var con = new DbConnectionProvider(dbName).GetOpenConnection())
                {
                    var parms = new DynamicParameters();                    
                    parms.Add("P_NoteID", request.NoteID, DbType.Int32);
                    parms.Add("P_UserID", request.UserID, DbType.Int32);
                    parms.Add("P_Content", request.Content, DbType.String);
                    parms.Add("P_IsAgreed", request.IsAgreed, DbType.Boolean);

                    result.NoteCommentID = con.ExecuteScalar<int>("sp_SubmitCmuNoteComment"
                       , parms
                       , CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                result.ResultMessage = "肌友圈帖子评论异常";
                result.Result = ResultCode.Error;
                result.Errors = new List<string>();
                result.Errors.Add(ex.Message);
                LogHelper.WriteErrorLog(ex);
            }
            return result;
        }      
    }
}
