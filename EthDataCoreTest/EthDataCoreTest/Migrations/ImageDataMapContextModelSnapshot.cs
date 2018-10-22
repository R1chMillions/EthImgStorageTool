﻿// <auto-generated />
using System;
using DataProcess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EthDataCoreTest.Migrations
{
    [DbContext(typeof(ImageDataMapContext))]
    partial class ImageDataMapContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("DataProcess.ImageDataMap", b =>
                {
                    b.Property<string>("ImageName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountAddress");

                    b.Property<DateTime>("PublishTime");

                    b.Property<string>("TransactionHash");

                    b.HasKey("ImageName");

                    b.ToTable("DataMaps");
                });
#pragma warning restore 612, 618
        }
    }
}