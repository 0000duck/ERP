using System;
namespace ERP.Model
{
	/// <summary>
	/// Users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Users
	{
		public Users()
		{}
		#region Model
		private int _uid;
		private string _uname;
		private string _upwd;
		private string _ugender;
		private string _ulevel;
		private string _uphone;
		private string _uemail;
		/// <summary>
		/// 
		/// </summary>
		public int UID
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UName
		{
			set{ _uname=value;}
			get{return _uname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPwd
		{
			set{ _upwd=value;}
			get{return _upwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UGender
		{
			set{ _ugender=value;}
			get{return _ugender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ULevel
		{
			set{ _ulevel=value;}
			get{return _ulevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPhone
		{
			set{ _uphone=value;}
			get{return _uphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UEmail
		{
			set{ _uemail=value;}
			get{return _uemail;}
		}
		#endregion Model

	}
}

