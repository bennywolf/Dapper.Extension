using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 权限表BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestModuleModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 菜单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MoCode { get; set; }
        /// <summary>
        /// 菜单名称
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MoName { get; set; }
        /// <summary>
        /// 菜单URL
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        public string MoUrl { get; set; }
        /// <summary>
        /// 模块状态（0，开启，1，关闭）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MoState { get; set; }
        /// <summary>
        /// 描述
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string MoDescribe { get; set; }
        /// <summary>
        /// 父亲节点CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MoFacode { get; set; }
        /// <summary>
        /// 是否是叶子节点
        /// Type:int(11) IsNull:YES Default:0
        /// </summary>
        public int? IsLeaf { get; set; }
        /// <summary>
        /// 排序字段
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? MoSort { get; set; }
        /// <summary>
        /// 菜单图标
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        public string MoLogo { get; set; }
        /// <summary>
        /// 菜单类型（0普通，1CMS，2系统权限）
        /// Type:int(11) IsNull:YES Default:0
        /// </summary>
        public int? MoType { get; set; }
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
		public T_MODULE GetEntity()
		{
			return new T_MODULE()
			{
				Id = this.Id,
				MoCode = this.MoCode,
				MoName = this.MoName,
				MoUrl = this.MoUrl,
				MoState = this.MoState,
				MoDescribe = this.MoDescribe,
				MoFacode = this.MoFacode,
				IsLeaf = this.IsLeaf,
				MoSort = this.MoSort,
				MoLogo = this.MoLogo,
				MoType = this.MoType,
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

