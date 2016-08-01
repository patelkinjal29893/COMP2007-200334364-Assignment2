﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace DesiTadkaRestaurant.Models
{

    [Table("Menu")]
    public partial class Menu
    {
        public int MenuId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public string SDescription { get; set; }

        [Required]
        public string LDescription { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        public string ThumbImage { get; set; }

        [Required]
        [StringLength(50)]
        public string LargeImage { get; set; }
    }
    public class MenuContex : DbContext
    {
        public MenuContex() : base("str") { }

        public DbSet<Menu> Menu { get; set; }
    }
}
