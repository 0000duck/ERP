using System;
namespace ERP.Model
{
	/// <summary>
	/// Records:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Records
	{
		public Records()
		{}
		#region Model
		private int _rid;
		private int? _rmcode;
		private string _rmname;
		private int? _rquantity;
		private int? _rtype;
		private string _rhander;
		private DateTime? _rtime;
		/// <summary>
		/// 
		/// </summary>
		public int RID
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RMCode
		{
			set{ _rmcode=value;}
			get{return _rmcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RMName
		{
			set{ _rmname=value;}
			get{return _rmname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RQuantity
		{
			set{ _rquantity=value;}
			get{return _rquantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RType
		{
			set{ _rtype=value;}
			get{return _rtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RHander
		{
			set{ _rhander=value;}
			get{return _rhander;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RTime
		{
			set{ _rtime=value;}
			get{return _rtime;}
		}
		#endregion Model

	}
}

