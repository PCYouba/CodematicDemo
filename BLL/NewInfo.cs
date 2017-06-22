using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using rr2.Model;
namespace rr2.BLL
{
	/// <summary>
	/// NewInfo
	/// </summary>
	public partial class NewInfo
	{
		private readonly rr2.DAL.NewInfo dal=new rr2.DAL.NewInfo();
		public NewInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(rr2.Model.NewInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(rr2.Model.NewInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int newId)
		{
			
			return dal.Delete(newId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string newIdlist )
		{
			return dal.DeleteList(newIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public rr2.Model.NewInfo GetModel(int newId)
		{
			
			return dal.GetModel(newId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public rr2.Model.NewInfo GetModelByCache(int newId)
		{
			
			string CacheKey = "NewInfoModel-" + newId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(newId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (rr2.Model.NewInfo)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<rr2.Model.NewInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<rr2.Model.NewInfo> DataTableToList(DataTable dt)
		{
			List<rr2.Model.NewInfo> modelList = new List<rr2.Model.NewInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				rr2.Model.NewInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

