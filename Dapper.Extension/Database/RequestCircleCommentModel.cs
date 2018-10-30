using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 圈子评论BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestCircleCommentModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 圈子
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CiCode { get; set; }
        /// <summary>
        /// 圈子评论
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CcCode { get; set; }
        /// <summary>
        /// 评论的父评论CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PccCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string PmeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string PmeHeadPhoto { get; set; }
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
        /// 正文
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        public string CreateTimestamp { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_CIRCLE_COMMENT GetEntity()
		{
			return new T_CIRCLE_COMMENT()
			{
				Id = this.Id,
				CiCode = this.CiCode,
				CcCode = this.CcCode,
				PccCode = this.PccCode,
				PmeName = this.PmeName,
				PmeHeadPhoto = this.PmeHeadPhoto,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				Content = this.Content,
				CreateTime = this.CreateTime,
				CreateTimestamp = this.CreateTimestamp,
 
			};
		}
	}
}

