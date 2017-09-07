using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTest1
{
    public partial class IsPostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCity.Items.Clear();
                LoadCityDropDownList();
            }
        }
        public void LoadCityDropDownList()
        {
            ListItem li1 = new ListItem("London");
            ddlCity.Items.Add(li1);

            ListItem li2 = new ListItem("Sydney");
            ddlCity.Items.Add(li2);

            ListItem li3 = new ListItem("Mumbai");
            ddlCity.Items.Add(li3);
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
        }
    }
}