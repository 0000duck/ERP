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
using System.Data.SqlClient;

namespace ERP.Web.WareHouseManager
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ERP.BLL.Materials bll = new ERP.BLL.Materials();
            ERP.Model.Materials model = new ERP.Model.Materials();

            model.MCode = Convert.ToInt32(TextBoxMCode.Text);
            model.MName = TextBoxMName.Text.ToString();
            model.MModel = TextBoxMModel.Text.ToString();
            model.MMaterial = TextBoxMMaterial.Text.ToString();
            model.MStandard = TextBoxMStandard.Text.ToString();
            model.MUnit = TextBoxMUnit.Text.ToString();
            model.MNumber = Convert.ToInt32(TextBoxMNumber.Text);
            //仓库名称-由下拉菜单选择
            model.WName = DropDownList.Text.ToString();

            try
            {
                bll.Add(model);
                Response.Write("<script>alert('插入成功');history.back()</script>");

                TextBoxMCode.Text = "";
                TextBoxMName.Text = "";
                TextBoxMModel.Text = "";
                TextBoxMMaterial.Text = "";
                TextBoxMStandard.Text = "";
                TextBoxMUnit.Text = "";
                TextBoxMNumber.Text = "";
            }
            catch (Exception)
            {

                Response.Write("<script>alert('插入失败');history.back()</script>");

                TextBoxMCode.Text = "";
                TextBoxMName.Text = "";
                TextBoxMModel.Text = "";
                TextBoxMMaterial.Text = "";
                TextBoxMStandard.Text = "";
                TextBoxMUnit.Text = "";
                TextBoxMNumber.Text = "";
            }
            
        }

    }
}
