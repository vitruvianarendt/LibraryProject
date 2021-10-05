using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Display(Name = "Genre")]
        public string Name { get; set; }
        public List<Book> books { get; set; }
        public Genre ()
         {
            books = new List<Book>();
        }

}
}