using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 供应商BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_supplier")]
	public class T_SUPPLIER
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// 供应商CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("SU_CODE",false)]
        public string SuCode { get; set; }
        /// <summary>
        /// 名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SU_NAME",false)]
        public string SuName { get; set; }
        /// <summary>
        /// 地址
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SU_ADDRESS",false)]
        public string SuAddress { get; set; }
        /// <summary>
        /// 联系人
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SU_LINKMEN",false)]
        public string SuLinkmen { get; set; }
        /// <summary>
        /// 描述
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("SU_DESC",false)]
        public string SuDesc { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

