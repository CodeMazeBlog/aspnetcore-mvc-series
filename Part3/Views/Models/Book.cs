using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorkingWithViews.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Book Title")]
        [Required]
        public string Title { get; set; }

        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 100)]
        public decimal Price { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
    }
}
