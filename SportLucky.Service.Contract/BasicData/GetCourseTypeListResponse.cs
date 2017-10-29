using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取课程类型列表响应报文
    /// </summary>
    public class GetCourseTypeListResponse : BaseResponse
    {
        
        /// <summary>
        /// 课程类型列表
        /// </summary>
        [DataMember]
        public List<CourseTypeDTO> CourseTypeList { get; set; }
    }
}
