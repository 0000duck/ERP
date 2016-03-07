using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace ERP.Web
{
    public partial class InventoryQuery : System.Web.UI.Page
    {
        ERP.BLL.Materials bll = new ERP.BLL.Materials();
        string strWhere = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        protected void DropDownListMethodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListMethodSelect.Text=="按物料代码查询")
            {
                Label.Text = "请选择物料代码";
                DropDownListMCode.Visible = true;
                DropDownListMName.Visible = false;
                DropDownListWName.Visible = false;
            }
            if (DropDownListMethodSelect.Text == "按物料名称查询")
            {
                Label.Text = "请选择物料名称";
                DropDownListMCode.Visible = false;
                DropDownListMName.Visible = true;
                DropDownListWName.Visible = false;
            }
            if (DropDownListMethodSelect.Text == "按仓库名称查询")
            {
                Label.Text = "请选择仓库名称";
                DropDownListMCode.Visible = false;
                DropDownListMName.Visible = false;
                DropDownListWName.Visible = true;
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadList();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex != -1)
            {
                int id = e.Row.RowIndex + 1;
                e.Row.Cells[0].Text = id.ToString();
            }
        }

        protected void ButtonQuery_Click(object sender, EventArgs e)
        {
            if (DropDownListMethodSelect.Text=="按物料代码查询")
            {
                strWhere = "MCode ='" + DropDownListMCode.Text.ToString() + "'";
                LoadList();
            }
            if (DropDownListMethodSelect.Text == "按物料名称查询")
            {
                strWhere = "MName ='" + DropDownListMName.Text.ToString() + "'";
                LoadList();
            }
            if (DropDownListMethodSelect.Text == "按仓库名称查询")
            {
                strWhere = "WName ='" + DropDownListWName.Text.ToString() + "'";
                LoadList();
            }
            
        }

        private void LoadList()
        {
            
            GridView1.DataSource = bll.GetList(strWhere).Tables[0].DefaultView;
            GridView1.DataBind();
        }
    }
}
