using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rr2.BLL;
using System.Data;
using System.Configuration;

namespace newsUI
{
    public partial class consulting : System.Web.UI.Page
    {
      public   class pageInfo
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
        public DataTable newsinfotable = new DataTable();//定义数据表以便存储数据
      
        public pageInfo pi;
       
        rr2.BLL.newsInfo bllnewsinfo = new rr2.BLL.newsInfo();//实例化业务逻辑，以便抽取数据到newsinfotable
     
       

        protected void Page_Load(object sender, EventArgs e)
        {
            //计算总页数
            pi = pageCount();
            if(Request.QueryString["page"]== null)
            {
                pi.pageindex = 1;
            }
            else
            {
                pi.pageindex = int.Parse(Request.QueryString["page"]);
            }
            newsinfotable = bllnewsinfo.GetList(pi.pagesize, pi.pageindex,"").Tables[0];


            //控件显示页数
            for (int i = 1; i <= pi.pagecount; i++)
            {
               

                DropDownList1.Items.Add(i.ToString());
            }

           
           

        }
       

        public  pageInfo pageCount()//计算总页数
        {
            pageInfo pi = new pageInfo();
            pi.totalcount = bllnewsinfo.GetRecordCount("");//获取数据总条数
            pi.pagesize = int.Parse(ConfigurationManager.AppSettings["pagesize"]);
            //int pagecount = 总条数%每页条数 ==0 ？ 总条数/每页条数 ：总条数/每页条数　＋１
            pi.pagecount = pi.totalcount % pi.pagesize == 0 ? pi.totalcount / pi.pagesize : pi.totalcount / pi.pagesize + 1;

            return pi;
        }


      

        protected void Button1_Click(object sender, EventArgs e)
        {

           
            //跳转
            Response.Redirect("consulting.aspx?page=" + DropDownList1.SelectedItem.Text);


        }
    }
}