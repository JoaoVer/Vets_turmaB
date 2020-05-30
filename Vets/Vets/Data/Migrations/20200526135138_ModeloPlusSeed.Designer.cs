﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vets.Data;

namespace Vets.Data.Migrations
{
    [DbContext(typeof(VetsDB))]
    [Migration("20200526135138_ModeloPlusSeed")]
    partial class ModeloPlusSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Vets.Models.Animais", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DonoFK")
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<string>("Raca")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DonoFK");

                    b.ToTable("Animais");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DonoFK = 1,
                            Especie = "Cão",
                            Foto = "animal1.jpg",
                            Nome = "Bubi",
                            Peso = 24.0,
                            Raca = "Pastor Alemão"
                        },
                        new
                        {
                            ID = 10,
                            DonoFK = 1,
                            Especie = "Gato",
                            Foto = "animal10.jpg",
                            Nome = "Saltitão",
                            Peso = 2.0,
                            Raca = "Persa"
                        },
                        new
                        {
                            ID = 3,
                            DonoFK = 2,
                            Especie = "Cão",
                            Foto = "animal3.jpg",
                            Nome = "Tripé",
                            Peso = 4.0,
                            Raca = "Serra Estrela"
                        },
                        new
                        {
                            ID = 2,
                            DonoFK = 3,
                            Especie = "Cão",
                            Foto = "animal2.jpg",
                            Nome = "Pastor",
                            Peso = 50.0,
                            Raca = "Serra Estrela"
                        },
                        new
                        {
                            ID = 4,
                            DonoFK = 3,
                            Especie = "Cavalo",
                            Foto = "animal4.jpg",
                            Nome = "Saltador",
                            Peso = 580.0,
                            Raca = "Lusitana"
                        },
                        new
                        {
                            ID = 5,
                            DonoFK = 3,
                            Especie = "Gato",
                            Foto = "animal5.jpg",
                            Nome = "Tareco",
                            Peso = 1.0,
                            Raca = "siamês"
                        },
                        new
                        {
                            ID = 8,
                            DonoFK = 7,
                            Especie = "Cão",
                            Foto = "animal8.jpg",
                            Nome = "Forte",
                            Peso = 20.0,
                            Raca = "Rottweiler"
                        },
                        new
                        {
                            ID = 9,
                            DonoFK = 8,
                            Especie = "Vaca",
                            Foto = "animal9.jpg",
                            Nome = "Castanho",
                            Peso = 652.0,
                            Raca = "Mirandesa"
                        },
                        new
                        {
                            ID = 6,
                            DonoFK = 9,
                            Especie = "Cão",
                            Foto = "animal6.jpg",
                            Nome = "Cusca",
                            Peso = 45.0,
                            Raca = "Labrador"
                        },
                        new
                        {
                            ID = 7,
                            DonoFK = 10,
                            Especie = "Cão",
                            Foto = "animal7.jpg",
                            Nome = "Morde Tudo",
                            Peso = 39.0,
                            Raca = "Dobermann"
                        });
                });

            modelBuilder.Entity("Vets.Models.Consultas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VeterinarioFK")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AnimalFK");

                    b.HasIndex("VeterinarioFK");

                    b.ToTable("Consultas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AnimalFK = 1,
                            Data = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 2,
                            AnimalFK = 3,
                            Data = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 3,
                            AnimalFK = 2,
                            Data = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 4,
                            AnimalFK = 4,
                            Data = new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 2
                        },
                        new
                        {
                            ID = 5,
                            AnimalFK = 9,
                            Data = new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 2
                        },
                        new
                        {
                            ID = 6,
                            AnimalFK = 5,
                            Data = new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 3
                        },
                        new
                        {
                            ID = 7,
                            AnimalFK = 6,
                            Data = new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 3
                        },
                        new
                        {
                            ID = 8,
                            AnimalFK = 7,
                            Data = new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 3
                        },
                        new
                        {
                            ID = 9,
                            AnimalFK = 8,
                            Data = new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 3
                        },
                        new
                        {
                            ID = 10,
                            AnimalFK = 9,
                            Data = new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 2
                        },
                        new
                        {
                            ID = 11,
                            AnimalFK = 10,
                            Data = new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 12,
                            AnimalFK = 7,
                            Data = new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 13,
                            AnimalFK = 1,
                            Data = new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 14,
                            AnimalFK = 2,
                            Data = new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 15,
                            AnimalFK = 5,
                            Data = new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 16,
                            AnimalFK = 6,
                            Data = new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 17,
                            AnimalFK = 9,
                            Data = new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 2
                        },
                        new
                        {
                            ID = 18,
                            AnimalFK = 1,
                            Data = new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 3
                        },
                        new
                        {
                            ID = 19,
                            AnimalFK = 10,
                            Data = new DateTime(2020, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        },
                        new
                        {
                            ID = 20,
                            AnimalFK = 5,
                            Data = new DateTime(2020, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VeterinarioFK = 1
                        });
                });

            modelBuilder.Entity("Vets.Models.Donos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NIF")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("ID");

                    b.ToTable("Donos");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            NIF = "813635582",
                            Nome = "Luís Freitas",
                            Sexo = "M"
                        },
                        new
                        {
                            ID = 2,
                            NIF = "854613462",
                            Nome = "Andreia Gomes",
                            Sexo = "F"
                        },
                        new
                        {
                            ID = 3,
                            NIF = "265368715",
                            Nome = "Cristina Sousa",
                            Sexo = "F"
                        },
                        new
                        {
                            ID = 4,
                            NIF = "835623190",
                            Nome = "Sónia Rosa",
                            Sexo = "F"
                        },
                        new
                        {
                            ID = 5,
                            NIF = "751512205",
                            Nome = "António Santos",
                            Sexo = "M"
                        },
                        new
                        {
                            ID = 6,
                            NIF = "728663835",
                            Nome = "Gustavo Alves",
                            Sexo = "M"
                        },
                        new
                        {
                            ID = 7,
                            NIF = "644388118",
                            Nome = "Rosa Vieira",
                            Sexo = "F"
                        },
                        new
                        {
                            ID = 8,
                            NIF = "262618487",
                            Nome = "Daniel Dias",
                            Sexo = "M"
                        },
                        new
                        {
                            ID = 9,
                            NIF = "842615197",
                            Nome = "Tânia Gomes",
                            Sexo = "F"
                        },
                        new
                        {
                            ID = 10,
                            NIF = "635139506",
                            Nome = "Andreia Correia",
                            Sexo = "F"
                        });
                });

            modelBuilder.Entity("Vets.Models.Veterinarios", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumCedulaProf")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.HasKey("ID");

                    b.ToTable("Veterinarios");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Fotografia = "Maria.jpg",
                            Nome = "Maria Pinto",
                            NumCedulaProf = "vet-34589"
                        },
                        new
                        {
                            ID = 2,
                            Fotografia = "Ricardo.jpg",
                            Nome = "Ricardo Ribeiro",
                            NumCedulaProf = "vet-34590"
                        },
                        new
                        {
                            ID = 3,
                            Fotografia = "Jose.jpg",
                            Nome = "José Soares",
                            NumCedulaProf = "vet-56732"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vets.Models.Animais", b =>
                {
                    b.HasOne("Vets.Models.Donos", "Dono")
                        .WithMany("Animais")
                        .HasForeignKey("DonoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vets.Models.Consultas", b =>
                {
                    b.HasOne("Vets.Models.Animais", "Animal")
                        .WithMany("ListaConsultas")
                        .HasForeignKey("AnimalFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vets.Models.Veterinarios", "Veterinario")
                        .WithMany("Consultas")
                        .HasForeignKey("VeterinarioFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
