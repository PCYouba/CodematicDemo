using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace rr2.Web.newsInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtuserId.Text))
			{
				strErr+="userId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTypeId.Text))
			{
				strErr+="typeId格式错误！\\n";	
			}
			if(this.txtnewsTitle.Text.Trim().Length==0)
			{
				strErr+="newsTitle不能为空！\\n";	
			}
			if(this.txtnewsContent.Text.Trim().Length==0)
			{
				strErr+="newsContent不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtnewsCount.Text))
			{
				strErr+="newsCount格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtnewsReleaseTime.Text))
			{
				strErr+="newsReleaseTime格式错误！\\n";	
			}
			if(this.txtext1.Text.Trim().Length==0)
			{
				strErr+="ext1不能为空！\\n";	
			}
			if(this.txtext2.Text.Trim().Length==0)
			{
				strErr+="ext2不能为空！\\n";	
			}
			if(this.txtext3.Text.Trim().Length==0)
			{
				strErr+="ext3不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int userId=int.Parse(this.txtuserId.Text);
			int typeId=int.Parse(this.txtTypeId.Text);
			string newsTitle=this.txtnewsTitle.Text;
			string newsContent=this.txtnewsContent.Text;
			int newsCount=int.Parse(this.txtnewsCount.Text);
			DateTime newsReleaseTime=DateTime.Parse(this.txtnewsReleaseTime.Text);
			string ext1=this.txtext1.Text;
			string ext2=this.txtext2.Text;
			string ext3=this.txtext3.Text;

			rr2.Model.newsInfo model=new rr2.Model.newsInfo();
			model.userId=userId;
			model.typeId=typeId;
			model.newsTitle=newsTitle;
			model.newsContent=newsContent;
			model.newsCount=newsCount;
			model.newsReleaseTime=newsReleaseTime;
			model.ext1=ext1;
			model.ext2=ext2;
			model.ext3=ext3;

			rr2.BLL.newsInfo bll=new rr2.BLL.newsInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
