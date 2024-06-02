﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebshopApi.Data;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240308105115_dodanStatusNarudzbe")]
    partial class dodanStatusNarudzbe
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI.Data.Models.Artikl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artikl");
                });

            modelBuilder.Entity("WebAPI.Data.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("Is2FOtkljucano")
                        .HasColumnType("bit");

                    b.Property<int>("KorisnickiRacunId")
                        .HasColumnType("int");

                    b.Property<string>("TwoFKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrijednost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiRacunId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("WebAPI.Data.Models.BlokiranaPrijavaRačun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KorisnickiRacunID")
                        .HasColumnType("int");

                    b.Property<DateTime>("VrijemeOdblokade")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiRacunID");

                    b.ToTable("BlokiranaPrijavaRačun");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Brend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brend");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Kategorije.GlavnaKategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GlavnaKategorija");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Kategorije.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GlavnaKategorijaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GlavnaKategorijaID");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Kategorije.Potkategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategorijaID");

                    b.ToTable("Potkategorija");
                });

            modelBuilder.Entity("WebAPI.Data.Models.KorisnickiRacun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumModifikovanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Is2FActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isKupac")
                        .HasColumnType("bit");

                    b.Property<bool>("saljiNovosti")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KorisnickiRacun");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("WebAPI.Data.Models.Korpa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("KupacId")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Korpa");
                });

            modelBuilder.Entity("WebAPI.Data.Models.LogKretanjePoSistemu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ExceptionMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsException")
                        .HasColumnType("bit");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("PostData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueryPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Vrijeme")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("LogKretanjePoSistemu");
                });

            modelBuilder.Entity("WebAPI.Data.Models.LogOdjava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("IpAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Vrijeme")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("LogOdjava");
                });

            modelBuilder.Entity("WebAPI.Data.Models.LogPrijava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("IpAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<bool>("Uspjesno")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Vrijeme")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("LogPrijava");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Ocjena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KupacId")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<int>("Vrijednost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Proizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrendID")
                        .HasColumnType("int");

                    b.Property<int>("BrojKlikova")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PocetnaCijena")
                        .HasColumnType("real");

                    b.Property<int>("PocetnaKolicina")
                        .HasColumnType("int");

                    b.Property<int>("Popust")
                        .HasColumnType("int");

                    b.Property<int>("PotkategorijaID")
                        .HasColumnType("int");

                    b.Property<string>("SlikaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrendID");

                    b.HasIndex("PotkategorijaID");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("WebAPI.Data.Models.ProizvodSlika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<string>("SlikaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProizvodSlika");
                });

            modelBuilder.Entity("WebAPI.Data.Models.RacunAktivacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActivateKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnickiRacunID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiRacunID");

                    b.ToTable("RacunAktivacija");
                });

            modelBuilder.Entity("WebAPI.Data.Models.StatusNarudzbe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StatusNarudzbe");
                });

            modelBuilder.Entity("WebAPI.Data.Models.UpozorenjeKorisnickiRacun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KorisnickiRacunID")
                        .HasColumnType("int");

                    b.Property<string>("TipProblema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiRacunID");

                    b.ToTable("UpozorenjeKorisnickiRacun");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Administrator", b =>
                {
                    b.HasBaseType("WebAPI.Data.Models.KorisnickiRacun");

                    b.Property<DateTime?>("ZadnjiLogin")
                        .HasColumnType("datetime2");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Kupac", b =>
                {
                    b.HasBaseType("WebAPI.Data.Models.KorisnickiRacun");

                    b.ToTable("Kupac");
                });

            modelBuilder.Entity("WebAPI.Data.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("WebAPI.Data.Models.KorisnickiRacun", "korisnickiRacun")
                        .WithMany()
                        .HasForeignKey("KorisnickiRacunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiRacun");
                });

            modelBuilder.Entity("WebAPI.Data.Models.BlokiranaPrijavaRačun", b =>
                {
                    b.HasOne("WebAPI.Data.Models.KorisnickiRacun", "KorisnickiRacun")
                        .WithMany()
                        .HasForeignKey("KorisnickiRacunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiRacun");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Kategorije.Kategorija", b =>
                {
                    b.HasOne("WebAPI.Data.Models.Kategorije.GlavnaKategorija", "GlavnaKategorija")
                        .WithMany()
                        .HasForeignKey("GlavnaKategorijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GlavnaKategorija");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Kategorije.Potkategorija", b =>
                {
                    b.HasOne("WebAPI.Data.Models.Kategorije.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategorija");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Korpa", b =>
                {
                    b.HasOne("WebAPI.Data.Models.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Data.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupac");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("WebAPI.Data.Models.LogKretanjePoSistemu", b =>
                {
                    b.HasOne("WebAPI.Data.Models.KorisnickiRacun", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("WebAPI.Data.Models.LogOdjava", b =>
                {
                    b.HasOne("WebAPI.Data.Models.KorisnickiRacun", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("WebAPI.Data.Models.LogPrijava", b =>
                {
                    b.HasOne("WebAPI.Data.Models.KorisnickiRacun", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Ocjena", b =>
                {
                    b.HasOne("WebAPI.Data.Models.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Data.Models.Proizvod", "Proizvod")
                        .WithMany("Ocjene")
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupac");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Proizvod", b =>
                {
                    b.HasOne("WebAPI.Data.Models.Brend", "Brend")
                        .WithMany()
                        .HasForeignKey("BrendID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Data.Models.Kategorije.Potkategorija", "Potkategorija")
                        .WithMany()
                        .HasForeignKey("PotkategorijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brend");

                    b.Navigation("Potkategorija");
                });

            modelBuilder.Entity("WebAPI.Data.Models.RacunAktivacija", b =>
                {
                    b.HasOne("WebAPI.Data.Models.KorisnickiRacun", "KorisnickiRacun")
                        .WithMany()
                        .HasForeignKey("KorisnickiRacunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiRacun");
                });

            modelBuilder.Entity("WebAPI.Data.Models.UpozorenjeKorisnickiRacun", b =>
                {
                    b.HasOne("WebAPI.Data.Models.KorisnickiRacun", "KorisnickiRacun")
                        .WithMany()
                        .HasForeignKey("KorisnickiRacunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiRacun");
                });

            modelBuilder.Entity("WebAPI.Data.Models.Administrator", b =>
                {
                    b.HasOne("WebAPI.Data.Models.KorisnickiRacun", null)
                        .WithOne()
                        .HasForeignKey("WebAPI.Data.Models.Administrator", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Data.Models.Kupac", b =>
                {
                    b.HasOne("WebAPI.Data.Models.KorisnickiRacun", null)
                        .WithOne()
                        .HasForeignKey("WebAPI.Data.Models.Kupac", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Data.Models.Proizvod", b =>
                {
                    b.Navigation("Ocjene");
                });
#pragma warning restore 612, 618
        }
    }
}
