using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 更新场馆详情请求报文
    /// </summary>
    public class UpdateGymDetailRequest
    {
        /// <summary>
        /// 场馆详情
        /// </summary>
        public GymDTO GymDetail { get; set; }
    }
}
