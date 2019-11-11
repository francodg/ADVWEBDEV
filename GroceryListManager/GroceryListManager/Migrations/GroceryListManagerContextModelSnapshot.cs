﻿// <auto-generated />
using GroceryListManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryListManager.Migrations
{
    [DbContext(typeof(GroceryListManagerContext))]
    partial class GroceryListManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroceryListManager.Models.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.Property<bool>("purchased");

                    b.Property<int>("quantity");

                    b.HasKey("id");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            id = 1,
                            name = "Eggs",
                            purchased = false,
                            quantity = 1
                        },
                        new
                        {
                            id = 2,
                            name = "Milk",
                            purchased = false,
                            quantity = 1
                        },
                        new
                        {
                            id = 3,
                            name = "Bread",
                            purchased = false,
                            quantity = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}