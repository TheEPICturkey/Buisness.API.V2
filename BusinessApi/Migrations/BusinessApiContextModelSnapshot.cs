﻿// <auto-generated />
using BusinessApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessApi.Migrations
{
    [DbContext(typeof(BusinessApiContext))]
    partial class BusinessApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BusinessApi.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Rating")
                        .HasColumnType("double");

                    b.Property<string>("Review")
                        .HasColumnType("longtext");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Address = "1234 Fifth Street WA",
                            Description = "Bakery",
                            Name = "Pierres Bakery",
                            Rating = 4.7999999999999998,
                            Review = "Very tastey!"
                        },
                        new
                        {
                            BusinessId = 2,
                            Address = "1234 Fifth Street WA",
                            Description = "Factory",
                            Name = "Silly String Factory",
                            Rating = 2.2000000000000002,
                            Review = "Too much work"
                        },
                        new
                        {
                            BusinessId = 3,
                            Address = "1234 Fifth Street WA",
                            Description = "Hair Salon",
                            Name = "Hair Salon",
                            Rating = 3.3999999999999999,
                            Review = "I got an awesome mullet!"
                        },
                        new
                        {
                            BusinessId = 4,
                            Address = "1234 Fifth Street WA",
                            Description = "Pizza Parlor",
                            Name = "Goodboy's Pizza Parlor",
                            Rating = 5.0,
                            Review = "Best Pizza In The World!"
                        },
                        new
                        {
                            BusinessId = 5,
                            Address = "1234 Fifth Street WA",
                            Description = "Dessert Shop",
                            Name = "James J. Jameson's Treats",
                            Rating = 0.5,
                            Review = "Wouldnt give me a free treat:("
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
