using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NextGen_Application_BookAuthor;




namespace NextGen_Application_Bookauthor_DataAccess
{
    public class BookAuthor_DataAccessLayer: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}