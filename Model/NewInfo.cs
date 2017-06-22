using System;
namespace rr2.Model
{
	/// <summary>
	/// NewInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NewInfo
	{
		public NewInfo()
		{}
		#region Model
		private int _newid;
		private string _newtitle;
		private string _newcoutent;
		private int? _typeid;
		private int? _userid;
		private DateTime? _newtime;
		private string _newnr;
		/// <summary>
		/// 
		/// </summary>
		public int newId
		{
			set{ _newid=value;}
			get{return _newid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string newTitle
		{
			set{ _newtitle=value;}
			get{return _newtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string newCoutent
		{
			set{ _newcoutent=value;}
			get{return _newcoutent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? typeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? userId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? newTime
		{
			set{ _newtime=value;}
			get{return _newtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string newNR
		{
			set{ _newnr=value;}
			get{return _newnr;}
		}
		#endregion Model

	}
}

