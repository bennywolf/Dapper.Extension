using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 产品规格价格BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestProductSpecModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 产品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PrCode { get; set; }
        /// <summary>
        /// 产品规格CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PsCode { get; set; }
        /// <summary>
        /// 规格
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// 团购价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? PriceGroup { get; set; }
        /// <summary>
        /// 价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// 单位
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 成本价
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? CostPrice { get; set; }
        /// <summary>
        /// 销量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? SaleCount { get; set; }
        /// <summary>
        /// 库存数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? StockCount { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsDelete { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string Version { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_PRODUCT_SPEC GetEntity()
		{
			return new T_PRODUCT_SPEC()
			{
				Id = this.Id,
				PrCode = this.PrCode,
				PsCode = this.PsCode,
				Spec = this.Spec,
				PriceGroup = this.PriceGroup,
				Price = this.Price,
				Unit = this.Unit,
				CostPrice = this.CostPrice,
				SaleCount = this.SaleCount,
				StockCount = this.StockCount,
				CreateTime = this.CreateTime,
				UpdateTime = this.UpdateTime,
				IsDelete = this.IsDelete,
				Version = this.Version,
 
			};
		}
	}
}

