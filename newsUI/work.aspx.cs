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
    public partial class work : System.Web.UI.Page
    {
        public DataTable newstableweibo = new DataTable();//定义一个内存数据表，用来存储从数据库中抽取出来的数据
        public DataTable newstableweixin = new DataTable();
        public DataTable newstableruanwen = new DataTable();
        public DataTable newstablemeiti = new DataTable();
        rr2.BLL.newsInfo bllnewsinfo = new rr2.BLL.newsInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            newstableweibo = bllnewsinfo.GetList(2, "typeId=1", "newsReleaseTime desc").Tables[0];//准备好数据，前端使用
            newstableweixin = bllnewsinfo.GetList(2, "typeId=2", "newsReleaseTime desc").Tables[0];//准备好数据，前端使用
            newstableruanwen = bllnewsinfo.GetList(2, "typeId=3", "newsReleaseTime desc").Tables[0];//准备好数据，前端使用
            newstablemeiti = bllnewsinfo.GetList(2, "typeId=4", "newsReleaseTime desc").Tables[0];//准备好数据，前端使用
        }
    }
}