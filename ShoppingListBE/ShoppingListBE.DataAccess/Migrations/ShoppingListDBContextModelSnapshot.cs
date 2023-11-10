﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingListBE.DataAccess.Models;

#nullable disable

namespace ShoppingListBE.DataAccess.Migrations
{
    [DbContext(typeof(ShoppingListDBContext))]
    partial class ShoppingListDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<bool>("isFinished")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Lists");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.ListProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.HasIndex("ProductId");

                    b.ToTable("ListsProducts");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ClientId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.Category", b =>
                {
                    b.HasOne("ShoppingListBE.DataAccess.Models.Client", "Client")
                        .WithMany("Categories")
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.List", b =>
                {
                    b.HasOne("ShoppingListBE.DataAccess.Models.Client", "Client")
                        .WithMany("Lists")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.ListProduct", b =>
                {
                    b.HasOne("ShoppingListBE.DataAccess.Models.List", "List")
                        .WithMany("ListsProducts")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingListBE.DataAccess.Models.Product", "Product")
                        .WithMany("ListsProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("List");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.Product", b =>
                {
                    b.HasOne("ShoppingListBE.DataAccess.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingListBE.DataAccess.Models.Client", "Client")
                        .WithMany("Products")
                        .HasForeignKey("ClientId");

                    b.Navigation("Category");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.Client", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Lists");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.List", b =>
                {
                    b.Navigation("ListsProducts");
                });

            modelBuilder.Entity("ShoppingListBE.DataAccess.Models.Product", b =>
                {
                    b.Navigation("ListsProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
