using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 课程预订信息
    /// </summary>
    public class CourseBookingDTO
    {
        public long CourseBookingID { get; set;}
        
        /// <summary>
        /// 客人的用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 课程类型ID
        /// </summary>
        public int CourseTypeID { get; set; }

        /// <summary>
        /// 选择的教练ID
        /// </summary>
        public int CoachID { get; set; }

        /// <summary>
        /// 预订时间
        /// </summary>
        public DateTime BookingTime { get; set; }


        /// <summary>
        /// 上课日期
        /// </summary>
        public DateTime CourseDate { get; set; }

        /// <summary>
        /// 课程开始时间,格式HH:mm
        /// </summary>
        public TimeSpan CourseBeginTime { get; set; }

        /// <summary>
        /// 课程结束时间,格式HH:mm
        /// </summary>
        public TimeSpan CourseEndTime { get; set; }

        /// <summary>
        /// 课时
        /// </summary>
        public int Hours { get; set; }

        /// <summary>
        /// 预订状态,0-新订 1-教练已确认 2-完成 3-取消 4-过期
        /// </summary>
        public sbyte BookingStatus { get; set; }

        /// <summary>
        /// 场馆地址
        /// </summary>
        public string GymAddress { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

       
    }


  
}
