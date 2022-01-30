using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_lib
{
    [Table("ShelfBooks")]
    public class ShelfBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int shelfBookID{get;set;}
        
        [ForeignKey("shelfID")]
        public Shelf shelf{get;set;}
        
        [ForeignKey("bookID")]
        public Book book{get;set;}
    }
}