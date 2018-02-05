namespace NextGen_Application_Bookauthor_DataAccess.Migrations
{
    using NextGen_Application_BookAuthor;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NextGen_Application_Bookauthor_DataAccess.BookAuthor_DataAccessLayer>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NextGen_Application_Bookauthor_DataAccess.BookAuthor_DataAccessLayer context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Books.AddOrUpdate(
                new Book
                {
                    BookName = "DataStrutureAndAlgorithum",
                    Genre = "computerscience",
                    Publication = "Pson",
                    Description = "Engineering ComputerScience book",
                    AuthorId=1
                });
            context.SaveChanges();

            context.Authors.AddOrUpdate(
                new Author
                {
                    FistName = "DataStrutureAndAlgorithum",
                    LastName = "computerscience",
                    Url = "www.peson.com",
             
                });
            context.SaveChanges();

        }
    }
}
