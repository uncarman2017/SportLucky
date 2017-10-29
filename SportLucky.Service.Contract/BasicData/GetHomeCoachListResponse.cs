using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取首页推荐教练列表响应报文
    /// </summary>
    public class GetHomeCoachListResponse : BaseResponse
    {
        /// <summary>
        /// 教练列表
        /// </summary>
        [DataMember]
        public List<BriefCoachDTO> Coaches { get; set; }
    }
}
