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
    public class BasicDataController : ApiController, IBasicDataService
    {
        #region 场馆接口

        /// <summary>
        /// 新增场馆明细
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/AddGymDetail")]
        public AddGymDetailResponse AddGymDetail(AddGymDetailRequest request)
        {
            return BasicDataManager.GetInstance().AddGymDetail(request);
        }

        /// <summary>
        /// 获取场馆详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetGymDetail")]
        public GetGymDetailResponse GetGymDetail(GetGymDetailRequest request)
        {
            return BasicDataManager.GetInstance().GetGymDetail(request);
        }

        /// <summary>
        /// 搜索场馆信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SearchGym")]
        public SearchGymResponse SearchGym(SearchGymRequest request)
        {
            return BasicDataManager.GetInstance().SearchGym(request);
        }

       

        /// <summary>
        /// 更新场馆位置信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdateGymLocation")]
        public UpdateGymLocationResponse UpdateGymLocation(UpdateGymLocationRequest request)
        {
            return BasicDataManager.GetInstance().UpdateGymLocation(request);
        }

       
        [HttpPost]
        [Route("api/SubmitGymCorrection")]
        public SubmitGymCorrectionResponse SubmitGymCorrection(SubmitGymCorrectionRequest request)
        {
            return BasicDataManager.GetInstance().SubmitGymCorrection(request);
        }

        [HttpPost]
        [Route("api/RemoveGymPhoto")]
        public RemoveGymPhotoResponse RemoveGymPhoto(RemoveGymPhotoRequest request)
        {
            return BasicDataManager.GetInstance().RemoveGymPhoto(request);
        }

        #endregion

        #region 教练接口

        [HttpPost]
        [Route("api/AddCoachDetail")]
        public AddCoachDetailResponse AddCoachDetail(AddCoachDetailRequest request)
        {
            return BasicDataManager.GetInstance().AddCoachDetail(request);
        }

        /// <summary>
        /// 获取教练详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetCoachDetail")]
        public GetCoachDetailResponse GetCoachDetail(GetCoachDetailRequest request)
        {
            return BasicDataManager.GetInstance().GetCoachDetail(request);
        }

        /// <summary>
        /// 首页搜索教练和场馆信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SearchCoachAndGym")]
        public SearchCoachAndGymResponse SearchCoachAndGym(SearchCoachAndGymRequest request)
        {
            return BasicDataManager.GetInstance().SearchCoachAndGym(request);
        }

        /// <summary>
        /// 搜索教练信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SearchCoach")]
        public SearchCoachResponse SearchCoach(SearchCoachRequest request)
        {
            return BasicDataManager.GetInstance().SearchCoach(request);
        }

        /// <summary>
        /// 获取首页推荐教练列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetHomeCoachList")]
        public GetHomeCoachListResponse GetHomeCoachList(GetHomeCoachListRequest request)
        {
            return BasicDataManager.GetInstance().GetHomeCoachList(request);
        }

        [HttpPost]
        [Route("api/RemoveCoachPhoto")]
        public RemoveCoachPhotoResponse RemoveCoachPhoto(RemoveCoachPhotoRequest request)
        {
            return BasicDataManager.GetInstance().RemoveCoachPhoto(request);
        }
        #endregion

        #region 用户接口
        /// <summary>
        /// 获取用户明细
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetUserDetail")]
        public GetUserDetailResponse GetUserDetail(GetUserDetailRequest request)
        {
            return BasicDataManager.GetInstance().GetUserDetail(request);
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UpdateUserInfo")]
        public UpdateUserInfoResponse UpdateUserInfo(UpdateUserInfoRequest request)
        {
            return BasicDataManager.GetInstance().UpdateUserInfo(request);
        }
        #endregion

        #region 文章接口
        /// <summary>
        /// 获取首页推荐文章列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetHomeArticleList")]
        public GetHomeArticleListResponse GetHomeArticleList(GetHomeArticleListRequest request)
        {
            return BasicDataManager.GetInstance().GetHomeArticleList(request);
        }

        #endregion

        #region 其他接口

        public GetCourseTypeListResponse GetCourseTypeList(GetCourseTypeListRequest request)
        {
            return BasicDataManager.GetInstance().GetCourseTypeList(request);
        }

        public GetDicItemListResponse GetDicItemList(GetDicItemListRequest request)
        {
            return BasicDataManager.GetInstance().GetDicItemList(request);
        }

        #endregion


      
    }
}