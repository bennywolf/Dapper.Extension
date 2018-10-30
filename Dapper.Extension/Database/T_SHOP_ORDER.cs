using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 购物订单BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_shop_order")]
	public class T_SHOP_ORDER
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 商品名称
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("PR_NAMES",false)]
        public string PrNames { get; set; }
        /// <summary>
        /// 用户
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 用户名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_NAME",false)]
        public string MeName { get; set; }
        /// <summary>
        /// 用户头像
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_HEAD_PHOTO",false)]
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 收货地址CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MA_CODE",false)]
        public string MaCode { get; set; }
        /// <summary>
        /// 收货人
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MA_NAME",false)]
        public string MaName { get; set; }
        /// <summary>
        /// 收货人号码
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MA_MOBILE",false)]
        public string MaMobile { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MA_PROVI",false)]
        public string MaProvi { get; set; }
        /// <summary>
        /// 市
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MA_CITY",false)]
        public string MaCity { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MA_AREA",false)]
        public string MaArea { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MA_DETAIL",false)]
        public string MaDetail { get; set; }
        /// <summary>
        /// 用户收货地址
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("ADDRESS_JSON",false)]
        public string AddressJson { get; set; }
        /// <summary>
        /// 商户订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SO_CODE",false)]
        public string SoCode { get; set; }
        /// <summary>
        /// 商户单号
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        [Column("TRADE_NO",false)]
        public string TradeNo { get; set; }
        /// <summary>
        /// 支付单号
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("TRANSACTION_ID",false)]
        public string TransactionId { get; set; }
        /// <summary>
        /// 支付时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("PAYMENT_TIME",false)]
        public DateTime? PaymentTime { get; set; }
        /// <summary>
        /// 支付状态0,未付款，1已付款
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("PAYMENT_STATUS",false)]
        public int? PaymentStatus { get; set; }
        /// <summary>
        /// 结算方式：0余额全款,1余额及微信,2微信全款
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("PAYMENT_TYPE",false)]
        public int? PaymentType { get; set; }
        /// <summary>
        /// 微信退款ID
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        [Column("REFUND_ID",false)]
        public string RefundId { get; set; }
        /// <summary>
        /// 退款金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("REFUND_FEE",false)]
        public decimal? RefundFee { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("REFUND_TIME",false)]
        public DateTime? RefundTime { get; set; }
        /// <summary>
        /// 用户留言
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("REMARK",false)]
        public string Remark { get; set; }
        /// <summary>
        /// 优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MC_CODE",false)]
        public string McCode { get; set; }
        /// <summary>
        /// 0未付款,1已付款,2待发货,3已发货,4确认收货
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STATUS",false)]
        public int? Status { get; set; }
        /// <summary>
        /// 分享优惠金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("SHARE_AMOUNT",false)]
        public decimal? ShareAmount { get; set; }
        /// <summary>
        /// 余额抵押
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("BAL_AMOUNT",false)]
        public decimal? BalAmount { get; set; }
        /// <summary>
        /// 优惠金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("DIS_AMOUNT",false)]
        public decimal? DisAmount { get; set; }
        /// <summary>
        /// 微信抵押金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("WX_AMOUNT",false)]
        public decimal? WxAmount { get; set; }
        /// <summary>
        /// 应付金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("SHO_AMOUNT",false)]
        public decimal? ShoAmount { get; set; }
        /// <summary>
        /// 订单总价
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("AMOUNT",false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 快递名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("EMS_NAME",false)]
        public string EmsName { get; set; }
        /// <summary>
        /// 快递号码
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("EMS_NO",false)]
        public string EmsNo { get; set; }
        /// <summary>
        /// 邮费
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("EMS_MONEY",false)]
        public decimal? EmsMoney { get; set; }
        /// <summary>
        /// 发货时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("DELIVER_TIME",false)]
        public DateTime? DeliverTime { get; set; }
        /// <summary>
        /// 创建下单时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 确认收货时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CONFIRM_TIME",false)]
        public DateTime? ConfirmTime { get; set; }
        /// <summary>
        /// 发货方式（0=快递，1=自提）
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        [Column("DELIVER_TYPE",false)]
        public int? DeliverType { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SD_CODE",false)]
        public string SdCode { get; set; }
        /// <summary>
        /// 自提详情
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("DELIVER_JSON",false)]
        public string DeliverJson { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CANCLE_TIME",false)]
        public DateTime? CancleTime { get; set; }
        /// <summary>
        /// 优惠券总金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("PACKET",false)]
        public decimal? Packet { get; set; }
        /// <summary>
        /// 评价时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("COMMENT_TIME",false)]
        public DateTime? CommentTime { get; set; }
        /// <summary>
        /// 是否售后
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_AFTER",false)]
        public int? IsAfter { get; set; }
        /// <summary>
        /// 售后状态：0未处理，1处理中，2已解决
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("AFTER_STATUS",false)]
        public int? AfterStatus { get; set; }
        /// <summary>
        /// 是否分享
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_SHARE",false)]
        public int? IsShare { get; set; }
        /// <summary>
        /// 团队CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PX_CODE",false)]
        public string PxCode { get; set; }
        /// <summary>
        /// 转化率
        /// Type:decimal(10,4) IsNull:YES Default:null
        /// </summary>
        [Column("CON_RATE",false)]
        public decimal? ConRate { get; set; }
        /// <summary>
        /// 团长分红
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("SALES_AMOUNT",false)]
        public decimal? SalesAmount { get; set; }
   
	}
}

