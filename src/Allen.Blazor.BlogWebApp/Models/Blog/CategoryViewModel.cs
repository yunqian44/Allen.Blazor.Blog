using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allen.Blazor.BlogWebApp.Models.Blog
{
    public class CategoryViewModel
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 展示名称
        /// </summary>
        public string DisplayName { get; set; }
    }
}
