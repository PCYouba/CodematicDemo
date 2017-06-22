using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newsUI
{
    public partial class updatetype : System.Web.UI.Page
    {
        rr2.Model.typeInfo mdltype = new rr2.Model.typeInfo();
        rr2.BLL.typeInfo blltype = new rr2.BLL.typeInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            string typeid = Request.QueryString["typeId"];
            if (!IsPostBack)
            {
                mdltype = blltype.GetModel(int.Parse(typeid));
                TBtype.Text = mdltype.typeName;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //把界面修改过的内容放置到实体对象
            mdltype.typeId = int.Parse(Request.QueryString["typeId"]);
            mdltype.typeName = TBtype.Text;
            //把新信息传给业务逻辑更新到数据库
            blltype.Update(mdltype);
            Response.Redirect("typeQuery.aspx?ts=upsucess");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("typeQuery.aspx");
        }
    }
}