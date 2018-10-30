using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    ///  供应商邮费BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestSupplierPostageModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SupCode { get; set; }
        /// <summary>
        /// 供应商
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SuCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SuDesc { get; set; }
        /// <summary>
        /// 包邮订单最低金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? LowAmount { get; set; }
        /// <summary>
        /// 运费
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 包邮地区
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string FreeArea { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SUPPLIER_POSTAGE GetEntity()
		{
			return new T_SUPPLIER_POSTAGE()
			{
				Id = this.Id,
				SupCode = this.SupCode,
				SuCode = this.SuCode,
				SuDesc = this.SuDesc,
				LowAmount = this.LowAmount,
				Amount = this.Amount,
				FreeArea = this.FreeArea,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

