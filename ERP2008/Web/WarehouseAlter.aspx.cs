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
    public partial class WarehouseAlter : System.Web.UI.Page
    {
        ERP.BLL.Warehouses bll = new ERP.BLL.Warehouses();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadList();
            }
            
        }
        private void LoadList()
        {

            GridView1.DataSource = bll.GetAllList().Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadList();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadList();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int strIDWhere = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            try
            {
                if (bll.Delete(strIDWhere))
                {
                    Response.Write("<script language=javascript>alert('删除成功！')</script>");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('删除失败！')</script>");
                }
                LoadList();
            }
            catch (Exception erro)
            {

                Response.Write("错误信息:" + erro.Message);
            }
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadList();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            ERP.Model.Warehouses model = new ERP.Model.Warehouses();

            model.WID = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0]).Text);
            model.WName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text.ToString();
            model.WArea = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
            model.WAddress = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.ToString();
            model.WDescribe = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text.ToString();

            try
            {
                bool TrueOrFalse = bll.Update(model);
                if (TrueOrFalse)
                {
                    Response.Write("<script language=javascript>alert('保存成功！')</script>");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('保存失败！')</script>");
                }
                GridView1.EditIndex = -1;
                LoadList();
            }
            catch (Exception erro)
            {

                Response.Write("错误信息:" + erro.Message);
            }
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
