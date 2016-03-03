using System;
using System.Collections.Generic;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERP.Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Membership.CreateUser("admin", "admin");
        }

        protected void ImageButtonLogin_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (Membership.ValidateUser(this.TextBoxUserName.Text, this.TextBoxPassword.Text))
                {
                    FormsAuthentication.SetAuthCookie(this.TextBoxUserName.Text, false);

                    Response.Redirect(FormsAuthentication.DefaultUrl);
                }
                else
                {
                    this.LabelInfo.Text = "登录失败";
                }
            }
            catch (Exception ex)
            {

                this.LabelInfo.Text = ex.Message;
            }
        }
    }
}