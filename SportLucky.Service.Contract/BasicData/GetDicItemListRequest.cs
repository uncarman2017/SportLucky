using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 获取字典项列表请求报文
    /// </summary>
    public class GetDicItemListRequest
    {
        /// <summary>
        /// 字典项类型
        /// 如
        ///CollectionType-收藏对象的类型
        ///ConsumeWay-肌点消费途径
        ///GainWay-肌点获取途径
        /// </summary>
        public string DicType { get; set; }
    }
}
