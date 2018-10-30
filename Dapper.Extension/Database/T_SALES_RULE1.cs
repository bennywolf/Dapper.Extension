using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 分销一级BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_sales_rule1")]
	public class T_SALES_RULE1
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 说明
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("DESCRIPT",false)]
        public string Descript { get; set; }
        /// <summary>
        /// 级别分销人数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("COUNT",false)]
        public int? Count { get; set; }
        /// <summary>
        /// 奖励金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("AMOUNT",false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 产品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PR_CODE",false)]
        public string PrCode { get; set; }
   
	}
}

