using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newsUI
{
    /// <summary>
    /// typedel 的摘要说明
    /// </summary>
    public class typedel : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string typeid = context.Request.QueryString["typeId"];
            rr2.BLL.typeInfo blltype = new rr2.BLL.typeInfo();
            blltype.Delete(int.Parse(typeid));
            context.Response.Redirect("typeQuery.aspx?ts=delsucess");


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