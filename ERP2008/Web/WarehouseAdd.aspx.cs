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
    public partial class WarehouseAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ERP.BLL.Warehouses bll = new ERP.BLL.Warehouses();
            ERP.Model.Warehouses model = new ERP.Model.Warehouses();

            model.WName = TextBoxWName.Text.ToString();
            model.WArea = Convert.ToInt32(TextBoxWArea.Text);
            model.WAddress = TextBoxWAddress.Text.ToString();
            model.WDescribe = TextBoxWDescribe.Text.ToString();

            try
            {
                bll.Add(model);
                Response.Write("<script>alert('添加新仓库成功');history.back()</script>");

                TextBoxWName.Text = "";
                TextBoxWArea.Text = "";
                TextBoxWAddress.Text = "";
                TextBoxWDescribe.Text = "";
            }
            catch (Exception)
            {

                Response.Write("<script>alert('未知错误，添加新仓库失败！');history.back()</script>");

                TextBoxWName.Text = "";
                TextBoxWArea.Text = "";
                TextBoxWAddress.Text = "";
                TextBoxWDescribe.Text = "";
            }
        }
    }
}
