using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户表BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_member")]
	public class T_MEMBER
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
        /// 0男,1女
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("ME_GANDER",false)]
        public int? MeGander { get; set; }
        /// <summary>
        /// 联系电话
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_MOBILE",false)]
        public string MeMobile { get; set; }
        /// <summary>
        /// 昵称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_NAME",false)]
        public string MeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        [Column("ME_OPENID",false)]
        public string MeOpenid { get; set; }
        /// <summary>
        /// 头像
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_HEAD_PHOTO",false)]
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 推荐人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_FACODE",false)]
        public string MeFacode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("FA_NAME",false)]
        public string FaName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("FA_HEAD_PHOTO",false)]
        public string FaHeadPhoto { get; set; }
        /// <summary>
        /// 可用余额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("ME_BAL_AMOUNT",false)]
        public decimal? MeBalAmount { get; set; }
        /// <summary>
        /// 提现冻结金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("ME_FRE_AMOUNT",false)]
        public decimal? MeFreAmount { get; set; }
        /// <summary>
        /// 分销盈利金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("ME_SAL_AMOUNT",false)]
        public decimal? MeSalAmount { get; set; }
        /// <summary>
        /// 分销待收益金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("ME_TMP_SAL_AMOUNT",false)]
        public decimal? MeTmpSalAmount { get; set; }
        /// <summary>
        /// 订单数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("ME_ORD_COUNT",false)]
        public int? MeOrdCount { get; set; }
        /// <summary>
        /// 所有下级订单笔数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("ME_SUB_ORD_COUNT",false)]
        public int? MeSubOrdCount { get; set; }
        /// <summary>
        /// 子用户数,推荐的用户数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("ME_SUB_COUNT",false)]
        public int? MeSubCount { get; set; }
        /// <summary>
        /// 用户二维码
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("QR_CODE",false)]
        public string QrCode { get; set; }
        /// <summary>
        /// 版本
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
        /// 提货人姓名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("DELIVER_NAME",false)]
        public string DeliverName { get; set; }
        /// <summary>
        /// 提货手机号
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("DELIVER_MOBILE",false)]
        public string DeliverMobile { get; set; }
        /// <summary>
        /// 是否代理：0不是，1是
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_PROXY",false)]
        public int? IsProxy { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PX_CODE",false)]
        public string PxCode { get; set; }
        /// <summary>
        /// 分销转换率
        /// Type:decimal(10,4) IsNull:YES Default:null
        /// </summary>
        [Column("SALES_RATE",false)]
        public decimal? SalesRate { get; set; }
   
	}
}

