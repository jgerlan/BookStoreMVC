using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class BookWeb
    {
        [Key]
        public long isbn { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public string publishing { get; set; }
        [Required]
        public int publishingNumber { get; set; }
    }
}