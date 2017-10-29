using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserDTO
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public long UserID { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 手机信息
        /// </summary>
        public string MobileInfo { get; set; }
       

        /// <summary>
        /// 用户类型 1-教练 2-客人
        /// </summary>
        public sbyte UserType { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 性别
        /// 0: 男
        /// 1: 女
        /// </summary>
        public sbyte Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public sbyte Age { get; set; }

        /// <summary>
        /// 个人签名
        /// </summary>
        public string PersonalSign { get; set; }

        /// <summary>
        /// 头像图片路径
        /// </summary>
        public string HeadPortraitUri { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// 用户状态
        /// 0: 待审核
        /// 1: 有效
        /// 2: 注销
        /// </summary>
        public sbyte UserStatus { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd
        {
            get; set;
        }
    }
}
