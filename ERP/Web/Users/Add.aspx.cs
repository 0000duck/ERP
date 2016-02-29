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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string UName=this.txtUName.Text;
			string UPwd=this.txtUPwd.Text;
			string UGender=this.txtUGender.Text;
			string ULevel=this.txtULevel.Text;
			string UPhone=this.txtUPhone.Text;
			string UEmail=this.txtUEmail.Text;

			ERP.Model.Users model=new ERP.Model.Users();
			model.UName=UName;
			model.UPwd=UPwd;
			model.UGender=UGender;
			model.ULevel=ULevel;
			model.UPhone=UPhone;
			model.UEmail=UEmail;

			ERP.BLL.Users bll=new ERP.BLL.Users();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
