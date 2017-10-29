using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 基础数据服务接口
    /// </summary>
    [ServiceContract]
    public interface IBasicDataService
    {
        #region 场馆
        AddGymDetailResponse AddGymDetail(AddGymDetailRequest request);

        GetGymDetailResponse GetGymDetail(GetGymDetailRequest request);

        SearchGymResponse SearchGym(SearchGymRequest request);

        UpdateGymLocationResponse UpdateGymLocation(UpdateGymLocationRequest request);

        SubmitGymCorrectionResponse SubmitGymCorrection(SubmitGymCorrectionRequest request);

        RemoveGymPhotoResponse RemoveGymPhoto(RemoveGymPhotoRequest request);

        #endregion

        #region 教练

        AddCoachDetailResponse AddCoachDetail(AddCoachDetailRequest request);

        GetCoachDetailResponse GetCoachDetail(GetCoachDetailRequest request);


        SearchCoachResponse SearchCoach(SearchCoachRequest request);

        SearchCoachAndGymResponse SearchCoachAndGym(SearchCoachAndGymRequest request);

        GetHomeCoachListResponse GetHomeCoachList(GetHomeCoachListRequest request);

        RemoveCoachPhotoResponse RemoveCoachPhoto(RemoveCoachPhotoRequest request);

      
        #endregion

        #region 用户

        GetUserDetailResponse GetUserDetail(GetUserDetailRequest request);

        UpdateUserInfoResponse UpdateUserInfo(UpdateUserInfoRequest request);

        #endregion

        #region 文章

        GetHomeArticleListResponse GetHomeArticleList(GetHomeArticleListRequest request);

        #endregion

        #region 其他
        GetCourseTypeListResponse GetCourseTypeList(GetCourseTypeListRequest request);
        GetDicItemListResponse GetDicItemList(GetDicItemListRequest request);
        #endregion

    }
}
