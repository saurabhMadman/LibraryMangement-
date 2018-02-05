using NextGen_Application_BookAuthor;
using NextGen_Application_Bookauthor_DataAccess;
using NextGen_Application_Bookauthor_ForntEnd;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace NextGen_Application_Bookauthor_ForntEnd
{
    public partial class authorUI : System.Web.UI.Page
    {
        BookAuthor_DataAccessLayer db;

//Constructor initializing DbLayer

          public authorUI()
           {
             db = new BookAuthor_DataAccessLayer();
           }
        
//page load

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Author_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject = new NextGen_Application_Bookauthor_DataAccess.BLL.AuthorBL();
        }
    }
}