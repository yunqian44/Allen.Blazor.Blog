using Allen.Blazor.BlogWebApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allen.Blazor.BlogWebApp.Models.Base
{
    /// <summary>
    /// 服务层响应实体
    /// </summary>
    public class ServiceResult
    {
        /// <summary>
        /// 本构造函数 默认为 处理成功
        /// </summary>
        public ServiceResult()
        {

        }
    
        /// <summary>
        /// 本构造函数 默认为 处理成功，且将返回数据传入
        /// </summary>
        /// <param name="d">返回数据</param>
        public ServiceResult(dynamic d)
        {
            this.Data = d;
        }

        /// <summary>
        /// 默认作为出现错误时使用；
        /// </summary>
        /// <param name="code">错误码</param>
        /// <param name="msg">错误信息</param>
        public ServiceResult(ServiceResultCode code, string msg)
        {
            this.Code = ServiceResultCode.Failed;
            this.Msg = msg;
        }

        /// <summary>
        /// 成功
        /// </summary>
        public bool Success => Code == ServiceResultCode.Succeed;


        /// <summary>
        /// 响应码
        /// </summary>
        public ServiceResultCode Code { get; set; }

        public string Msg { get; set; }

        public dynamic Data { get; set; }
    }


    /// <summary>
    /// Api返回数据格式
    /// </summary>
    public class ServiceResult<T> : ServiceResult where T : class
    {
        public ServiceResult()
        {
            
        }

        public ServiceResult(T d)
            : this()
        {
            this.Data = d;
        }

        public ServiceResult(ServiceResultCode code, string msg)
        {
            this.Code = ServiceResultCode.Failed;
            this.Msg = msg;
        }

        public new T Data { get; set; }
    }
}
