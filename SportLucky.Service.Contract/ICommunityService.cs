using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 社区(运动缘)服务接口
    /// </summary>
    [ServiceContract]
    public interface ICommunityService
    {
        SubmitCmuNoteCommentResponse SubmitCmuNoteComment(SubmitCmuNoteCommentRequest request);

        SubmitCmuNoteResponse SubmitCmuNote(SubmitCmuNoteRequest request);
    }
}
