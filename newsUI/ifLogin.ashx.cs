using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newsUI
{
    /// <summary>
    /// ifLogin1 的摘要说明
    /// </summary>
    public class ifLogin1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context) /*在ProcessRequest下面写功能代码，区别于一般的处理程序*/
        {
            context.Response.ContentType = "text/plain";
            string userName = context.Request.Form["txtName"];
            string userPass = context.Request.Form["txtPassword"];
            rr2.BLL.userInfo blluser = new rr2.BLL.userInfo();
            if(blluser.Exists(userName,userPass))
            {
                context.Response.Redirect("Aindex.aspx");
            }
            else
            {
                context.Response.Write("<script>alert('请检查用户名或者密码！');window.location.href='getDemo.aspx';</script>");
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}