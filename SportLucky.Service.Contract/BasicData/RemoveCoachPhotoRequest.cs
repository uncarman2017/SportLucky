using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 移除教练照片请求报文
    /// </summary>
    public class RemoveCoachPhotoRequest
    {
        /// <summary>
        /// 教练ID
        /// </summary>
        public int CoachID { get; set; }

        /// <summary>
        /// 照片ID
        /// </summary>
        public long PhotoID { get; set; }
    }
}
