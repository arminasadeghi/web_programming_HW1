using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace entity_lib
{
    [Table("Users")]
    public class User
    {

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID{get;set;}
        public string UserName{get;set;}
        public string FamilyName{get;set;}
        
        [NotMapped]
        public int Age{get;set;}
        
        // public ICollection<Shelf> Shelf{get;set;}

    }
}