using System;
namespace rr2.Model
{
	/// <summary>
	/// newsInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class newsInfo
	{
		public newsInfo()
		{}
		#region Model
		private int _newsid;
		private int? _userid;
		private int? _typeid;
		private string _newstitle;
		private string _newscontent;
		private int? _newscount;
		private DateTime? _newsreleasetime= DateTime.Now;
		private string _ext1;
		private string _ext2;
		private string _ext3;
		/// <summary>
		/// 
		/// </summary>
		public int newsId
		{
			set{ _newsid=value;}
			get{return _newsid;}
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
		public int? typeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string newsTitle
		{
			set{ _newstitle=value;}
			get{return _newstitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string newsContent
		{
			set{ _newscontent=value;}
			get{return _newscontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? newsCount
		{
			set{ _newscount=value;}
			get{return _newscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? newsReleaseTime
		{
			set{ _newsreleasetime=value;}
			get{return _newsreleasetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ext1
		{
			set{ _ext1=value;}
			get{return _ext1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ext2
		{
			set{ _ext2=value;}
			get{return _ext2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ext3
		{
			set{ _ext3=value;}
			get{return _ext3;}
		}
		#endregion Model

	}
}

