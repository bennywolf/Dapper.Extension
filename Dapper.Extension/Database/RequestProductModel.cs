using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 产品表BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestProductModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 类别
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PtCode { get; set; }
        /// <summary>
        /// 类别名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string PtName { get; set; }
        /// <summary>
        /// 产品参数JSON
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Params { get; set; }
        /// <summary>
        /// 产品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PrCode { get; set; }
        /// <summary>
        /// 产品名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 产品图片
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Images { get; set; }
        /// <summary>
        /// 排序
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 0抢购优惠,1中秋新品,2热门
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? PrGroup { get; set; }
        /// <summary>
        /// 是否开启倒计时
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? OnTimer { get; set; }
        /// <summary>
        /// 倒计结束时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? Deadline { get; set; }
        /// <summary>
        /// 标签
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// 缩略图
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Thumbnail { get; set; }
        /// <summary>
        /// 最低价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? PriceMin { get; set; }
        /// <summary>
        /// 最高价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? PriceMax { get; set; }
        /// <summary>
        /// 团购价格
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? PriceGroup { get; set; }
        /// <summary>
        /// 产品简介
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Detail { get; set; }
        /// <summary>
        /// 详细说明
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string PrContent { get; set; }
        /// <summary>
        /// 总库存数量（假）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? PrStockCount { get; set; }
        /// <summary>
        /// 总销售数据（假）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? PrSaleCount { get; set; }
        /// <summary>
        /// 库存（真）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? StockCount { get; set; }
        /// <summary>
        /// 销量（真）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? SaleCount { get; set; }
        /// <summary>
        /// 上线时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? OnlineTime { get; set; }
        /// <summary>
        /// 1上线，0下线
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsOnline { get; set; }
        /// <summary>
        /// 删除时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? DeleteTime { get; set; }
        /// <summary>
        /// 1删除，0默认
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsDelete { get; set; }
        /// <summary>
        /// 最后一次修改时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 锁版本号
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 是否热门
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsHot { get; set; }
        /// <summary>
        /// 是否限量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsLimit { get; set; }
        /// <summary>
        /// 是否收取邮费1是
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsEms { get; set; }
        /// <summary>
        /// 邮费
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? EmsAmount { get; set; }
        /// <summary>
        /// 包邮地区
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string EmsAddr { get; set; }
        /// <summary>
        /// 优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CoCode { get; set; }
        /// <summary>
        /// 优惠券
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string CouponJson { get; set; }
        /// <summary>
        /// 首页类别CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PhtCode { get; set; }
        /// <summary>
        /// 首页类别NAME
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string PhtName { get; set; }
        /// <summary>
        /// 供应商
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SuCode { get; set; }
        /// <summary>
        /// 产品分销金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? SalesAmount { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_PRODUCT GetEntity()
		{
			return new T_PRODUCT()
			{
				Id = this.Id,
				PtCode = this.PtCode,
				PtName = this.PtName,
				Params = this.Params,
				PrCode = this.PrCode,
				Name = this.Name,
				Images = this.Images,
				Sort = this.Sort,
				PrGroup = this.PrGroup,
				OnTimer = this.OnTimer,
				Deadline = this.Deadline,
				Tags = this.Tags,
				Thumbnail = this.Thumbnail,
				PriceMin = this.PriceMin,
				PriceMax = this.PriceMax,
				PriceGroup = this.PriceGroup,
				Detail = this.Detail,
				PrContent = this.PrContent,
				PrStockCount = this.PrStockCount,
				PrSaleCount = this.PrSaleCount,
				StockCount = this.StockCount,
				SaleCount = this.SaleCount,
				OnlineTime = this.OnlineTime,
				IsOnline = this.IsOnline,
				DeleteTime = this.DeleteTime,
				IsDelete = this.IsDelete,
				UpdateTime = this.UpdateTime,
				CreateTime = this.CreateTime,
				Version = this.Version,
				IsHot = this.IsHot,
				IsLimit = this.IsLimit,
				IsEms = this.IsEms,
				EmsAmount = this.EmsAmount,
				EmsAddr = this.EmsAddr,
				CoCode = this.CoCode,
				CouponJson = this.CouponJson,
				PhtCode = this.PhtCode,
				PhtName = this.PhtName,
				SuCode = this.SuCode,
				SalesAmount = this.SalesAmount,
 
			};
		}
	}
}

