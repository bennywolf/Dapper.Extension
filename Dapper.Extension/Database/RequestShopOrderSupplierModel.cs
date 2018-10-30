using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 供应商订单BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestShopOrderSupplierModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 供应商订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SosCode { get; set; }
        /// <summary>
        /// 供应商
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SuCode { get; set; }
        /// <summary>
        /// 供应商名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SuName { get; set; }
        /// <summary>
        /// 用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 供应商联系人
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SuLinkmen { get; set; }
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
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MaCity { get; set; }
        /// <summary>
        /// 小区
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MaArea { get; set; }
        /// <summary>
        /// 详情位置
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MaDetail { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string AddressJson { get; set; }
        /// <summary>
        /// 订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SoCode { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 发货时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? DeliverTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? ConfirmTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 发货方式（0=快递，1=自提）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? DeliverType { get; set; }
        /// <summary>
        /// 自提点CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SdCode { get; set; }
        /// <summary>
        /// 自提详情
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string DeliverJson { get; set; }
        /// <summary>
        /// 留言
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 商户订单号
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string TradeNo { get; set; }
        /// <summary>
        /// 邮费
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? EmsMoney { get; set; }
        /// <summary>
        /// 商品总金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? PrAmount { get; set; }
        /// <summary>
        /// 订单总金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string PrNames { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string EmsName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string EmsNo { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PxCode { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SHOP_ORDER_SUPPLIER GetEntity()
		{
			return new T_SHOP_ORDER_SUPPLIER()
			{
				Id = this.Id,
				SosCode = this.SosCode,
				SuCode = this.SuCode,
				SuName = this.SuName,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				SuLinkmen = this.SuLinkmen,
				MaCode = this.MaCode,
				MaName = this.MaName,
				MaMobile = this.MaMobile,
				MaProvi = this.MaProvi,
				MaCity = this.MaCity,
				MaArea = this.MaArea,
				MaDetail = this.MaDetail,
				AddressJson = this.AddressJson,
				SoCode = this.SoCode,
				Status = this.Status,
				DeliverTime = this.DeliverTime,
				ConfirmTime = this.ConfirmTime,
				CreateTime = this.CreateTime,
				DeliverType = this.DeliverType,
				SdCode = this.SdCode,
				DeliverJson = this.DeliverJson,
				Remark = this.Remark,
				TradeNo = this.TradeNo,
				EmsMoney = this.EmsMoney,
				PrAmount = this.PrAmount,
				Amount = this.Amount,
				PrNames = this.PrNames,
				EmsName = this.EmsName,
				EmsNo = this.EmsNo,
				PxCode = this.PxCode,
 
			};
		}
	}
}

