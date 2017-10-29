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
    public class AdminController : ApiController, IAdminService
    {
        /// <summary>
        /// 更新场馆详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdateGymDetail")]
        public UpdateGymDetailResponse UpdateGymDetail(UpdateGymDetailRequest request)
        {
            return AdminManager.GetInstance().UpdateGymDetail(request);
        }

        /// <summary>
        /// 更新教练详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdateCoachDetail")]
        public UpdateCoachDetailResponse UpdateCoachDetail(UpdateCoachDetailRequest request)
        {
            return AdminManager.GetInstance().UpdateCoachDetail(request);
        }

        /// <summary>
        /// 审核教练
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/ApproveCoach")]
        public ApproveCoachResponse ApproveCoach(ApproveCoachRequest request)
        {
            return AdminManager.GetInstance().ApproveCoach(request);
        }

        /// <summary>
        /// 审核场馆
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/ApproveGym")]
        public ApproveGymResponse ApproveGym(ApproveGymRequest request)
        {
            return AdminManager.GetInstance().ApproveGym(request);
        }

        /// <summary>
        /// 提交用户反馈
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SubmitUserFeedback")]
        public SubmitUserFeedbackResponse SubmitUserFeedback(SubmitUserFeedbackRequest request)
        {
            return AdminManager.GetInstance().SubmitUserFeedback(request);
        }

        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
        
        
    }
}