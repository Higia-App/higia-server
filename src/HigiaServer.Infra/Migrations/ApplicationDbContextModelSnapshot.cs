﻿// <auto-generated />
using System;
using HigiaServer.Domain.Entities;
using HigiaServer.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HigiaServer.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("HigiaServer.Domain.Common.BaseUserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasColumnName("address");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("birthday");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("created_at");

                    b.Property<Administrator>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("BOOLEAN")
                        .HasColumnName("is_admin");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("last_modified_at");

                    b.Property<Administrator>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("uuid")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("user", (string)null);

                    b.HasDiscriminator<bool>("IsAdmin");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HigiaServer.Domain.Entities.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("created_at");

                    b.Property<Administrator>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasColumnName("description");

                    b.Property<string>("EndCoordinate")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasColumnName("final_coordinate");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("end_time");

                    b.Property<DateTime>("ExpectedEndTime")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("expected_end_time");

                    b.Property<string>("InitialCoordinate")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasColumnName("initial_coordinate");

                    b.Property<DateTime>("InitialTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("last_modified_at");

                    b.Property<Administrator>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("uuid")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasColumnName("observation");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("start_time");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("task", (string)null);
                });

            modelBuilder.Entity("task_user", b =>
                {
                    b.Property<Guid>("user_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("task_id")
                        .HasColumnType("uuid");

                    b.HasKey("user_id", "task_id");

                    b.HasIndex("task_id");

                    b.ToTable("task_user");
                });

            modelBuilder.Entity("HigiaServer.Domain.Entities.Administrator", b =>
                {
                    b.HasBaseType("HigiaServer.Domain.Common.BaseUserEntity");

                    b.HasDiscriminator().HasValue(true);
                });

            modelBuilder.Entity("HigiaServer.Domain.Entities.Collaborator", b =>
                {
                    b.HasBaseType("HigiaServer.Domain.Common.BaseUserEntity");

                    b.HasDiscriminator().HasValue(false);
                });

            modelBuilder.Entity("task_user", b =>
                {
                    b.HasOne("HigiaServer.Domain.Entities.Task", null)
                        .WithMany()
                        .HasForeignKey("task_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HigiaServer.Domain.Entities.Collaborator", null)
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
