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
namespace rr2.Web.NewInfo
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
					int newId=(Convert.ToInt32(strid));
					ShowInfo(newId);
				}
			}
		}
		
	private void ShowInfo(int newId)
	{
		rr2.BLL.NewInfo bll=new rr2.BLL.NewInfo();
		rr2.Model.NewInfo model=bll.GetModel(newId);
		this.lblnewId.Text=model.newId.ToString();
		this.lblnewTitle.Text=model.newTitle;
		this.lblnewCoutent.Text=model.newCoutent;
		this.lbltypeId.Text=model.typeId.ToString();
		this.lbluserId.Text=model.userId.ToString();
		this.lblnewTime.Text=model.newTime.ToString();
		this.lblnewNR.Text=model.newNR;

	}


    }
}
