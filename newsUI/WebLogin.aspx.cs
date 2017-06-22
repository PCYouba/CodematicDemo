using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace newsUI
{
    public partial class WebLogin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
                

        }

        protected void ButOK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server=.;database=Newsdb;uid=sa;pwd=123");
                conn.Open();
                SqlCommand com = new SqlCommand(@"select userLoginName,userPass from  userInfo where userLoginName = @userLoginName AND userPass = @userPass", conn);

                SqlParameter sParams1 = new SqlParameter("@userLoginName", TBname.Text);
                SqlParameter sParams2 = new SqlParameter("@userPass", TBPassword.Text);
               
                com.Parameters.Add(sParams1);
                com.Parameters.Add(sParams2);
                SqlDataReader red = com.ExecuteReader();
                if (red.Read())
                {
                    Response.Redirect("Aindex.aspx");

                }
                else
                {
                    //LblTishi.Text = "登录失败，请检查用户名或密码";
                    //Response.Write("登录失败");
                    Response.Write("<script>alert('请你检查你的登录名与密码是否正确！')</script>");

                }
                red.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        protected void Buttjump_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void TBname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Butsign_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reg.aspx");
        }


    }
}