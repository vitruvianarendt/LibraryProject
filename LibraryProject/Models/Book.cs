using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
       
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        [Required]
        public string Title { get; set; }
        [Display(Name = "Cover Art")]
        public string CoverUrl { get; set; }
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }
        [Display(Name = "Author")]
        public Author Author { get; set; }
        [Display(Name = "Details")]
        public string Description { get; set; }
        public int Pages { get; set; }
        public int Price { get; set; }
        [Display(Name = "Available Copies")]
        public int Copies { get; set; }

    }
}