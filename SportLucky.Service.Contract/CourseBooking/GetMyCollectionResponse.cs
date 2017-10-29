using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取我的收藏响应报文
    /// </summary>
    public class GetMyCollectionResponse : BaseResponse
    {
        /// <summary>
        /// 收藏品列表
        /// </summary>
        public List<CollectionDTO> MyCollections { get; set; }
    }
}
