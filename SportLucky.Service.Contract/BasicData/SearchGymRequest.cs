using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 搜索场馆请求报文
    /// </summary>
    public class SearchGymRequest
    {
        public SearchGymRequest()
        {
            Courses = new List<CourseTypeDTO>();

        }

        /// <summary>
        /// 城市ID
        /// </summary>
        public int CityID { get; set; }

        /// <summary>
        /// 行政区ID
        /// </summary>
        public int DistrictID { get; set; }

        /// <summary>
        /// 场馆支持的课程列表
        /// </summary>
        public List<CourseTypeDTO> Courses { get; set; }
    }
}
