using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 组织架构（公司，部门）BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestOrganizationModel : RequstModel
	{
        /// <summary>
        /// ID
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string OgCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        public string OgName { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? LeftNum { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? RightNum { get; set; }
        /// <summary>
        /// 排序字段
        /// Type:int(11) IsNull:YES Default:0
        /// </summary>
        public int? OgSort { get; set; }
        /// <summary>
        /// 创建时间戳
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        public int? CreateTimeStamp { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改时间戳
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        public int? UpdateTimeStamp { get; set; }
        /// <summary>
        /// 修改时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 创建人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string CreateUser { get; set; }
        /// <summary>
        /// 修改时间
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string UpdateUser { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_ORGANIZATION GetEntity()
		{
			return new T_ORGANIZATION()
			{
				Id = this.Id,
				OgCode = this.OgCode,
				OgName = this.OgName,
				LeftNum = this.LeftNum,
				RightNum = this.RightNum,
				OgSort = this.OgSort,
				CreateTimeStamp = this.CreateTimeStamp,
				CreateTime = this.CreateTime,
				UpdateTimeStamp = this.UpdateTimeStamp,
				UpdateTime = this.UpdateTime,
				CreateUser = this.CreateUser,
				UpdateUser = this.UpdateUser,
 
			};
		}
	}
}

