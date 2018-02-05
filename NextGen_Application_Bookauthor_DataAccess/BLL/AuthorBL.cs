using NextGen_Application_BookAuthor;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI.WebControls;

namespace NextGen_Application_Bookauthor_DataAccess.BLL
{
    public class AuthorBL
    {
        BookAuthor_DataAccessLayer db;

        //Constructor initializing DbLayer

        public AuthorBL()
        {
            db = new BookAuthor_DataAccessLayer();
        }

        //page load

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //method to Get Data from Author Table
        //return type IQueryAble

        public IQueryable<NextGen_Application_BookAuthor.Author> GetAuthor()
        {
            var res = db.Authors;
            return res;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        //what find() method is doing: Finds an entity with the given primary key values. If an entity with the given
        //     primary key values exists in the context, then it is returned immediately without
        //     making a request to the store. Otherwise, a request is made to the store for
        //     an entity with the given primary key values and this entity, if found, is attached
        //     to the context and returned. If no entity is found in the context or the store,
        //     then null is returned.

        public void UpdateAuthor(int aid, ModelMethodContext context)
        {
            Author item = null;
            item = db.Authors.Find(aid);
            if (item == null)
            {
                // The item wasn't found
               context.ModelState.AddModelError("", String.Format("Item with id {0} was not found", aid));
                return;
            }
           context.TryUpdateModel(item);
            if (context.ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();
                db.SaveChanges();
            }

        }

 //Delete Method
        // The id parameter name should match the DataKeyNames value set on the control
        //Delete Method
        //state():-Gets or sets the state of the entity.
        //Entry():-Gets a System.Data.Entity.Infrastructure.DbEntityEntry`1 object for the given
        //     entity providing access to information about the entity and the ability to perform
        //     actions on the entity.
        //
        // Parameters:
        //   entity:
        //     The entity.
        //
        //EntityStates.Delete.
        //Describes the state of an entity.
        //
 //     The entity is being tracked by the context and exists in the database, but has
 //     been marked for deletion from the database the next time SaveChanges is called.

        public void DeleteAuthor(int aid, ModelMethodContext context)
        {

            var item = new Author { Aid = aid };

            db.Entry(item).State = EntityState.Deleted;
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                context.ModelState.AddModelError("",
                   String.Format("Item with id {0} no longer exists in the database.", aid));
            }
        }
//Insert book
        public void InsertBook(ModelMethodContext context)
        {
            var item = new Book();

            context.TryUpdateModel(item);
            if (context.ModelState.IsValid)
            {
                db.Books.Add(item);
                db.SaveChanges();
            }
        }
    }
    
}