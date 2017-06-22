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
namespace rr2.Web.NewInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int newId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(newId);
				}
			}
		}
			
	private void ShowInfo(int newId)
	{
		rr2.BLL.NewInfo bll=new rr2.BLL.NewInfo();
		rr2.Model.NewInfo model=bll.GetModel(newId);
		this.lblnewId.Text=model.newId.ToString();
		this.txtnewTitle.Text=model.newTitle;
		this.txtnewCoutent.Text=model.newCoutent;
		this.txttypeId.Text=model.typeId.ToString();
		this.txtuserId.Text=model.userId.ToString();
		this.txtnewTime.Text=model.newTime.ToString();
		this.txtnewNR.Text=model.newNR;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtnewTitle.Text.Trim().Length==0)
			{
				strErr+="newTitle不能为空！\\n";	
			}
			if(this.txtnewCoutent.Text.Trim().Length==0)
			{
				strErr+="newCoutent不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txttypeId.Text))
			{
				strErr+="typeId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuserId.Text))
			{
				strErr+="userId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtnewTime.Text))
			{
				strErr+="newTime格式错误！\\n";	
			}
			if(this.txtnewNR.Text.Trim().Length==0)
			{
				strErr+="newNR不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int newId=int.Parse(this.lblnewId.Text);
			string newTitle=this.txtnewTitle.Text;
			string newCoutent=this.txtnewCoutent.Text;
			int typeId=int.Parse(this.txttypeId.Text);
			int userId=int.Parse(this.txtuserId.Text);
			DateTime newTime=DateTime.Parse(this.txtnewTime.Text);
			string newNR=this.txtnewNR.Text;


			rr2.Model.NewInfo model=new rr2.Model.NewInfo();
			model.newId=newId;
			model.newTitle=newTitle;
			model.newCoutent=newCoutent;
			model.typeId=typeId;
			model.userId=userId;
			model.newTime=newTime;
			model.newNR=newNR;

			rr2.BLL.NewInfo bll=new rr2.BLL.NewInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
