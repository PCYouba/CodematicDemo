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
namespace rr2.Web.commentInfo
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
					int commentId=(Convert.ToInt32(strid));
					ShowInfo(commentId);
				}
			}
		}
		
	private void ShowInfo(int commentId)
	{
		rr2.BLL.commentInfo bll=new rr2.BLL.commentInfo();
		rr2.Model.commentInfo model=bll.GetModel(commentId);
		this.lblcommentId.Text=model.commentId.ToString();
		this.lblnewsId.Text=model.newsId.ToString();
		this.lblownUserId.Text=model.ownUserId.ToString();
		this.lblcheckUserId.Text=model.checkUserId.ToString();
		this.lblcommentContent.Text=model.commentContent;
		this.lblcommentTime.Text=model.commentTime.ToString();
		this.lblext1.Text=model.ext1;
		this.lblext2.Text=model.ext2;
		this.lblext3.Text=model.ext3;

	}


    }
}
