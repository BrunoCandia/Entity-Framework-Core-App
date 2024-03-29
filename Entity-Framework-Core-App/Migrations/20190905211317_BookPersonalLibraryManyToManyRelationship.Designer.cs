﻿// <auto-generated />
using System;
using Entity_Framework_Core_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity_Framework_Core_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190905211317_BookPersonalLibraryManyToManyRelationship")]
    partial class BookPersonalLibraryManyToManyRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity_Framework_Core_App.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DoB");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Nationality");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.AuthorBiography", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<string>("Biography");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId")
                        .IsUnique();

                    b.ToTable("AuthorBiographies");
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Isbn")
                        .HasMaxLength(10);

                    b.Property<string>("Title")
                        .HasMaxLength(32);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("Isbn")
                        .IsUnique()
                        .HasName("IsbnIndex")
                        .HasFilter("[Isbn] IS NOT NULL");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Clients");
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

            modelBuilder.Entity("Entity_Framework_Core_App.Models.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("Genre");

                    b.Property<DateTime>("Initiated");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.PersonalLibrary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.HasKey("Id");

                    b.ToTable("PersonalLibraries");
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.PersonalLibraryBook", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("PersonalLibraryId");

                    b.HasKey("BookId", "PersonalLibraryId");

                    b.HasIndex("PersonalLibraryId");

                    b.ToTable("PersonalLibraryBooks");
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

            modelBuilder.Entity("Entity_Framework_Core_App.Models.AuthorBiography", b =>
                {
                    b.HasOne("Entity_Framework_Core_App.Models.Author", "Author")
                        .WithOne("Biography")
                        .HasForeignKey("Entity_Framework_Core_App.Models.AuthorBiography", "AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.Book", b =>
                {
                    b.HasOne("Entity_Framework_Core_App.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.Membership", b =>
                {
                    b.HasOne("Entity_Framework_Core_App.Models.Client", "Client")
                        .WithOne("Membership")
                        .HasForeignKey("Entity_Framework_Core_App.Models.Membership", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity_Framework_Core_App.Models.PersonalLibraryBook", b =>
                {
                    b.HasOne("Entity_Framework_Core_App.Models.Book", "Book")
                        .WithMany("PersonalLibraryBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entity_Framework_Core_App.Models.PersonalLibrary", "PersonalLibrary")
                        .WithMany("PersonalLibraryBooks")
                        .HasForeignKey("PersonalLibraryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
