﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Office_assistant.Context;

namespace Office_assistant.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190625122711_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Office_assistant.Model.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("Office_assistant.Model.subFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FoodId");

                    b.Property<string>("Food_name")
                        .IsRequired();

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.ToTable("subFood");
                });

            modelBuilder.Entity("Office_assistant.Model.subFood", b =>
                {
                    b.HasOne("Office_assistant.Model.Food")
                        .WithMany("subFoods")
                        .HasForeignKey("FoodId");
                });
#pragma warning restore 612, 618
        }
    }
}
