﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;


namespace newsUI
{
    public partial class newsQuery : System.Web.UI.Page
    {
        public class pageInfo
        {/// <summary>
         /// 每页条数
         /// </summary>
            public int pagesize { get; set; }
            /// <summary>
            /// 总页数
            /// </summary>
            public int pagecount { get; set; }
            /// <summary>
            /// 当前页码
            /// </summary>
            public int pageindex { get; set; }
            /// <summary>
            /// 总条数
            /// </summary>
            public int totalcount { get; set; }

            public int num { get; set; }

        }
        public DataTable newstable = new DataTable();//定义数据表以便存储数据
        rr2.Model.newsInfo mdlnews = new rr2.Model.newsInfo();
        rr2.BLL.newsInfo bllnewsinfo = new rr2.BLL.newsInfo();//实例化业务逻辑，以便抽取数据到newstable

        public DataTable usertable = new DataTable();//定义数据表以便存储数据 显示发布人
        rr2.BLL.userInfo blluser = new rr2.BLL.userInfo();
        public pageInfo pi;


        protected void Page_Load(object sender, EventArgs e)
        {
            usertable = blluser.GetAllList().Tables[0];//用户表
            //计算总页数
            pi = pageCount();
            if (Request.QueryString["page"] == null)
            {
                pi.pageindex = 1;
            }
            else
            {
                pi.pageindex = int.Parse(Request.QueryString["page"]);
            }
            newstable = bllnewsinfo.GetList(pi.pagesize, pi.pageindex, "").Tables[0];//新闻表
          


        }

        public pageInfo pageCount()//计算总页数
        {
            pageInfo pi = new pageInfo();
            pi.totalcount = bllnewsinfo.GetRecordCount("");//获取数据总条数
            pi.pagesize = int.Parse(ConfigurationManager.AppSettings["pagesize"]);
            //int pagecount = 总条数%每页条数 ==0 ？ 总条数/每页条数 ：总条数/每页条数　＋１
            pi.pagecount = pi.totalcount % pi.pagesize == 0 ? pi.totalcount / pi.pagesize : pi.totalcount / pi.pagesize + 1;

            return pi;
        }
    }
}