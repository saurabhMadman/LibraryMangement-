using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NextGen_Application_BookAuthor
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Bid { get; set; }
     
        [Required]
        public string BookName { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Publication { get; set; }
        [Required]
        public string Description { get; set; }
        
        [ForeignKey("author")]
         public int AuthorId { get; set;}
        
         public Author author { get; set; }
      //  [DataType(DataType.Date)]
       // [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
       // [ScaffoldColumn(false)]
        //public DateTime alter { get; set; }

    }
}