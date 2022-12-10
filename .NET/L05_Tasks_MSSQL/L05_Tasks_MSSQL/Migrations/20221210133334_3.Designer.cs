﻿// <auto-generated />
using System;
using L05_Tasks_MSSQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    [Migration("20221210133334_3")]
    partial class _3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AvailableBooksInLibrary")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("ECoverType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Marcel Proust",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6746),
                            ECoverType = "Paperback",
                            PublishYear = 2001,
                            Title = "In Search of Lost Time",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6781)
                        },
                        new
                        {
                            Id = 2,
                            Author = "James Joyce",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6785),
                            ECoverType = "Hardcover",
                            PublishYear = 2002,
                            Title = "Ulysses",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6787)
                        },
                        new
                        {
                            Id = 3,
                            Author = "Miguel de Cervantes",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6789),
                            ECoverType = "Electronic",
                            PublishYear = 2003,
                            Title = "Don Quixote",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6791)
                        },
                        new
                        {
                            Id = 4,
                            Author = "Gabriel Garcia Marquez",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6792),
                            ECoverType = "Hardcover",
                            PublishYear = 2004,
                            Title = "One Hundred Years of Solitude",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6794)
                        },
                        new
                        {
                            Id = 5,
                            Author = "F. Scott Fitzgerald",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6796),
                            ECoverType = "Hardcover",
                            PublishYear = 2005,
                            Title = "The Great Gatsby",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6797)
                        },
                        new
                        {
                            Id = 6,
                            Author = "Herman Melville",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6799),
                            ECoverType = "Paperback",
                            PublishYear = 2006,
                            Title = "Moby Dick",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6848)
                        },
                        new
                        {
                            Id = 7,
                            Author = "Leo Tolstoy",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6851),
                            ECoverType = "Paperback",
                            PublishYear = 2007,
                            Title = "War and Peace",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6853)
                        },
                        new
                        {
                            Id = 8,
                            Author = "William Shakespeare",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6855),
                            ECoverType = "Hardcover",
                            PublishYear = 2008,
                            Title = "Hamlet",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6856)
                        },
                        new
                        {
                            Id = 9,
                            Author = "William Shakespeare",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6858),
                            ECoverType = "Hardcover",
                            PublishYear = 2009,
                            Title = "King Lear",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6860)
                        },
                        new
                        {
                            Id = 10,
                            Author = "William Shakespeare",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6862),
                            ECoverType = "Paperback",
                            PublishYear = 2010,
                            Title = "The Tempest",
                            Updated = new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6863)
                        });
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.LibraryBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsTaken")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("LibraryBooks");
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.UserBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BookReturned")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookTaken")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibraryBookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LibraryBookId");

                    b.HasIndex("UserId");

                    b.ToTable("UserBooks");
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.LibraryBook", b =>
                {
                    b.HasOne("L05_Tasks_MSSQL.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.UserBook", b =>
                {
                    b.HasOne("L05_Tasks_MSSQL.Models.LibraryBook", "LibraryBook")
                        .WithMany()
                        .HasForeignKey("LibraryBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("L05_Tasks_MSSQL.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LibraryBook");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
