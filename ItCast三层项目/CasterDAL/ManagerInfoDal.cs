using CasterDal;
using CasterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using CasterCommon;

namespace CasterDAL
{
    public partial class ManagerInfoDal
    {
        public object SQLiteParameter { get; private set; }

        /// <summary>
        /// 拿到数据
        /// </summary>
        /// <returns>数据List</returns>
        public List<ManagerInfo> GetList()
        {
            //sql语句
            string sql = "select * from ManagerInfo";
            //调用SqlHelper的方法取出数据，存入DataTable
            DataTable dt = SqliteHelper.GetDataTable(sql);
            //将数据放入list中
            List<ManagerInfo> list = new List<ManagerInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ManagerInfo()
                {
                    MId = Convert.ToInt32(row["mid"]),
                    MName = row["mname"].ToString(),
                    MPwd = row["mpwd"].ToString(),
                    MType = Convert.ToInt32(row["mtype"])
                });
            }
            return list;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="mi">ManagerInfo对象</param>
        /// <returns></returns>
        public int Insert(ManagerInfo mi)
        {
            //sql语句
            string sql = "insert into ManagerInfo(mname, mpwd, mtype) values(@name, @pwd, @type)";
            //拿到输入的数据
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@name", mi.MName),
                new SQLiteParameter("@pwd", Md5Helper.EncryptString(mi.MPwd)),
                new SQLiteParameter("@type", mi.MType)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

    }
}
