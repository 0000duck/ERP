using System;
namespace ERP.Model
{
	/// <summary>
	/// Materials:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Materials
	{
		public Materials()
		{}
		#region Model
		private int _mid;
		private int _mcode;
		private string _mname;
		private string _mmodel;
		private string _mmaterial;
		private string _mstandard;
		private string _munit;
		private int? _mnumber;
		private string _wname;
		/// <summary>
		/// 
		/// </summary>
		public int MID
		{
			set{ _mid=value;}
			get{return _mid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MCode
		{
			set{ _mcode=value;}
			get{return _mcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MName
		{
			set{ _mname=value;}
			get{return _mname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MModel
		{
			set{ _mmodel=value;}
			get{return _mmodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MMaterial
		{
			set{ _mmaterial=value;}
			get{return _mmaterial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MStandard
		{
			set{ _mstandard=value;}
			get{return _mstandard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MUnit
		{
			set{ _munit=value;}
			get{return _munit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MNumber
		{
			set{ _mnumber=value;}
			get{return _mnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WName
		{
			set{ _wname=value;}
			get{return _wname;}
		}
		#endregion Model

	}
}

