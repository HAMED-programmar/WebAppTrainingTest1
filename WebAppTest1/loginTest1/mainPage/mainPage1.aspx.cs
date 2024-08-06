using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTest1.loginTest1.mainPage
{
    public partial class mainPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUser"] != null)
            {
                string struserid = Session["idUser"].ToString();
                if (struserid != "10")
                {
                    Response.Redirect("../error/errortest1.html", true);
                    return;
                }
            }
            else
            {
                Response.Redirect("../error/errortest1.html", true);
                return;
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Session.Remove("idUser");
            Response.Redirect("../login/login.aspx");
        }
    }
}