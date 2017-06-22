using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newsUI
{
    /// <summary>
    /// del 的摘要说明
    /// </summary>
    public class del : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userid = context.Request.QueryString["userId"];
            rr2.BLL.userInfo blluser = new rr2.BLL.userInfo();
            blluser.Delete(int.Parse(userid));
            context.Response.Redirect("userList.aspx?ts=delsucess");


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