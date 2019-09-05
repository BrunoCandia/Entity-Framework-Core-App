﻿// <auto-generated />
using System;
using Entity_Framework_Core_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity_Framework_Core_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity_Framework_Core_App.Models.Author", b =>
                {
                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("DoB");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Nationality");

                    b.HasKey("FirstName", "LastName");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Isbn")
                        .HasMaxLength(10);

                    b.Property<string>("Title")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("Isbn")
                        .IsUnique()
                        .HasName("IsbnIndex")
                        .HasFilter("[Isbn] IS NOT NULL");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("StreetName");

                    b.Property<int>("StreetNumber");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CompletedAt");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsCompleted");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ToDoS");
                });
#pragma warning restore 612, 618
        }
    }
}
