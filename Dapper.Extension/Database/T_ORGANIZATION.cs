using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 组织架构（公司，部门）BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_organization")]
	public class T_ORGANIZATION
	{
        /// <summary>
        /// ID
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("OG_CODE",false)]
        public string OgCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("OG_NAME",false)]
        public string OgName { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("LEFT_NUM",false)]
        public int? LeftNum { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("RIGHT_NUM",false)]
        public int? RightNum { get; set; }
        /// <summary>
        /// 排序字段
        /// Type:int(11) IsNull:YES Default:0
        /// </summary>
        [Column("OG_SORT",false)]
        public int? OgSort { get; set; }
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

