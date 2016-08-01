namespace DesiTadkaRestaurant.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DesiTadka : DbContext
    {
        public DesiTadka()
            : base("name=str")
        {
        }

        public virtual DbSet<MenuType> MenuTypes { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
    }
}
