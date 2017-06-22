using System;
namespace rr2.Model
{
	/// <summary>
	/// commentInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class commentInfo
	{
		public commentInfo()
		{}
		#region Model
		private int _commentid;
		private int? _newsid;
		private int? _ownuserid;
		private int? _checkuserid;
		private string _commentcontent;
		private DateTime? _commenttime = DateTime.Now;
        private string _ext1;
		private string _ext2;
		private string _ext3;
		/// <summary>
		/// 
		/// </summary>
		public int commentId
		{
			set{ _commentid=value;}
			get{return _commentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? newsId
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ownUserId
		{
			set{ _ownuserid=value;}
			get{return _ownuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? checkUserId
		{
			set{ _checkuserid=value;}
			get{return _checkuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string commentContent
		{
			set{ _commentcontent=value;}
			get{return _commentcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? commentTime
		{
			set{ _commenttime=value;}
			get{return _commenttime;}
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

