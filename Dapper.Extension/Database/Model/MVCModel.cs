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
    public class MVCModel: IModel
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
        /// 拍序字符串
        ///</summary>
        public int OrderBy { get; set; }
    }
}