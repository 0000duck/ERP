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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int WID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(WID);
				}
			}
		}
			
	private void ShowInfo(int WID)
	{
		ERP.BLL.Warehouses bll=new ERP.BLL.Warehouses();
		ERP.Model.Warehouses model=bll.GetModel(WID);
		this.lblWID.Text=model.WID.ToString();
		this.lblWName.Text=model.WName;
		this.txtWArea.Text=model.WArea.ToString();
		this.txtWAddress.Text=model.WAddress;
		this.txtWDescribe.Text=model.WDescribe;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			int WID=int.Parse(this.lblWID.Text);
			string WName=this.lblWName.Text;
			decimal WArea=decimal.Parse(this.txtWArea.Text);
			string WAddress=this.txtWAddress.Text;
			string WDescribe=this.txtWDescribe.Text;


			ERP.Model.Warehouses model=new ERP.Model.Warehouses();
			model.WID=WID;
			model.WName=WName;
			model.WArea=WArea;
			model.WAddress=WAddress;
			model.WDescribe=WDescribe;

			ERP.BLL.Warehouses bll=new ERP.BLL.Warehouses();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
