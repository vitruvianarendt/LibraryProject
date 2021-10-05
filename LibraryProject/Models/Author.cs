using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{
    public class Author
    {
       [Key]
       public int AuthorId { get; set; }
       [Display(Name = "Author")]
       public string Name { get; set; }
       public List<Book> books { get; set; }
       public Author()
       {
           books = new List<Book>();
       }


    }
}