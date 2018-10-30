using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 滚动消息BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestScrollMessageModel : RequstModel
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
        public string MeCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SmCode { get; set; }
        /// <summary>
        /// 分组
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? SmGroup { get; set; }
        /// <summary>
        /// 是否圈子
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsCircle { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SmContent { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SCROLL_MESSAGE GetEntity()
		{
			return new T_SCROLL_MESSAGE()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				MeHeadPhoto = this.MeHeadPhoto,
				SmCode = this.SmCode,
				SmGroup = this.SmGroup,
				IsCircle = this.IsCircle,
				SmContent = this.SmContent,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

