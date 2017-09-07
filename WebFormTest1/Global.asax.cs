using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebFormTest1
{
    public class Global : System.Web.HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Create Application state variables
            Application["TotalApplications"] = 0;
            Application["TotalUserSessions"] = 0;
            // Increment TotalApplications by 1
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
        }
        void Session_Start(object sender, EventArgs e)
        {
            // Increment TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            // Decrement TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] - 1;
        }
    }
}