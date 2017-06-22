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
namespace rr2.Web.userInfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int userId=(Convert.ToInt32(strid));
					ShowInfo(userId);
				}
			}
		}
		
	private void ShowInfo(int userId)
	{
		rr2.BLL.userInfo bll=new rr2.BLL.userInfo();
		rr2.Model.userInfo model=bll.GetModel(userId);
		this.lbluserId.Text=model.userId.ToString();
		this.lbluserLoginName.Text=model.userLoginName;
		this.lbluserTrueName.Text=model.userTrueName;
		this.lbluserPass.Text=model.userPass;
		this.lbluserEmail.Text=model.userEmail;
		this.lbluserTel.Text=model.userTel;
		this.lblflag.Text=model.flag.ToString();
		this.lblext1.Text=model.ext1;
		this.lblext2.Text=model.ext2;
		this.lblext3.Text=model.ext3;

	}


    }
}
