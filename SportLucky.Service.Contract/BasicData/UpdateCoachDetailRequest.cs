using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 更新教练详情信息请求报文
    /// </summary>
    public class UpdateCoachDetailRequest
    {
        /// <summary>
        /// 教练编号
        /// </summary>
        public string CoachNumber { get; set; }

        /// <summary>
        /// 星级
        /// </summary>
        public sbyte Level { get; set; }

        /// <summary>
        /// 健身馆ID
        /// </summary>
        public int GymID { get; set; }

        /// <summary>
        /// 个人签名
        /// </summary>
        public string PersonalSign { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string BriefIntroduction { get; set; }

        /// <summary>
        /// 荣誉描述
        /// </summary>
        public string HonorDesc { get; set; }

        /// <summary>
        /// 课程描述
        /// </summary>
        public string CourseDesc { get; set; }

        /// <summary>
        /// 联系信息
        /// </summary>
        public string ContactInfo { get; set; }

        /// <summary>
        /// 头像图片Uri
        /// </summary>
        public string HeadPortraitUri { get; set; }
    }
}
