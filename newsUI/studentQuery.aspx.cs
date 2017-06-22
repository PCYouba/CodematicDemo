using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rr2.Model;
using rr2.BLL;

namespace newsUI
{
    public partial class studentQuery : System.Web.UI.Page
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
            if(jg == 0)
            {
                LabelResule.Text = "添加失败，请检查数据完整性";

            }
            else
            {
                LabelResule.Text = "添加成功！！";
            }


        }
    }
}