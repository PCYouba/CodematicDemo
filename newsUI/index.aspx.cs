using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rr2.BLL;
using rr2.Model;
using System.Data;

namespace newsUI
{
    public partial class index : System.Web.UI.Page
    {
        public DataTable newsinfotable = new DataTable();//定义一个内存数据表，用来存储从数据库中抽取出来的数据
        rr2.BLL.newsInfo bllnewsinfo = new rr2.BLL.newsInfo();

       

        protected void Page_Load(object sender, EventArgs e)
        {
            newsinfotable = bllnewsinfo.GetList(4,"", "newsReleaseTime asc") .Tables[0];//准备好数据，前端使用

        }
    }
}