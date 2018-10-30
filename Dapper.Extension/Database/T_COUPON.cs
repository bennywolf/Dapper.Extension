using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户优惠券BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_coupon")]
	public class T_COUPON
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CO_CODE",false)]
        public string CoCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CO_DESC",false)]
        public string CoDesc { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("CO_TITLE",false)]
        public string CoTitle { get; set; }
        /// <summary>
        /// 最低使用金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("LOW_AMOUT",false)]
        public decimal? LowAmout { get; set; }
        /// <summary>
        /// 优惠券金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("DIS_AMOUT",false)]
        public decimal? DisAmout { get; set; }
        /// <summary>
        /// 失效时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("EXPIRY_TIME",false)]
        public DateTime? ExpiryTime { get; set; }
        /// <summary>
        /// 最大发放数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("MAX_COUNT",false)]
        public int? MaxCount { get; set; }
        /// <summary>
        /// 已发放数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("GET_COUNT",false)]
        public int? GetCount { get; set; }
        /// <summary>
        /// 0,新人专享,1普通优惠券
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("CO_TYPE",false)]
        public int? CoType { get; set; }
        /// <summary>
        /// 防止丢失更新版本
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        [Column("VERSION",false)]
        public string Version { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PR_CODE",false)]
        public string PrCode { get; set; }
   
	}
}

