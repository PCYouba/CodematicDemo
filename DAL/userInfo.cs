using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace rr2.DAL
{
	/// <summary>
	/// 数据访问类:userInfo
	/// </summary>
	public partial class userInfo
	{
		public userInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("userId", "userInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userInfo");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)
			};
			parameters[0].Value = userId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


       


        /// <summary>
		/// 通过用户名和密码判断是否存在该记录
		/// </summary>
		public bool Exists(string userName, string userPass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from userInfo");
            strSql.Append(" where userLoginName=@userLoginName and userPass=@userPass");
            SqlParameter[] parameters = {
                    new SqlParameter("@userLoginName", SqlDbType.VarChar,50),
                    new SqlParameter("@userPass", SqlDbType.VarChar,50)

            };
            parameters[0].Value = userName;
            parameters[1].Value = userPass;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(rr2.Model.userInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userInfo(");
			strSql.Append("userLoginName,userTrueName,userPass,userEmail,userTel,flag,ext1,ext2,ext3)");
			strSql.Append(" values (");
			strSql.Append("@userLoginName,@userTrueName,@userPass,@userEmail,@userTel,@flag,@ext1,@ext2,@ext3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userLoginName", SqlDbType.VarChar,50),
					new SqlParameter("@userTrueName", SqlDbType.VarChar,50),
					new SqlParameter("@userPass", SqlDbType.VarChar,30),
					new SqlParameter("@userEmail", SqlDbType.VarChar,50),
					new SqlParameter("@userTel", SqlDbType.VarChar,20),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@ext1", SqlDbType.VarChar,200),
					new SqlParameter("@ext2", SqlDbType.VarChar,200),
					new SqlParameter("@ext3", SqlDbType.VarChar,200)};
			parameters[0].Value = model.userLoginName;
			parameters[1].Value = model.userTrueName;
			parameters[2].Value = model.userPass;
			parameters[3].Value = model.userEmail;
			parameters[4].Value = model.userTel;
			parameters[5].Value = model.flag;
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
		public bool Update(rr2.Model.userInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userInfo set ");
			strSql.Append("userLoginName=@userLoginName,");
			strSql.Append("userTrueName=@userTrueName,");
			strSql.Append("userPass=@userPass,");
			strSql.Append("userEmail=@userEmail,");
			strSql.Append("userTel=@userTel,");
			strSql.Append("flag=@flag,");
			strSql.Append("ext1=@ext1,");
			strSql.Append("ext2=@ext2,");
			strSql.Append("ext3=@ext3");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userLoginName", SqlDbType.VarChar,50),
					new SqlParameter("@userTrueName", SqlDbType.VarChar,50),
					new SqlParameter("@userPass", SqlDbType.VarChar,30),
					new SqlParameter("@userEmail", SqlDbType.VarChar,50),
					new SqlParameter("@userTel", SqlDbType.VarChar,20),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@ext1", SqlDbType.VarChar,200),
					new SqlParameter("@ext2", SqlDbType.VarChar,200),
					new SqlParameter("@ext3", SqlDbType.VarChar,200),
					new SqlParameter("@userId", SqlDbType.Int,4)};
			parameters[0].Value = model.userLoginName;
			parameters[1].Value = model.userTrueName;
			parameters[2].Value = model.userPass;
			parameters[3].Value = model.userEmail;
			parameters[4].Value = model.userTel;
			parameters[5].Value = model.flag;
			parameters[6].Value = model.ext1;
			parameters[7].Value = model.ext2;
			parameters[8].Value = model.ext3;
			parameters[9].Value = model.userId;

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
		public bool Delete(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userInfo ");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)
			};
			parameters[0].Value = userId;

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
		public bool DeleteList(string userIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userInfo ");
			strSql.Append(" where userId in ("+userIdlist + ")  ");
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
		public rr2.Model.userInfo GetModel(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 userId,userLoginName,userTrueName,userPass,userEmail,userTel,flag,ext1,ext2,ext3 from userInfo ");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)
			};
			parameters[0].Value = userId;

			rr2.Model.userInfo model=new rr2.Model.userInfo();
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
		public rr2.Model.userInfo DataRowToModel(DataRow row)
		{
			rr2.Model.userInfo model=new rr2.Model.userInfo();
			if (row != null)
			{
				if(row["userId"]!=null && row["userId"].ToString()!="")
				{
					model.userId=int.Parse(row["userId"].ToString());
				}
				if(row["userLoginName"]!=null)
				{
					model.userLoginName=row["userLoginName"].ToString();
				}
				if(row["userTrueName"]!=null)
				{
					model.userTrueName=row["userTrueName"].ToString();
				}
				if(row["userPass"]!=null)
				{
					model.userPass=row["userPass"].ToString();
				}
				if(row["userEmail"]!=null)
				{
					model.userEmail=row["userEmail"].ToString();
				}
				if(row["userTel"]!=null)
				{
					model.userTel=row["userTel"].ToString();
				}
				if(row["flag"]!=null && row["flag"].ToString()!="")
				{
					model.flag=int.Parse(row["flag"].ToString());
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
			strSql.Append("select userId,userLoginName,userTrueName,userPass,userEmail,userTel,flag,ext1,ext2,ext3 ");
			strSql.Append(" FROM userInfo ");
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
			strSql.Append(" userId,userLoginName,userTrueName,userPass,userEmail,userTel,flag,ext1,ext2,ext3 ");
			strSql.Append(" FROM userInfo ");
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
			strSql.Append("select count(1) FROM userInfo ");
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
				strSql.Append("order by T.userId desc");
			}
			strSql.Append(")AS Row, T.*  from userInfo T ");
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
            parameters[0].Value = "userInfo";
            parameters[1].Value = "userId";
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

