﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 移除场馆照片请求报文
    /// </summary>
    public class RemoveGymPhotoRequest
    {
        /// <summary>
        /// 场馆ID
        /// </summary>
        public int GymID { get; set; }

        /// <summary>
        /// 照片ID
        /// </summary>
        public long PhotoID { get; set; }

    }
}
