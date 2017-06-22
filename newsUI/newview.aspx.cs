using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rr2.Model;
using rr2.BLL;
using System.Data;
using System.Configuration;

namespace newsUI
{
    public partial class newview : System.Web.UI.Page
    {
        public rr2.Model.newsInfo curtnew = new rr2.Model.newsInfo();
        public rr2.BLL.newsInfo bllnews = new rr2.BLL.newsInfo();

        public DataTable commtable = new DataTable();
        rr2.BLL.commentInfo bllcomminfo = new rr2.BLL.commentInfo();//实例化业务逻辑，以便抽取数据到table

        public DataTable usertable = new DataTable();
         rr2.BLL.userInfo blluser = new rr2.BLL.userInfo();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            usertable = blluser.GetAllList().Tables[0];

            int newid = int.Parse(Request.QueryString["newId"]);
            curtnew = bllnews.GetModel(newid);
            
            commtable = bllcomminfo.GetList(4, "", "commentTime desc").Tables[0];
            
           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}