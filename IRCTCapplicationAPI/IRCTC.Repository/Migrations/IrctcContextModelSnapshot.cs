﻿// <auto-generated />
using System;
using IRCTC.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IRCTC.Repository.Migrations
{
    [DbContext(typeof(IrctcContext))]
    partial class IrctcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IRCTCModel.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<int>("BookingStatusId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("FromStop")
                        .HasColumnType("int");

                    b.Property<int>("ToStop")
                        .HasColumnType("int");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<int>("TrainClassId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("BookingStatusId");

                    b.HasIndex("FromStop");

                    b.HasIndex("ToStop");

                    b.HasIndex("TrainClassId");

                    b.HasIndex("UserId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("IRCTCModel.Models.BookingStatus", b =>
                {
                    b.Property<int>("BookingStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingStatusId");

                    b.ToTable("BookingStatus");

                    b.HasData(
                        new
                        {
                            BookingStatusId = 1,
                            Status = "Confirmed"
                        },
                        new
                        {
                            BookingStatusId = 2,
                            Status = "Cancelled"
                        });
                });

            modelBuilder.Entity("IRCTCModel.Models.Coach", b =>
                {
                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<double>("BaseCharge")
                        .HasColumnType("float");

                    b.Property<string>("CoachName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CoachId");

                    b.ToTable("Coach");

                    b.HasData(
                        new
                        {
                            CoachId = 1,
                            BaseCharge = 100.0,
                            CoachName = "ACFirstClass"
                        },
                        new
                        {
                            CoachId = 2,
                            BaseCharge = 200.0,
                            CoachName = "ExecChairCar"
                        },
                        new
                        {
                            CoachId = 3,
                            BaseCharge = 150.0,
                            CoachName = "ACChairCar"
                        },
                        new
                        {
                            CoachId = 4,
                            BaseCharge = 80.0,
                            CoachName = "Sleeper"
                        },
                        new
                        {
                            CoachId = 5,
                            BaseCharge = 50.0,
                            CoachName = "SecondSitting"
                        },
                        new
                        {
                            CoachId = 6,
                            BaseCharge = 130.0,
                            CoachName = "ACSecondTier"
                        },
                        new
                        {
                            CoachId = 7,
                            BaseCharge = 150.0,
                            CoachName = "ACThirdTier"
                        },
                        new
                        {
                            CoachId = 8,
                            BaseCharge = 85.0,
                            CoachName = "ACThreeEconomy"
                        });
                });

            modelBuilder.Entity("IRCTCModel.Models.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassengerId"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<bool>("HasArrived")
                        .HasColumnType("bit");

                    b.Property<string>("PassengerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("PassengerId");

                    b.HasIndex("BookingId");

                    b.HasIndex("SeatId");

                    b.ToTable("Passenger");
                });

            modelBuilder.Entity("IRCTCModel.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatId"));

                    b.Property<string>("SeatNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SeatStatusId")
                        .HasColumnType("int");

                    b.Property<int>("SeatTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TrainClassId")
                        .HasColumnType("int");

                    b.HasKey("SeatId");

                    b.HasIndex("SeatStatusId");

                    b.HasIndex("SeatTypeId");

                    b.HasIndex("TrainClassId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("IRCTCModel.Models.SeatStatus", b =>
                {
                    b.Property<int>("SeatStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeatStatusId");

                    b.ToTable("SeatStatus");

                    b.HasData(
                        new
                        {
                            SeatStatusId = 1,
                            Status = "Confirmed"
                        },
                        new
                        {
                            SeatStatusId = 2,
                            Status = "NotConfirmed"
                        },
                        new
                        {
                            SeatStatusId = 3,
                            Status = "TicketCancelled"
                        });
                });

            modelBuilder.Entity("IRCTCModel.Models.SeatType", b =>
                {
                    b.Property<int>("SeatTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SeatTypeId");

                    b.ToTable("SeatType");

                    b.HasData(
                        new
                        {
                            SeatTypeId = 1,
                            TypeName = "LowerBerth"
                        },
                        new
                        {
                            SeatTypeId = 2,
                            TypeName = "UpperBerth"
                        },
                        new
                        {
                            SeatTypeId = 3,
                            TypeName = "MiddleBerth"
                        },
                        new
                        {
                            SeatTypeId = 4,
                            TypeName = "WindowSeat"
                        },
                        new
                        {
                            SeatTypeId = 5,
                            TypeName = "MiddleSeat"
                        },
                        new
                        {
                            SeatTypeId = 6,
                            TypeName = "AisleSeat"
                        });
                });

            modelBuilder.Entity("IRCTCModel.Models.Station", b =>
                {
                    b.Property<int>("StationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationId"));

                    b.Property<string>("StationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StationId");

                    b.ToTable("Station");
                });

            modelBuilder.Entity("IRCTCModel.Models.Train", b =>
                {
                    b.Property<int>("TrainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FromStationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReachingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ToStationId")
                        .HasColumnType("int");

                    b.Property<string>("TrainName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrainTypeID")
                        .HasColumnType("int");

                    b.HasKey("TrainId");

                    b.HasIndex("FromStationId");

                    b.HasIndex("ToStationId");

                    b.HasIndex("TrainTypeID");

                    b.ToTable("Train");
                });

            modelBuilder.Entity("IRCTCModel.Models.TrainClass", b =>
                {
                    b.Property<int>("TrainClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainClassId"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.HasKey("TrainClassId");

                    b.HasIndex("ClassId");

                    b.HasIndex("TrainId");

                    b.ToTable("TrainClass");
                });

            modelBuilder.Entity("IRCTCModel.Models.TrainStop", b =>
                {
                    b.Property<int>("TrainStopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainStopId"));

                    b.Property<DateTime>("ReachingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StationCount")
                        .HasColumnType("int");

                    b.Property<int>("StopStationId")
                        .HasColumnType("int");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.HasKey("TrainStopId");

                    b.HasIndex("StopStationId");

                    b.HasIndex("TrainId");

                    b.ToTable("TrainStop");
                });

            modelBuilder.Entity("IRCTCModel.Models.TrainType", b =>
                {
                    b.Property<int>("TrainTypeID")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TrainTypeID");

                    b.ToTable("TrainType");

                    b.HasData(
                        new
                        {
                            TrainTypeID = 1,
                            TypeName = "Janshatabdi"
                        },
                        new
                        {
                            TrainTypeID = 2,
                            TypeName = "Shatabdi"
                        },
                        new
                        {
                            TrainTypeID = 3,
                            TypeName = "Antyodaya"
                        },
                        new
                        {
                            TrainTypeID = 4,
                            TypeName = "Intercity"
                        },
                        new
                        {
                            TrainTypeID = 5,
                            TypeName = "Express"
                        });
                });

            modelBuilder.Entity("IRCTCModel.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdentityCardID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserTypeID")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserTypeID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("IRCTCModel.Models.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserTypeId");

                    b.ToTable("UserType");

                    b.HasData(
                        new
                        {
                            UserTypeId = 1,
                            TypeName = "Passenger"
                        },
                        new
                        {
                            UserTypeId = 2,
                            TypeName = "TTE"
                        });
                });

            modelBuilder.Entity("IRCTCModel.Models.Booking", b =>
                {
                    b.HasOne("IRCTCModel.Models.BookingStatus", "BookingStatus")
                        .WithMany("Bookings")
                        .HasForeignKey("BookingStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.TrainStop", "FromTrainStop")
                        .WithMany("FromBookings")
                        .HasForeignKey("FromStop")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.TrainStop", "ToTrainStop")
                        .WithMany("ToBookings")
                        .HasForeignKey("ToStop")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.TrainClass", "TrainClass")
                        .WithMany("Bookings")
                        .HasForeignKey("TrainClassId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BookingStatus");

                    b.Navigation("FromTrainStop");

                    b.Navigation("ToTrainStop");

                    b.Navigation("TrainClass");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IRCTCModel.Models.Passenger", b =>
                {
                    b.HasOne("IRCTCModel.Models.Booking", "Booking")
                        .WithMany("Passengers")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.Seat", "Seat")
                        .WithMany("Passengers")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("IRCTCModel.Models.Seat", b =>
                {
                    b.HasOne("IRCTCModel.Models.SeatStatus", "SeatStatus")
                        .WithMany("Seats")
                        .HasForeignKey("SeatStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.SeatType", "SeatType")
                        .WithMany("Seats")
                        .HasForeignKey("SeatTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.TrainClass", "TrainClass")
                        .WithMany("Seats")
                        .HasForeignKey("TrainClassId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SeatStatus");

                    b.Navigation("SeatType");

                    b.Navigation("TrainClass");
                });

            modelBuilder.Entity("IRCTCModel.Models.Train", b =>
                {
                    b.HasOne("IRCTCModel.Models.Station", "FromStation")
                        .WithMany("FromTrains")
                        .HasForeignKey("FromStationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.Station", "ToStation")
                        .WithMany("ToTrains")
                        .HasForeignKey("ToStationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.TrainType", "TrainType")
                        .WithMany("Trains")
                        .HasForeignKey("TrainTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FromStation");

                    b.Navigation("ToStation");

                    b.Navigation("TrainType");
                });

            modelBuilder.Entity("IRCTCModel.Models.TrainClass", b =>
                {
                    b.HasOne("IRCTCModel.Models.Coach", "Coach")
                        .WithMany("TrainClasses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.Train", "Train")
                        .WithMany("TrainClasses")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("IRCTCModel.Models.TrainStop", b =>
                {
                    b.HasOne("IRCTCModel.Models.Station", "Station")
                        .WithMany("TrainStops")
                        .HasForeignKey("StopStationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IRCTCModel.Models.Train", "Train")
                        .WithMany("TrainStops")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Station");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("IRCTCModel.Models.User", b =>
                {
                    b.HasOne("IRCTCModel.Models.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("IRCTCModel.Models.Booking", b =>
                {
                    b.Navigation("Passengers");
                });

            modelBuilder.Entity("IRCTCModel.Models.BookingStatus", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("IRCTCModel.Models.Coach", b =>
                {
                    b.Navigation("TrainClasses");
                });

            modelBuilder.Entity("IRCTCModel.Models.Seat", b =>
                {
                    b.Navigation("Passengers");
                });

            modelBuilder.Entity("IRCTCModel.Models.SeatStatus", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("IRCTCModel.Models.SeatType", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("IRCTCModel.Models.Station", b =>
                {
                    b.Navigation("FromTrains");

                    b.Navigation("ToTrains");

                    b.Navigation("TrainStops");
                });

            modelBuilder.Entity("IRCTCModel.Models.Train", b =>
                {
                    b.Navigation("TrainClasses");

                    b.Navigation("TrainStops");
                });

            modelBuilder.Entity("IRCTCModel.Models.TrainClass", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("IRCTCModel.Models.TrainStop", b =>
                {
                    b.Navigation("FromBookings");

                    b.Navigation("ToBookings");
                });

            modelBuilder.Entity("IRCTCModel.Models.TrainType", b =>
                {
                    b.Navigation("Trains");
                });

            modelBuilder.Entity("IRCTCModel.Models.User", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("IRCTCModel.Models.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
