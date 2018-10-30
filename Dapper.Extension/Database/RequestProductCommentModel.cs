using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 产品评论BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestProductCommentModel : RequstModel
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
        public string PcCode { get; set; }
        /// <summary>
        /// 订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SoCode { get; set; }
        /// <summary>
        /// 产品CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PrCode { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Images { get; set; }
        /// <summary>
        /// 星级
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? PcLevel { get; set; }
        /// <summary>
        /// 评论内容
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string PcContent { get; set; }
        /// <summary>
        /// 用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
        /// <summary>
        /// 头像
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_PRODUCT_COMMENT GetEntity()
		{
			return new T_PRODUCT_COMMENT()
			{
				Id = this.Id,
				PcCode = this.PcCode,
				SoCode = this.SoCode,
				PrCode = this.PrCode,
				Images = this.Images,
				PcLevel = this.PcLevel,
				PcContent = this.PcContent,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

