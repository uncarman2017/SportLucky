using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取首页推荐文章列表响应报文
    /// </summary>
    public class GetHomeArticleListResponse : BaseResponse
    {
        /// <summary>
        /// 文章列表
        /// </summary>
        [DataMember]
        public List<BriefArticleDTO> Articles { get; set; }
    }
}
