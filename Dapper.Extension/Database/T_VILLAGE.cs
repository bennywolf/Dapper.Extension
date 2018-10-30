using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 小区表BASE TABLE
	/// 更新时间：2018-10-30 17:21:11
    /// </summary>
    [Table("t_village")]
	public class T_VILLAGE
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:0
        /// </summary>
        [Column("ID",false)]
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("VI_CODE",false)]
        public string ViCode { get; set; }
        /// <summary>
        /// 名称
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("NAME",false)]
        public string Name { get; set; }
        /// <summary>
        /// 详细地址
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("ADDRESS",false)]
        public string Address { get; set; }
        /// <summary>
        /// 精度
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("POINT_X",false)]
        public string PointX { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("POINT_Y",false)]
        public string PointY { get; set; }
        /// <summary>
        /// 省
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("PROVI",false)]
        public string Provi { get; set; }
        /// <summary>
        /// 市
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        [Column("CITY",false)]
        public string City { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        [Column("AREA",false)]
        public string Area { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        [Column("CREATE_TIME",false)]
        public DateTime? CreateTime { get; set; }
   
	}
}

