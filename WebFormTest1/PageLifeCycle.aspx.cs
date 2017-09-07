using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTest1
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        #region pagecycle
        //protected void Page_PreInit(object sender, EventArgs e)
        //{ Response.Write("Page_PreInit" + "<br/>"); }

        //protected void Page_Init(object sender, EventArgs e)
        //{ Response.Write("Page_Init" + "<br/>"); }

        //protected void Page_InitComplete(object sender, EventArgs e)
        //{ Response.Write("Page_InitComplete" + "<br/>"); }

        //protected void Page_PreLoad(object sender, EventArgs e)
        //{ Response.Write("Page_PreLoad" + "<br/>"); }

        //protected void Page_LoadComplete(object sender, EventArgs e)
        //{ Response.Write("Page_LoadComplete" + "<br/>"); }

        //protected void Page_PreRender(object sender, EventArgs e)
        //{ Response.Write("Page_PreRender" + "<br/>"); }

        //protected void Page_PreRenderComplete(object sender, EventArgs e)
        //{ Response.Write("Page_PreRenderComplete" + "<br/>"); }

        //protected void Page_Unload(object sender, EventArgs e)
        //{
        //    //Response.Write("Page_Unload" + "<br/>"); 
        //}
        #endregion

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit" + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init" + "<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_InitComplete" + "<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad" + "<br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page_LoadComplete" + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender" + "<br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page_PreRenderComplete" + "<br/>");
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed Event" + "<br/>");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button Click" + "<br/>");
        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {
            Response.Write("Text Changed Event" + "<br/>");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Write("Button Click" + "<br/>");
        }

        //Page_PreInit
        //Page_Init
        //Page_InitComplete
        //Page_PreLoad
        //Text Changed Event
        //Button Click
        //Page_LoadComplete
        //Page_PreRender
        //Page_PreRenderComplete
    }
}