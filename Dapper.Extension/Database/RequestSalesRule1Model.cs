using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 分销一级BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestSalesRule1Model : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 说明
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Descript { get; set; }
        /// <summary>
        /// 级别分销人数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 奖励金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 产品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PrCode { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SALES_RULE1 GetEntity()
		{
			return new T_SALES_RULE1()
			{
				Id = this.Id,
				Descript = this.Descript,
				Count = this.Count,
				Amount = this.Amount,
				PrCode = this.PrCode,
 
			};
		}
	}
}

