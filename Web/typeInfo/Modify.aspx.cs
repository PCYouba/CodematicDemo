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
namespace rr2.Web.typeInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int typeId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(typeId);
				}
			}
		}
			
	private void ShowInfo(int typeId)
	{
		rr2.BLL.typeInfo bll=new rr2.BLL.typeInfo();
		rr2.Model.typeInfo model=bll.GetModel(typeId);
		this.lbltypeId.Text=model.typeId.ToString();
		this.txttypeName.Text=model.typeName;
		this.txtext1.Text=model.ext1;
		this.txtext2.Text=model.ext2;
		this.txtext3.Text=model.ext3;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txttypeName.Text.Trim().Length==0)
			{
				strErr+="typeName不能为空！\\n";	
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
			int typeId=int.Parse(this.lbltypeId.Text);
			string typeName=this.txttypeName.Text;
			string ext1=this.txtext1.Text;
			string ext2=this.txtext2.Text;
			string ext3=this.txtext3.Text;


			rr2.Model.typeInfo model=new rr2.Model.typeInfo();
			model.typeId=typeId;
			model.typeName=typeName;
			model.ext1=ext1;
			model.ext2=ext2;
			model.ext3=ext3;

			rr2.BLL.typeInfo bll=new rr2.BLL.typeInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
