using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace rr2.DAL
{
	/// <summary>
	/// 数据访问类:typeInfo
	/// </summary>
	public partial class typeInfo
	{
		public typeInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("typeId", "typeInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int typeId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from typeInfo");
			strSql.Append(" where typeId=@typeId");
			SqlParameter[] parameters = {
					new SqlParameter("@typeId", SqlDbType.Int,4)
			};
			parameters[0].Value = typeId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(rr2.Model.typeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into typeInfo(");
			strSql.Append("typeName,ext1,ext2,ext3)");
			strSql.Append(" values (");
			strSql.Append("@typeName,@ext1,@ext2,@ext3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@typeName", SqlDbType.VarChar,50),
					new SqlParameter("@ext1", SqlDbType.VarChar,200),
					new SqlParameter("@ext2", SqlDbType.VarChar,200),
					new SqlParameter("@ext3", SqlDbType.VarChar,200)};
			parameters[0].Value = model.typeName;
			parameters[1].Value = model.ext1;
			parameters[2].Value = model.ext2;
			parameters[3].Value = model.ext3;

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
		public bool Update(rr2.Model.typeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update typeInfo set ");
			strSql.Append("typeName=@typeName,");
			strSql.Append("ext1=@ext1,");
			strSql.Append("ext2=@ext2,");
			strSql.Append("ext3=@ext3");
			strSql.Append(" where typeId=@typeId");
			SqlParameter[] parameters = {
					new SqlParameter("@typeName", SqlDbType.VarChar,50),
					new SqlParameter("@ext1", SqlDbType.VarChar,200),
					new SqlParameter("@ext2", SqlDbType.VarChar,200),
					new SqlParameter("@ext3", SqlDbType.VarChar,200),
					new SqlParameter("@typeId", SqlDbType.Int,4)};
			parameters[0].Value = model.typeName;
			parameters[1].Value = model.ext1;
			parameters[2].Value = model.ext2;
			parameters[3].Value = model.ext3;
			parameters[4].Value = model.typeId;

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
		public bool Delete(int typeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from typeInfo ");
			strSql.Append(" where typeId=@typeId");
			SqlParameter[] parameters = {
					new SqlParameter("@typeId", SqlDbType.Int,4)
			};
			parameters[0].Value = typeId;

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
		public bool DeleteList(string typeIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from typeInfo ");
			strSql.Append(" where typeId in ("+typeIdlist + ")  ");
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
		public rr2.Model.typeInfo GetModel(int typeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 typeId,typeName,ext1,ext2,ext3 from typeInfo ");
			strSql.Append(" where typeId=@typeId");
			SqlParameter[] parameters = {
					new SqlParameter("@typeId", SqlDbType.Int,4)
			};
			parameters[0].Value = typeId;

			rr2.Model.typeInfo model=new rr2.Model.typeInfo();
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
		public rr2.Model.typeInfo DataRowToModel(DataRow row)
		{
			rr2.Model.typeInfo model=new rr2.Model.typeInfo();
			if (row != null)
			{
				if(row["typeId"]!=null && row["typeId"].ToString()!="")
				{
					model.typeId=int.Parse(row["typeId"].ToString());
				}
				if(row["typeName"]!=null)
				{
					model.typeName=row["typeName"].ToString();
				}
				if(row["ext1"]!=null)
				{
					model.ext1=row["ext1"].ToString();
				}
				if(row["ext2"]!=null)
				{
					model.ext2=row["ext2"].ToString();
				}
				if(row["ext3"]!=null)
				{
					model.ext3=row["ext3"].ToString();
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
			strSql.Append("select typeId,typeName,ext1,ext2,ext3 ");
			strSql.Append(" FROM typeInfo ");
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
			strSql.Append(" typeId,typeName,ext1,ext2,ext3 ");
			strSql.Append(" FROM typeInfo ");
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
			strSql.Append("select count(1) FROM typeInfo ");
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
				strSql.Append("order by T.typeId desc");
			}
			strSql.Append(")AS Row, T.*  from typeInfo T ");
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
            parameters[0].Value = "typeInfo";
            parameters[1].Value = "typeId";
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

