using NextGen_Application_Bookauthor_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace NextGen_Application_Bookauthor_ForntEnd
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["TotalApplications"] = 0;

            Application["TotalUserSessions"] = 0;
            // Increment TotalApplications by 1

            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
       
        // Create Application state variables
    


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