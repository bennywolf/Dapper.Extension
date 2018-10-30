using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 销售明细BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestSalesDetailModel : RequstModel
	{
        /// <summary>
        /// 
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SdCode { get; set; }
        /// <summary>
        /// 用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string MeCode { get; set; }
        /// <summary>
        /// 用户姓名
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string MeHeadPhoto { get; set; }
        /// <summary>
        /// 获利金额
        /// Type:decimal(18,2) IsNull:YES Default:null
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 子用户
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SubCode { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SubName { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string SubHeadPhoto { get; set; }
        /// <summary>
        /// 
        /// Type:varchar(225) IsNull:YES Default:null
        /// </summary>
        public string Descript { get; set; }
        /// <summary>
        /// 
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 级别
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? SdLevel { get; set; }
        /// <summary>
        /// 审核状态
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 订单CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string SoCode { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_SALES_DETAIL GetEntity()
		{
			return new T_SALES_DETAIL()
			{
				Id = this.Id,
				SdCode = this.SdCode,
				MeCode = this.MeCode,
				MeName = this.MeName,
				MeHeadPhoto = this.MeHeadPhoto,
				Amount = this.Amount,
				SubCode = this.SubCode,
				SubName = this.SubName,
				SubHeadPhoto = this.SubHeadPhoto,
				Descript = this.Descript,
				CreateTime = this.CreateTime,
				SdLevel = this.SdLevel,
				Status = this.Status,
				SoCode = this.SoCode,
 
			};
		}
	}
}

