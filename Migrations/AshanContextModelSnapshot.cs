﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using servPart;

namespace servPart.Migrations
{
    [DbContext(typeof(AshanContext))]
    partial class AshanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HistoryProductQrcodewithType", b =>
                {
                    b.Property<int>("HistoriesID")
                        .HasColumnType("int");

                    b.Property<string>("ProductsQrcode")
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("HistoriesID", "ProductsQrcode");

                    b.HasIndex("ProductsQrcode");

                    b.ToTable("HistoryProductQrcodewithType");
                });

            modelBuilder.Entity("ProductQrcodewithTypeTypeProduct", b =>
                {
                    b.Property<string>("ProductsQrcode")
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("TypesID")
                        .HasColumnType("int");

                    b.HasKey("ProductsQrcode", "TypesID");

                    b.HasIndex("TypesID");

                    b.ToTable("ProductQrcodewithTypeTypeProduct");
                });

            modelBuilder.Entity("servPart.Storage.Entity.History", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("servPart.Storage.Entity.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("addres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("servPart.Storage.Entity.ProductQrcodewithType", b =>
                {
                    b.Property<string>("Qrcode")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int?>("ImageID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProducterID")
                        .HasColumnType("int");

                    b.Property<int?>("Stock1_1ID")
                        .HasColumnType("int");

                    b.Property<int?>("StockByClassID")
                        .HasColumnType("int");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Qrcode");

                    b.HasIndex("ImageID");

                    b.HasIndex("ProducterID");

                    b.HasIndex("Stock1_1ID");

                    b.HasIndex("StockByClassID");

                    b.ToTable("ProductQrcodes");
                });

            modelBuilder.Entity("servPart.Storage.Entity.Producter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Producters");
                });

            modelBuilder.Entity("servPart.Storage.Entity.Stock", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<string>("productQrcode")
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("ID");

                    b.HasIndex("productQrcode");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("servPart.Storage.Entity.Stock1_1", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Stocks1_1");
                });

            modelBuilder.Entity("servPart.Storage.Entity.StockByClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<int?>("_classID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("_classID");

                    b.ToTable("StocksByClass");
                });

            modelBuilder.Entity("servPart.Storage.Entity.StockOfType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TypeID")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("TypeID");

                    b.ToTable("StocksOfType");
                });

            modelBuilder.Entity("servPart.Storage.Entity.TypeProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("servPart.Storage.Entity.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("br_day")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("e_mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("num_buy")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("sum_buy")
                        .HasColumnType("float");

                    b.Property<string>("tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("typeID")
                        .HasColumnType("int");

                    b.Property<int?>("userClassID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("typeID");

                    b.HasIndex("userClassID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("servPart.Storage.Entity.UserClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("end_sum")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("start_sum")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("UserClasses");
                });

            modelBuilder.Entity("servPart.Storage.Entity.UserType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TypeProductID")
                        .HasColumnType("int");

                    b.Property<int?>("TypeProductID1")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TypeProductID");

                    b.HasIndex("TypeProductID1");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("HistoryProductQrcodewithType", b =>
                {
                    b.HasOne("servPart.Storage.Entity.History", null)
                        .WithMany()
                        .HasForeignKey("HistoriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("servPart.Storage.Entity.ProductQrcodewithType", null)
                        .WithMany()
                        .HasForeignKey("ProductsQrcode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductQrcodewithTypeTypeProduct", b =>
                {
                    b.HasOne("servPart.Storage.Entity.ProductQrcodewithType", null)
                        .WithMany()
                        .HasForeignKey("ProductsQrcode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("servPart.Storage.Entity.TypeProduct", null)
                        .WithMany()
                        .HasForeignKey("TypesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("servPart.Storage.Entity.History", b =>
                {
                    b.HasOne("servPart.Storage.Entity.User", "User")
                        .WithMany("Histories")
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("servPart.Storage.Entity.ProductQrcodewithType", b =>
                {
                    b.HasOne("servPart.Storage.Entity.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageID");

                    b.HasOne("servPart.Storage.Entity.Producter", "Producter")
                        .WithMany("Products")
                        .HasForeignKey("ProducterID");

                    b.HasOne("servPart.Storage.Entity.Stock1_1", null)
                        .WithMany("products")
                        .HasForeignKey("Stock1_1ID");

                    b.HasOne("servPart.Storage.Entity.StockByClass", null)
                        .WithMany("products")
                        .HasForeignKey("StockByClassID");

                    b.Navigation("Image");

                    b.Navigation("Producter");
                });

            modelBuilder.Entity("servPart.Storage.Entity.Stock", b =>
                {
                    b.HasOne("servPart.Storage.Entity.ProductQrcodewithType", "product")
                        .WithMany()
                        .HasForeignKey("productQrcode");

                    b.Navigation("product");
                });

            modelBuilder.Entity("servPart.Storage.Entity.StockByClass", b =>
                {
                    b.HasOne("servPart.Storage.Entity.UserClass", "_class")
                        .WithMany()
                        .HasForeignKey("_classID");

                    b.Navigation("_class");
                });

            modelBuilder.Entity("servPart.Storage.Entity.StockOfType", b =>
                {
                    b.HasOne("servPart.Storage.Entity.TypeProduct", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("servPart.Storage.Entity.User", b =>
                {
                    b.HasOne("servPart.Storage.Entity.UserType", "type")
                        .WithMany("Users")
                        .HasForeignKey("typeID");

                    b.HasOne("servPart.Storage.Entity.UserClass", "userClass")
                        .WithMany("Users")
                        .HasForeignKey("userClassID");

                    b.Navigation("type");

                    b.Navigation("userClass");
                });

            modelBuilder.Entity("servPart.Storage.Entity.UserType", b =>
                {
                    b.HasOne("servPart.Storage.Entity.TypeProduct", null)
                        .WithMany("AntiTargetTypes")
                        .HasForeignKey("TypeProductID");

                    b.HasOne("servPart.Storage.Entity.TypeProduct", null)
                        .WithMany("TargetTypes")
                        .HasForeignKey("TypeProductID1");
                });

            modelBuilder.Entity("servPart.Storage.Entity.Producter", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("servPart.Storage.Entity.Stock1_1", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("servPart.Storage.Entity.StockByClass", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("servPart.Storage.Entity.TypeProduct", b =>
                {
                    b.Navigation("AntiTargetTypes");

                    b.Navigation("TargetTypes");
                });

            modelBuilder.Entity("servPart.Storage.Entity.User", b =>
                {
                    b.Navigation("Histories");
                });

            modelBuilder.Entity("servPart.Storage.Entity.UserClass", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("servPart.Storage.Entity.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
