﻿// <auto-generated />
using System;
using AttributeRouting.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AttributeRouting.Migrations
{
    [DbContext(typeof(BookSampleContext))]
    [Migration("20210107101216_seeddata")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AttributeRouting.Model.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Name = "Chris Anderson"
                        },
                        new
                        {
                            AuthorId = 2,
                            Name = "Cole Nussbaumer Knaflic"
                        },
                        new
                        {
                            AuthorId = 3,
                            Name = "Jeff Patton"
                        },
                        new
                        {
                            AuthorId = 4,
                            Name = "John MacCormick"
                        });
                });

            modelBuilder.Entity("AttributeRouting.Model.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            Description = "你可以用言語來改變自己，也改變世界 TED唯一官方版演講指南（限量精裝版）",
                            Genre = "溝通說話",
                            Price = 320m,
                            PublishDate = new DateTime(2016, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "TED TALKS 說話的力量"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            Description = "打破80/20法則，獲利無限延伸 (最新增訂版)",
                            Genre = "經濟學",
                            Price = 450m,
                            PublishDate = new DateTime(2009, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "尾理論"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 2,
                            Description = "Google總監首度公開絕活，教你做對圖表、說對話，所有人都聽你的！",
                            Genre = "演講/簡報",
                            Price = 420m,
                            PublishDate = new DateTime(2016, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Google必修的圖表簡報術"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 3,
                            Description = "大型的便利貼模型，期望你感受到整個團隊全心參與並且充滿創造性。",
                            Genre = "Software",
                            Price = 580m,
                            PublishDate = new DateTime(2016, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "User Story Mapping"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 4,
                            Description = "讓今日電腦無所不能的最強概念",
                            Genre = "觀念/趨勢",
                            Price = 360m,
                            PublishDate = new DateTime(2014, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "改變世界的九大演算法"
                        });
                });

            modelBuilder.Entity("AttributeRouting.Model.Book", b =>
                {
                    b.HasOne("AttributeRouting.Model.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
