using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TestFilm.Models;

namespace TestFilm.Migrations
{
    [DbContext(typeof(FilmContext))]
    [Migration("20170508213040_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestFilm.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Director");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("User");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });
        }
    }
}
