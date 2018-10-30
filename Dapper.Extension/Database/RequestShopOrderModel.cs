using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 购物订单BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestShopOrderModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 商品名称
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string PrNames { get; set; }
        /// <summary>
        /// 用户
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 用户名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
        /// <summary>
        /// 用户头像
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 收货地址CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MaCode { get; set; }
        /// <summary>
        /// 收货人
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MaName { get; set; }
        /// <summary>
        /// 收货人号码
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MaMobile { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MaProvi { get; set; }
        /// <summary>
        /// 市
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MaCity { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MaArea { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MaDetail { get; set; }
        /// <summary>
        /// 用户收货地址
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string AddressJson { get; set; }
        /// <summary>
        /// 商户订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SoCode { get; set; }
        /// <summary>
        /// 商户单号
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string TradeNo { get; set; }
        /// <summary>
        /// 支付单号
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string TransactionId { get; set; }
        /// <summary>
        /// 支付时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? PaymentTime { get; set; }
        /// <summary>
        /// 支付状态0,未付款，1已付款
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? PaymentStatus { get; set; }
        /// <summary>
        /// 结算方式：0余额全款,1余额及微信,2微信全款
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? PaymentType { get; set; }
        /// <summary>
        /// 微信退款ID
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string RefundId { get; set; }
        /// <summary>
        /// 退款金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? RefundFee { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? RefundTime { get; set; }
        /// <summary>
        /// 用户留言
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string McCode { get; set; }
        /// <summary>
        /// 0未付款,1已付款,2待发货,3已发货,4确认收货
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 分享优惠金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? ShareAmount { get; set; }
        /// <summary>
        /// 余额抵押
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? BalAmount { get; set; }
        /// <summary>
        /// 优惠金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? DisAmount { get; set; }
        /// <summary>
        /// 微信抵押金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? WxAmount { get; set; }
        /// <summary>
        /// 应付金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? ShoAmount { get; set; }
        /// <summary>
        /// 订单总价
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 快递名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string EmsName { get; set; }
        /// <summary>
        /// 快递号码
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string EmsNo { get; set; }
        /// <summary>
        /// 邮费
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? EmsMoney { get; set; }
        /// <summary>
        /// 发货时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? DeliverTime { get; set; }
        /// <summary>
        /// 创建下单时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 确认收货时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? ConfirmTime { get; set; }
        /// <summary>
        /// 发货方式（0=快递，1=自提）
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        public int? DeliverType { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SdCode { get; set; }
        /// <summary>
        /// 自提详情
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string DeliverJson { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CancleTime { get; set; }
        /// <summary>
        /// 优惠券总金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Packet { get; set; }
        /// <summary>
        /// 评价时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CommentTime { get; set; }
        /// <summary>
        /// 是否售后
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsAfter { get; set; }
        /// <summary>
        /// 售后状态：0未处理，1处理中，2已解决
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? AfterStatus { get; set; }
        /// <summary>
        /// 是否分享
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsShare { get; set; }
        /// <summary>
        /// 团队CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PxCode { get; set; }
        /// <summary>
        /// 转化率
        /// Type:decimal(10,4) IsNull:YES Default:null
        /// </summary>
        public decimal? ConRate { get; set; }
        /// <summary>
        /// 团长分红
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? SalesAmount { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SHOP_ORDER GetEntity()
		{
			return new T_SHOP_ORDER()
			{
				Id = this.Id,
				PrNames = this.PrNames,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				MaCode = this.MaCode,
				MaName = this.MaName,
				MaMobile = this.MaMobile,
				MaProvi = this.MaProvi,
				MaCity = this.MaCity,
				MaArea = this.MaArea,
				MaDetail = this.MaDetail,
				AddressJson = this.AddressJson,
				SoCode = this.SoCode,
				TradeNo = this.TradeNo,
				TransactionId = this.TransactionId,
				PaymentTime = this.PaymentTime,
				PaymentStatus = this.PaymentStatus,
				PaymentType = this.PaymentType,
				RefundId = this.RefundId,
				RefundFee = this.RefundFee,
				RefundTime = this.RefundTime,
				Remark = this.Remark,
				McCode = this.McCode,
				Status = this.Status,
				ShareAmount = this.ShareAmount,
				BalAmount = this.BalAmount,
				DisAmount = this.DisAmount,
				WxAmount = this.WxAmount,
				ShoAmount = this.ShoAmount,
				Amount = this.Amount,
				EmsName = this.EmsName,
				EmsNo = this.EmsNo,
				EmsMoney = this.EmsMoney,
				DeliverTime = this.DeliverTime,
				CreateTime = this.CreateTime,
				ConfirmTime = this.ConfirmTime,
				DeliverType = this.DeliverType,
				SdCode = this.SdCode,
				DeliverJson = this.DeliverJson,
				CancleTime = this.CancleTime,
				Packet = this.Packet,
				CommentTime = this.CommentTime,
				IsAfter = this.IsAfter,
				AfterStatus = this.AfterStatus,
				IsShare = this.IsShare,
				PxCode = this.PxCode,
				ConRate = this.ConRate,
				SalesAmount = this.SalesAmount,
 
			};
		}
	}
}

