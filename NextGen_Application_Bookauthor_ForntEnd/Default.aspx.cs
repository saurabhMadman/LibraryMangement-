using NextGen_Application_Bookauthor_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NextGen_Application_Bookauthor_ForntEnd
{
    public partial class _Default : Page
    {
        BookAuthor_DataAccessLayer db = new BookAuthor_DataAccessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Number of Applications: " + Application["TotalApplications"]);
            Response.Write("<br/>");
            Response.Write("Number of Users Online: " + Application["TotalUserSessions"]);

        }
      
        //TotalApplications and TotalUserSession are Application varibale which used to tarce session opertion.
    }
}