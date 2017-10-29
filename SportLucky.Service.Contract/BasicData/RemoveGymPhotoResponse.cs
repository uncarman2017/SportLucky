using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 移除场馆照片响应报文
    /// </summary>
    public class RemoveGymPhotoResponse : BaseResponse
    {
        /// <summary>
        /// 场馆ID
        /// </summary>
        public int GymID { get; set; }


        /// <summary>
        /// 新的照片列表
        /// </summary>
        public List<PhotoDTO> Photos { get; set; }
    }
}
