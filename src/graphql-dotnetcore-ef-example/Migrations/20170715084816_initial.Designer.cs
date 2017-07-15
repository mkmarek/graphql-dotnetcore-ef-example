using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GraphQLCMS.Database;

namespace graphqldotnetcoreefexample.Migrations
{
    [DbContext(typeof(CmsContext))]
    [Migration("20170715084816_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GraphQLCMS.Database.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuthorId");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("article");
                });

            modelBuilder.Entity("GraphQLCMS.Database.Entities.ArticleTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArticleId");

                    b.Property<int?>("ArticleTagId");

                    b.Property<string>("TagName");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ArticleTagId");

                    b.ToTable("article_tag");
                });

            modelBuilder.Entity("GraphQLCMS.Database.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("author");
                });

            modelBuilder.Entity("GraphQLCMS.Database.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArticleId");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ParentId");

                    b.ToTable("category");
                });

            modelBuilder.Entity("GraphQLCMS.Database.Entities.Article", b =>
                {
                    b.HasOne("GraphQLCMS.Database.Entities.Author", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("GraphQLCMS.Database.Entities.ArticleTag", b =>
                {
                    b.HasOne("GraphQLCMS.Database.Entities.Article")
                        .WithMany("Tags")
                        .HasForeignKey("ArticleId");

                    b.HasOne("GraphQLCMS.Database.Entities.ArticleTag")
                        .WithMany("Articles")
                        .HasForeignKey("ArticleTagId");
                });

            modelBuilder.Entity("GraphQLCMS.Database.Entities.Category", b =>
                {
                    b.HasOne("GraphQLCMS.Database.Entities.Article")
                        .WithMany("Categories")
                        .HasForeignKey("ArticleId");

                    b.HasOne("GraphQLCMS.Database.Entities.Category", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });
        }
    }
}
