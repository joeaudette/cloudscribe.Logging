﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using cloudscribe.Logging.EFCore.PostgreSql;

namespace cloudscribe.Logging.EFCore.PostgreSql.Migrations
{
    [DbContext(typeof(LoggingDbContext))]
    partial class LoggingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", "'uuid-ossp', '', ''")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("Relational:Sequence:.LogIds", "'LogIds', '', '1', '1', '', '', 'Int64', 'False'");

            modelBuilder.Entity("cloudscribe.Logging.Models.LogItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Culture")
                        .HasColumnName("culture")
                        .HasMaxLength(10);

                    b.Property<int>("EventId")
                        .HasColumnName("event_id");

                    b.Property<string>("IpAddress")
                        .HasColumnName("ip_address")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LogDateUtc")
                        .HasColumnName("log_date");

                    b.Property<string>("LogLevel")
                        .HasColumnName("log_level")
                        .HasMaxLength(20);

                    b.Property<string>("Logger")
                        .HasColumnName("logger")
                        .HasMaxLength(255);

                    b.Property<string>("Message")
                        .HasColumnName("message");

                    b.Property<string>("ShortUrl")
                        .HasColumnName("short_url")
                        .HasMaxLength(255);

                    b.Property<string>("StateJson")
                        .HasColumnName("state_json");

                    b.Property<string>("Thread")
                        .HasColumnName("thread")
                        .HasMaxLength(255);

                    b.Property<string>("Url")
                        .HasColumnName("url");

                    b.HasKey("Id")
                        .HasName("pk_cs_system_log");

                    b.ToTable("cs_system_log");
                });
#pragma warning restore 612, 618
        }
    }
}