using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using rr2.Model;
namespace rr2.BLL
{
	/// <summary>
	/// userInfo
	/// </summary>
	public partial class userInfo
	{
		private readonly rr2.DAL.userInfo dal=new rr2.DAL.userInfo();
		public userInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userId)
		{
			return dal.Exists(userId);
		}


        /// <summary>
        /// 通过用户名和密码判断是否存在该记录
        /// </summary>
        public bool Exists(string userName, string userPass)
        {
            if(userName ==""||userPass =="")
            {
                return false;
            }
            return dal.Exists(userName,userPass);
        }





        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int  Add(rr2.Model.userInfo model)
		{
            if(model.userLoginName !="" & model.userTrueName !="" & model.userPass !="" & model.userEmail !="" & model.userTel !="" )

            {
                return new rr2.DAL.userInfo().Add(model);
            }
            else
            {
                return 0;
            }

                //return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(rr2.Model.userInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int userId)
		{
			
			return dal.Delete(userId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string userIdlist )
		{
			return dal.DeleteList(userIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public rr2.Model.userInfo GetModel(int userId)
		{
			
			return dal.GetModel(userId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public rr2.Model.userInfo GetModelByCache(int userId)
		{
			
			string CacheKey = "userInfoModel-" + userId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(userId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (rr2.Model.userInfo)objModel;
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
		public List<rr2.Model.userInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<rr2.Model.userInfo> DataTableToList(DataTable dt)
		{
			List<rr2.Model.userInfo> modelList = new List<rr2.Model.userInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				rr2.Model.userInfo model;
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
		public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

