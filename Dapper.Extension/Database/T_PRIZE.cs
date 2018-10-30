using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 奖品BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_prize")]
	public class T_PRIZE
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
        [Column("PR_CODE",false)]
        public string PrCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("TITLE",false)]
        public string Title { get; set; }
        /// <summary>
        /// 开奖时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("ON_TIME",false)]
        public DateTime? OnTime { get; set; }
        /// <summary>
        /// 正文
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("CONTENT",false)]
        public string Content { get; set; }
        /// <summary>
        /// 相关产品
        /// Type:varchar(500) IsNull:YES Default:null
        /// </summary>
        [Column("PRODUCT",false)]
        public string Product { get; set; }
        /// <summary>
        /// 0未开奖
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("STATUS",false)]
        public int? Status { get; set; }
        /// <summary>
        /// 参与人数
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("ME_COUNT",false)]
        public int? MeCount { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 缩略图
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("THUMBNAIL",false)]
        public string Thumbnail { get; set; }
        /// <summary>
        /// 图文介绍
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("IMAGES",false)]
        public string Images { get; set; }
        /// <summary>
        /// 券CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CO_CODE",false)]
        public string CoCode { get; set; }
   
	}
}

