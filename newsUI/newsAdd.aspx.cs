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
    public partial class newsAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            rr2.Model.newsInfo curnews = new rr2.Model.newsInfo();

            curnews.userId = 18;
            curnews.typeId = int.Parse(DropDownList1.SelectedValue);
            curnews.newsTitle = TBnewsTitle.Text;
            curnews.newsReleaseTime = DateTime.Parse(TBnewsReleaseTime.Text);
            curnews.newsContent=  HttpContext.Current.Request.Form["myEditor"];
            int jg = new rr2.BLL.newsInfo().Add(curnews);
            if(jg== 0)
            {
                LabelResule.Text = "添加失败，请检查数据完整性";
            }
            else
            {
                LabelResule.Text = "添加成功！";
            }
        }
    }
}