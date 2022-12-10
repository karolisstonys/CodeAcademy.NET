﻿// <auto-generated />
using System;
using L05_Tasks_MSSQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ISBN");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ISBN = "0553211765",
                            Author = "Charles Dickens",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6937),
                            ECoverType = "Hardcover",
                            PublishYear = 1989,
                            Title = "A Tale of Two Cities",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6975)
                        },
                        new
                        {
                            ISBN = "0786275391",
                            Author = "Antoine de Saint-Exupery",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6980),
                            ECoverType = "Hardcover",
                            PublishYear = 2005,
                            Title = "The Little Prince",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6982)
                        },
                        new
                        {
                            ISBN = "1856134032",
                            Author = "Rowling, J. K.",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6984),
                            ECoverType = "Hardcover",
                            PublishYear = 1997,
                            Title = "Harry Potter and The Philosopher's Stone",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6986)
                        },
                        new
                        {
                            ISBN = "0451528905",
                            Author = "Miguel de Cervantes",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6987),
                            ECoverType = "Paperback",
                            PublishYear = 2003,
                            Title = "Don Quixote",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6989)
                        },
                        new
                        {
                            ISBN = "0847980790",
                            Author = "Agatha Christie",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6991),
                            ECoverType = "Paperback",
                            PublishYear = 1939,
                            Title = "And Then There Were None",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6993)
                        },
                        new
                        {
                            ISBN = "0020198817",
                            Author = "F. Scott Fitzgerald",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6994),
                            ECoverType = "Paperback",
                            PublishYear = 1992,
                            Title = "The Great Gatsby",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6996)
                        },
                        new
                        {
                            ISBN = "0553213113",
                            Author = "Herman Melville",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6998),
                            ECoverType = "Paperback",
                            PublishYear = 1981,
                            Title = "Moby Dick",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6999)
                        },
                        new
                        {
                            ISBN = "1400079985",
                            Author = "Leo Tolstoy",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7001),
                            ECoverType = "Paperback",
                            PublishYear = 2008,
                            Title = "War and Peace",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7003)
                        },
                        new
                        {
                            ISBN = "0451526929",
                            Author = "William Shakespeare",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7005),
                            ECoverType = "Paperback",
                            PublishYear = 1998,
                            Title = "Hamlet",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7006)
                        },
                        new
                        {
                            ISBN = "0439136350",
                            Author = "Rowling, J. K.",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7008),
                            ECoverType = "Hardcover",
                            PublishYear = 1999,
                            Title = "Harry Potter And The Prisoner Of Azkaban",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7010)
                        },
                        new
                        {
                            ISBN = "1856136124",
                            Author = "Rowling, J. K.",
                            AvailableBooksInLibrary = 0,
                            Created = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7012),
                            ECoverType = "Paperback",
                            PublishYear = 1998,
                            Title = "Harry Potter and the Chamber of Secrets",
                            Updated = new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7013)
                        });
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.LibraryBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BookISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsTaken")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookISBN");

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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.UserBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BookReturned")
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
                        .WithMany("LibraryBooks")
                        .HasForeignKey("BookISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.UserBook", b =>
                {
                    b.HasOne("L05_Tasks_MSSQL.Models.LibraryBook", "LibraryBook")
                        .WithMany("UserBooks")
                        .HasForeignKey("LibraryBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("L05_Tasks_MSSQL.Models.User", "User")
                        .WithMany("UserBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LibraryBook");

                    b.Navigation("User");
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.Book", b =>
                {
                    b.Navigation("LibraryBooks");
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.LibraryBook", b =>
                {
                    b.Navigation("UserBooks");
                });

            modelBuilder.Entity("L05_Tasks_MSSQL.Models.User", b =>
                {
                    b.Navigation("UserBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
