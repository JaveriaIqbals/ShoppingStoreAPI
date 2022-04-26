﻿using System.ComponentModel.DataAnnotations;

namespace ShoppingStoreAPI.Models
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; } // PK

        [Required]
        public string ProdName { get; set; } = "none";
        
        public string? ProdDesc { get; set; }

        [Required]
        public double ProdPrice { get; set; }
    }
}
