using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取场馆详情请求报文
    /// </summary>
    public class GetGymDetailRequest
    {
        /// <summary>
        /// 场馆ID
        /// </summary>
        public int GymID { get; set; }
    }
}
