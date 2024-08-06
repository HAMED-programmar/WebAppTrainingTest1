using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppTest1.loginTest1.mainPage;

namespace WebAppTest1.loginTest1.login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnopen_Click(object sender, EventArgs e)
        {
            if (textusername.Value.Trim().ToLower() == "hhy88" &&
                password.Value.Trim().ToLower() == "1234")
            {
                Session.Add("idUser","10");
                Response.Redirect("../mainPage/mainPage1.aspx");
            }
            else
            {
                lberror.InnerHtml = "نام کاربری یا رمز ورود اشتباه است";



            }    

               
        }
    }
}