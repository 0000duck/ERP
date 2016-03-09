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
    public partial class RecordsOut : System.Web.UI.Page
    {
        ERP.BLL.Records bll = new ERP.BLL.Records();
        string strWhere = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "请选择物料名称：";
                DropDownListMethodSelect.Text = "按物料名称查询";
                DropDownListRMName.Visible = true;
                DropDownListRHander.Visible = false;
                DropDownListDateFrom.Visible = false;
                DropDownListDateTo.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                ButtonQuery1.Visible = true;
                ButtonQuery2.Visible = false;

                LoadList();
            }
        }

        private void LoadList()
        {
            GridView1.DataSource = bll.GetList(strWhere).Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void ButtonQuery1_Click(object sender, EventArgs e)
        {
            if (DropDownListMethodSelect.Text == "按经办人查询")
            {
                strWhere = "RHander = '" + DropDownListRHander.Text.ToString() + "'" + "and RType = 2";
                LoadList();
            }
            if (DropDownListMethodSelect.Text == "按物料名称查询")
            {
                strWhere = "RMName = '" + DropDownListRMName.Text.ToString() + "'" + "and RType = 2";
                LoadList();
            }

        }

        protected void ButtonQuery2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(DropDownListDateFrom.Text) <= Convert.ToDateTime(DropDownListDateTo.Text))
            {
                strWhere = "RTime between '" + Convert.ToDateTime(DropDownListDateFrom.Text).ToString("yyyy-MM-dd") + "'and'"
                + Convert.ToDateTime(DropDownListDateTo.Text).ToString("yyyy-MM-dd") + "'" + "and RType = 2";
                LoadList();
            }
        }

        protected void DropDownListMethodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListMethodSelect.Text == "按物料名称查询")
            {
                Label1.Text = "请选择物料名称：";
                DropDownListRMName.Visible = true;
                DropDownListRHander.Visible = false;
                DropDownListDateFrom.Visible = false;
                DropDownListDateTo.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                ButtonQuery1.Visible = true;
                ButtonQuery2.Visible = false;
            }
            if (DropDownListMethodSelect.Text == "按日期查询")
            {
                Label1.Text = "请选择日期：";
                Label1.Visible = false;
                DropDownListRMName.Visible = false;
                DropDownListRHander.Visible = false;
                DropDownListDateFrom.Visible = true;
                DropDownListDateTo.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                ButtonQuery1.Visible = false;
                ButtonQuery2.Visible = true;
            }
            if (DropDownListMethodSelect.Text == "按经办人查询")
            {
                Label1.Text = "请选择经办人：";
                DropDownListRMName.Visible = false;
                DropDownListRHander.Visible = true;
                DropDownListDateFrom.Visible = false;
                DropDownListDateTo.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                ButtonQuery1.Visible = true;
                ButtonQuery2.Visible = false;
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
    }
}
