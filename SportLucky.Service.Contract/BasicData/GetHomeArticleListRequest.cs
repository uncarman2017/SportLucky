using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取首页推荐文章请求报文
    /// </summary>
    public class GetHomeArticleListRequest
    {
        /// <summary>
        /// 文章发布的开始日期
        /// </summary>
        public DateTime BeginDate { get; set; }


        /// <summary>
        /// 文章发布的结束日期
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
