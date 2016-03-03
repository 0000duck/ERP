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
namespace ERP.Web.Materials
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int MID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(MID);
				}
			}
		}
			
	private void ShowInfo(int MID)
	{
		ERP.BLL.Materials bll=new ERP.BLL.Materials();
		ERP.Model.Materials model=bll.GetModel(MID);
		this.lblMID.Text=model.MID.ToString();
		this.txtMCode.Text=model.MCode.ToString();
		this.lblMName.Text=model.MName;
		this.txtMModel.Text=model.MModel;
		this.txtMMaterial.Text=model.MMaterial;
		this.txtMStandard.Text=model.MStandard;
		this.txtMUnit.Text=model.MUnit;
		this.txtMNumber.Text=model.MNumber.ToString();
		this.txtWName.Text=model.WName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMCode.Text))
			{
				strErr+="MCode格式错误！\\n";	
			}
			if(this.txtMModel.Text.Trim().Length==0)
			{
				strErr+="MModel不能为空！\\n";	
			}
			if(this.txtMMaterial.Text.Trim().Length==0)
			{
				strErr+="MMaterial不能为空！\\n";	
			}
			if(this.txtMStandard.Text.Trim().Length==0)
			{
				strErr+="MStandard不能为空！\\n";	
			}
			if(this.txtMUnit.Text.Trim().Length==0)
			{
				strErr+="MUnit不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMNumber.Text))
			{
				strErr+="MNumber格式错误！\\n";	
			}
			if(this.txtWName.Text.Trim().Length==0)
			{
				strErr+="WName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MID=int.Parse(this.lblMID.Text);
			int MCode=int.Parse(this.txtMCode.Text);
			string MName=this.lblMName.Text;
			string MModel=this.txtMModel.Text;
			string MMaterial=this.txtMMaterial.Text;
			string MStandard=this.txtMStandard.Text;
			string MUnit=this.txtMUnit.Text;
			int MNumber=int.Parse(this.txtMNumber.Text);
			string WName=this.txtWName.Text;


			ERP.Model.Materials model=new ERP.Model.Materials();
			model.MID=MID;
			model.MCode=MCode;
			model.MName=MName;
			model.MModel=MModel;
			model.MMaterial=MMaterial;
			model.MStandard=MStandard;
			model.MUnit=MUnit;
			model.MNumber=MNumber;
			model.WName=WName;

			ERP.BLL.Materials bll=new ERP.BLL.Materials();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
