using System;
namespace rr2.Model
{
	/// <summary>
	/// typeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class typeInfo
	{
		public typeInfo()
		{}
		#region Model
		private int _typeid;
		private string _typename;
		private string _ext1;
		private string _ext2;
		private string _ext3;
		/// <summary>
		/// 
		/// </summary>
		public int typeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string typeName
		{
			set{ _typename=value;}
			get{return _typename;}
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

