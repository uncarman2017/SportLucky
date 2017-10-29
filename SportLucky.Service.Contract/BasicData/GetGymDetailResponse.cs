using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取场馆详情响应报文
    /// </summary>
    public class GetGymDetailResponse : BaseResponse
    {
        /// <summary>
        /// 场馆详情信息
        /// </summary>
        [DataMember]
        public GymDTO GymDetail { get; set; }
    }
}
