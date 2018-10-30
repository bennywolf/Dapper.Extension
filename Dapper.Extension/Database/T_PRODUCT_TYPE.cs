using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 产品分类BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_product_type")]
	public class T_PRODUCT_TYPE
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        [Column("ID",true)]
        public int? Id { get; set; }
        /// <summary>
        /// CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PT_CODE",false)]
        public string PtCode { get; set; }
        /// <summary>
        /// 类别名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("PT_NAME",false)]
        public string PtName { get; set; }
        /// <summary>
        /// 类别图标
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("PT_IMAGE",false)]
        public string PtImage { get; set; }
        /// <summary>
        /// 顺序
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        [Column("PT_SORT",false)]
        public int? PtSort { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

