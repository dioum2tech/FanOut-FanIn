﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using FanIn_Fan_out.Shared.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FanIn_Fan_out.Shared.Infrastructure.DatabaseContext;

public partial class AdventureWorks2012Context : DbContext
{
    public AdventureWorks2012Context()
    {
    }

    public AdventureWorks2012Context(DbContextOptions<AdventureWorks2012Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Product { get; set; }
    public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

    //    modelBuilder.Entity<Product>(entity =>
    //    {
    //        entity.ToTable("Product", "Production");

    //        entity.HasComment("Products sold or used in the manfacturing of sold products.");

    //        entity.HasIndex(e => e.Name, "AK_Product_Name")
    //            .IsUnique();

    //        entity.HasIndex(e => e.ProductNumber, "AK_Product_ProductNumber")
    //            .IsUnique();

    //        entity.HasIndex(e => e.Rowguid, "AK_Product_rowguid")
    //            .IsUnique();

    //        entity.Property(e => e.ProductId)
    //            .HasColumnName("ProductID")
    //            .HasComment("Primary key for Product records.");

    //        entity.Property(e => e.Class)
    //            .HasMaxLength(2)
    //            .IsFixedLength()
    //            .HasComment("H = High, M = Medium, L = Low");

    //        entity.Property(e => e.Color)
    //            .HasMaxLength(15)
    //            .HasComment("Product color.");

    //        entity.Property(e => e.DaysToManufacture).HasComment("Number of days required to manufacture the product.");

    //        entity.Property(e => e.DiscontinuedDate)
    //            .HasColumnType("datetime")
    //            .HasComment("Date the product was discontinued.");

    //        entity.Property(e => e.FinishedGoodsFlag)
    //            .IsRequired()
    //            .HasDefaultValueSql("((1))")
    //            .HasComment("0 = Product is not a salable item. 1 = Product is salable.");

    //        entity.Property(e => e.ListPrice)
    //            .HasColumnType("money")
    //            .HasComment("Selling price.");

    //        entity.Property(e => e.MakeFlag)
    //            .IsRequired()
    //            .HasDefaultValueSql("((1))")
    //            .HasComment("0 = Product is purchased, 1 = Product is manufactured in-house.");

    //        entity.Property(e => e.ModifiedDate)
    //            .HasColumnType("datetime")
    //            .HasDefaultValueSql("(getdate())")
    //            .HasComment("Date and time the record was last updated.");

    //        entity.Property(e => e.Name)
    //            .IsRequired()
    //            .HasMaxLength(50)
    //            .HasComment("Name of the product.");

    //        entity.Property(e => e.ProductLine)
    //            .HasMaxLength(2)
    //            .IsFixedLength()
    //            .HasComment("R = Road, M = Mountain, T = Touring, S = Standard");

    //        entity.Property(e => e.ProductModelId)
    //            .HasColumnName("ProductModelID")
    //            .HasComment("Product is a member of this product model. Foreign key to ProductModel.ProductModelID.");

    //        entity.Property(e => e.ProductNumber)
    //            .IsRequired()
    //            .HasMaxLength(25)
    //            .HasComment("Unique product identification number.");

    //        entity.Property(e => e.ProductSubcategoryId)
    //            .HasColumnName("ProductSubcategoryID")
    //            .HasComment("Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ");

    //        entity.Property(e => e.ReorderPoint).HasComment("Inventory level that triggers a purchase order or work order. ");

    //        entity.Property(e => e.Rowguid)
    //            .HasColumnName("rowguid")
    //            .HasDefaultValueSql("(newid())")
    //            .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

    //        entity.Property(e => e.SafetyStockLevel).HasComment("Minimum inventory quantity. ");

    //        entity.Property(e => e.SellEndDate)
    //            .HasColumnType("datetime")
    //            .HasComment("Date the product was no longer available for sale.");

    //        entity.Property(e => e.SellStartDate)
    //            .HasColumnType("datetime")
    //            .HasComment("Date the product was available for sale.");

    //        entity.Property(e => e.Size)
    //            .HasMaxLength(5)
    //            .HasComment("Product size.");

    //        entity.Property(e => e.SizeUnitMeasureCode)
    //            .HasMaxLength(3)
    //            .IsFixedLength()
    //            .HasComment("Unit of measure for Size column.");

    //        entity.Property(e => e.StandardCost)
    //            .HasColumnType("money")
    //            .HasComment("Standard cost of the product.");

    //        entity.Property(e => e.Style)
    //            .HasMaxLength(2)
    //            .IsFixedLength()
    //            .HasComment("W = Womens, M = Mens, U = Universal");

    //        entity.Property(e => e.Weight)
    //            .HasColumnType("decimal(8, 2)")
    //            .HasComment("Product weight.");

    //        entity.Property(e => e.WeightUnitMeasureCode)
    //            .HasMaxLength(3)
    //            .IsFixedLength()
    //            .HasComment("Unit of measure for Weight column.");
    //    });

    //    modelBuilder.Entity<SalesOrderDetail>(entity =>
    //    {
    //        entity.HasKey(e => new { e.SalesOrderId, e.SalesOrderDetailId })
    //            .HasName("PK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID");

    //        entity.ToTable("SalesOrderDetail", "Sales");

    //        entity.HasComment("Individual products associated with a specific sales order. See SalesOrderHeader.");

    //        entity.HasIndex(e => e.Rowguid, "AK_SalesOrderDetail_rowguid")
    //            .IsUnique();

    //        entity.HasIndex(e => e.ProductId, "IX_SalesOrderDetail_ProductID");

    //        entity.Property(e => e.SalesOrderId)
    //            .HasColumnName("SalesOrderID")
    //            .HasComment("Primary key. Foreign key to SalesOrderHeader.SalesOrderID.");

    //        entity.Property(e => e.SalesOrderDetailId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("SalesOrderDetailID")
    //            .HasComment("Primary key. One incremental unique number per product sold.");

    //        entity.Property(e => e.CarrierTrackingNumber)
    //            .HasMaxLength(25)
    //            .HasComment("Shipment tracking number supplied by the shipper.");

    //        entity.Property(e => e.LineTotal)
    //            .HasColumnType("numeric(38, 6)")
    //            .HasComputedColumnSql("(isnull(([UnitPrice]*((1.0)-[UnitPriceDiscount]))*[OrderQty],(0.0)))", false)
    //            .HasComment("Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.");

    //        entity.Property(e => e.ModifiedDate)
    //            .HasColumnType("datetime")
    //            .HasDefaultValueSql("(getdate())")
    //            .HasComment("Date and time the record was last updated.");

    //        entity.Property(e => e.OrderQty).HasComment("Quantity ordered per product.");

    //        entity.Property(e => e.ProductId)
    //            .HasColumnName("ProductID")
    //            .HasComment("Product sold to customer. Foreign key to Product.ProductID.");

    //        entity.Property(e => e.Rowguid)
    //            .HasColumnName("rowguid")
    //            .HasDefaultValueSql("(newid())")
    //            .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

    //        entity.Property(e => e.SpecialOfferId)
    //            .HasColumnName("SpecialOfferID")
    //            .HasComment("Promotional code. Foreign key to SpecialOffer.SpecialOfferID.");

    //        entity.Property(e => e.UnitPrice)
    //            .HasColumnType("money")
    //            .HasComment("Selling price of a single product.");

    //        entity.Property(e => e.UnitPriceDiscount)
    //            .HasColumnType("money")
    //            .HasComment("Discount amount.");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}