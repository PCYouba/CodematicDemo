using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace rr2.DAL
{
	/// <summary>
	/// 数据访问类:NewInfo
	/// </summary>
	public partial class NewInfo
	{
		public NewInfo()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(rr2.Model.NewInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NewInfo(");
			strSql.Append("newTitle,newCoutent,typeId,userId,newTime,newNR)");
			strSql.Append(" values (");
			strSql.Append("@newTitle,@newCoutent,@typeId,@userId,@newTime,@newNR)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@newTitle", SqlDbType.VarChar,100),
					new SqlParameter("@newCoutent", SqlDbType.Text),
					new SqlParameter("@typeId", SqlDbType.Int,4),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@newTime", SqlDbType.DateTime),
					new SqlParameter("@newNR", SqlDbType.VarChar,1000)};
			parameters[0].Value = model.newTitle;
			parameters[1].Value = model.newCoutent;
			parameters[2].Value = model.typeId;
			parameters[3].Value = model.userId;
			parameters[4].Value = model.newTime;
			parameters[5].Value = model.newNR;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(rr2.Model.NewInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NewInfo set ");
			strSql.Append("newTitle=@newTitle,");
			strSql.Append("newCoutent=@newCoutent,");
			strSql.Append("typeId=@typeId,");
			strSql.Append("userId=@userId,");
			strSql.Append("newTime=@newTime,");
			strSql.Append("newNR=@newNR");
			strSql.Append(" where newId=@newId");
			SqlParameter[] parameters = {
					new SqlParameter("@newTitle", SqlDbType.VarChar,100),
					new SqlParameter("@newCoutent", SqlDbType.Text),
					new SqlParameter("@typeId", SqlDbType.Int,4),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@newTime", SqlDbType.DateTime),
					new SqlParameter("@newNR", SqlDbType.VarChar,1000),
					new SqlParameter("@newId", SqlDbType.Int,4)};
			parameters[0].Value = model.newTitle;
			parameters[1].Value = model.newCoutent;
			parameters[2].Value = model.typeId;
			parameters[3].Value = model.userId;
			parameters[4].Value = model.newTime;
			parameters[5].Value = model.newNR;
			parameters[6].Value = model.newId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int newId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NewInfo ");
			strSql.Append(" where newId=@newId");
			SqlParameter[] parameters = {
					new SqlParameter("@newId", SqlDbType.Int,4)
			};
			parameters[0].Value = newId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string newIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NewInfo ");
			strSql.Append(" where newId in ("+newIdlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public rr2.Model.NewInfo GetModel(int newId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 newId,newTitle,newCoutent,typeId,userId,newTime,newNR from NewInfo ");
			strSql.Append(" where newId=@newId");
			SqlParameter[] parameters = {
					new SqlParameter("@newId", SqlDbType.Int,4)
			};
			parameters[0].Value = newId;

			rr2.Model.NewInfo model=new rr2.Model.NewInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public rr2.Model.NewInfo DataRowToModel(DataRow row)
		{
			rr2.Model.NewInfo model=new rr2.Model.NewInfo();
			if (row != null)
			{
				if(row["newId"]!=null && row["newId"].ToString()!="")
				{
					model.newId=int.Parse(row["newId"].ToString());
				}
				if(row["newTitle"]!=null)
				{
					model.newTitle=row["newTitle"].ToString();
				}
				if(row["newCoutent"]!=null)
				{
					model.newCoutent=row["newCoutent"].ToString();
				}
				if(row["typeId"]!=null && row["typeId"].ToString()!="")
				{
					model.typeId=int.Parse(row["typeId"].ToString());
				}
				if(row["userId"]!=null && row["userId"].ToString()!="")
				{
					model.userId=int.Parse(row["userId"].ToString());
				}
				if(row["newTime"]!=null && row["newTime"].ToString()!="")
				{
					model.newTime=DateTime.Parse(row["newTime"].ToString());
				}
				if(row["newNR"]!=null)
				{
					model.newNR=row["newNR"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select newId,newTitle,newCoutent,typeId,userId,newTime,newNR ");
			strSql.Append(" FROM NewInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" newId,newTitle,newCoutent,typeId,userId,newTime,newNR ");
			strSql.Append(" FROM NewInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM NewInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.newId desc");
			}
			strSql.Append(")AS Row, T.*  from NewInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "NewInfo";
            parameters[1].Value = "newId";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage", parameters, "ds");
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

