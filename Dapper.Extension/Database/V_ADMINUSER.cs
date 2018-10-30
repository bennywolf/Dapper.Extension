using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// VIEWVIEW
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("v_adminuser")]
	public class V_ADMINUSER
	{
        /// <summary>
        /// ID
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        [Column("ID",false)]
        public int? Id { get; set; }
        /// <summary>
        /// 后台用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("AU_CODE",false)]
        public string AuCode { get; set; }
        /// <summary>
        /// 后台用户名称
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("AU_NAME",false)]
        public string AuName { get; set; }
        /// <summary>
        /// 组织架构CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("OG_CODE",false)]
        public string OgCode { get; set; }
        /// <summary>
        /// 姓名全拼
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("AU_NAME_LETTER",false)]
        public string AuNameLetter { get; set; }
        /// <summary>
        /// 拼音首字母
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("AU_FIRST_LETTER",false)]
        public string AuFirstLetter { get; set; }
        /// <summary>
        /// 描述
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("AU_DESCRIBE",false)]
        public string AuDescribe { get; set; }
        /// <summary>
        /// 管理员账号
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("AU_ACCOUNT",false)]
        public string AuAccount { get; set; }
        /// <summary>
        /// 职务
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("AU_POST",false)]
        public string AuPost { get; set; }
        /// <summary>
        /// 手机号
        /// Type:varchar(11) IsNull:YES Default:null
        /// </summary>
        [Column("AU_MOBILE",false)]
        public string AuMobile { get; set; }
        /// <summary>
        /// 性别
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("AU_SEX",false)]
        public int? AuSex { get; set; }
        /// <summary>
        /// 密码
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("AU_PASSWORD",false)]
        public string AuPassword { get; set; }
        /// <summary>
        /// 是否有效
        /// Type:int(11) IsNull:YES Default:1
        /// </summary>
        [Column("AU_ISUSED",false)]
        public int? AuIsused { get; set; }
        /// <summary>
        /// 创建时间戳
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME_STAMP",false)]
        public int? CreateTimeStamp { get; set; }
        /// <summary>
        /// 排序字段
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("AU_SORT",false)]
        public int? AuSort { get; set; }
        /// <summary>
        /// 修改时间戳
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        [Column("UPDATE_TIME_STAMP",false)]
        public int? UpdateTimeStamp { get; set; }
        /// <summary>
        /// 创建人
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_USER",false)]
        public string CreateUser { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        [Column("OG_NAME",false)]
        public string OgName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("ORGANIZATION_NAME",false)]
        public string OrganizationName { get; set; }
   
	}
}

