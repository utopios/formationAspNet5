﻿// <auto-generated />
using FormationAspNet5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FormationAspNet5.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("FormationAspNet5.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext")
                        .HasColumnName("adresse");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext")
                        .HasColumnName("prenom");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("nom");

                    b.HasKey("Id");

                    b.ToTable("personne");
                });
#pragma warning restore 612, 618
        }
    }
}
