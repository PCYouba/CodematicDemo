using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rr2.Model;
using System.Data;
using rr2.BLL;

namespace newsUI
{
    public partial class zzzzz : System.Web.UI.Page
    {
        public DataTable newstable = new DataTable();
        rr2.BLL.newsInfo bllnews = new rr2.BLL.newsInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            rr2.Model.commentInfo curcomm = new rr2.Model.commentInfo();
            curcomm.newsId = int.Parse(HttpContext.Current.Request.QueryString["newid"]);
            curcomm.ownUserId = 18;
            curcomm.checkUserId = 1;
            curcomm.commentContent = HttpContext.Current.Request.Form["myEditor"];
            curcomm.commentTime = DateTime.Now;
            int jg = new rr2.BLL.commentInfo().Add(curcomm);
            if (jg==0)
            {
                LabelResule.Text = "添加失败，请检查数据完整性";
            }
            else
            {
                LabelResule.Text = "添加成功！";
            }
            //Response.Redirect("newview.aspx?ts=sucess");

        }
    }
}