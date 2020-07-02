using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allen.Blazor.BlogWebApp.Models.Blog
{
    public class PostForPagedViewModel
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        public string Url { get; set; }
    }
}
