using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 搜索场馆响应报文
    /// </summary>
    public class SearchGymResponse : BaseResponse
    {
        [DataMember]
        public List<BriefGymDTO> Gyms { get; set; }
    }
}
