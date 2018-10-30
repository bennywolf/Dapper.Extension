using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    ///  供应商邮费BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_supplier_postage")]
	public class T_SUPPLIER_POSTAGE
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SUP_CODE",false)]
        public string SupCode { get; set; }
        /// <summary>
        /// 供应商
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SU_CODE",false)]
        public string SuCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SU_DESC",false)]
        public string SuDesc { get; set; }
        /// <summary>
        /// 包邮订单最低金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("LOW_AMOUNT",false)]
        public decimal? LowAmount { get; set; }
        /// <summary>
        /// 运费
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("AMOUNT",false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 包邮地区
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("FREE_AREA",false)]
        public string FreeArea { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

