using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 所有MVCModel的基类，用于扩展MVCModel的公共属性
    /// </summary>
    public class MVCModel : IModel
    {
        /// <summary>
        /// 页码
        /// </summary>
		public int PageIndex { get; set; }
        /// <summary>
        /// 页长
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 总页码
        /// </summary>
        public int PageCount { get; set; }
        ///<summary>
        /// 排序序字符串
        ///</summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// 是否查询所有:1是,0否
        /// </summary>
        public int QueryAll { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        public int TotalCount { get; set; }
    }
}