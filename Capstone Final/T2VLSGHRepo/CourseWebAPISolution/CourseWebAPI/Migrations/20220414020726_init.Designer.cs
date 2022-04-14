﻿// <auto-generated />
using System;
using CourseWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseWebAPI.Migrations
{
    [DbContext(typeof(VLSContext))]
    [Migration("20220414020726_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseWebAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "daniel@.net.com",
                            Name = "Daniel",
                            Number = "987654321",
                            Specialization = "HTML5, CSS, JS, TS"
                        },
                        new
                        {
                            Id = 2,
                            Email = "alif@.net.com",
                            Name = "Alif",
                            Number = "987654321",
                            Specialization = "Angular"
                        },
                        new
                        {
                            Id = 3,
                            Email = "subbu@.net.com",
                            Name = "Subbu",
                            Number = "987654321",
                            Specialization = ".NET, Angular, HTML5, CSS, JS, TS"
                        },
                        new
                        {
                            Id = 4,
                            Email = "meer@.net.com",
                            Name = "Meer",
                            Number = "987654321",
                            Specialization = ".NET, Angular"
                        });
                });

            modelBuilder.Entity("CourseWebAPI.Models.Certificate", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentUserName");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("CourseWebAPI.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("End")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Start")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Cost = 59.9f,
                            Description = "random string",
                            End = "25-04-2022, 09:00",
                            Name = ".NET Core",
                            Start = "20-04-2022, 09:00",
                            Video = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Cost = 1.5f,
                            Description = "U smile and then u happy",
                            End = "20-05-2022, 09:00",
                            Name = "How to be Happy",
                            Start = "20-04-2022, 09:00",
                            Video = "https://www.youtube.com/watch?v=kB8pG1-dIAA"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Cost = 12.9f,
                            Description = "focus on the things not done",
                            End = "05-05-2022, 09:00",
                            Name = "How to be truly agile",
                            Start = "01-05-2022, 09:00",
                            Video = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 3,
                            Cost = 0f,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            End = "20-06-2022, 11:00",
                            Name = "Long test and how to copy paste",
                            Start = "20-04-2022, 10:00",
                            Video = "https://www.youtube.com/watch?v=kB8pG1-dIAA"
                        });
                });

            modelBuilder.Entity("CourseWebAPI.Models.Student", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PassKey")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Password")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("UserName");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseWebAPI.Models.StudentCourse", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("StudentUserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentUserName");

                    b.ToTable("StudentsCourses");
                });

            modelBuilder.Entity("CourseWebAPI.Models.Certificate", b =>
                {
                    b.HasOne("CourseWebAPI.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseWebAPI.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentUserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CourseWebAPI.Models.Course", b =>
                {
                    b.HasOne("CourseWebAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("CourseWebAPI.Models.StudentCourse", b =>
                {
                    b.HasOne("CourseWebAPI.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseWebAPI.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentUserName");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
