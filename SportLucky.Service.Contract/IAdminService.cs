using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 后台管理服务接口
    /// </summary>
    [ServiceContract]
    public interface IAdminService
    {
        ApproveCoachResponse ApproveCoach(ApproveCoachRequest request);

        ApproveGymResponse ApproveGym(ApproveGymRequest request);

        SubmitUserFeedbackResponse SubmitUserFeedback(SubmitUserFeedbackRequest request);

        UpdateCoachDetailResponse UpdateCoachDetail(UpdateCoachDetailRequest request);

        UpdateGymDetailResponse UpdateGymDetail(UpdateGymDetailRequest request);

    }
}
