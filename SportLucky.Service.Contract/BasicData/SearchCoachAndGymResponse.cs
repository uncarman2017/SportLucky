using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    
    /// <summary>
    /// 搜索教练和场馆响应报文
    /// </summary>
    public class SearchCoachAndGymResponse : BaseResponse
    {
        /// <summary>
        /// 教练和场馆列表
        /// </summary>
        public List<BriefCoachAndGymDTO> CoachAndGymList { get; set; }
    }
}
