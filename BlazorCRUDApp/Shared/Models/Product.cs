﻿using System.ComponentModel.DataAnnotations;
namespace BlazorCRUDApp.Shared.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
