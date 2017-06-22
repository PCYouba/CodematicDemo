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
namespace rr2.Web.typeInfo
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
					int typeId=(Convert.ToInt32(strid));
					ShowInfo(typeId);
				}
			}
		}
		
	private void ShowInfo(int typeId)
	{
		rr2.BLL.typeInfo bll=new rr2.BLL.typeInfo();
		rr2.Model.typeInfo model=bll.GetModel(typeId);
		this.lbltypeId.Text=model.typeId.ToString();
		this.lbltypeName.Text=model.typeName;
		this.lblext1.Text=model.ext1;
		this.lblext2.Text=model.ext2;
		this.lblext3.Text=model.ext3;

	}


    }
}
