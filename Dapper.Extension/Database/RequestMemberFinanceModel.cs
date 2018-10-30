using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 消费明细表BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestMemberFinanceModel : RequstModel
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
        public string MeCode { get; set; }
        /// <summary>
        /// CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MfCode { get; set; }
        /// <summary>
        /// 描述
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string MfDesc { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? MfAmount { get; set; }
        /// <summary>
        /// 0收入，1支出
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MfType { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreatetTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_MEMBER_FINANCE GetEntity()
		{
			return new T_MEMBER_FINANCE()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				MfCode = this.MfCode,
				MfDesc = this.MfDesc,
				MfAmount = this.MfAmount,
				MfType = this.MfType,
				CreatetTime = this.CreatetTime,
 
			};
		}
	}
}

