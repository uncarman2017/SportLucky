using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 场馆详细信息
    /// </summary>
    public class GymDTO
    {
        public GymDTO()
        {
            Photos = new List<PhotoDTO>();
        }

        /// <summary>
        /// 场馆ID
        /// </summary>
        public int GymID { get; set; }

        /// <summary>
        /// 城市ID
        /// </summary>
        public int CityID { get; set; }

        /// <summary>
        /// 行政区ID
        /// </summary>
        public int DistrictID { get; set; }

        /// <summary>
        /// 场馆名称
        /// </summary>
        public string GymName { get; set; }

        /// <summary>
        /// 场馆地址
        /// </summary>
        public string GymAddress { get; set; }

        /// <summary>
        /// 场馆描述
        /// </summary>
        public string GymDesc { get; set; }

        /// <summary>
        /// 场馆联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 场馆位置所在经度
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// 场馆位置所在纬度
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// 场馆评价星级
        /// </summary>
        public sbyte StarLevel { get; set; }

        /// <summary>
        /// 附加服务描述(JSON字符串)
        /// </summary>
        public string AdditionalService { get; set; }

        /// <summary>
        /// 是否免费
        /// </summary>
        public bool IsFree { get; set; }

        /// <summary>
        /// 是否有无线网络
        /// </summary>
        public bool HasWifi { get; set; }

        /// <summary>
        /// 有无停车位
        /// </summary>
        public bool HasParking { get; set; }

        /// <summary>
        /// 有无饮料
        /// </summary>
        public bool HasDrink { get; set; }

        /// <summary>
        /// 是否售卖器材
        /// </summary>
        public bool HasEquipmentSale { get; set; }

        /// <summary>
        /// 是否出租器材
        /// </summary>
        public bool HasEquipmentRented { get; set; }

        /// <summary>
        /// 负责人用户ID
        /// </summary>
        public int PrincipalID { get; set; }

        /// <summary>
        /// 场馆照片Json
        /// </summary>
        public string Photos_Json { get; set; }

        /// <summary>
        /// 场馆照片
        /// </summary>
        public List<PhotoDTO> Photos { get; set; }

        /// <summary>
        /// 场馆支持的课程类型列表
        /// </summary>
        public List<CourseTypeDTO> Courses { get; set; }

        /// <summary>
        /// 场馆评论
        /// </summary>
        public List<GymCommentDTO> Comments { get; set; }
    }

    public class BriefGymDTO
    {
        /// <summary>
        /// 场馆ID
        /// </summary>
        public int GymID { get; set; }

        /// <summary>
        /// 城市ID
        /// </summary>
        public int CityID { get; set; }

        /// <summary>
        /// 行政区ID
        /// </summary>
        public int DistrictID { get; set; }

        /// <summary>
        /// 场馆名称
        /// </summary>
        public string GymName { get; set; }

        /// <summary>
        /// 场馆支持的课程类型列表
        /// </summary>
        public List<CourseTypeDTO> Courses { get; set; }

        public PhotoDTO Photo { get; set; }

    }

    /// <summary>
    /// 场馆评论
    /// </summary>
    public class GymCommentDTO
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 评论日期
        /// </summary>
        public DateTime CommentDate { get; set; }

        /// <summary>
        /// 评论星级
        /// </summary>
        public sbyte StarLevel { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 场馆照片列表
        /// </summary>
        public List<PhotoDTO> Photos { get; set; }

    }

  
}
