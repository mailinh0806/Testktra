﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TestKT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("TestKT.Models.Linh", b =>
                {
                    b.Property<string>("IDten")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tinhcach")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IDten");

                    b.HasIndex("Ma");

                    b.ToTable("Linh");
                });

            modelBuilder.Entity("TestKT.Models.People", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Ma");

                    b.ToTable("People");
                });

            modelBuilder.Entity("TestKT.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("TestKT.Models.Linh", b =>
                {
                    b.HasOne("TestKT.Models.People", "People")
                        .WithMany()
                        .HasForeignKey("Ma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("People");
                });
#pragma warning restore 612, 618
        }
    }
}
