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
namespace rr2.Web.newsInfo
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
					int newsId=(Convert.ToInt32(strid));
					ShowInfo(newsId);
				}
			}
		}
		
	private void ShowInfo(int newsId)
	{
		rr2.BLL.newsInfo bll=new rr2.BLL.newsInfo();
		rr2.Model.newsInfo model=bll.GetModel(newsId);
		this.lblnewsId.Text=model.newsId.ToString();
		this.lbluserId.Text=model.userId.ToString();
		this.lblTypeId.Text=model.typeId.ToString();
		this.lblnewsTitle.Text=model.newsTitle;
		this.lblnewsContent.Text=model.newsContent;
		this.lblnewsCount.Text=model.newsCount.ToString();
		this.lblnewsReleaseTime.Text=model.newsReleaseTime.ToString();
		this.lblext1.Text=model.ext1;
		this.lblext2.Text=model.ext2;
		this.lblext3.Text=model.ext3;

	}


    }
}
