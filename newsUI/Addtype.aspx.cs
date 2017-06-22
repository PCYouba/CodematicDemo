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
    public partial class Addtype : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            rr2.Model.typeInfo curtype = new rr2.Model.typeInfo();
            curtype.typeName = TBtype.Text;
            int jg = new rr2.BLL.typeInfo().Add(curtype);
            if (jg == 0)
            {
                LabelResule.Text = "添加失败，请检查后重试！";
            }

            else
            {
                LabelResule.Text = "添加成功！";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("typeQuery.aspx");
        }

       

    }
}