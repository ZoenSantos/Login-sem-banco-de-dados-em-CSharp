using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2024_08_15_Login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if(Login1.UserName == "legal" && Login1.Password == "senha boa")
            {
                e.Authenticated = true;
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                e.Authenticated = false;
            }
        }
    }
}