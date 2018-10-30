using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 标签关联表BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestLabelrelationModel : RequstModel
	{
        /// <summary>
        /// ID
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 标签CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string LbCode { get; set; }
        /// <summary>
        /// 关联CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string ReCode { get; set; }
        /// <summary>
        /// 关联类型(0代表组织架构，1代表个人账号)
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? ReType { get; set; }
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
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        public string CreateUser { get; set; }
        /// <summary>
        /// 修改时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? UpdateUser { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_LABELRELATION GetEntity()
		{
			return new T_LABELRELATION()
			{
				Id = this.Id,
				LbCode = this.LbCode,
				ReCode = this.ReCode,
				ReType = this.ReType,
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

