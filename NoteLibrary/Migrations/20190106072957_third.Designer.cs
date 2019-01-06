﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteLibrary.Models.Contexts;

namespace NoteLibrary.Migrations
{
    [DbContext(typeof(NoteContext))]
    [Migration("20190106072957_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NoteLibrary.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryIdId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("State");

                    b.HasKey("Id");

                    b.HasIndex("CategoryIdId");

                    b.ToTable("CategoryTable");
                });

            modelBuilder.Entity("NoteLibrary.Models.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddedUserUserName");

                    b.Property<int?>("CategoryId");

                    b.Property<string>("CourseName")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("FilePath")
                        .IsRequired();

                    b.Property<bool>("State");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UploadDate");

                    b.HasKey("Id");

                    b.HasIndex("AddedUserUserName");

                    b.HasIndex("CategoryId");

                    b.ToTable("FileTable");
                });

            modelBuilder.Entity("NoteLibrary.Models.Entities.User", b =>
                {
                    b.Property<string>("UserName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Department")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Id");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<bool>("State");

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<string>("University")
                        .IsRequired();

                    b.HasKey("UserName");

                    b.ToTable("UserTable");
                });

            modelBuilder.Entity("NoteLibrary.Models.Entities.Category", b =>
                {
                    b.HasOne("NoteLibrary.Models.Entities.Category", "CategoryId")
                        .WithMany()
                        .HasForeignKey("CategoryIdId");
                });

            modelBuilder.Entity("NoteLibrary.Models.Entities.File", b =>
                {
                    b.HasOne("NoteLibrary.Models.Entities.User", "AddedUser")
                        .WithMany("Files")
                        .HasForeignKey("AddedUserUserName");

                    b.HasOne("NoteLibrary.Models.Entities.Category", "Category")
                        .WithMany("Files")
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
