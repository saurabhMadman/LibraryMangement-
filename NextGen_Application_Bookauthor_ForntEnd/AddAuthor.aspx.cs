using NextGen_Application_BookAuthor;
using NextGen_Application_Bookauthor_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NextGen_Application_Bookauthor_ForntEnd
{
    public partial class AddAuthor : System.Web.UI.Page
    {
        BookAuthor_DataAccessLayer db;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
//Constructor 
        public AddAuthor()
        {
            db = new BookAuthor_DataAccessLayer();
        }

//Insert method 
        //Using TryUpdateModel():- Updates the specified model instance using values from the data-bound control.
        // Parameters:
        //   model:
        //     The model.
        //
        // Type parameters:
        //   TModel:
        //     The type of the model

        public void FormView1_InsertItem()
        {
            var item = new Author();
            TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                  db.Authors.Add(item);
                  db.SaveChanges();
            }
        }

//if values inserted then page is redirected
        protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/authorUI");
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/authorUI");
        }
    }
}