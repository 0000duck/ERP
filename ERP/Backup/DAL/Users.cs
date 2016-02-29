using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:Users
	/// </summary>
	public partial class Users
	{
		public Users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UID", "Users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Users");
			strSql.Append(" where UID=@UID");
			SqlParameter[] parameters = {
					new SqlParameter("@UID", SqlDbType.Int,4)
			};
			parameters[0].Value = UID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ERP.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Users(");
			strSql.Append("UName,UPwd,UGender,ULevel,UPhone,UEmail)");
			strSql.Append(" values (");
			strSql.Append("@UName,@UPwd,@UGender,@ULevel,@UPhone,@UEmail)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UName", SqlDbType.NVarChar,50),
					new SqlParameter("@UPwd", SqlDbType.NVarChar,50),
					new SqlParameter("@UGender", SqlDbType.Char,2),
					new SqlParameter("@ULevel", SqlDbType.NVarChar,50),
					new SqlParameter("@UPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@UEmail", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.UName;
			parameters[1].Value = model.UPwd;
			parameters[2].Value = model.UGender;
			parameters[3].Value = model.ULevel;
			parameters[4].Value = model.UPhone;
			parameters[5].Value = model.UEmail;

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
		public bool Update(ERP.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Users set ");
			strSql.Append("UName=@UName,");
			strSql.Append("UPwd=@UPwd,");
			strSql.Append("UGender=@UGender,");
			strSql.Append("ULevel=@ULevel,");
			strSql.Append("UPhone=@UPhone,");
			strSql.Append("UEmail=@UEmail");
			strSql.Append(" where UID=@UID");
			SqlParameter[] parameters = {
					new SqlParameter("@UName", SqlDbType.NVarChar,50),
					new SqlParameter("@UPwd", SqlDbType.NVarChar,50),
					new SqlParameter("@UGender", SqlDbType.Char,2),
					new SqlParameter("@ULevel", SqlDbType.NVarChar,50),
					new SqlParameter("@UPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@UEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@UID", SqlDbType.Int,4)};
			parameters[0].Value = model.UName;
			parameters[1].Value = model.UPwd;
			parameters[2].Value = model.UGender;
			parameters[3].Value = model.ULevel;
			parameters[4].Value = model.UPhone;
			parameters[5].Value = model.UEmail;
			parameters[6].Value = model.UID;

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
		public bool Delete(int UID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where UID=@UID");
			SqlParameter[] parameters = {
					new SqlParameter("@UID", SqlDbType.Int,4)
			};
			parameters[0].Value = UID;

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
		public bool DeleteList(string UIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where UID in ("+UIDlist + ")  ");
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
		public ERP.Model.Users GetModel(int UID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UID,UName,UPwd,UGender,ULevel,UPhone,UEmail from Users ");
			strSql.Append(" where UID=@UID");
			SqlParameter[] parameters = {
					new SqlParameter("@UID", SqlDbType.Int,4)
			};
			parameters[0].Value = UID;

			ERP.Model.Users model=new ERP.Model.Users();
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
		public ERP.Model.Users DataRowToModel(DataRow row)
		{
			ERP.Model.Users model=new ERP.Model.Users();
			if (row != null)
			{
				if(row["UID"]!=null && row["UID"].ToString()!="")
				{
					model.UID=int.Parse(row["UID"].ToString());
				}
				if(row["UName"]!=null)
				{
					model.UName=row["UName"].ToString();
				}
				if(row["UPwd"]!=null)
				{
					model.UPwd=row["UPwd"].ToString();
				}
				if(row["UGender"]!=null)
				{
					model.UGender=row["UGender"].ToString();
				}
				if(row["ULevel"]!=null)
				{
					model.ULevel=row["ULevel"].ToString();
				}
				if(row["UPhone"]!=null)
				{
					model.UPhone=row["UPhone"].ToString();
				}
				if(row["UEmail"]!=null)
				{
					model.UEmail=row["UEmail"].ToString();
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
			strSql.Append("select UID,UName,UPwd,UGender,ULevel,UPhone,UEmail ");
			strSql.Append(" FROM Users ");
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
			strSql.Append(" UID,UName,UPwd,UGender,ULevel,UPhone,UEmail ");
			strSql.Append(" FROM Users ");
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
			strSql.Append("select count(1) FROM Users ");
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
				strSql.Append("order by T.UID desc");
			}
			strSql.Append(")AS Row, T.*  from Users T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
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
			parameters[0].Value = "Users";
			parameters[1].Value = "UID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

