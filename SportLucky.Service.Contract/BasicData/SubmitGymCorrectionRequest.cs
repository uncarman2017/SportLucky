using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 提交场馆纠错信息请求报文
    /// </summary>
    public class SubmitGymCorrectionRequest
    {
        /// <summary>
        /// 提交人用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 场馆ID
        /// </summary>
        public int GymID { get; set; }

        /// <summary>
        /// 纠错类型, 1-电话有误,2-地址有误,3-地图位置有误
        /// </summary>
        public sbyte CorrectType { get; set; }

        /// <summary>
        /// 纠错内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 纠错照片列表
        /// </summary>
        public List<PhotoDTO> PhotoList { get; set; }

        /// <summary>
        /// 纠错照片Jason对象数组
        /// </summary>
        public string Photos { get; set; }
    }
}
