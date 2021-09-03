﻿// <auto-generated />
using System;
using JAP_Task_1_MoviesApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JAP_Task_1_MoviesApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("JAP_Task_1_MoviesApi.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Overview")
                        .HasColumnType("text");

                    b.Property<string>("PosterPath")
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<double>("VoteAverage")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Overview = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/iXbWpCkIauBMStSTUT9v4GXvdgH.jpg",
                            ReleaseDate = new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Suicide Squad",
                            VoteAverage = 8.0
                        },
                        new
                        {
                            Id = 2,
                            Overview = "A devastated husband vows to bring justice to the people responsible for his wife's death while protecting the only family he has left, his daughter.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/cP7odDzzFBD9ycxj2laTeFWGLjD.jpg",
                            ReleaseDate = new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sweet Girl",
                            VoteAverage = 7.0
                        },
                        new
                        {
                            Id = 3,
                            Overview = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg",
                            ReleaseDate = new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Jungle Cruise",
                            VoteAverage = 7.9000000000000004
                        },
                        new
                        {
                            Id = 4,
                            Overview = "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling metropolis into a state of chaos.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg",
                            ReleaseDate = new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "PAW Patrol: The Movie",
                            VoteAverage = 8.0999999999999996
                        },
                        new
                        {
                            Id = 5,
                            Overview = "A rooster and his fowl partner embark on a dangerous trip to the Congo to recover their stolen eggs from a group of Russian goons.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/wrlQnKHLCBheXMNWotyr5cVDqNM.jpg",
                            ReleaseDate = new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Eggs Run",
                            VoteAverage = 8.4000000000000004
                        },
                        new
                        {
                            Id = 6,
                            Overview = "Natasha Romanoff, also known as Black Widow, confronts the darker parts of her ledger when a dangerous conspiracy with ties to her past arises. Pursued by a force that will stop at nothing to bring her down, Natasha must deal with her history as a spy and the broken relationships left in her wake long before she became an Avenger.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg",
                            ReleaseDate = new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Black Widow",
                            VoteAverage = 7.7999999999999998
                        },
                        new
                        {
                            Id = 7,
                            Overview = "When LeBron and his young son Dom are trapped in a digital space by a rogue A.I., LeBron must get them home safe by leading Bugs, Lola Bunny and the whole gang of notoriously undisciplined Looney Tunes to victory over the A.I.'s digitized champions on the court. It's Tunes versus Goons in the highest-stakes challenge of his life.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg",
                            ReleaseDate = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Space Jam: A New Legacy",
                            VoteAverage = 7.5
                        },
                        new
                        {
                            Id = 8,
                            Overview = "A man will become a criminal to save his family.  Director: Shawn Welling  Writer: Derek H. Potts  Stars: Tom Vera, Tom Sizemore, Lee Majors |",
                            PosterPath = "https://image.tmdb.org/t/p/w500/7p0O4mKYLIhU2E5Zcq9Z3vOZ4e9.jpg",
                            ReleaseDate = new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Narco Sub",
                            VoteAverage = 7.0999999999999996
                        },
                        new
                        {
                            Id = 9,
                            Overview = "A bank teller called Guy realizes he is a background character in an open world video game called Free City that will soon go offline.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/hEqw9swA8gFJuNjgWYEypwZfkZg.jpg",
                            ReleaseDate = new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Free Guy",
                            VoteAverage = 7.7999999999999998
                        },
                        new
                        {
                            Id = 10,
                            Overview = "Evan McCauley has skills he never learned and memories of places he has never visited. Self-medicated and on the brink of a mental breakdown, a secret group that call themselves “Infinites” come to his rescue, revealing that his memories are real.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg",
                            ReleaseDate = new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Infinite",
                            VoteAverage = 7.5
                        },
                        new
                        {
                            Id = 11,
                            Overview = "Whilst vacationing in Greece, Beckett, becomes the target of a manhunt after a devastating car accident forces him to run for his life across the country to clear his name but tensions escalate as the authorities close in and political unrest mounts which makes Beckett fall even deeper into a dangerous web of conspiracy.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/fBJducGBcmrcIOQdhm4BUBNDiMu.jpg",
                            ReleaseDate = new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Beckett",
                            VoteAverage = 6.5
                        },
                        new
                        {
                            Id = 12,
                            Overview = "Dominic Toretto and his crew battle the most skilled assassin and high-performance driver they've ever encountered: his forsaken brother.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg",
                            ReleaseDate = new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "F9",
                            VoteAverage = 7.5999999999999996
                        },
                        new
                        {
                            Id = 13,
                            Overview = "The Templeton brothers — Tim and his Boss Baby little bro Ted — have become adults and drifted away from each other. But a new boss baby with a cutting-edge approach and a can-do attitude is about to bring them together again … and inspire a new family business.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/kv2Qk9MKFFQo4WQPaYta599HkJP.jpg",
                            ReleaseDate = new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Boss Baby",
                            VoteAverage = 7.7999999999999998
                        },
                        new
                        {
                            Id = 14,
                            Overview = "A waiter pretends to be an important businessman in order to reach the upper class through his entrepreneurial dreams.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/zvGC5jX5wQmU1GgPc0VGZz7Mtcs.jpg",
                            ReleaseDate = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "El mesero",
                            VoteAverage = 8.5
                        },
                        new
                        {
                            Id = 15,
                            Overview = "Luca and his best friend Alberto experience an unforgettable summer on the Italian Riviera. But all the fun is threatened by a deeply-held secret: they are sea monsters from another world just below the water’s surface.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/jTswp6KyDYKtvC52GbHagrZbGvD.jpg",
                            ReleaseDate = new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Luca",
                            VoteAverage = 8.0999999999999996
                        },
                        new
                        {
                            Id = 16,
                            Overview = "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species. The only hope for survival is for soldiers and civilians from the present to be transported to the future and join the fight. Among those recruited is high school teacher and family man Dan Forester. Determined to save the world for his young daughter, Dan teams up with a brilliant scientist and his estranged father in a desperate quest to rewrite the fate of the planet.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                            ReleaseDate = new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Tomorrow War",
                            VoteAverage = 8.1999999999999993
                        },
                        new
                        {
                            Id = 17,
                            Overview = "",
                            PosterPath = "https://image.tmdb.org/t/p/w500/oxNoVgbu2v9ETL93Kri1pw8osYf.jpg",
                            ReleaseDate = new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Breathless",
                            VoteAverage = 7.0999999999999996
                        },
                        new
                        {
                            Id = 18,
                            Overview = "A mysterious former secret service agent must urgently return to France when his estranged son  is falsely accused of arms and drug trafficking by the government, following a blunder by an overzealous bureaucrat and a mafia operation.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/ttpKJ7XQxDZV252KNEHXtykYT41.jpg",
                            ReleaseDate = new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Last Mercenary",
                            VoteAverage = 7.0
                        },
                        new
                        {
                            Id = 19,
                            Overview = "The Loud family travel to Scotland and discover they are descendants of Scottish royalty as they move into their giant ancestral castle.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/mab5wPeGVjbMyYMzyzfdKKnG9cl.jpg",
                            ReleaseDate = new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Loud House Movie",
                            VoteAverage = 8.5
                        },
                        new
                        {
                            Id = 20,
                            Overview = "Lindy is an acid-tongued woman with rage issues who controls her temper by shocking herself with an electrode vest. One day she makes a connection with Justin, who gives her a glimmer of hope for a shock-free future, but when he’s murdered she launches herself on a revenge-fueled rampage in pursuit of his killer.",
                            PosterPath = "https://image.tmdb.org/t/p/w500/gYZAHan5CHPFXORpQMvOjCTug4E.jpg",
                            ReleaseDate = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Jolt",
                            VoteAverage = 6.7999999999999998
                        });
                });

            modelBuilder.Entity("JAP_Task_1_MoviesApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
