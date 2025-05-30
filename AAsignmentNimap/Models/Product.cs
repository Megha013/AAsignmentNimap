﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AAsignmentNimap.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        //public virtual Category? Category { get; set; }
        [NotMapped]
        public string? CategoryName { get; set; }
    }
}
