using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newsUI
{
    public partial class ifLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.Form["txtName"];
            string userPass = Request.Form["txtPassword"];
            rr2.BLL.userInfo blluser = new rr2.BLL.userInfo();
            if(blluser.Exists(userName,userPass))
            {
                Response.Redirect("Aindex.aspx");
            }
            else
            {
                Response.Write("<script>alert('请检查用户名和密码是否正确');window.location.href='getDemo.aspx'</script>");
            }
        }
    }
}