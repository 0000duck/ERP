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
namespace ERP.Web.Materials
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
					int MID=(Convert.ToInt32(strid));
					ShowInfo(MID);
				}
			}
		}
		
	private void ShowInfo(int MID)
	{
		ERP.BLL.Materials bll=new ERP.BLL.Materials();
		ERP.Model.Materials model=bll.GetModel(MID);
		this.lblMID.Text=model.MID.ToString();
		this.lblMCode.Text=model.MCode.ToString();
		this.lblMName.Text=model.MName;
		this.lblMModel.Text=model.MModel;
		this.lblMMaterial.Text=model.MMaterial;
		this.lblMStandard.Text=model.MStandard;
		this.lblMUnit.Text=model.MUnit;
		this.lblMNumber.Text=model.MNumber.ToString();
		this.lblWName.Text=model.WName;

	}


    }
}
