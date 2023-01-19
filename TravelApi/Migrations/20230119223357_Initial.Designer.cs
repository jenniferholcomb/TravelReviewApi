﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20230119223357_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            Country = "Canada",
                            Location = "Montreal",
                            Rating = 4,
                            Review = "Lovely city, great architecture and food, best to visit in summer (winter is cold).",
                            State = "Quebec"
                        },
                        new
                        {
                            DestinationId = 2,
                            Country = "Canada",
                            Location = "Vancouver",
                            Rating = 5,
                            Review = "Great place, especially if you love a mix of outdoors and urban life. Delicious food and shopping, mild weather in the winter.",
                            State = "B.C."
                        },
                        new
                        {
                            DestinationId = 3,
                            Country = "Australia",
                            Location = "Sydney",
                            Rating = 5,
                            Review = "Such a fun city. All the usual tourist destinations a must, but head north too. Manly is beautiful. Or East to the Blue Mountains for the coolest caves.",
                            State = "NSW"
                        },
                        new
                        {
                            DestinationId = 4,
                            Country = "USA",
                            Location = "Honolulu",
                            Rating = 3,
                            Review = "Love Hawaii, and a Honolulu is a must stop, but don't spend all your time here. Visit other islands first, then a couple nights here. Plan a trip to Pearl Harbor, hike Diamond Head, and head out to North Shore.",
                            State = "Hawaii"
                        },
                        new
                        {
                            DestinationId = 5,
                            Country = "Mexico",
                            Location = "Bucerias",
                            Rating = 4,
                            Review = "Great little town. Personally like the pace better than Puerto Vallarta. And the food is excellent. Try the burrito wherever you go. Relaxing vacation.",
                            State = "Nayarit"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}