using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 场馆新增请求报文
    /// </summary>
    public class AddGymDetailRequest
    {
        /// <summary>
        /// 场馆详情信息
        /// </summary>
        public GymDTO GymDetail { get; set; }
    }
}
