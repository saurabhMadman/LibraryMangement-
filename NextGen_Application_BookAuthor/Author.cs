using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NextGen_Application_BookAuthor
{
    [Table("Authors")]
    public class Author

    {
        [Key]
        [ScaffoldColumn(false)]
        public int Aid { get; set; }

        [Required]
        public string FistName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Url { get; set; }

        public ICollection<Book> book { set; get;}

   

    }
}