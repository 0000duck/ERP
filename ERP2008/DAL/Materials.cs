using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ERP.DAL
{
	/// <summary>
	/// 数据访问类:Materials
	/// </summary>
	public partial class Materials
	{
		public Materials()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MID", "Materials"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string MName,int MID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Materials");
			strSql.Append(" where MName=@MName and MID=@MID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MName", SqlDbType.NVarChar,50),
					new SqlParameter("@MID", SqlDbType.Int,4)			};
			parameters[0].Value = MName;
			parameters[1].Value = MID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ERP.Model.Materials model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Materials(");
			strSql.Append("MCode,MName,MModel,MMaterial,MStandard,MUnit,MNumber,WName)");
			strSql.Append(" values (");
			strSql.Append("@MCode,@MName,@MModel,@MMaterial,@MStandard,@MUnit,@MNumber,@WName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MCode", SqlDbType.Int,4),
					new SqlParameter("@MName", SqlDbType.NVarChar,50),
					new SqlParameter("@MModel", SqlDbType.NVarChar,50),
					new SqlParameter("@MMaterial", SqlDbType.NVarChar,50),
					new SqlParameter("@MStandard", SqlDbType.NVarChar,50),
					new SqlParameter("@MUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@MNumber", SqlDbType.Int,4),
					new SqlParameter("@WName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.MCode;
			parameters[1].Value = model.MName;
			parameters[2].Value = model.MModel;
			parameters[3].Value = model.MMaterial;
			parameters[4].Value = model.MStandard;
			parameters[5].Value = model.MUnit;
			parameters[6].Value = model.MNumber;
			parameters[7].Value = model.WName;

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
		public bool Update(ERP.Model.Materials model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Materials set ");
			strSql.Append("MCode=@MCode,");
			strSql.Append("MModel=@MModel,");
			strSql.Append("MMaterial=@MMaterial,");
			strSql.Append("MStandard=@MStandard,");
			strSql.Append("MUnit=@MUnit,");
			strSql.Append("MNumber=@MNumber,");
			strSql.Append("WName=@WName");
			strSql.Append(" where MID=@MID");
			SqlParameter[] parameters = {
					new SqlParameter("@MCode", SqlDbType.Int,4),
					new SqlParameter("@MModel", SqlDbType.NVarChar,50),
					new SqlParameter("@MMaterial", SqlDbType.NVarChar,50),
					new SqlParameter("@MStandard", SqlDbType.NVarChar,50),
					new SqlParameter("@MUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@MNumber", SqlDbType.Int,4),
					new SqlParameter("@WName", SqlDbType.NVarChar,50),
					new SqlParameter("@MID", SqlDbType.Int,4),
					new SqlParameter("@MName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.MCode;
			parameters[1].Value = model.MModel;
			parameters[2].Value = model.MMaterial;
			parameters[3].Value = model.MStandard;
			parameters[4].Value = model.MUnit;
			parameters[5].Value = model.MNumber;
			parameters[6].Value = model.WName;
			parameters[7].Value = model.MID;
			parameters[8].Value = model.MName;

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
		public bool Delete(int MID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Materials ");
			strSql.Append(" where MID=@MID");
			SqlParameter[] parameters = {
					new SqlParameter("@MID", SqlDbType.Int,4)
			};
			parameters[0].Value = MID;

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
		public bool Delete(string MName,int MID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Materials ");
			strSql.Append(" where MName=@MName and MID=@MID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MName", SqlDbType.NVarChar,50),
					new SqlParameter("@MID", SqlDbType.Int,4)			};
			parameters[0].Value = MName;
			parameters[1].Value = MID;

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
		public bool DeleteList(string MIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Materials ");
			strSql.Append(" where MID in ("+MIDlist + ")  ");
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
		public ERP.Model.Materials GetModel(int MID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MID,MCode,MName,MModel,MMaterial,MStandard,MUnit,MNumber,WName from Materials ");
			strSql.Append(" where MID=@MID");
			SqlParameter[] parameters = {
					new SqlParameter("@MID", SqlDbType.Int,4)
			};
			parameters[0].Value = MID;

			ERP.Model.Materials model=new ERP.Model.Materials();
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
		public ERP.Model.Materials DataRowToModel(DataRow row)
		{
			ERP.Model.Materials model=new ERP.Model.Materials();
			if (row != null)
			{
				if(row["MID"]!=null && row["MID"].ToString()!="")
				{
					model.MID=int.Parse(row["MID"].ToString());
				}
				if(row["MCode"]!=null && row["MCode"].ToString()!="")
				{
					model.MCode=int.Parse(row["MCode"].ToString());
				}
				if(row["MName"]!=null)
				{
					model.MName=row["MName"].ToString();
				}
				if(row["MModel"]!=null)
				{
					model.MModel=row["MModel"].ToString();
				}
				if(row["MMaterial"]!=null)
				{
					model.MMaterial=row["MMaterial"].ToString();
				}
				if(row["MStandard"]!=null)
				{
					model.MStandard=row["MStandard"].ToString();
				}
				if(row["MUnit"]!=null)
				{
					model.MUnit=row["MUnit"].ToString();
				}
				if(row["MNumber"]!=null && row["MNumber"].ToString()!="")
				{
					model.MNumber=int.Parse(row["MNumber"].ToString());
				}
				if(row["WName"]!=null)
				{
					model.WName=row["WName"].ToString();
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
			strSql.Append("select MID,MCode,MName,MModel,MMaterial,MStandard,MUnit,MNumber,WName ");
			strSql.Append(" FROM Materials ");
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
			strSql.Append(" MID,MCode,MName,MModel,MMaterial,MStandard,MUnit,MNumber,WName ");
			strSql.Append(" FROM Materials ");
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
			strSql.Append("select count(1) FROM Materials ");
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
				strSql.Append("order by T.MID desc");
			}
			strSql.Append(")AS Row, T.*  from Materials T ");
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
			parameters[0].Value = "Materials";
			parameters[1].Value = "MID";
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

