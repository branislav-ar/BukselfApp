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
    [Migration("20210707200830_v10")]
    partial class v10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjekatSWE.Models.FavUser", b =>
                {
                    b.Property<int>("IDFU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDFU")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Uname1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Username1");

                    b.Property<string>("Uname2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Username2");

                    b.HasKey("IDFU");

                    b.ToTable("FavUser");
                });

            modelBuilder.Entity("ProjekatSWE.Models.Favourite", b =>
                {
                    b.Property<int>("IDFB")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDFB")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IDK")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IDK");

                    b.Property<string>("Uname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Username");

                    b.HasKey("IDFB");

                    b.ToTable("Favourite");
                });

            modelBuilder.Entity("ProjekatSWE.Models.Knjiga", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BPhotoPath")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BPhotoPath");

                    b.Property<int>("Br1")
                        .HasColumnType("int")
                        .HasColumnName("Br1");

                    b.Property<int>("Br2")
                        .HasColumnType("int")
                        .HasColumnName("Br2");

                    b.Property<int>("Br3")
                        .HasColumnType("int")
                        .HasColumnName("Br3");

                    b.Property<int>("Br4")
                        .HasColumnType("int")
                        .HasColumnName("Br4");

                    b.Property<int>("Br5")
                        .HasColumnType("int")
                        .HasColumnName("Br5");

                    b.Property<int>("BrR")
                        .HasColumnType("int")
                        .HasColumnName("BrR");

                    b.Property<string>("Godina")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Godina");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ime");

                    b.Property<string>("KnjigaOpis")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("KnjigaOpis");

                    b.Property<string>("Pisac")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pisac");

                    b.Property<float>("Prosek")
                        .HasColumnType("real")
                        .HasColumnName("Prosek");

                    b.Property<string>("Zanr")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Zanr");

                    b.HasKey("ID");

                    b.ToTable("Knjiga");
                });

            modelBuilder.Entity("ProjekatSWE.Models.Korisnik", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Username");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Adresa");

                    b.Property<int>("BrR")
                        .HasColumnType("int")
                        .HasColumnName("BrR");

                    b.Property<string>("Datum")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Datum");

                    b.Property<string>("Drzava")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Drzava");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ime");

                    b.Property<string>("KPhotoPath")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("KPhotoPath");

                    b.Property<string>("POpis")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("POpis");

                    b.Property<string>("Pol")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pol");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Prezime");

                    b.Property<string>("Pw")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pw");

                    b.HasKey("Username");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("ProjekatSWE.Models.Recenzija", b =>
                {
                    b.Property<int>("IDR")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDR")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDK")
                        .HasColumnType("int")
                        .HasColumnName("IDK");

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Komentar");

                    b.Property<int>("Ocena")
                        .HasColumnType("int")
                        .HasColumnName("Ocena");

                    b.Property<string>("Uname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Uname");

                    b.HasKey("IDR");

                    b.ToTable("Recenzija");
                });
#pragma warning restore 612, 618
        }
    }
}
