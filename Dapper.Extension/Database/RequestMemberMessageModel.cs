using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 用户消息BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestMemberMessageModel : RequstModel
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
        /// 0九仙号外,1系统消息,2交易消息,3客服消息
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MmGroup { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MmCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Page { get; set; }
        /// <summary>
        /// 是否已读
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? IsRead { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_MEMBER_MESSAGE GetEntity()
		{
			return new T_MEMBER_MESSAGE()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				MmGroup = this.MmGroup,
				MmCode = this.MmCode,
				Content = this.Content,
				CreateTime = this.CreateTime,
				Page = this.Page,
				IsRead = this.IsRead,
 
			};
		}
	}
}

