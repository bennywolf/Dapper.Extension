using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 分享减免规则BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestShareRuleModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? DisAmount { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Descript { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SHARE_RULE GetEntity()
		{
			return new T_SHARE_RULE()
			{
				Id = this.Id,
				Amount = this.Amount,
				DisAmount = this.DisAmount,
				Descript = this.Descript,
 
			};
		}
	}
}

