using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 供应商订单BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_shop_order_supplier")]
	public class T_SHOP_ORDER_SUPPLIER
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 供应商订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SOS_CODE",false)]
        public string SosCode { get; set; }
        /// <summary>
        /// 供应商
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SU_CODE",false)]
        public string SuCode { get; set; }
        /// <summary>
        /// 供应商名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SU_NAME",false)]
        public string SuName { get; set; }
        /// <summary>
        /// 用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ME_NAME",false)]
        public string MeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ME_HEAD_PHOTO",false)]
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 供应商联系人
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SU_LINKMEN",false)]
        public string SuLinkmen { get; set; }
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
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MA_CITY",false)]
        public string MaCity { get; set; }
        /// <summary>
        /// 小区
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MA_AREA",false)]
        public string MaArea { get; set; }
        /// <summary>
        /// 详情位置
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("MA_DETAIL",false)]
        public string MaDetail { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("ADDRESS_JSON",false)]
        public string AddressJson { get; set; }
        /// <summary>
        /// 订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SO_CODE",false)]
        public string SoCode { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STATUS",false)]
        public int? Status { get; set; }
        /// <summary>
        /// 发货时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("DELIVER_TIME",false)]
        public DateTime? DeliverTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CONFIRM_TIME",false)]
        public DateTime? ConfirmTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 发货方式（0=快递，1=自提）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("DELIVER_TYPE",false)]
        public int? DeliverType { get; set; }
        /// <summary>
        /// 自提点CODE
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
        /// 留言
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("REMARK",false)]
        public string Remark { get; set; }
        /// <summary>
        /// 商户订单号
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("TRADE_NO",false)]
        public string TradeNo { get; set; }
        /// <summary>
        /// 邮费
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("EMS_MONEY",false)]
        public decimal? EmsMoney { get; set; }
        /// <summary>
        /// 商品总金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("PR_AMOUNT",false)]
        public decimal? PrAmount { get; set; }
        /// <summary>
        /// 订单总金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("AMOUNT",false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("PR_NAMES",false)]
        public string PrNames { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("EMS_NAME",false)]
        public string EmsName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("EMS_NO",false)]
        public string EmsNo { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PX_CODE",false)]
        public string PxCode { get; set; }
   
	}
}

