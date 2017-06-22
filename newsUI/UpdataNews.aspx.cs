using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newsUI
{
    public partial class UpdataNews : System.Web.UI.Page
    {
        rr2.Model.newsInfo mdlnews = new rr2.Model.newsInfo();
        rr2.BLL.newsInfo bllnews = new rr2.BLL.newsInfo();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            string newsid = Request.QueryString["newsId"];//从地址栏获取传过来的值
            if (!IsPostBack)//回传提交，如果不是第一次执行，则不走这段代码
            {
                mdlnews = bllnews.GetModel(int.Parse(newsid));
                UserId.Value = newsid;
                TBnewsContent.Text = mdlnews.newsContent;
                TBnewType.Text = mdlnews.typeId.ToString();
                TBnewsTitle.Text = mdlnews.newsTitle;
                TBnewsUser.Text = mdlnews.userId.ToString();
                TBnewsReleaseTime.Text = mdlnews.newsReleaseTime.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //1.把界面修改过的内容放置到实体对象
         mdlnews.newsId = int.Parse(UserId.Value);
            mdlnews.typeId = int.Parse(TBnewType.Text);
            mdlnews.newsTitle = TBnewsTitle.Text;
            mdlnews.newsContent = TBnewsContent.Text;
            mdlnews.typeId = int.Parse(TBnewsUser.Text);
            mdlnews.newsReleaseTime =DateTime.Parse(TBnewsReleaseTime.Text);

            //2.把新的信息，传给业务逻辑更新到数据库
            bllnews.Update(mdlnews);
            Response.Redirect("newsQuery.aspx");
        }

        protected void HiddenField1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}