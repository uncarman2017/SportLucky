using SportLucky.Service.Contract;
using SportLucky.Service.Domain.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Domain.Business
{
    public abstract class BaseManager<T> where T:class
    {
        protected static T self = null;
        protected const string dbName = "SportLuckyDB";

        protected TResult CreateResponse<TResult>(string requestDesc) where TResult:new ()
        {
            var result = new TResult();
            (result as BaseResponse).RequestDescription = requestDesc;
            (result as BaseResponse).ResultMessage = string.Format("{0}成功", requestDesc);
            (result as BaseResponse).Result = ResultCode.Success;
            return result;
        }
        protected void HandleResponseException<TResult>(ref TResult result, Exception ex)
        {
            (result as BaseResponse).ResultMessage = string.Format("{0}异常", (result as BaseResponse).RequestDescription);
            (result as BaseResponse).Result = ResultCode.Error;
            (result as BaseResponse).Errors.Add(ex.Message);
            LogHelper.WriteErrorLog(ex);
        }
    }
}
