using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 教练和场馆信息
    /// </summary>
    public class BriefCoachAndGymDTO
    {
        /// <summary>
        /// 信息类型, 1-场馆 2-教练
        /// </summary>
        public sbyte InfoType { get; set; }

        /// <summary>
        /// 教练或场馆ID
        /// </summary>
        public int InfoID { get; set; }

        /// <summary>
        /// 教练或场馆名称
        /// </summary>
        public string CoachOrGymName { get; set; }

      
    }
}
