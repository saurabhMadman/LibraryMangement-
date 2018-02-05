using NextGen_Application_BookAuthor;
using NextGen_Application_Bookauthor_DataAccess;
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
    public partial class book : System.Web.UI.Page
    {
        BookAuthor_DataAccessLayer db;

//constructor to intiate Db
        public book()
        {
             db = new BookAuthor_DataAccessLayer();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Book_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject = new NextGen_Application_Bookauthor_DataAccess.BLL.BookBL();
        }


    }
}

        