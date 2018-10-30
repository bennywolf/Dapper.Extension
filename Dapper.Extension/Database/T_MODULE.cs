using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 权限表BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_module")]
	public class T_MODULE
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 菜单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MO_CODE",false)]
        public string MoCode { get; set; }
        /// <summary>
        /// 菜单名称
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MO_NAME",false)]
        public string MoName { get; set; }
        /// <summary>
        /// 菜单URL
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("MO_URL",false)]
        public string MoUrl { get; set; }
        /// <summary>
        /// 模块状态（0，开启，1，关闭）
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("MO_STATE",false)]
        public int? MoState { get; set; }
        /// <summary>
        /// 描述
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("MO_DESCRIBE",false)]
        public string MoDescribe { get; set; }
        /// <summary>
        /// 父亲节点CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("MO_FACODE",false)]
        public string MoFacode { get; set; }
        /// <summary>
        /// 是否是叶子节点
        /// Type:int(11) IsNull:YES Default:0
        /// </summary>
        [Column("IS_LEAF",false)]
        public int? IsLeaf { get; set; }
        /// <summary>
        /// 排序字段
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("MO_SORT",false)]
        public int? MoSort { get; set; }
        /// <summary>
        /// 菜单图标
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("MO_LOGO",false)]
        public string MoLogo { get; set; }
        /// <summary>
        /// 菜单类型（0普通，1CMS，2系统权限）
        /// Type:int(11) IsNull:YES Default:0
        /// </summary>
        [Column("MO_TYPE",false)]
        public int? MoType { get; set; }
        /// <summary>
        /// 创建时间戳
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME_STAMP",false)]
        public int? CreateTimeStamp { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改时间戳
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        [Column("UPDATE_TIME_STAMP",false)]
        public int? UpdateTimeStamp { get; set; }
        /// <summary>
        /// 修改时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("UPDATE_TIME",false)]
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 创建人
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_USER",false)]
        public string CreateUser { get; set; }
        /// <summary>
        /// 修改时间
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("UPDATE_USER",false)]
        public string UpdateUser { get; set; }
   
	}
}

