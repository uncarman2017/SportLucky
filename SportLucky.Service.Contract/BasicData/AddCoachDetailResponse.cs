using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 私教入驻响应报文
    /// </summary>
    public class AddCoachDetailResponse : BaseResponse
    {
        /// <summary>
        /// 教练ID
        /// </summary>
        public int CoachID { get; set; }
    }
}
