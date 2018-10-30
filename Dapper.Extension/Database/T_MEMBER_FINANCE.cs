using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 消费明细表BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_member_finance")]
	public class T_MEMBER_FINANCE
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
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MF_CODE",false)]
        public string MfCode { get; set; }
        /// <summary>
        /// 描述
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("MF_DESC",false)]
        public string MfDesc { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("MF_AMOUNT",false)]
        public decimal? MfAmount { get; set; }
        /// <summary>
        /// 0收入，1支出
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("MF_TYPE",false)]
        public int? MfType { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATET_TIME",false)]
        public DateTime? CreatetTime { get; set; }
   
	}
}

