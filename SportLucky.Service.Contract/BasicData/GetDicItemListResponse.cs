using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取字典项列表响应报文
    /// </summary>
    public class GetDicItemListResponse : BaseResponse
    {
        /// <summary>
        /// 字典项列表
        /// </summary>
        [DataMember]
        public List<DictionaryItemDTO> DicItemList { get; set; }
    }
}
