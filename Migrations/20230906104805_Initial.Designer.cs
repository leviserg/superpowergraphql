﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using superpowergraphql.Data;

#nullable disable

namespace superpowergraphql.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230906104805_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("superpowergraphql.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cccaa09d-7a88-4597-afe8-0fc211e29241"),
                            Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("38a8321a-616f-4080-a534-26d4f3b23f7a"),
                            Title = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("9192a43c-b181-42bf-85fc-21f1e7432e87"),
                            Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("38a8321a-616f-4080-a534-26d4f3b23f7a"),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("2a857883-f362-4e87-ba98-6ade9d22bb0d"),
                            Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("38a8321a-616f-4080-a534-26d4f3b23f7a"),
                            Title = "The Dark Knight Rises"
                        },
                        new
                        {
                            Id = new Guid("9c1b8076-033b-43a3-9a00-b37009b5182a"),
                            Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                            Instructor = "George Lucas",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("d1000b3c-68be-4021-ab6b-09aa0f201a9f"),
                            Title = "Star Wars: Episode IV – A New Hope"
                        },
                        new
                        {
                            Id = new Guid("2a203741-8f64-4c12-80f0-f685e39900d1"),
                            Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                            Instructor = "Irvin Kershner",
                            ReleaseDate = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("d1000b3c-68be-4021-ab6b-09aa0f201a9f"),
                            Title = "Star Wars: Episode V – The Empire Strikes Back"
                        },
                        new
                        {
                            Id = new Guid("061bdf21-48de-4634-810a-d61513e7c782"),
                            Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                            Instructor = "Richard Marquand",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("d1000b3c-68be-4021-ab6b-09aa0f201a9f"),
                            Title = "Star Wars: Episode VI – Return of the Jedi"
                        },
                        new
                        {
                            Id = new Guid("d8a3de3f-0ee8-4eb5-bdb0-18cf14f33f26"),
                            Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                            Instructor = "Cate Shortland",
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("e7929c8e-9f47-4bfd-9c7a-0b21882a2f5e"),
                            Title = "Black Widow"
                        });
                });

            modelBuilder.Entity("superpowergraphql.Models.Superhero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Superheroes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("38a8321a-616f-4080-a534-26d4f3b23f7a"),
                            Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            Height = 1.9299999999999999,
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("d1000b3c-68be-4021-ab6b-09aa0f201a9f"),
                            Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            Height = 1.7,
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("e7929c8e-9f47-4bfd-9c7a-0b21882a2f5e"),
                            Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                            Height = 1.7,
                            Name = "Black Widow"
                        });
                });

            modelBuilder.Entity("superpowergraphql.Models.Superpower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperPower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Superpowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1da25121-acb3-4aee-99cb-68f28adde908"),
                            Description = "He's always a step ahead.",
                            SuperPower = "Intellect.",
                            SuperheroId = new Guid("38a8321a-616f-4080-a534-26d4f3b23f7a")
                        },
                        new
                        {
                            Id = new Guid("c2517153-8c4a-4b20-bef7-bba500e2cdf2"),
                            Description = "Sublime fighting skills.",
                            SuperPower = "Fighting",
                            SuperheroId = new Guid("38a8321a-616f-4080-a534-26d4f3b23f7a")
                        },
                        new
                        {
                            Id = new Guid("d16ed8e1-5daf-4efc-b7e5-ad7037b24775"),
                            Description = "He got a lot of money",
                            SuperPower = "Wealth.",
                            SuperheroId = new Guid("38a8321a-616f-4080-a534-26d4f3b23f7a")
                        },
                        new
                        {
                            Id = new Guid("83ebf74d-3784-4b60-809e-d765a66e3ea1"),
                            Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                            SuperPower = "Deflect blaster power.",
                            SuperheroId = new Guid("d1000b3c-68be-4021-ab6b-09aa0f201a9f")
                        },
                        new
                        {
                            Id = new Guid("1ae8817e-2fcd-4f42-b63a-7ea48055eb36"),
                            Description = "She's good at spying at people.",
                            SuperPower = "Espionage",
                            SuperheroId = new Guid("e7929c8e-9f47-4bfd-9c7a-0b21882a2f5e")
                        },
                        new
                        {
                            Id = new Guid("0ffcd264-d3af-4df9-baf4-a5684504c2b5"),
                            Description = "She knows how to infiltrate the enemy.",
                            SuperPower = "Infiltration",
                            SuperheroId = new Guid("e7929c8e-9f47-4bfd-9c7a-0b21882a2f5e")
                        },
                        new
                        {
                            Id = new Guid("9b405a5b-b213-4fff-8768-ea8d8bd57a64"),
                            Description = "The knowledge of how to undermine others.",
                            SuperPower = "Subterfuge",
                            SuperheroId = new Guid("e7929c8e-9f47-4bfd-9c7a-0b21882a2f5e")
                        });
                });

            modelBuilder.Entity("superpowergraphql.Models.Movie", b =>
                {
                    b.HasOne("superpowergraphql.Models.Superhero", "Superhero")
                        .WithMany("Movies")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("superpowergraphql.Models.Superpower", b =>
                {
                    b.HasOne("superpowergraphql.Models.Superhero", "Superhero")
                        .WithMany("Superpowers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("superpowergraphql.Models.Superhero", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Superpowers");
                });
#pragma warning restore 612, 618
        }
    }
}
