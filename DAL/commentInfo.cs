using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace rr2.DAL
{
	/// <summary>
	/// 数据访问类:commentInfo
	/// </summary>
	public partial class commentInfo
	{
		public commentInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("commentId", "commentInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int commentId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from commentInfo");
			strSql.Append(" where commentId=@commentId");
			SqlParameter[] parameters = {
					new SqlParameter("@commentId", SqlDbType.Int,4)
			};
			parameters[0].Value = commentId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(rr2.Model.commentInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into commentInfo(");
			strSql.Append("newsId,ownUserId,checkUserId,commentContent,commentTime,ext1,ext2,ext3)");
			strSql.Append(" values (");
			strSql.Append("@newsId,@ownUserId,@checkUserId,@commentContent,@commentTime,@ext1,@ext2,@ext3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@newsId", SqlDbType.Int,4),
					new SqlParameter("@ownUserId", SqlDbType.Int,4),
					new SqlParameter("@checkUserId", SqlDbType.Int,4),
					new SqlParameter("@commentContent", SqlDbType.VarChar,1000),
					new SqlParameter("@commentTime", SqlDbType.DateTime),
					new SqlParameter("@ext1", SqlDbType.VarChar,200),
					new SqlParameter("@ext2", SqlDbType.VarChar,200),
					new SqlParameter("@ext3", SqlDbType.VarChar,200)};
			parameters[0].Value = model.newsId;
			parameters[1].Value = model.ownUserId;
			parameters[2].Value = model.checkUserId;
			parameters[3].Value = model.commentContent;
			parameters[4].Value = model.commentTime;
			parameters[5].Value = model.ext1;
			parameters[6].Value = model.ext2;
			parameters[7].Value = model.ext3;

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
		public bool Update(rr2.Model.commentInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update commentInfo set ");
			strSql.Append("newsId=@newsId,");
			strSql.Append("ownUserId=@ownUserId,");
			strSql.Append("checkUserId=@checkUserId,");
			strSql.Append("commentContent=@commentContent,");
			strSql.Append("commentTime=@commentTime,");
			strSql.Append("ext1=@ext1,");
			strSql.Append("ext2=@ext2,");
			strSql.Append("ext3=@ext3");
			strSql.Append(" where commentId=@commentId");
			SqlParameter[] parameters = {
					new SqlParameter("@newsId", SqlDbType.Int,4),
					new SqlParameter("@ownUserId", SqlDbType.Int,4),
					new SqlParameter("@checkUserId", SqlDbType.Int,4),
					new SqlParameter("@commentContent", SqlDbType.VarChar,1000),
					new SqlParameter("@commentTime", SqlDbType.DateTime),
					new SqlParameter("@ext1", SqlDbType.VarChar,200),
					new SqlParameter("@ext2", SqlDbType.VarChar,200),
					new SqlParameter("@ext3", SqlDbType.VarChar,200),
					new SqlParameter("@commentId", SqlDbType.Int,4)};
			parameters[0].Value = model.newsId;
			parameters[1].Value = model.ownUserId;
			parameters[2].Value = model.checkUserId;
			parameters[3].Value = model.commentContent;
			parameters[4].Value = model.commentTime;
			parameters[5].Value = model.ext1;
			parameters[6].Value = model.ext2;
			parameters[7].Value = model.ext3;
			parameters[8].Value = model.commentId;

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
		public bool Delete(int commentId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from commentInfo ");
			strSql.Append(" where commentId=@commentId");
			SqlParameter[] parameters = {
					new SqlParameter("@commentId", SqlDbType.Int,4)
			};
			parameters[0].Value = commentId;

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
		public bool DeleteList(string commentIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from commentInfo ");
			strSql.Append(" where commentId in ("+commentIdlist + ")  ");
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
		public rr2.Model.commentInfo GetModel(int commentId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 commentId,newsId,ownUserId,checkUserId,commentContent,commentTime,ext1,ext2,ext3 from commentInfo ");
			strSql.Append(" where commentId=@commentId");
			SqlParameter[] parameters = {
					new SqlParameter("@commentId", SqlDbType.Int,4)
			};
			parameters[0].Value = commentId;

			rr2.Model.commentInfo model=new rr2.Model.commentInfo();
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
		public rr2.Model.commentInfo DataRowToModel(DataRow row)
		{
			rr2.Model.commentInfo model=new rr2.Model.commentInfo();
			if (row != null)
			{
				if(row["commentId"]!=null && row["commentId"].ToString()!="")
				{
					model.commentId=int.Parse(row["commentId"].ToString());
				}
				if(row["newsId"]!=null && row["newsId"].ToString()!="")
				{
					model.newsId=int.Parse(row["newsId"].ToString());
				}
				if(row["ownUserId"]!=null && row["ownUserId"].ToString()!="")
				{
					model.ownUserId=int.Parse(row["ownUserId"].ToString());
				}
				if(row["checkUserId"]!=null && row["checkUserId"].ToString()!="")
				{
					model.checkUserId=int.Parse(row["checkUserId"].ToString());
				}
				if(row["commentContent"]!=null)
				{
					model.commentContent=row["commentContent"].ToString();
				}
				if(row["commentTime"]!=null && row["commentTime"].ToString()!="")
				{
					model.commentTime=DateTime.Parse(row["commentTime"].ToString());
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
			strSql.Append("select commentId,newsId,ownUserId,checkUserId,commentContent,commentTime,ext1,ext2,ext3 ");
			strSql.Append(" FROM commentInfo ");
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
			strSql.Append(" commentId,newsId,ownUserId,checkUserId,commentContent,commentTime,ext1,ext2,ext3 ");
			strSql.Append(" FROM commentInfo ");
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
			strSql.Append("select count(1) FROM commentInfo ");
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
				strSql.Append("order by T.commentId desc");
			}
			strSql.Append(")AS Row, T.*  from commentInfo T ");
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
            parameters[0].Value = "commentInfo";
            parameters[1].Value = "commentId";
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

