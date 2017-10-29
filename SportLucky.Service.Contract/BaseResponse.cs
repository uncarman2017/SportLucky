using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Contract
{
    [DataContract]
    public abstract class BaseResponse
    {
        List<string> _errors;

        /// <summary>
        /// 执行结果代码
        /// </summary>        
        [DataMember]
        public string Result { get;set;}

        /// <summary>
        /// 返回消息
        /// </summary>
        [DataMember]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 错误信息列表
        /// </summary>
        [DataMember]
        public List<string> Errors
        {
            get
            {
                if (this._errors == null)
                {
                    this._errors = new List<string>();
                }

                return this._errors;
            }
            set
            {
                this._errors = value;
            }
        }

        /// <summary>
        /// 身份令牌号
        /// </summary>
        [DataMember]
        public string Token { get; set; }

        /// <summary>
        /// 当前请求操作
        /// </summary>
        public string RequestDescription { get; set; }
    }
}
