using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 奖品BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestPrizeModel : RequstModel
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
        public string PrCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 开奖时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? OnTime { get; set; }
        /// <summary>
        /// 正文
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 相关产品
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string Product { get; set; }
        /// <summary>
        /// 0未开奖
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 参与人数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MeCount { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 缩略图
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Thumbnail { get; set; }
        /// <summary>
        /// 图文介绍
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Images { get; set; }
        /// <summary>
        /// 券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CoCode { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_PRIZE GetEntity()
		{
			return new T_PRIZE()
			{
				Id = this.Id,
				PrCode = this.PrCode,
				Title = this.Title,
				OnTime = this.OnTime,
				Content = this.Content,
				Product = this.Product,
				Status = this.Status,
				MeCount = this.MeCount,
				CreateTime = this.CreateTime,
				Thumbnail = this.Thumbnail,
				Images = this.Images,
				CoCode = this.CoCode,
 
			};
		}
	}
}

