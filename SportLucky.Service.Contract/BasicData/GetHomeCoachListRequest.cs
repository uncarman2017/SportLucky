using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取首页推荐教练列表请求报文
    /// </summary>
    public class GetHomeCoachListRequest
    {
        /// <summary>
        /// 推荐日期的开始日期
        /// </summary>
        public DateTime BeginDate { get; set; }


        /// <summary>
        /// 推荐日期的结束日期
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
