using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取教练详情响应报文
    /// </summary>
    public class GetCoachDetailResponse : BaseResponse
    {
        /// <summary>
        /// 教练详情
        /// </summary>
        [DataMember]
        public CoachDTO Coach { get; set; }
    }
}
