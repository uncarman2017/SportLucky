using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 提交推荐响应
    /// </summary>
    public class SubmitCollectionResponse : BaseResponse
    {
        /// <summary>
        /// 新建的收藏记录ID
        /// </summary>
        [DataMember]
        public long CollectionID { get; set; }
    }
}
