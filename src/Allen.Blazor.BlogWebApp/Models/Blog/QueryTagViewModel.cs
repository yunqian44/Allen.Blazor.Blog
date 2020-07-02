using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allen.Blazor.BlogWebApp.Models.Blog
{
    public class QueryTagViewModel: TagViewModel
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int Count { get; set; }
    }
}
