using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTest1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Number of Applications: " + Application["TotalApplications"]);
            //Response.Write("<br/>");
            //Response.Write("Number of Users Online: " + Application["TotalUserSessions"]);
            //if (!IsPostBack)
            //{
            //    txtClick.Text = "0";
            //}
            //if (!IsPostBack)
            //{
            //    if (Session["Clicks"] == null)
            //    {
            //        Session["Clicks"] = 0;
            //    }
            //    txtClick.Text = Session["Clicks"].ToString();
            //}

            if (!IsPostBack)
            {
                if (Application["Clicks"] == null)
                {
                    Application["Clicks"] = 0;
                }
                txtClick.Text = Application["Clicks"].ToString();
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            //ClicksCount = ClicksCount + 1;
            //txtClick.Text = ClicksCount.ToString();

            //if (ViewState["Clicks"] != null)
            //{
            //    ClicksCount = (int)ViewState["Clicks"] + 1;
            //}
            //txtClick.Text = ClicksCount.ToString(); ;
            //ViewState["Clicks"] = ClicksCount;

            //int ClicksCount = Convert.ToInt32(txtClick.Text) + 1;
            //txtClick.Text = ClicksCount.ToString();

            //int ClicksCount = (int)Session["Clicks"] + 1;
            //txtClick.Text = ClicksCount.ToString();
            //Session["Clicks"] = ClicksCount;

            int ClicksCount = (int)Application["Clicks"] + 1;
            txtClick.Text = ClicksCount.ToString();
            Application["Clicks"] = ClicksCount;
        }
    }
}