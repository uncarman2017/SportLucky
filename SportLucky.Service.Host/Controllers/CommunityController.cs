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
    public class CommunityController : ApiController, ICommunityService
    {
        /// <summary>
        /// 提交社区(运动缘)帖子
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SubmitCmuNote")]
        public SubmitCmuNoteResponse SubmitCmuNote(SubmitCmuNoteRequest request)
        {
            return CommunityManager.GetInstance().SubmitCmuNote(request);
        }

        /// <summary>
        /// 提交社区(运动缘)帖子评论
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SubmitCmuNoteComment")]
        public SubmitCmuNoteCommentResponse SubmitCmuNoteComment(SubmitCmuNoteCommentRequest request)
        {
            return CommunityManager.GetInstance().SubmitCmuNoteComment(request);
        }

        
    }
}