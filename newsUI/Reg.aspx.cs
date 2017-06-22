using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newsUI
{
    public partial class Reg : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            rr2.Model.userInfo curuser = new rr2.Model.userInfo();
            curuser.userLoginName = TBusername.Text;
            curuser.userTrueName = TBuserTrue.Text;
            curuser.userPass = TBuserpwd.Text;
            curuser.userEmail = TBuserEmail.Text;
            curuser.userTel = TBuserTel.Text;
            curuser.flag = int.Parse(DropDownList1.SelectedValue);
            int jg = new rr2.BLL.userInfo().Add(curuser);
            if (jg == 0)
            {
                LblTishi.Text = "注册失败，请检查数据完整性";

            }
            else
            {
                LblTishi.Text = "注册成功！！";
               
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebLogin.aspx");
        }
    }
}