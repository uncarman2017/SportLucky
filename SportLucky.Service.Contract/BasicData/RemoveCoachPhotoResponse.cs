using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    public class RemoveCoachPhotoResponse : BaseResponse
    {
        /// <summary>
        /// 教练ID
        /// </summary>
        public int CoachID { get; set; }


        /// <summary>
        /// 新的照片列表
        /// </summary>
        public List<PhotoDTO> Photos { get; set; }
    }
}
