using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_lib
{
    [Table("Shelfs")]
    public class Shelf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int shelfID{get;set;}

        public string topic{get;set;}
        
        [ForeignKey("ownerID")]
        public User user{get;set;}

    }
} 