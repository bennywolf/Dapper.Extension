using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 订单详情BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_shop_order_detail")]
	public class T_SHOP_ORDER_DETAIL
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SO_CODE",false)]
        public string SoCode { get; set; }
        /// <summary>
        /// 产品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PR_CODE",false)]
        public string PrCode { get; set; }
        /// <summary>
        /// 产品名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("NAME",false)]
        public string Name { get; set; }
        /// <summary>
        /// 产品缩略图
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("THUMBNAIL",false)]
        public string Thumbnail { get; set; }
        /// <summary>
        /// 规格
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
        /// 单价
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("PRICE",false)]
        public decimal? Price { get; set; }
        /// <summary>
        /// 是否团购
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_GROUP",false)]
        public int? IsGroup { get; set; }
        /// <summary>
        /// 单位
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("UNIT",false)]
        public string Unit { get; set; }
        /// <summary>
        /// 类别CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PT_CODE",false)]
        public string PtCode { get; set; }
        /// <summary>
        /// 类别名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("PT_NAME",false)]
        public string PtName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PHT_CODE",false)]
        public string PhtCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("PHT_NAME",false)]
        public string PhtName { get; set; }
        /// <summary>
        /// 订单产品详情
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SOD_CODE",false)]
        public string SodCode { get; set; }
        /// <summary>
        /// 购买数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("NUM",false)]
        public int? Num { get; set; }
        /// <summary>
        /// 小计
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("TOL_AMOUNT",false)]
        public decimal? TolAmount { get; set; }
        /// <summary>
        /// 领取的优惠券
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CO_CODE",false)]
        public string CoCode { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 是否评论
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_COMMENT",false)]
        public int? IsComment { get; set; }
        /// <summary>
        /// 供应商CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SU_CODE",false)]
        public string SuCode { get; set; }
        /// <summary>
        /// 供应商订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SOS_CODE",false)]
        public string SosCode { get; set; }
   
	}
}

