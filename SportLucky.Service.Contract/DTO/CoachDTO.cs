using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{

    /// <summary>
    /// 教练详细信息
    /// </summary>
    public class CoachDTO
    {
        public CoachDTO()
        {
            Courses = new List<CourseTypeDTO>();
            Photos = new List<PhotoDTO>();
        }

        /// <summary>
        /// 教练编号
        /// </summary>
        public int CoachID { get; set; }

        /// <summary>
        /// 教练对应的用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 教练姓名
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 星级,1~5表示1到5星级
        /// </summary>
        public sbyte Level { get; set; }
        
        /// <summary>
        /// 是否公益教练
        /// </summary>
        public bool IsFree { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string ContactInfo { get; set; }

        /// <summary>
        /// 个性签名
        /// </summary>
        public string PersonalSign { get; set; }

        /// <summary>
        /// 个人简介
        /// </summary>

        public string BriefIntroduction { get; set; }

        /// <summary>
        /// 获得荣誉描述
        /// </summary>
        public string HonorDesc { get; set; }

        /// <summary>
        /// 证书
        /// </summary>
        public string Certificates { get; set; }

        /// <summary>
        /// 课程安排描述
        /// </summary>
        public string CourseDesc { get; set; }

        /// <summary>
        /// 所在场馆描述
        /// </summary>
        public string GymDesc { get; set; }

        /// <summary>
        /// 活动区域描述
        /// </summary>
        public string AreaDesc { get; set; }

        /// <summary>
        /// 推荐日期
        /// </summary>
        public DateTime RecommendDate { get; set; }

        /// <summary>
        /// 教练照片Json
        /// </summary>
        public string Photos_Json { get; set; }

        /// <summary>
        /// 教练照片
        /// </summary>
        public List<PhotoDTO> Photos { get; set; }
       
        /// <summary>
        /// 课程安排
        /// </summary>
        public List<CourseTypeDTO> Courses { get; set; }

        /// <summary>
        /// 是否首页推荐
        /// </summary>
        public bool IsHomeRecommended { get; set; }

        /// <summary>
        /// 教龄
        /// </summary>
        public int Years { get; set; }
    }

    /// <summary>
    /// 教练简短信息
    /// </summary>
    public class BriefCoachDTO
    {
        /// <summary>
        /// 教练编号
        /// </summary>
        public int CoachID { get; set; }

        /// <summary>
        /// 教练对应的用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 教练级别,1-初级教练 2-中级教练 3-高级教练 4-培训师
        /// </summary>
        public sbyte Level { get; set; }

        /// <summary>
        /// 教练名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 头像图片路径
        /// </summary>
        public string HeadPortraitUri { get; set; }

        /// <summary>
        /// 简短介绍
        /// </summary>
        public string BriefIntroduction { get; set; }
    }

    

}

