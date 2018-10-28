using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// BASE TABLE
	/// 更新时间：2018-10-28 14:58:17
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
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Age { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Remark { get; set; }
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
				Age = this.Age,
				Name = this.Name,
				Remark = this.Remark,
				CreateTime = this.CreateTime,
 
			};
		}
	}
}

