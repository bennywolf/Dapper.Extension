using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 标签表BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_label")]
	public class T_LABEL
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("LB_CODE",false)]
        public string LbCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("LB_NAME",false)]
        public string LbName { get; set; }
        /// <summary>
        /// 排序字段
        /// Type:int(11) IsNull:YES Default:0
        /// </summary>
        [Column("LB_SORT",false)]
        public int? LbSort { get; set; }
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
        /// <summary>
        /// 数据权限（0,1,2,3,4查看，新增和修改，删除，锁定）
        /// Type:varchar(50) IsNull:YES Default:
        /// </summary>
        [Column("LB_POWER",false)]
        public string LbPower { get; set; }
   
	}
}

