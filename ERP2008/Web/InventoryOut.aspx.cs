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
    public partial class InventoryOut : System.Web.UI.Page
    {
        ERP.BLL.Materials bllMaterials = new ERP.BLL.Materials();
        ERP.BLL.Records bllRecords = new ERP.BLL.Records();
        ERP.Model.Records modelRecords = new ERP.Model.Records();
        ERP.Model.Materials modelMaterials = new ERP.Model.Materials();
        string strWhere = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //页面启动，显示所有物料信息
            if (!IsPostBack)
            {
                LoadList();
                TextBoxSenderMan.Text = HttpContext.Current.User.Identity.Name.ToString();
            }
        }

        private void LoadList()
        {
            GridView1.DataSource = bllMaterials.GetList(strWhere).Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //点提交后，物料信息数量减少，记录表增加一条记录
            strWhere = "MName = '" + DropDownListMName.Text.ToString() + "'";

            try
            {
                //给Records的model赋值
                DataRow dw = bllMaterials.GetList(strWhere).Tables[0].Rows[0];
                modelRecords.RMCode = Convert.ToInt32(dw[1]);
                modelRecords.RMName = dw[2].ToString();
                modelRecords.RQuantity = Convert.ToInt32(TextBoxNumberIn.Text);
                modelRecords.RType = 2;//1指入库，2指出库
                modelRecords.RHander = HttpContext.Current.User.Identity.Name.ToString();
                modelRecords.RTime = Convert.ToDateTime(DateTime.Now.Date.ToString("yyyy-MM-dd"));

                //给Materials的model赋值
                modelMaterials.MID = Convert.ToInt32(dw[0]);
                modelMaterials.MCode = Convert.ToInt32(dw[1]);
                modelMaterials.MName = dw[2].ToString();
                modelMaterials.MModel = dw[3].ToString();
                modelMaterials.MMaterial = dw[4].ToString();
                modelMaterials.MStandard = dw[5].ToString();
                modelMaterials.MUnit = dw[6].ToString();
                modelMaterials.MNumber = Convert.ToInt32(dw[7]) - Convert.ToInt32(TextBoxNumberIn.Text);
                modelMaterials.WName = dw[8].ToString();

                bool boolRecords = bllRecords.Add(modelRecords);
                bool boolMaterials = bllMaterials.Update(modelMaterials);

                if (boolRecords && boolMaterials)
                {
                    Response.Write("<script language='javascript'>alert('出库信息添加成功！');</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('出库信息添加失败！');</script>");
                }
                LoadList();
                TextBoxNumberIn.Text = "";
            }
            catch (Exception erro)
            {

                Response.Write("错误信息:" + erro.Message);
            }

        }

        protected void ButtonQuery_Click(object sender, EventArgs e)
        {
            strWhere = "MName = '" + DropDownListMName.Text.ToString() + "'";
            LoadList();
        }

        protected void DropDownListMName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
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
