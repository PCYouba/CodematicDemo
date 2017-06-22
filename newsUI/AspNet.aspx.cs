using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newsUI
{
    public partial class AspNet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string userName = Request.Form["TextBox1"];
            string userPass = Request.Form["TextBox2"];
            Response.Write(string.Format("通过post提交用户名：{0},密码：{1}", userName, userPass));


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}