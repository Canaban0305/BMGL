using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMGL.UI
{
    public partial class Hpage123 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('" + Session["LoginUser"] + "');</script>");
        }

        protected void btnregister_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Login.html");
        }
    }
}