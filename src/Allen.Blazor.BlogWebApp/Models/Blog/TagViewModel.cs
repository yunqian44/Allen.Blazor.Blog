using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allen.Blazor.BlogWebApp.Models.Blog
{
    public class TagViewModel
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// 展示名称
        /// </summary>
        public string DisplayName { get; set; }
    }
}
