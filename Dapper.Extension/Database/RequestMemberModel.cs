using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// BASE TABLE
	/// 更新时间：2018-10-27 21:53:48
    /// </summary>
	public class RequestMemberModel : RequstModel
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
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MeAge { get; set; }
        /// <summary>
        /// 
        /// Type:decimal(10,0) IsNull:YES Default:null
        /// </summary>
        public decimal? Balance { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_MEMBER GetEntity()
		{
			return new T_MEMBER()
			{
				Id = this.Id,
				MeCode = this.MeCode,
				MeAge = this.MeAge,
				Balance = this.Balance,
				Comment = this.Comment,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

