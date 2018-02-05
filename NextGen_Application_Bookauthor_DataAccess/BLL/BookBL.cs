using NextGen_Application_BookAuthor;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.ModelBinding;

using System.Web.UI.WebControls;

namespace NextGen_Application_Bookauthor_DataAccess.BLL
{
    public class BookBL
    {

        BookAuthor_DataAccessLayer db;

        //constructor to intiate Db
        public BookBL()
        {
            db = new BookAuthor_DataAccessLayer();
        }


        public IQueryable<NextGen_Application_BookAuthor.Book> GetBook()
        {
            var res = db.Books.Include(s => s.author);
            return res;

        }
       


        public void UpdateBook(int bid, ModelMethodContext context)
        {
            Book item = null;
            item = db.Books.Find(bid);
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
               context.ModelState.AddModelError("", String.Format("Item with id {0} was not found", bid));
                return;
            }
            context.TryUpdateModel(item);
            if (context.ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();
                db.SaveChanges();
            }
        }

        public void DeleteBook(int bid,  ModelMethodContext context)
        {
            var item = new Book { Bid = bid };
            db.Entry(item).State = EntityState.Deleted;
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                context.ModelState.AddModelError("",
                 String.Format("Item with id {0} no longer exists in the database.", bid));
            }
        }

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





