using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
     /// <summary>
    /// 获取我的预约列表请求报文
    /// </summary>
    public class GetMyBookingListRequest
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 预订开始日期
        /// </summary>
        public DateTime BeginDate { get; set; }


        /// <summary>
        /// 预订结束日期
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
