﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestXAFAppBlazor.Module.BusinessObjects;

#nullable disable

namespace TestXAFAppBlazor.Module.Migrations
{
    [DbContext(typeof(TestXAFAppBlazorEFCoreDbContext))]
    [Migration("20240129110941_AddedEnum")]
    partial class AddedEnum
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Proxies:ChangeTracking", true)
                .HasAnnotation("Proxies:CheckEquality", true)
                .HasAnnotation("Proxies:LazyLoading", false)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerTestimonial", b =>
                {
                    b.Property<Guid>("CustomersID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestimonialsID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomersID", "TestimonialsID");

                    b.HasIndex("TestimonialsID");

                    b.ToTable("CustomerTestimonial");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.MediaDataObject", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MediaDataKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MediaResourceID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("MediaResourceID");

                    b.ToTable("MediaDataObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.MediaResourceObject", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("MediaData")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ID");

                    b.ToTable("MediaResourceObject");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Authorization", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SetupID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserCode")
                        .HasColumnType("int");

                    b.Property<decimal>("UserCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("SetupID");

                    b.ToTable("Authorization");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PhotoID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("PhotoID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Project", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(4096)
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ManagerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ManagerID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.ProjectTask", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignedToID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasMaxLength(4096)
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProjectID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AssignedToID");

                    b.HasIndex("ProjectID");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Setup", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("PortalServer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("SystemName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Setups");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Testimonial", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Highlight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.WebService", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Appearence")
                        .HasColumnType("int");

                    b.Property<Guid?>("AuthorizationID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enpoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SetupID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("AuthorizationID");

                    b.HasIndex("SetupID");

                    b.ToTable("WebService");
                });

            modelBuilder.Entity("CustomerTestimonial", b =>
                {
                    b.HasOne("TestXAFAppBlazor.Module.BusinessObjects.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestXAFAppBlazor.Module.BusinessObjects.Testimonial", null)
                        .WithMany()
                        .HasForeignKey("TestimonialsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.MediaDataObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.MediaResourceObject", "MediaResource")
                        .WithMany()
                        .HasForeignKey("MediaResourceID");

                    b.Navigation("MediaResource");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Authorization", b =>
                {
                    b.HasOne("TestXAFAppBlazor.Module.BusinessObjects.Setup", "Setup")
                        .WithMany("Authorizations")
                        .HasForeignKey("SetupID");

                    b.Navigation("Setup");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Customer", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.MediaDataObject", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoID");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Project", b =>
                {
                    b.HasOne("TestXAFAppBlazor.Module.BusinessObjects.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.ProjectTask", b =>
                {
                    b.HasOne("TestXAFAppBlazor.Module.BusinessObjects.Employee", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("AssignedToID");

                    b.HasOne("TestXAFAppBlazor.Module.BusinessObjects.Project", "Project")
                        .WithMany("ProjectTasks")
                        .HasForeignKey("ProjectID");

                    b.Navigation("AssignedTo");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.WebService", b =>
                {
                    b.HasOne("TestXAFAppBlazor.Module.BusinessObjects.Authorization", "Authorization")
                        .WithMany()
                        .HasForeignKey("AuthorizationID");

                    b.HasOne("TestXAFAppBlazor.Module.BusinessObjects.Setup", "Setup")
                        .WithMany("Webservices")
                        .HasForeignKey("SetupID");

                    b.Navigation("Authorization");

                    b.Navigation("Setup");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Project", b =>
                {
                    b.Navigation("ProjectTasks");
                });

            modelBuilder.Entity("TestXAFAppBlazor.Module.BusinessObjects.Setup", b =>
                {
                    b.Navigation("Authorizations");

                    b.Navigation("Webservices");
                });
#pragma warning restore 612, 618
        }
    }
}