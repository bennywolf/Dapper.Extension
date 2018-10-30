using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 分销二级BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestSalesRule2Model : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(10,4) IsNull:YES Default:null
        /// </summary>
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Descript { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SALES_RULE2 GetEntity()
		{
			return new T_SALES_RULE2()
			{
				Id = this.Id,
				Count = this.Count,
				Rate = this.Rate,
				Descript = this.Descript,
 
			};
		}
	}
}

