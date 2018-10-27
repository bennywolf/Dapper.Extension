using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// BASE TABLE
	/// 更新时间：2018-10-27 13:10:29
    /// </summary>
    [Table("t_member")]
	public class T_MEMBER
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
        [Column("ME_CODE",false)]
        public string MeCode { get; set; }
        /// <summary>
        /// 年龄
        /// Type:int(11) IsNull:YES Default:0
        /// </summary>
        [Column("ME_AGE",false)]
        public int? MeAge { get; set; }
        /// <summary>
        /// 余额
        /// Type:decimal(18,2) IsNull:YES Default:0.00
        /// </summary>
        [Column("BALANCE",false)]
        public decimal? Balance { get; set; }
        /// <summary>
        /// 
        /// Type:text IsNull:YES Default:null
        /// </summary>
        [Column("COMMENT",false)]
        public string Comment { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

