using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 产品表BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_product")]
	public class T_PRODUCT
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 类别
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
        /// 产品参数JSON
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("PARAMS",false)]
        public string Params { get; set; }
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
        /// 产品图片
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("IMAGES",false)]
        public string Images { get; set; }
        /// <summary>
        /// 排序
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("SORT",false)]
        public int? Sort { get; set; }
        /// <summary>
        /// 0抢购优惠,1中秋新品,2热门
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("PR_GROUP",false)]
        public int? PrGroup { get; set; }
        /// <summary>
        /// 是否开启倒计时
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("ON_TIMER",false)]
        public int? OnTimer { get; set; }
        /// <summary>
        /// 倒计结束时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("DEADLINE",false)]
        public DateTime? Deadline { get; set; }
        /// <summary>
        /// 标签
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("TAGS",false)]
        public string Tags { get; set; }
        /// <summary>
        /// 缩略图
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("THUMBNAIL",false)]
        public string Thumbnail { get; set; }
        /// <summary>
        /// 最低价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("PRICE_MIN",false)]
        public decimal? PriceMin { get; set; }
        /// <summary>
        /// 最高价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("PRICE_MAX",false)]
        public decimal? PriceMax { get; set; }
        /// <summary>
        /// 团购价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("PRICE_GROUP",false)]
        public decimal? PriceGroup { get; set; }
        /// <summary>
        /// 产品简介
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("DETAIL",false)]
        public string Detail { get; set; }
        /// <summary>
        /// 详细说明
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("PR_CONTENT",false)]
        public string PrContent { get; set; }
        /// <summary>
        /// 总库存数量（假）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("PR_STOCK_COUNT",false)]
        public int? PrStockCount { get; set; }
        /// <summary>
        /// 总销售数据（假）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("PR_SALE_COUNT",false)]
        public int? PrSaleCount { get; set; }
        /// <summary>
        /// 库存（真）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STOCK_COUNT",false)]
        public int? StockCount { get; set; }
        /// <summary>
        /// 销量（真）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("SALE_COUNT",false)]
        public int? SaleCount { get; set; }
        /// <summary>
        /// 上线时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("ONLINE_TIME",false)]
        public DateTime? OnlineTime { get; set; }
        /// <summary>
        /// 1上线，0下线
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_ONLINE",false)]
        public int? IsOnline { get; set; }
        /// <summary>
        /// 删除时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("DELETE_TIME",false)]
        public DateTime? DeleteTime { get; set; }
        /// <summary>
        /// 1删除，0默认
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_DELETE",false)]
        public int? IsDelete { get; set; }
        /// <summary>
        /// 最后一次修改时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("UPDATE_TIME",false)]
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 锁版本号
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        [Column("VERSION",false)]
        public string Version { get; set; }
        /// <summary>
        /// 是否热门
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_HOT",false)]
        public int? IsHot { get; set; }
        /// <summary>
        /// 是否限量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_LIMIT",false)]
        public int? IsLimit { get; set; }
        /// <summary>
        /// 是否收取邮费1是
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_EMS",false)]
        public int? IsEms { get; set; }
        /// <summary>
        /// 邮费
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("EMS_AMOUNT",false)]
        public decimal? EmsAmount { get; set; }
        /// <summary>
        /// 包邮地区
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("EMS_ADDR",false)]
        public string EmsAddr { get; set; }
        /// <summary>
        /// 优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CO_CODE",false)]
        public string CoCode { get; set; }
        /// <summary>
        /// 优惠券
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("COUPON_JSON",false)]
        public string CouponJson { get; set; }
        /// <summary>
        /// 首页类别CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PHT_CODE",false)]
        public string PhtCode { get; set; }
        /// <summary>
        /// 首页类别NAME
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("PHT_NAME",false)]
        public string PhtName { get; set; }
        /// <summary>
        /// 供应商
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SU_CODE",false)]
        public string SuCode { get; set; }
        /// <summary>
        /// 产品分销金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        [Column("SALES_AMOUNT",false)]
        public decimal? SalesAmount { get; set; }
   
	}
}

