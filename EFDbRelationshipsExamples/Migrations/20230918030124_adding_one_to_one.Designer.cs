﻿// <auto-generated />
using EFDbRelationshipsExamples.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDbRelationshipsExamples.Migrations
{
    [DbContext(typeof(DbContextSqlServer))]
    [Migration("20230918030124_adding_one_to_one")]
    partial class adding_one_to_one
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFDbRelationshipsExamples.Entities.Backpack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Backpacks");
                });

            modelBuilder.Entity("EFDbRelationshipsExamples.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("EFDbRelationshipsExamples.Entities.Backpack", b =>
                {
                    b.HasOne("EFDbRelationshipsExamples.Entities.Character", "Character")
                        .WithOne("BackPack")
                        .HasForeignKey("EFDbRelationshipsExamples.Entities.Backpack", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("EFDbRelationshipsExamples.Entities.Character", b =>
                {
                    b.Navigation("BackPack")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
