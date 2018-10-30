using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 圈子BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestCircleModel : RequstModel
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
        public string CiCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 标题
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 缩略图
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Thumbnail { get; set; }
        /// <summary>
        /// 正文
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 图片
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Images { get; set; }
        /// <summary>
        /// 浏览量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? BroCount { get; set; }
        /// <summary>
        /// 点赞量
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? LikCount { get; set; }
        /// <summary>
        /// 评论次数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? ComCount { get; set; }
        /// <summary>
        /// 宝贝,产品
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string PrCodeList { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string Location { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_CIRCLE GetEntity()
		{
			return new T_CIRCLE()
			{
				Id = this.Id,
				CiCode = this.CiCode,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				Title = this.Title,
				Thumbnail = this.Thumbnail,
				Content = this.Content,
				Images = this.Images,
				BroCount = this.BroCount,
				LikCount = this.LikCount,
				ComCount = this.ComCount,
				PrCodeList = this.PrCodeList,
				CreateTime = this.CreateTime,
				Location = this.Location,
 
			};
		}
	}
}

