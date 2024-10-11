﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudySystem.Data.EF;

#nullable disable

namespace StudySystem.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231102084635_v19")]
    partial class v19
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StudySystem.Data.Entites.AddressUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Descriptions")
                        .HasColumnType("text");

                    b.Property<string>("DistrictCode")
                        .HasColumnType("text");

                    b.Property<string>("ProvinceCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<string>("WardCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DistrictCode");

                    b.HasIndex("ProvinceCode");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.HasIndex("WardCode");

                    b.HasIndex("UserID", "WardCode", "DistrictCode", "ProvinceCode");

                    b.ToTable("AddressUsers");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AdministrativeRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CodeNameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("administrative_regions");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AdministrativeUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CodeNameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullNameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortNameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("administrative_units");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CartId"));

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("character varying(12)");

                    b.HasKey("CartId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CartItemId"));

                    b.Property<int>("CartId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("text");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.District", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int?>("AdministrativeUnitId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("CodeName")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("FullNameEn")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.Property<string>("ProvinceCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("ProvinceCode", "AdministrativeUnitId");

                    b.ToTable("districts");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("character varying(12)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderItemId"));

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("text");

                    b.Property<string>("ProductImage")
                        .HasColumnType("text");

                    b.Property<string>("ProductManufacturer")
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<double?>("ProductPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("ProductQuantity")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.ProductCategory", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<string>("CategoryId")
                        .HasColumnType("text");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Province", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int?>("AdministrativeRegionId")
                        .HasColumnType("integer");

                    b.Property<int?>("AdministrativeUnitId")
                        .HasColumnType("integer");

                    b.Property<string>("CodeName")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("FullNameEn")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("AdministrativeRegionId", "AdministrativeUnitId");

                    b.ToTable("provinces");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.UserDetail", b =>
                {
                    b.Property<string>("UserID")
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RankUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserFullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.HasIndex("UserID")
                        .HasDatabaseName("IX_UserDetail_UserID");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.UserToken", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpireTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExpireTimeOnline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.VerificationOTP", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpireTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserID");

                    b.ToTable("VerificationOTPs");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Ward", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int?>("AdministrativeUnitId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("CodeName")
                        .HasColumnType("text");

                    b.Property<string>("DistrictCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("FullNameEn")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("DistrictCode", "AdministrativeUnitId");

                    b.ToTable("wards");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.WishList", b =>
                {
                    b.Property<int>("WishListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WishListId"));

                    b.Property<DateTime>("CreateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("character varying(12)");

                    b.HasKey("WishListId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("WishLists");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AddressUser", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.District", "District")
                        .WithMany("AddressUsers")
                        .HasForeignKey("DistrictCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudySystem.Data.Entites.Province", "Province")
                        .WithMany("AddressUsers")
                        .HasForeignKey("ProvinceCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudySystem.Data.Entites.UserDetail", "UserDetail")
                        .WithOne("AddressUser")
                        .HasForeignKey("StudySystem.Data.Entites.AddressUser", "UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudySystem.Data.Entites.Ward", "Ward")
                        .WithMany("AddressUsers")
                        .HasForeignKey("WardCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("District");

                    b.Navigation("Province");

                    b.Navigation("UserDetail");

                    b.Navigation("Ward");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Cart", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.UserDetail", "UserDetail")
                        .WithMany("Carts")
                        .HasForeignKey("UserId");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.CartItem", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudySystem.Data.Entites.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId");

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.District", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Districts")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudySystem.Data.Entites.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AdministrativeUnit");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Order", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.UserDetail", "UserDetail")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.OrderItem", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudySystem.Data.Entites.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.ProductCategory", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudySystem.Data.Entites.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Province", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.AdministrativeRegion", "AdministrativeRegion")
                        .WithMany("Provinces")
                        .HasForeignKey("AdministrativeRegionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudySystem.Data.Entites.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Provinces")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AdministrativeRegion");

                    b.Navigation("AdministrativeUnit");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Ward", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Wards")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudySystem.Data.Entites.District", "District")
                        .WithMany("Wards")
                        .HasForeignKey("DistrictCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AdministrativeUnit");

                    b.Navigation("District");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.WishList", b =>
                {
                    b.HasOne("StudySystem.Data.Entites.Product", "Product")
                        .WithMany("WishLists")
                        .HasForeignKey("ProductId");

                    b.HasOne("StudySystem.Data.Entites.UserDetail", "UserDetail")
                        .WithMany("WishLists")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AdministrativeRegion", b =>
                {
                    b.Navigation("Provinces");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.AdministrativeUnit", b =>
                {
                    b.Navigation("Districts");

                    b.Navigation("Provinces");

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.District", b =>
                {
                    b.Navigation("AddressUsers");

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderItems");

                    b.Navigation("ProductCategories");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Province", b =>
                {
                    b.Navigation("AddressUsers");

                    b.Navigation("Districts");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.UserDetail", b =>
                {
                    b.Navigation("AddressUser");

                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("StudySystem.Data.Entites.Ward", b =>
                {
                    b.Navigation("AddressUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
