using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newsUI
{
    public partial class AspNethtml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string userName = Request.QueryString["Text1"];
            string userPass = Request.QueryString["Text2"];
            Response.Write(string.Format("通过get提交用户名：{0},密码：{1}", userName, userPass));
        }
    }
}