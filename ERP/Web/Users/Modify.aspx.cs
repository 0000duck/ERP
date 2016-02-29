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
namespace ERP.Web.Users
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int UID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(UID);
				}
			}
		}
			
	private void ShowInfo(int UID)
	{
		ERP.BLL.Users bll=new ERP.BLL.Users();
		ERP.Model.Users model=bll.GetModel(UID);
		this.lblUID.Text=model.UID.ToString();
		this.txtUName.Text=model.UName;
		this.txtUPwd.Text=model.UPwd;
		this.txtUGender.Text=model.UGender;
		this.txtULevel.Text=model.ULevel;
		this.txtUPhone.Text=model.UPhone;
		this.txtUEmail.Text=model.UEmail;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUName.Text.Trim().Length==0)
			{
				strErr+="UName不能为空！\\n";	
			}
			if(this.txtUPwd.Text.Trim().Length==0)
			{
				strErr+="UPwd不能为空！\\n";	
			}
			if(this.txtUGender.Text.Trim().Length==0)
			{
				strErr+="UGender不能为空！\\n";	
			}
			if(this.txtULevel.Text.Trim().Length==0)
			{
				strErr+="ULevel不能为空！\\n";	
			}
			if(this.txtUPhone.Text.Trim().Length==0)
			{
				strErr+="UPhone不能为空！\\n";	
			}
			if(this.txtUEmail.Text.Trim().Length==0)
			{
				strErr+="UEmail不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UID=int.Parse(this.lblUID.Text);
			string UName=this.txtUName.Text;
			string UPwd=this.txtUPwd.Text;
			string UGender=this.txtUGender.Text;
			string ULevel=this.txtULevel.Text;
			string UPhone=this.txtUPhone.Text;
			string UEmail=this.txtUEmail.Text;


			ERP.Model.Users model=new ERP.Model.Users();
			model.UID=UID;
			model.UName=UName;
			model.UPwd=UPwd;
			model.UGender=UGender;
			model.ULevel=ULevel;
			model.UPhone=UPhone;
			model.UEmail=UEmail;

			ERP.BLL.Users bll=new ERP.BLL.Users();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
