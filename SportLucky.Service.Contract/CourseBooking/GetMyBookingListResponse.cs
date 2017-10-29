using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取我的预约列表响应报文
    /// </summary>
    public class GetMyBookingListResponse : BaseResponse
    {
        /// <summary>
        /// 我的预订列表
        /// </summary>
        [DataMember]
        public List<CourseBookingDTO> MyBookingList { get; set; }
    }
}
