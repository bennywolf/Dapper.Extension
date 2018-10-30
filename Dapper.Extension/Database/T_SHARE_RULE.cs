using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 分享减免规则BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_share_rule")]
	public class T_SHARE_RULE
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("AMOUNT",false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("DIS_AMOUNT",false)]
        public decimal? DisAmount { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("DESCRIPT",false)]
        public string Descript { get; set; }
   
	}
}

