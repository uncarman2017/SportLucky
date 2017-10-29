using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{

    /// <summary>
    /// 文章信息
    /// </summary>
    public class ArticleDTO
    {
        public string Title { get; set; }

        public string BriefContent { get; set; }

        public int UserID { get; set; }
    }


    /// <summary>
    /// 文章简短信息
    /// </summary>
    public class BriefArticleDTO
    {
        public string Title { get; set; }

        public string BriefContent { get; set; }
    }
}
