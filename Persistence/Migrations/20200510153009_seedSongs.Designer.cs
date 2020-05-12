﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200510153009_seedSongs")]
    partial class seedSongs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Domain.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artist")
                        .HasColumnType("TEXT");

                    b.Property<string>("Movie")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "Palak Muchhal",
                            Movie = "MS Dhoni",
                            Name = "Kaun tujhe"
                        },
                        new
                        {
                            Id = 2,
                            Artist = "Neha Kakkar",
                            Movie = "Fever",
                            Name = "Mile ho tum"
                        },
                        new
                        {
                            Id = 3,
                            Artist = "Neha Kakkar",
                            Movie = "Wajah tum",
                            Name = "Mahi ve"
                        },
                        new
                        {
                            Id = 4,
                            Artist = "Young Desi",
                            Movie = "Luka Chuppi",
                            Name = "Coca cola"
                        });
                });

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Value 101"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Value 102"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Value 103"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
