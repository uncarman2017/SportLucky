using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 收藏对象请求
    /// </summary>
    public class SubmitCollectionRequest
    {
        /// <summary>
        /// 收藏者的用户ID
        /// </summary>
        public long UserID { get; set; }


        /// <summary>
        /// 收藏类型 1-教练 2-场馆 3-文章
        /// </summary>
        public sbyte CollectionType { get; set; }

        /// <summary>
        /// 待收藏的对象ID(CoachID,GymID,ArticleID)
        /// </summary>
        public long ObjectID { get; set; }
    }
}
