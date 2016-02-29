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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMCode.Text))
			{
				strErr+="MCode格式错误！\\n";	
			}
			if(this.txtMName.Text.Trim().Length==0)
			{
				strErr+="MName不能为空！\\n";	
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
			int MCode=int.Parse(this.txtMCode.Text);
			string MName=this.txtMName.Text;
			string MModel=this.txtMModel.Text;
			string MMaterial=this.txtMMaterial.Text;
			string MStandard=this.txtMStandard.Text;
			string MUnit=this.txtMUnit.Text;
			int MNumber=int.Parse(this.txtMNumber.Text);
			string WName=this.txtWName.Text;

			ERP.Model.Materials model=new ERP.Model.Materials();
			model.MCode=MCode;
			model.MName=MName;
			model.MModel=MModel;
			model.MMaterial=MMaterial;
			model.MStandard=MStandard;
			model.MUnit=MUnit;
			model.MNumber=MNumber;
			model.WName=WName;

			ERP.BLL.Materials bll=new ERP.BLL.Materials();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
