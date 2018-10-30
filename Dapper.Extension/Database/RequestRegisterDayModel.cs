using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// VIEWVIEW
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestRegisterDayModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:date IsNull:YES Default:null
        /// </summary>
        public DateTime? Day { get; set; }
        /// <summary>
        /// 
        /// Type:bigint(21) IsNull:NO Default:0
        /// </summary>
        public int? Count { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public V_REGISTER_DAY GetEntity()
		{
			return new V_REGISTER_DAY()
			{
				Day = this.Day,
				Count = this.Count,
 
			};
		}
	}
}

