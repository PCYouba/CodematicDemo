using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using rr2.BLL;
using rr2.Model;
using System.Data;
using System.Configuration;
namespace newsUI
{
    /// <summary>
    /// newsdel 的摘要说明
    /// </summary>
    public class newsdel : IHttpHandler
    {
        public DataSet commtable = new DataSet();
        public rr2.BLL.commentInfo bllcomm = new rr2.BLL.commentInfo();
        public rr2.BLL.newsInfo bllnews = new rr2.BLL.newsInfo();
       
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string newsid = context.Request.QueryString["newsId"];
            
            if (bllcomm.Exists(int.Parse(newsid)) == false)
            {

                 bllnews.Delete(int.Parse(newsid));
                 context.Response.Redirect("newsQuery.aspx?ts=delsucess");
            }
           
            else
            {
                HttpContext.Current.Response.Write("该新闻下有评论,请先删除评论！");

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