﻿// <auto-generated />
using System;
using EthImgStorage_Web_API.Models.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EthImgStorage_Web_API.Migrations
{
    [DbContext(typeof(PlatformDbContext))]
    partial class PlatformDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EthImgStorage_Web_API.Models.DataBase.LegalPersonData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("CompanyName");

                    b.Property<string>("IdPhotoAddress");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("LegalPersonDatas");
                });

            modelBuilder.Entity("EthImgStorage_Web_API.Models.DataBase.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Character");

                    b.Property<string>("EthereumAddress");

                    b.Property<string>("EthereumPassword");

                    b.Property<string>("LastSignInIp");

                    b.Property<DateTime>("LastSignInTime");

                    b.Property<DateTime>("LoginTime");

                    b.Property<long>("Mobile");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
