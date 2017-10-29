using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 搜索教练响应报文
    /// </summary>
    public class SearchCoachResponse : BaseResponse
    {
        /// <summary>
        /// 教练列表
        /// </summary>
        [DataMember]
        public List<BriefCoachDTO> Coaches { get; set; }
    }


   
}
