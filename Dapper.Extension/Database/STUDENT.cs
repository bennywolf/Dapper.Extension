using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// BASE TABLE
	/// 更新时间：2018-11-14 11:20:16
    /// </summary>
    [Table("student")]
	public class STUDENT : IModel
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
        [Column("NAME",false)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("AGE",false)]
        public int? Age { get; set; }
        /// <summary>
        /// 
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("MIN_AGE",false)]
        public int? MinAge { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(100) IsNull:YES Default:null
        /// </summary>
        [Column("VERSION",false)]
        public string Version { get; set; }
   
	}
}

