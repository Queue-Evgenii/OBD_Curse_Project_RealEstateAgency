using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RealEstateAgency.Models.db
{
    public partial class RealEstateAgencyContext : DbContext
    {
        public RealEstateAgencyContext()
        {
        }

        public RealEstateAgencyContext(DbContextOptions<RealEstateAgencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Apartament> Apartament { get; set; }
        public virtual DbSet<Deal> Deal { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<House> House { get; set; }
        public virtual DbSet<HouseBuilding> HouseBuilding { get; set; }
        public virtual DbSet<ObjectStatus> ObjectStatus { get; set; }
        public virtual DbSet<Passwords> Passwords { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<RealEstateObject> RealEstateObject { get; set; }
        public virtual DbSet<Show> Show { get; set; }
        public virtual DbSet<Street> Street { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=RealEstateAgency;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartament>(entity =>
            {
                entity.HasKey(e => e.IdObject);

                entity.Property(e => e.IdObject).ValueGeneratedNever();

                entity.Property(e => e.ApartService)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdObjectNavigation)
                    .WithOne(p => p.Apartament)
                    .HasForeignKey<Apartament>(d => d.IdObject)
                    .HasConstraintName("FK_Apartament");
            });

            modelBuilder.Entity<Deal>(entity =>
            {
                entity.HasKey(e => e.IdDeal);

                entity.Property(e => e.DateDeal).HasColumnType("datetime");

                entity.HasOne(d => d.IdShowNavigation)
                    .WithMany(p => p.Deal)
                    .HasForeignKey(d => d.IdShow)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deal_Show");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.NameDistrict);

                entity.Property(e => e.NameDistrict)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.Property(e => e.NamePosition)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.IdPerson)
                    .HasConstraintName("FK_Employee_Person");

                entity.HasOne(d => d.NamePositionNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.NamePosition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Position");
            });

            modelBuilder.Entity<House>(entity =>
            {
                entity.HasKey(e => e.IdObject);

                entity.Property(e => e.IdObject).ValueGeneratedNever();

                entity.Property(e => e.GarageDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HouseLoft)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdObjectNavigation)
                    .WithOne(p => p.House)
                    .HasForeignKey<House>(d => d.IdObject)
                    .HasConstraintName("FK_House");
            });

            modelBuilder.Entity<HouseBuilding>(entity =>
            {
                entity.HasKey(e => new { e.HouseNumber, e.StreetName });

                entity.Property(e => e.StreetName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WallMaterial)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.StreetNameNavigation)
                    .WithMany(p => p.HouseBuilding)
                    .HasForeignKey(d => d.StreetName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseBuilding_Street");
            });

            modelBuilder.Entity<ObjectStatus>(entity =>
            {
                entity.HasKey(e => e.StatusObject)
                    .HasName("PK_ObjStatus");

                entity.Property(e => e.StatusObject)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Passwords>(entity =>
            {
                entity.HasKey(e => e.IdPerson)
                    .HasName("PK_Users");

                entity.Property(e => e.IdPerson).ValueGeneratedNever();

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.IdPersonNavigation)
                    .WithOne(p => p.Passwords)
                    .HasForeignKey<Passwords>(d => d.IdPerson)
                    .HasConstraintName("FK_Users_Person");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.IdPerson);

                entity.Property(e => e.AddressPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasColumnName("MName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasKey(e => e.IdPhoto);

                entity.Property(e => e.PhotoLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdObjectNavigation)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.IdObject)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Photo_Object");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.NamePosition);

                entity.Property(e => e.NamePosition)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RealEstateObject>(entity =>
            {
                entity.HasKey(e => e.IdObject);

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.StatusObject)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonNavigation)
                    .WithMany(p => p.RealEstateObject)
                    .HasForeignKey(d => d.IdPerson)
                    .HasConstraintName("FK_Object_Person");

                entity.HasOne(d => d.StatusObjectNavigation)
                    .WithMany(p => p.RealEstateObject)
                    .HasForeignKey(d => d.StatusObject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Object_Status");

                entity.HasOne(d => d.HouseBuilding)
                    .WithMany(p => p.RealEstateObject)
                    .HasForeignKey(d => new { d.HouseNumber, d.StreetName })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Object_HouseBuilding");
            });

            modelBuilder.Entity<Show>(entity =>
            {
                entity.HasKey(e => e.IdShow);

                entity.Property(e => e.ShowDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Show)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Show_Employee");

                entity.HasOne(d => d.IdObjectNavigation)
                    .WithMany(p => p.Show)
                    .HasForeignKey(d => d.IdObject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Show_Object");

                entity.HasOne(d => d.IdPersonNavigation)
                    .WithMany(p => p.Show)
                    .HasForeignKey(d => d.IdPerson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Show_Person");
            });

            modelBuilder.Entity<Street>(entity =>
            {
                entity.HasKey(e => e.StreetName);

                entity.Property(e => e.StreetName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameDistrict)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.NameDistrictNavigation)
                    .WithMany(p => p.Street)
                    .HasForeignKey(d => d.NameDistrict)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Street_District");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
