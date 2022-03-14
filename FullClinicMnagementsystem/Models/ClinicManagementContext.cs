using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FullClinicMnagementsystem.Models
{
    public partial class ClinicManagementContext : DbContext
    {
        public ClinicManagementContext()
        {
        }

        public ClinicManagementContext(DbContextOptions<ClinicManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<PatientMedInfo> PatientMedInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ClinicManagement;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatientNo)
                    .HasName("PK__Patient__970ED8BDE7B07295");

                entity.ToTable("Patient");

                entity.Property(e => e.PatientMobNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientMedInfo>(entity =>
            {
                entity.HasKey(e => e.MedInfoId)
                    .HasName("PK__Patient___4E37B2E536019CDA");

                entity.ToTable("Patient_MedInfo");

                entity.Property(e => e.AppointmentDate).HasColumnType("date");

                entity.Property(e => e.BloodPressure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cholestrol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicineSubscribed)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NextAppointment).HasColumnType("date");

                entity.Property(e => e.PatientNo).HasColumnName("PatientNO");

                entity.Property(e => e.Sugar)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.PatientNoNavigation)
                    .WithMany(p => p.PatientMedInfos)
                    .HasForeignKey(d => d.PatientNo)
                    .HasConstraintName("FK__Patient_M__Patie__48CFD27E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
