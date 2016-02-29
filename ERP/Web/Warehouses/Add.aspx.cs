using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace ERP.Web.Warehouses
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtWName.Text.Trim().Length==0)
			{
				strErr+="WName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWArea.Text))
			{
				strErr+="WArea格式错误！\\n";	
			}
			if(this.txtWAddress.Text.Trim().Length==0)
			{
				strErr+="WAddress不能为空！\\n";	
			}
			if(this.txtWDescribe.Text.Trim().Length==0)
			{
				strErr+="WDescribe不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string WName=this.txtWName.Text;
			decimal WArea=decimal.Parse(this.txtWArea.Text);
			string WAddress=this.txtWAddress.Text;
			string WDescribe=this.txtWDescribe.Text;

			ERP.Model.Warehouses model=new ERP.Model.Warehouses();
			model.WName=WName;
			model.WArea=WArea;
			model.WAddress=WAddress;
			model.WDescribe=WDescribe;

			ERP.BLL.Warehouses bll=new ERP.BLL.Warehouses();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
