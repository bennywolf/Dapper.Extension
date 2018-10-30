using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 标签关联表BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_labelrelation")]
	public class T_LABELRELATION
	{
        /// <summary>
        /// ID
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 标签CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("LB_CODE",false)]
        public string LbCode { get; set; }
        /// <summary>
        /// 关联CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("RE_CODE",false)]
        public string ReCode { get; set; }
        /// <summary>
        /// 关联类型(0代表组织架构，1代表个人账号)
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("RE_TYPE",false)]
        public int? ReType { get; set; }
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
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_USER",false)]
        public string CreateUser { get; set; }
        /// <summary>
        /// 修改时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("UPDATE_USER",false)]
        public DateTime? UpdateUser { get; set; }
   
	}
}

