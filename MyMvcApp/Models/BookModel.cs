using System;
using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class BookModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Book Name Required")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Book Auther Required")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Book Price Required")]
        public double Price { get; set; }
        
        [Required(ErrorMessage = "Book Date Required")]
        public DateTime Date { get; set; }
    }
}