using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 照片
    /// </summary>
    public class PhotoDTO
    {
        /// <summary>
        /// 照片URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 照片描述
        /// </summary>
        public string Desc { get; set; }

    }

    /// <summary>
    /// 课程类型
    /// </summary>
    public class CourseTypeDTO
    {
        /// <summary>
        /// 课程类型ID
        /// </summary>
        public int CourseTypeID { get; set; }

        /// <summary>
        /// 收费类型, 0-公益课 1-公开课 2-教练提升等级培训课程 3-免费体验  4-限时折扣
        /// </summary>
        public sbyte ChargeType { get; set; }

        /// <summary>
        /// 课程类型名称
        /// </summary>
        public string CourseTypeName { get; set; }
    }

    /// <summary>
    /// 字典项类型
    /// </summary>
    public class DictionaryItemDTO
    {
        /// <summary>
        /// 字典项ID
        /// </summary>
        public int DicItemID { get; set; }

        /// <summary>
        /// 字典项类型
        /// 如
        ///CollectionType-收藏对象的类型
        ///ConsumeWay-肌点消费途径
        ///GainWay-肌点获取途径
        public string DicType { get; set; }

        /// <summary>
        /// 字典项文本
        /// </summary>
        public string ItemText { get; set; }

        /// <summary>
        /// 字典项值
        /// </summary>
        public short ItemValue { get; set; } 
    }
}
