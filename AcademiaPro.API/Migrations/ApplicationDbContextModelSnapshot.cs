﻿// <auto-generated />
using System;
using AcademiaPro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AcademiaPro.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("sms_app")
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("AcademiaPro.Domain.Entities.Classroom", b =>
                {
                    b.Property<int>("ClassroomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("ClassroomId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LevelId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<int>("StudentCount")
                        .HasColumnType("integer");

                    b.HasKey("ClassroomId");

                    b.HasIndex("LevelId");

                    b.ToTable("Classrooms", "sms_app");
                });

            modelBuilder.Entity("AcademiaPro.Domain.Entities.Level", b =>
                {
                    b.Property<int>("LevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("LevelId"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.HasKey("LevelId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Classes", "sms_app");

                    b.HasData(
                        new
                        {
                            LevelId = 1,
                            CreatedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5044),
                            LastModifiedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5092),
                            Name = "Class 1",
                            SortOrder = 1
                        },
                        new
                        {
                            LevelId = 2,
                            CreatedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5096),
                            LastModifiedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5097),
                            Name = "Class 2",
                            SortOrder = 2
                        },
                        new
                        {
                            LevelId = 3,
                            CreatedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5100),
                            LastModifiedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5101),
                            Name = "Class 3",
                            SortOrder = 3
                        },
                        new
                        {
                            LevelId = 4,
                            CreatedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5102),
                            LastModifiedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5103),
                            Name = "Class 4",
                            SortOrder = 4
                        },
                        new
                        {
                            LevelId = 5,
                            CreatedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5104),
                            LastModifiedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5105),
                            Name = "Class 5",
                            SortOrder = 5
                        },
                        new
                        {
                            LevelId = 6,
                            CreatedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5106),
                            LastModifiedAt = new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5124),
                            Name = "Class 6",
                            SortOrder = 6
                        });
                });

            modelBuilder.Entity("AcademiaPro.Domain.Entities.Classroom", b =>
                {
                    b.HasOne("AcademiaPro.Domain.Entities.Level", "Level")
                        .WithMany("Classrooms")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");
                });

            modelBuilder.Entity("AcademiaPro.Domain.Entities.Level", b =>
                {
                    b.Navigation("Classrooms");
                });
#pragma warning restore 612, 618
        }
    }
}
