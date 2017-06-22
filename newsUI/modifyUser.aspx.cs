using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newsUI
{
    public partial class modifyUser : System.Web.UI.Page
    {
        rr2.Model.userInfo mdluser = new rr2.Model.userInfo();
        rr2.BLL.userInfo blluser = new rr2.BLL.userInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            string userid = Request.QueryString["userId"];//从地址栏获取传过来的值
            if(!IsPostBack)//回传提交，如果不是第一次执行，则不走这段代码
            { 
            mdluser = blluser.GetModel(int.Parse(userid));
            TBusername.Text = mdluser.userLoginName;
            TBuserTrue.Text = mdluser.userTrueName;
            TBuserpwd.Text = mdluser.userPass;
            TBuserEmail.Text = mdluser.userEmail;
            TBuserTel.Text = mdluser.userTel;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //1.把界面修改过的内容放置到实体对象
            mdluser.userId = int.Parse(Request.QueryString["userId"]);
            mdluser.userLoginName = TBusername.Text;
            mdluser.userTrueName = TBuserTrue.Text;
            mdluser.userPass = TBuserpwd.Text;
            mdluser.userEmail = TBuserEmail.Text;
            mdluser.userTel = TBuserTel.Text;
            mdluser.flag = int.Parse(DropDownList1.SelectedValue);
            //2.把新的信息 传给业务逻辑更新到数据库
           
                blluser.Update(mdluser);
                Response.Redirect("userList.aspx?s=upsucess");
               
           
           

        }
    }
}