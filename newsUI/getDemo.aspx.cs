using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newsUI
{
    public partial class getDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region get提交
            //string userName = Request.QueryString["txtName"];
            //string userPass = Request.QueryString["txtPassword"];
            //Response.Write(string.Format("通过get提交用户名：{0},密码：{1}", userName, userPass));
            #endregion

            #region post提交
            string userName = Request.Form["txtName"];
            string userPass = Request.Form["txtPassword"];
            Response.Write(string.Format("通过post提交用户名：{0},密码：{1}", userName, userPass));
            #endregion
        }
    }
}