using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// VIEWVIEW
	/// 更新时间：2018-10-29 12:01:24
    /// </summary>
	public class RequestStudentModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        public int? Id { get; set; }
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
		public VSTUDENT GetEntity()
		{
			return new VSTUDENT()
			{
				Id = this.Id,
				Name = this.Name,
				Age = this.Age,
 
			};
		}
	}
}

