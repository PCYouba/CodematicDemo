using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newsUI
{
    /// <summary>
    /// commdel 的摘要说明
    /// </summary>
    public class commdel : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string commentid = context.Request.QueryString["commentId"];
            rr2.BLL.commentInfo bllcomment = new rr2.BLL.commentInfo();
            bllcomment.Delete(int.Parse(commentid));
            context.Response.Redirect("comment.aspx?ts=delsucess");
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