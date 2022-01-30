using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_lib
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookID{get;set;}
        public string title{get;set;}
        public string author{get;set;}
        public string publisher{get;set;}
        public int edition{get;set;}
        
        // public ICollection<Shelf> Shelf{get;set;}

    }
}