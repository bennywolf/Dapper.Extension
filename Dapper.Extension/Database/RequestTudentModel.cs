using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 学生表BASE TABLE
	/// 更新时间：2018-10-29 12:01:24
    /// </summary>
	public class RequestTudentModel : RequstModel
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
        public string CrCode { get; set; }
        /// <summary>
        /// 姓名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Age { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public STUDENT GetEntity()
		{
			return new STUDENT()
			{
				Id = this.Id,
				CrCode = this.CrCode,
				Name = this.Name,
				Age = this.Age,
 
			};
		}
	}
}

