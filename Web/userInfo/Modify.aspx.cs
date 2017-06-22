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
namespace rr2.Web.userInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int userId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(userId);
				}
			}
		}
			
	private void ShowInfo(int userId)
	{
		rr2.BLL.userInfo bll=new rr2.BLL.userInfo();
		rr2.Model.userInfo model=bll.GetModel(userId);
		this.lbluserId.Text=model.userId.ToString();
		this.txtuserLoginName.Text=model.userLoginName;
		this.txtuserTrueName.Text=model.userTrueName;
		this.txtuserPass.Text=model.userPass;
		this.txtuserEmail.Text=model.userEmail;
		this.txtuserTel.Text=model.userTel;
		this.txtflag.Text=model.flag.ToString();
		this.txtext1.Text=model.ext1;
		this.txtext2.Text=model.ext2;
		this.txtext3.Text=model.ext3;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuserLoginName.Text.Trim().Length==0)
			{
				strErr+="userLoginName不能为空！\\n";	
			}
			if(this.txtuserTrueName.Text.Trim().Length==0)
			{
				strErr+="userTrueName不能为空！\\n";	
			}
			if(this.txtuserPass.Text.Trim().Length==0)
			{
				strErr+="userPass不能为空！\\n";	
			}
			if(this.txtuserEmail.Text.Trim().Length==0)
			{
				strErr+="userEmail不能为空！\\n";	
			}
			if(this.txtuserTel.Text.Trim().Length==0)
			{
				strErr+="userTel不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtflag.Text))
			{
				strErr+="flag格式错误！\\n";	
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
			int userId=int.Parse(this.lbluserId.Text);
			string userLoginName=this.txtuserLoginName.Text;
			string userTrueName=this.txtuserTrueName.Text;
			string userPass=this.txtuserPass.Text;
			string userEmail=this.txtuserEmail.Text;
			string userTel=this.txtuserTel.Text;
			int flag=int.Parse(this.txtflag.Text);
			string ext1=this.txtext1.Text;
			string ext2=this.txtext2.Text;
			string ext3=this.txtext3.Text;


			rr2.Model.userInfo model=new rr2.Model.userInfo();
			model.userId=userId;
			model.userLoginName=userLoginName;
			model.userTrueName=userTrueName;
			model.userPass=userPass;
			model.userEmail=userEmail;
			model.userTel=userTel;
			model.flag=flag;
			model.ext1=ext1;
			model.ext2=ext2;
			model.ext3=ext3;

			rr2.BLL.userInfo bll=new rr2.BLL.userInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
