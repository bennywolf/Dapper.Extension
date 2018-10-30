using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户优惠券BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_member_coupon")]
	public class T_MEMBER_COUPON
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 用户
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 用户优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MC_CODE",false)]
        public string McCode { get; set; }
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
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("CO_TYPE",false)]
        public int? CoType { get; set; }
        /// <summary>
        /// 是否使用1是，0不是
        /// Type:int(50) IsNull:YES Default:null
        /// </summary>
        [Column("IS_USE",false)]
        public int? IsUse { get; set; }
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
        /// 使用时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("USE_TIME",false)]
        public DateTime? UseTime { get; set; }
        /// <summary>
        /// 获取时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("GET_TIME",false)]
        public DateTime? GetTime { get; set; }
        /// <summary>
        /// 0购物,1注册
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("GET_TYPE",false)]
        public int? GetType { get; set; }
        /// <summary>
        /// 失效时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("EXPIRY_TIME",false)]
        public DateTime? ExpiryTime { get; set; }
        /// <summary>
        /// 获取该券的标识CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("GET_CODE",false)]
        public string GetCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PR_CODE",false)]
        public string PrCode { get; set; }
   
	}
}

