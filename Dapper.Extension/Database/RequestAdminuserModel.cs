using System;
using Dapper.Extension;

namespace Dapper.Extension.Model
{
    /// <summary>
    /// 后台用户BASE TABLE
	/// 更新时间：2018-10-30 17:20:52
    /// </summary>
	public class RequestAdminuserModel : RequstModel
	{
        /// <summary>
        /// ID
        /// Type:int(11) IsNull:NO Default:null
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 后台用户CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string AuCode { get; set; }
        /// <summary>
        /// 后台用户名称
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string AuName { get; set; }
        /// <summary>
        /// 组织架构CODE
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string OgCode { get; set; }
        /// <summary>
        /// 姓名全拼
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string AuNameLetter { get; set; }
        /// <summary>
        /// 拼音首字母
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string AuFirstLetter { get; set; }
        /// <summary>
        /// 描述
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string AuDescribe { get; set; }
        /// <summary>
        /// 管理员账号
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string AuAccount { get; set; }
        /// <summary>
        /// 职务
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string AuPost { get; set; }
        /// <summary>
        /// 手机号
        /// Type:varchar(11) IsNull:YES Default:null
        /// </summary>
        public string AuMobile { get; set; }
        /// <summary>
        /// 性别
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? AuSex { get; set; }
        /// <summary>
        /// 密码
        /// Type:varchar(50) IsNull:YES Default:null
        /// </summary>
        public string AuPassword { get; set; }
        /// <summary>
        /// 是否有效
        /// Type:int(11) IsNull:YES Default:1
        /// </summary>
        public int? AuIsused { get; set; }
        /// <summary>
        /// 排序字段
        /// Type:int(11) IsNull:YES Default:null
        /// </summary>
        public int? AuSort { get; set; }
        /// <summary>
        /// 创建时间戳
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        public int? CreateTimeStamp { get; set; }
        /// <summary>
        /// 创建时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改时间戳
        /// Type:bigint(20) IsNull:YES Default:null
        /// </summary>
        public int? UpdateTimeStamp { get; set; }
        /// <summary>
        /// 修改时间
        /// Type:datetime IsNull:YES Default:null
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 创建人
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        public string CreateUser { get; set; }
        /// <summary>
        /// 修改时间
        /// Type:varchar(255) IsNull:YES Default:null
        /// </summary>
        public string UpdateUser { get; set; }
        /// <summary>
        /// 数据权限（0自己，1单位，2全部，3自定义）
        /// Type:int(11) IsNull:YES Default:0
        /// </summary>
        public int? AmDatapower { get; set; }
        /// <summary>
        /// 自定义数据权限
        /// Type:text IsNull:YES Default:null
        /// </summary>
        public string AmOwnpower { get; set; }
   
		/// <summary>
        /// 将Mvc请求参数转换成Entity对象
        /// </summary>
        /// <returns></returns>
		public T_ADMINUSER GetEntity()
		{
			return new T_ADMINUSER()
			{
				Id = this.Id,
				AuCode = this.AuCode,
				AuName = this.AuName,
				OgCode = this.OgCode,
				AuNameLetter = this.AuNameLetter,
				AuFirstLetter = this.AuFirstLetter,
				AuDescribe = this.AuDescribe,
				AuAccount = this.AuAccount,
				AuPost = this.AuPost,
				AuMobile = this.AuMobile,
				AuSex = this.AuSex,
				AuPassword = this.AuPassword,
				AuIsused = this.AuIsused,
				AuSort = this.AuSort,
				CreateTimeStamp = this.CreateTimeStamp,
				CreateTime = this.CreateTime,
				UpdateTimeStamp = this.UpdateTimeStamp,
				UpdateTime = this.UpdateTime,
				CreateUser = this.CreateUser,
				UpdateUser = this.UpdateUser,
				AmDatapower = this.AmDatapower,
				AmOwnpower = this.AmOwnpower,
 
			};
		}
	}
}

