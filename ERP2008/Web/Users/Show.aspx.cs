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
namespace ERP.Web.Users
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int UID=(Convert.ToInt32(strid));
					ShowInfo(UID);
				}
			}
		}
		
	private void ShowInfo(int UID)
	{
		ERP.BLL.Users bll=new ERP.BLL.Users();
		ERP.Model.Users model=bll.GetModel(UID);
		this.lblUID.Text=model.UID.ToString();
		this.lblUName.Text=model.UName;
		this.lblUPwd.Text=model.UPwd;
		this.lblUGender.Text=model.UGender;
		this.lblULevel.Text=model.ULevel;
		this.lblUPhone.Text=model.UPhone;
		this.lblUEmail.Text=model.UEmail;

	}


    }
}
