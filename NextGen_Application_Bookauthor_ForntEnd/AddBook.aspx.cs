using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NextGen_Application_Bookauthor_DataAccess;
using NextGen_Application_BookAuthor;

namespace NextGen_Application_Bookauthor_ForntEnd
{
    public partial class AddBook : System.Web.UI.Page
    {
        BookAuthor_DataAccessLayer db;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
//Construtor
        public AddBook()
        {
            db = new BookAuthor_DataAccessLayer();
        }

        //Insert Method
        //using TryUpdateMethod():  Updates the model instance using values from the specified value provider.
        //
        // Parameters:
        //   model:
        //     The model.
        //
        public void FormView1_InsertItem()
        {
            var item = new Book();
            
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
               
                 db.Books.Add(item);
                  db.SaveChanges();    
            }
        }

//In both the casess if Inserted operation performed page will be redirect to book page which contain the data.

        protected void cancel_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Book");
        }

        protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Book");
        }
    }
}