// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

// <auto-generated />
using System;
using DataImport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataImport.Models.Migrations.SqlServer
{
    [DbContext(typeof(SqlDataImportDbContext))]
    [Migration("20190903191213_Update-V25-Api-Versions")]
    partial class UpdateV25ApiVersions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataImport.Models.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgentAction")
                        .HasMaxLength(50);

                    b.Property<string>("AgentTypeCode")
                        .HasMaxLength(50);

                    b.Property<bool>("Archived");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("Directory");

                    b.Property<bool>("Enabled");

                    b.Property<string>("FilePattern");

                    b.Property<DateTimeOffset?>("LastExecuted");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Password");

                    b.Property<Guid>("Queue");

                    b.Property<string>("Url");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("DataImport.Models.AgentSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentId");

                    b.Property<int>("Day");

                    b.Property<int>("Hour");

                    b.Property<int>("Minute");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.ToTable("AgentSchedules");
                });

            modelBuilder.Entity("DataImport.Models.ApiServer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApiVersion")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("AuthUrl")
                        .HasMaxLength(255);

                    b.Property<string>("Key")
                        .IsRequired();

                    b.Property<string>("Secret")
                        .IsRequired();

                    b.Property<string>("TokenUrl")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ApiServers");
                });

            modelBuilder.Entity("DataImport.Models.ApplicationLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Exception");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<DateTimeOffset>("Logged");

                    b.Property<string>("Logger")
                        .HasMaxLength(300);

                    b.Property<string>("MachineName")
                        .HasMaxLength(200);

                    b.Property<string>("Message");

                    b.Property<string>("Port")
                        .HasMaxLength(100);

                    b.Property<string>("Properties");

                    b.Property<string>("RemoteAddress");

                    b.Property<string>("ServerAddress")
                        .HasMaxLength(100);

                    b.Property<string>("ServerName")
                        .HasMaxLength(200);

                    b.Property<string>("Url")
                        .HasMaxLength(2000);

                    b.Property<string>("UserName")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Logged");

                    b.ToTable("ApplicationLogs");
                });

            modelBuilder.Entity("DataImport.Models.BootstrapData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("CreateDate");

                    b.Property<string>("Data")
                        .IsRequired();

                    b.Property<string>("Metadata")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("ProcessedDate");

                    b.Property<int>("ProcessingOrder");

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("BootstrapDatas");
                });

            modelBuilder.Entity("DataImport.Models.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactEmail");

                    b.Property<string>("ContactName");

                    b.Property<string>("ContactOrganization");

                    b.Property<bool>("InstanceAllowUserRegistration")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTimeOffset?>("JanitorReportLast");

                    b.Property<string>("TemplateSharingApiKey");

                    b.Property<string>("TemplateSharingApiSecret");

                    b.Property<string>("TemplateSharingApiUrl");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("DataImport.Models.DataMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColumnHeaders");

                    b.Property<DateTimeOffset?>("CreateDate");

                    b.Property<string>("Map")
                        .IsRequired();

                    b.Property<string>("Metadata")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("DataMaps");
                });

            modelBuilder.Entity("DataImport.Models.DataMapAgent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentId");

                    b.Property<int>("DataMapId");

                    b.Property<int>("ProcessingOrder");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("DataMapId");

                    b.ToTable("DataMapAgents");
                });

            modelBuilder.Entity("DataImport.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentId");

                    b.Property<DateTimeOffset?>("CreateDate");

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<string>("Message");

                    b.Property<int?>("Rows");

                    b.Property<int>("Status");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("CreateDate");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("DataImport.Models.IngestionLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgentId");

                    b.Property<string>("Data");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<Guid?>("EducationOrganizationId");

                    b.Property<string>("EndPointUrl");

                    b.Property<string>("FileName");

                    b.Property<string>("HttpStatusCode");

                    b.Property<string>("Level")
                        .HasMaxLength(255);

                    b.Property<string>("OdsResponse");

                    b.Property<string>("Operation")
                        .HasMaxLength(255);

                    b.Property<string>("Process");

                    b.Property<int>("Result");

                    b.Property<string>("RowNumber");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("Date");

                    b.HasIndex("Result");

                    b.ToTable("IngestionLogs");
                });

            modelBuilder.Entity("DataImport.Models.Lookup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<string>("SourceTable")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.HasIndex("SourceTable", "Key")
                        .IsUnique();

                    b.ToTable("Lookups");
                });

            modelBuilder.Entity("DataImport.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiSection");

                    b.Property<string>("Metadata")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("DataImport.Models.AgentSchedule", b =>
                {
                    b.HasOne("DataImport.Models.Agent", "Agent")
                        .WithMany("AgentSchedules")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataImport.Models.DataMapAgent", b =>
                {
                    b.HasOne("DataImport.Models.Agent", "Agent")
                        .WithMany("DataMapAgents")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataImport.Models.DataMap", "DataMap")
                        .WithMany("DataMapAgents")
                        .HasForeignKey("DataMapId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataImport.Models.File", b =>
                {
                    b.HasOne("DataImport.Models.Agent", "Agent")
                        .WithMany("Files")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataImport.Models.IngestionLog", b =>
                {
                    b.HasOne("DataImport.Models.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");
                });
#pragma warning restore 612, 618
        }
    }
}
