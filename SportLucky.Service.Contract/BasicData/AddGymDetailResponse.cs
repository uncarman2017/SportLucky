using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 场馆新增响应报文
    /// </summary>
    public class AddGymDetailResponse : BaseResponse
    {
        /// <summary>
        /// 新增的场馆ID
        /// </summary>
        [DataMember]
        public int GymID { get; set; }
    }
}
