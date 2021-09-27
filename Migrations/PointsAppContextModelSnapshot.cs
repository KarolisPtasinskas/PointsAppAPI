﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PointsAppWebAPI.Data;

namespace PointsAppWebAPI.Migrations
{
    [DbContext(typeof(PointsAppContext))]
    partial class PointsAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PointsAppWebAPI.Models.Coordinate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CoordinatesListId")
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoordinatesListId");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("PointsAppWebAPI.Models.CoordinatesList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoordinatesLists");
                });

            modelBuilder.Entity("PointsAppWebAPI.Models.Coordinate", b =>
                {
                    b.HasOne("PointsAppWebAPI.Models.CoordinatesList", "CoordinatesList")
                        .WithMany("Coordinates")
                        .HasForeignKey("CoordinatesListId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("CoordinatesList");
                });

            modelBuilder.Entity("PointsAppWebAPI.Models.CoordinatesList", b =>
                {
                    b.Navigation("Coordinates");
                });
#pragma warning restore 612, 618
        }
    }
}
