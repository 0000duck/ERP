using System;
namespace ERP.Model
{
	/// <summary>
	/// Warehouses:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Warehouses
	{
		public Warehouses()
		{}
		#region Model
		private int _wid;
		private string _wname;
		private decimal? _warea;
		private string _waddress;
		private string _wdescribe;
		/// <summary>
		/// 
		/// </summary>
		public int WID
		{
			set{ _wid=value;}
			get{return _wid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WName
		{
			set{ _wname=value;}
			get{return _wname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WArea
		{
			set{ _warea=value;}
			get{return _warea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WAddress
		{
			set{ _waddress=value;}
			get{return _waddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WDescribe
		{
			set{ _wdescribe=value;}
			get{return _wdescribe;}
		}
		#endregion Model

	}
}

