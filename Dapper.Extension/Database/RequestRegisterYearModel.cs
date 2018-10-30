using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// VIEWVIEW
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestRegisterYearModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:bigint(21) IsNull:NO Default:0
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 
        /// Type:int(4) IsNull:YES Default:null
        /// </summary>
        public int? Year { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public V_REGISTER_YEAR GetEntity()
		{
			return new V_REGISTER_YEAR()
			{
				Count = this.Count,
				Year = this.Year,
 
			};
		}
	}
}

