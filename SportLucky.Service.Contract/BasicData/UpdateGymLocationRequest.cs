using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 更新场馆地图位置信息请求报文
    /// </summary>
    public class UpdateGymLocationRequest
    {
        /// <summary>
        /// 场馆ID
        /// </summary>
        public int GymID { get; set; }

        /// <summary>
        /// 场馆所在位置的经度
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// 场馆所在位置的纬度
        /// </summary>
        public decimal Latitude { get; set; }
    }
}
