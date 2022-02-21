﻿// <auto-generated />
using System;
using Apocalypse.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Apocalypse.Migrations
{
    [DbContext(typeof(ApocalyseDbContext))]
    [Migration("20220221080457_a1")]
    partial class a1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Apocalypse.Models.Robots", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("manufacturedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("robots");
                });

            modelBuilder.Entity("Apocalypse.Models.Survivor", b =>
                {
                    b.Property<int>("SurvivorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("asinfected")
                        .HasColumnType("bit");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("longitude")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SurvivorId");

                    b.ToTable("survivors");
                });
#pragma warning restore 612, 618
        }
    }
}
