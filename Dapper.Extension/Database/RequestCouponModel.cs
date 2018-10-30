using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户优惠券BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestCouponModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 优惠券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CoCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CoDesc { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string CoTitle { get; set; }
        /// <summary>
        /// 最低使用金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? LowAmout { get; set; }
        /// <summary>
        /// 优惠券金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? DisAmout { get; set; }
        /// <summary>
        /// 失效时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? ExpiryTime { get; set; }
        /// <summary>
        /// 最大发放数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MaxCount { get; set; }
        /// <summary>
        /// 已发放数量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? GetCount { get; set; }
        /// <summary>
        /// 0,新人专享,1普通优惠券
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? CoType { get; set; }
        /// <summary>
        /// 防止丢失更新版本
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PrCode { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_COUPON GetEntity()
		{
			return new T_COUPON()
			{
				Id = this.Id,
				CoCode = this.CoCode,
				CoDesc = this.CoDesc,
				CoTitle = this.CoTitle,
				LowAmout = this.LowAmout,
				DisAmout = this.DisAmout,
				ExpiryTime = this.ExpiryTime,
				MaxCount = this.MaxCount,
				GetCount = this.GetCount,
				CoType = this.CoType,
				Version = this.Version,
				CreateTime = this.CreateTime,
				PrCode = this.PrCode,
 
			};
		}
	}
}

