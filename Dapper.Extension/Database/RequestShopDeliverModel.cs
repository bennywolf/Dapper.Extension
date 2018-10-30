using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 购物自提BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestShopDeliverModel : RequstModel
	{
        /// <summary>
        /// 自增ID
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SdCode { get; set; }
        /// <summary>
        /// 自提点名称
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        public string AddrDesc { get; set; }
        /// <summary>
        /// 自提点详细地址
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string AddrDetail { get; set; }
        /// <summary>
        /// 自提点联系人姓名
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        public string UsName { get; set; }
        /// <summary>
        /// 自提点联系人手机号
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        public string UsMobile { get; set; }
        /// <summary>
        /// 自提点经度
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string LocX { get; set; }
        /// <summary>
        /// 自提点纬度
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string LocY { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Sort { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SHOP_DELIVER GetEntity()
		{
			return new T_SHOP_DELIVER()
			{
				Id = this.Id,
				SdCode = this.SdCode,
				AddrDesc = this.AddrDesc,
				AddrDetail = this.AddrDetail,
				UsName = this.UsName,
				UsMobile = this.UsMobile,
				LocX = this.LocX,
				LocY = this.LocY,
				CreateTime = this.CreateTime,
				Sort = this.Sort,
 
			};
		}
	}
}

