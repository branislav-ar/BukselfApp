﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjekatSWE.Models;

namespace ProjekatSWE.Migrations
{
    [DbContext(typeof(BukSelfContext))]
    [Migration("20210623204526_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjekatSWE.Models.Knjiga", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Godina")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Godina");

                    b.Property<string>("Pisac")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pisac");

                    b.HasKey("ID");

                    b.ToTable("Knjiga");
                });

            modelBuilder.Entity("ProjekatSWE.Models.Korisnik", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Username");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ime");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Prezime");

                    b.Property<string>("Pw")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pw");

                    b.HasKey("Username");

                    b.ToTable("Korisnik");
                });
#pragma warning restore 612, 618
        }
    }
}