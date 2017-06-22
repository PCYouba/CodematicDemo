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
namespace rr2.Web.commentInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int commentId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(commentId);
				}
			}
		}
			
	private void ShowInfo(int commentId)
	{
		rr2.BLL.commentInfo bll=new rr2.BLL.commentInfo();
		rr2.Model.commentInfo model=bll.GetModel(commentId);
		this.lblcommentId.Text=model.commentId.ToString();
		this.txtnewsId.Text=model.newsId.ToString();
		this.txtownUserId.Text=model.ownUserId.ToString();
		this.txtcheckUserId.Text=model.checkUserId.ToString();
		this.txtcommentContent.Text=model.commentContent;
		this.txtcommentTime.Text=model.commentTime.ToString();
		this.txtext1.Text=model.ext1;
		this.txtext2.Text=model.ext2;
		this.txtext3.Text=model.ext3;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtnewsId.Text))
			{
				strErr+="newsId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtownUserId.Text))
			{
				strErr+="ownUserId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheckUserId.Text))
			{
				strErr+="checkUserId格式错误！\\n";	
			}
			if(this.txtcommentContent.Text.Trim().Length==0)
			{
				strErr+="commentContent不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcommentTime.Text))
			{
				strErr+="commentTime格式错误！\\n";	
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
			int commentId=int.Parse(this.lblcommentId.Text);
			int newsId=int.Parse(this.txtnewsId.Text);
			int ownUserId=int.Parse(this.txtownUserId.Text);
			int checkUserId=int.Parse(this.txtcheckUserId.Text);
			string commentContent=this.txtcommentContent.Text;
			DateTime commentTime=DateTime.Parse(this.txtcommentTime.Text);
			string ext1=this.txtext1.Text;
			string ext2=this.txtext2.Text;
			string ext3=this.txtext3.Text;


			rr2.Model.commentInfo model=new rr2.Model.commentInfo();
			model.commentId=commentId;
			model.newsId=newsId;
			model.ownUserId=ownUserId;
			model.checkUserId=checkUserId;
			model.commentContent=commentContent;
			model.commentTime=commentTime;
			model.ext1=ext1;
			model.ext2=ext2;
			model.ext3=ext3;

			rr2.BLL.commentInfo bll=new rr2.BLL.commentInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
