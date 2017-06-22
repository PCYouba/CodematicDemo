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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
