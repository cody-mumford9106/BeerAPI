﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerAPI.Models
{
    public class Beer
    {
        [Key]
        public int BeerId { get; set; }
        [Required]
        [MaxLength(80)]
        public string BeerName { get; set; }
        [MaxLength(10)]
        public string BeerClass { get; set; }
        [MaxLength(500)]
        public string BeerDescription { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Abv { get; set; }
        [ForeignKey("BreweryId")]
        public Brewery Brewer { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class DtoBeer
    {
        public int BeerId { get; set; }
        public string BeerName { get; set; }
        public string BeerClass { get; set; }
        public string BeerDescription { get; set; }
        public decimal Abv { get; set; }
        public Brewery Brewer { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}