using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace rr2.DAL
{
	/// <summary>
	/// 数据访问类:newsInfo
	/// </summary>
	public partial class newsInfo
	{
		public newsInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("newsId", "newsInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int newsId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from newsInfo");
			strSql.Append(" where newsId=@newsId");
			SqlParameter[] parameters = {
					new SqlParameter("@newsId", SqlDbType.Int,4)
			};
			parameters[0].Value = newsId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(rr2.Model.newsInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into newsInfo(");
			strSql.Append("userId,typeId,newsTitle,newsContent,newsCount,newsReleaseTime,ext1,ext2,ext3)");
			strSql.Append(" values (");
			strSql.Append("@userId,@typeId,@newsTitle,@newsContent,@newsCount,@newsReleaseTime,@ext1,@ext2,@ext3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@typeId", SqlDbType.Int,4),
					new SqlParameter("@newsTitle", SqlDbType.VarChar,100),
					new SqlParameter("@newsContent", SqlDbType.VarChar,4000),
					new SqlParameter("@newsCount", SqlDbType.Int,4),
					new SqlParameter("@newsReleaseTime", SqlDbType.DateTime),
					new SqlParameter("@ext1", SqlDbType.VarChar,200),
					new SqlParameter("@ext2", SqlDbType.VarChar,200),
					new SqlParameter("@ext3", SqlDbType.VarChar,200)};
			parameters[0].Value = model.userId;
			parameters[1].Value = model.typeId;
			parameters[2].Value = model.newsTitle;
			parameters[3].Value = model.newsContent;
			parameters[4].Value = model.newsCount;
			parameters[5].Value = model.newsReleaseTime;
			parameters[6].Value = model.ext1;
			parameters[7].Value = model.ext2;
			parameters[8].Value = model.ext3;

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
		public bool Update(rr2.Model.newsInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update newsInfo set ");
			strSql.Append("typeId=@typeId,");
			strSql.Append("newsTitle=@newsTitle,");
			strSql.Append("newsContent=@newsContent,");
			strSql.Append("newsCount=@newsCount,");
			strSql.Append("newsReleaseTime=@newsReleaseTime");
			strSql.Append(" where newsId=@newsId");
			SqlParameter[] parameters = {			
					new SqlParameter("@typeId", SqlDbType.Int,4),
					new SqlParameter("@newsTitle", SqlDbType.VarChar,100),
					new SqlParameter("@newsContent", SqlDbType.VarChar,4000),
					new SqlParameter("@newsCount", SqlDbType.Int,4),
					new SqlParameter("@newsReleaseTime", SqlDbType.DateTime),
					new SqlParameter("@newsId", SqlDbType.Int,4)};
			parameters[0].Value = model.typeId;
			parameters[1].Value = model.newsTitle;
            parameters[2].Value = model.newsContent;
            parameters[3].Value = model.newsCount;
            parameters[4].Value = model.newsReleaseTime;
            parameters[5].Value =  model.newsId;

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
		public bool Delete(int newsId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from newsInfo ");
			strSql.Append(" where newsId=@newsId");
			SqlParameter[] parameters = {
					new SqlParameter("@newsId", SqlDbType.Int,4)
			};
			parameters[0].Value = newsId;

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
		public bool DeleteList(string newsIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from newsInfo ");
			strSql.Append(" where newsId in ("+newsIdlist + ")  ");
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
		public rr2.Model.newsInfo GetModel(int newsId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 newsId,userId,typeId,newsTitle,newsContent,newsCount,newsReleaseTime,ext1,ext2,ext3 from newsInfo ");
			strSql.Append(" where newsId=@newsId");
			SqlParameter[] parameters = {
					new SqlParameter("@newsId", SqlDbType.Int,4)
			};
			parameters[0].Value = newsId;

			rr2.Model.newsInfo model=new rr2.Model.newsInfo();
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
		public rr2.Model.newsInfo DataRowToModel(DataRow row)
		{
			rr2.Model.newsInfo model=new rr2.Model.newsInfo();
			if (row != null)
			{
				if(row["newsId"]!=null && row["newsId"].ToString()!="")
				{
					model.newsId=int.Parse(row["newsId"].ToString());
				}
				if(row["userId"]!=null && row["userId"].ToString()!="")
				{
					model.userId=int.Parse(row["userId"].ToString());
				}
				if(row["typeId"]!=null && row["typeId"].ToString()!="")
				{
					model.typeId=int.Parse(row["typeId"].ToString());
				}
				if(row["newsTitle"]!=null)
				{
					model.newsTitle=row["newsTitle"].ToString();
				}
				if(row["newsContent"]!=null)
				{
					model.newsContent=row["newsContent"].ToString();
				}
				if(row["newsCount"]!=null && row["newsCount"].ToString()!="")
				{
					model.newsCount=int.Parse(row["newsCount"].ToString());
				}
				if(row["newsReleaseTime"]!=null && row["newsReleaseTime"].ToString()!="")
				{
					model.newsReleaseTime=DateTime.Parse(row["newsReleaseTime"].ToString());
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
		/// 多表查询
		/// </summary>
		public DataSet GetListmore(int PageSize, int PageIndex,string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select newsInfo.newsId,newsInfo.userId,newsInfo.typeId,newsInfo.newsTitle,newsInfo.newsContent,newsInfo.newsCount,newsInfo.newsReleaseTime,userInfo.userLoginName ");
            strSql.Append(" FROM newsInfo and userInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "newsInfo";
            parameters[1].Value = "newsId";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage", parameters, "ds");
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select newsId,userId,typeId,newsTitle,newsContent,newsCount,newsReleaseTime,ext1,ext2,ext3 ");
			strSql.Append(" FROM newsInfo ");
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
			strSql.Append(" newsId,userId,typeId,newsTitle,newsContent,newsCount,newsReleaseTime,ext1,ext2,ext3 ");
			strSql.Append(" FROM newsInfo ");
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
			strSql.Append("select count(1) FROM newsInfo ");
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
				strSql.Append("order by T.newsId desc");
			}
			strSql.Append(")AS Row, T.*  from newsInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 分页获取数据列表，自己做的
        /// </summary>
        //public DataSet GetList(int PageSize)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select Top 3 * from newsInfo where newsId NOT IN (select TOP ((@PageSize-1)*3) newsId from newsInfo)");


        //    SqlParameter[] parameters = {
        //            new SqlParameter("@PageSize", SqlDbType.Int)
        //            };

        //    parameters[0].Value = PageSize;
        //    return DbHelperSQL.Query(strSql.ToString(), parameters);
        //}



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
            parameters[0].Value = "newsInfo";
            parameters[1].Value = "newsId";
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

