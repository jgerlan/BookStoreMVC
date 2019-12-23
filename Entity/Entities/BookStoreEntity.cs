using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Entity.Entities
{
    public class BookStoreEntity
    {
        public long Id { get; set; }
        [Required]
        public long Isbn { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publishing { get; set; }
        [Required]
        public int PublishingNumber { get; set; }
        [Required]
        public int AmountStock { get; set; }
    }
}