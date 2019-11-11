using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroceryListManager.Models
{
    public class GroceryListManagerContext : DbContext
    {
        public GroceryListManagerContext (DbContextOptions<GroceryListManagerContext> options)
            : base(options)
        {
        }

        public DbSet<GroceryListManager.Models.Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    id = 1,
                    name = "Eggs",
                    quantity = 1,
                    purchased = false
                });

            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    id = 2,
                    name = "Milk",
                    quantity = 1,
                    purchased = false
                });

            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    id = 3,
                    name = "Bread",
                    quantity = 1,
                    purchased = false
                });

            base.OnModelCreating(modelBuilder);
        }
    }

    
}
