using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Security;

namespace ERP.BLL
{
    public class UserRole
    {
        public static string CurrentUserInfo
        {
            get
            {

                if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.AppendFormat("欢迎你:{0},你的角色是:", System.Web.HttpContext.Current.User.Identity.Name);
                    foreach (string role in Roles.GetRolesForUser())
                    {
                        sb.AppendFormat("{0},", role);
                    }
                    if (sb.ToString().EndsWith(","))
                    {
                        return sb.ToString().Substring(0, sb.ToString().Length - 1);
                    }
                    return sb.ToString();

                }
                else
                {
                    return "未登录用户";
                }
            }
        }
    }
}
