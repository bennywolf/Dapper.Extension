using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// bannerBASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_config_banner")]
	public class T_CONFIG_BANNER
	{
        /// <summary>
        /// ID
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// code
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CB_CODE",false)]
        public string CbCode { get; set; }
        /// <summary>
        /// 图片
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("IMG",false)]
        public string Img { get; set; }
        /// <summary>
        /// url
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("URL",false)]
        public string Url { get; set; }
        /// <summary>
        /// 是否上线
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("IS_ONLINE",false)]
        public int? IsOnline { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIMESTEMP",false)]
        public int? CreateTimestemp { get; set; }
        /// <summary>
        /// 0首页顶部banner,1社区bannner,2首页广告banner
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("CB_GROUP",false)]
        public int? CbGroup { get; set; }
        /// <summary>
        /// 排序
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("SORT",false)]
        public int? Sort { get; set; }
   
	}
}

