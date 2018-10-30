using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 购物车BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestShopCarModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 购物车CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string ScCode { get; set; }
        /// <summary>
        /// 规格
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PsCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string PrJson { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string PsJson { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? PsCount { get; set; }
        /// <summary>
        /// 是否团购
        /// Type:int(18) IsNull:YES Default:null
        /// </summary>
        public int? IsGroup { get; set; }
        /// <summary>
        /// 团购结束时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? GroupTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SHOP_CAR GetEntity()
		{
			return new T_SHOP_CAR()
			{
				Id = this.Id,
				ScCode = this.ScCode,
				PsCode = this.PsCode,
				MeCode = this.MeCode,
				PrJson = this.PrJson,
				PsJson = this.PsJson,
				PsCount = this.PsCount,
				IsGroup = this.IsGroup,
				GroupTime = this.GroupTime,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

