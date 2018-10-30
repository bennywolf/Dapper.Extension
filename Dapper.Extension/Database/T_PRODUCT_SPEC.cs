using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 产品规格价格BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_product_spec")]
	public class T_PRODUCT_SPEC
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 产品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PR_CODE",false)]
        public string PrCode { get; set; }
        /// <summary>
        /// 产品规格CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PS_CODE",false)]
        public string PsCode { get; set; }
        /// <summary>
        /// 规格
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SPEC",false)]
        public string Spec { get; set; }
        /// <summary>
        /// 团购价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("PRICE_GROUP",false)]
        public decimal? PriceGroup { get; set; }
        /// <summary>
        /// 价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("PRICE",false)]
        public decimal? Price { get; set; }
        /// <summary>
        /// 单位
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("UNIT",false)]
        public string Unit { get; set; }
        /// <summary>
        /// 成本价
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("COST_PRICE",false)]
        public decimal? CostPrice { get; set; }
        /// <summary>
        /// 销量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("SALE_COUNT",false)]
        public int? SaleCount { get; set; }
        /// <summary>
        /// 库存数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STOCK_COUNT",false)]
        public int? StockCount { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("UPDATE_TIME",false)]
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_DELETE",false)]
        public int? IsDelete { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        [Column("VERSION",false)]
        public string Version { get; set; }
   
	}
}

