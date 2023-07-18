using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DuAn1.Models;

public partial class BookingAirlineContext : DbContext
{
    public BookingAirlineContext()
    {
    }

    public BookingAirlineContext(DbContextOptions<BookingAirlineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<PlaneType> PlaneTypes { get; set; }

    public virtual DbSet<Recommend> Recommends { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SeatDetail> SeatDetails { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=BookingAirline;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bank__3213E83F7831BE5A");

            entity.ToTable("Bank");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankAccountNum).HasColumnName("bank_account_num");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .HasColumnName("display_name");

            entity.HasOne(d => d.Customer).WithMany(p => p.Banks)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bank__bank_accou__403A8C7D");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Class__3213E83FD9E17EDC");

            entity.ToTable("Class");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .HasColumnName("display_name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3213E83F0300AEA8");

            entity.ToTable("Customer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .HasColumnName("address");
            entity.Property(e => e.Dob).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((1))")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Flight__3213E83FE9D7B6D6");

            entity.ToTable("Flight");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateFlight)
                .HasColumnType("datetime")
                .HasColumnName("date_flight");
            entity.Property(e => e.FlightCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flight_code");
            entity.Property(e => e.GoFrom)
                .HasMaxLength(100)
                .HasColumnName("go_from");
            entity.Property(e => e.GoTo)
                .HasMaxLength(100)
                .HasColumnName("go_to");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.PlaneTypeId).HasColumnName("plane_type_id");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.Location).WithMany(p => p.Flights)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Flight__location__47DBAE45");

            entity.HasOne(d => d.PlaneType).WithMany(p => p.Flights)
                .HasForeignKey(d => d.PlaneTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Flight__date_fli__46E78A0C");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Location__3213E83FB3B0C6A2");

            entity.ToTable("Location");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .HasColumnName("display_name");
            entity.Property(e => e.LocaCode)
                .HasMaxLength(50)
                .HasColumnName("loca_code");
        });

        modelBuilder.Entity<PlaneType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Plane_ty__3213E83FFB234946");

            entity.ToTable("Plane_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .HasColumnName("display_name");
            entity.Property(e => e.PlaneCode)
                .HasMaxLength(50)
                .HasColumnName("plane_code");
            entity.Property(e => e.TotalSeat).HasColumnName("total_seat");
        });

        modelBuilder.Entity<Recommend>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recommen__3213E83F1426BAC6");

            entity.ToTable("Recommend");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content)
                .HasMaxLength(200)
                .HasColumnName("content");
            entity.Property(e => e.IdFlight).HasColumnName("id_flight");

            entity.HasOne(d => d.IdFlightNavigation).WithMany(p => p.Recommends)
                .HasForeignKey(d => d.IdFlight)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Recommend__conte__5535A963");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3213E83FD1F611DD");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(10)
                .HasColumnName("display_name");
        });

        modelBuilder.Entity<SeatDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Seat_det__3213E83FDF56E92C");

            entity.ToTable("Seat_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.PlaneTypeId).HasColumnName("plane_type_id");
            entity.Property(e => e.SeatCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seat_code");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((1))")
                .HasColumnName("status");

            entity.HasOne(d => d.Class).WithMany(p => p.SeatDetails)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Seat_deta__statu__5165187F");

            entity.HasOne(d => d.PlaneType).WithMany(p => p.SeatDetails)
                .HasForeignKey(d => d.PlaneTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Seat_deta__plane__52593CB8");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Staff__3213E83F02653B94");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .HasColumnName("display_name");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.RoleId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("role_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((1))")
                .HasColumnName("status");

            entity.HasOne(d => d.Role).WithMany(p => p.Staff)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Staff__status__3A81B327");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ticket__3213E83F89A83B44");

            entity.ToTable("Ticket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");
            entity.Property(e => e.TotalTicket).HasColumnName("total_ticket");
            entity.Property(e => e.TwoWay).HasColumnName("two_way");

            entity.HasOne(d => d.Customer).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ticket__customer__4AB81AF0");

            entity.HasOne(d => d.Flight).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.FlightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ticket__flight_i__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
