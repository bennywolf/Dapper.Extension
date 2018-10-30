using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 商品团购开放设置BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestProductOpenModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string ProCode { get; set; }
        /// <summary>
        /// 商品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PrCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PxCode { get; set; }
        /// <summary>
        /// 是否完全开放
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsOpen { get; set; }
        /// <summary>
        /// 开放时间
        /// Type:date IsNull:YES Default:null
        /// </summary>
        public DateTime? OpenTime { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_PRODUCT_OPEN GetEntity()
		{
			return new T_PRODUCT_OPEN()
			{
				Id = this.Id,
				ProCode = this.ProCode,
				PrCode = this.PrCode,
				PxCode = this.PxCode,
				IsOpen = this.IsOpen,
				OpenTime = this.OpenTime,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

