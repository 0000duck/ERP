using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 手动代码
            //创建储存数据的容器
            List<ManagerInfo> list = new List<ManagerInfo>();
            //连接字符串
            string connStr = @"data source=D:\桌面\C#\练习\ItCast三层项目\lib\ItcastCater.db;version=3;";
            //创建连接对象，创建command对象,打开连接，执行命令，读取，显示
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from ManagerInfo", conn);
                conn.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new ManagerInfo()
                        {
                            Mid = Convert.ToInt32(reader["Mid"]),
                            MName = reader["MName"].ToString(),
                            MPsw = reader["MPwd"].ToString(),
                            MType = Convert.ToInt32(reader["MType"])
                        });
                    }
                }
                reader.Close();
                dataGridView1.DataSource = list;
            } 
            #endregion



        }
    }
}
