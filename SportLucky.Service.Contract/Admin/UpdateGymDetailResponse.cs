using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 更新场馆详情响应报文
    /// </summary>
    public class UpdateGymDetailResponse : BaseResponse
    {
        /// <summary>
        /// 场馆ID
        /// </summary>
        [DataMember]
        public int GymID { get; set; }
    }
}
