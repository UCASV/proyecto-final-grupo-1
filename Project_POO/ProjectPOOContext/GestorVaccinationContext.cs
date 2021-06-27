using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class GestorVaccinationContext : DbContext
    {
        public GestorVaccinationContext()
        {
        }

        public GestorVaccinationContext(DbContextOptions<GestorVaccinationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentxsecondaryEffect> AppointmentxsecondaryEffects { get; set; }
        public virtual DbSet<Center> Centers { get; set; }
        public virtual DbSet<ChronicDisease> ChronicDiseases { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<CitizenxchronicDisease> CitizenxchronicDiseases { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employeexcenter> Employeexcenters { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<SecondaryEffect> SecondaryEffects { get; set; }
        public virtual DbSet<TypeAppointment> TypeAppointments { get; set; }
        public virtual DbSet<TypeCenter> TypeCenters { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Server=LAPTOP-HSVPQEO5;Database=GestorVaccination;Trusted_Connection=True;
                optionsBuilder.UseSqlServer("Server=.;Database=GestorVaccination;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ADatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("a_datetime");

                entity.Property(e => e.AStatus).HasColumnName("a_status");

                entity.Property(e => e.FinalTime).HasColumnName("final_time");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdCitizen)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_citizen");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.IdTypeAppointment)
                    .HasColumnName("id_type_appointment")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdVaccinationCenter).HasColumnName("id_vaccination_center");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.AppointmentIdCabinNavigations)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_ca__5629CD9C");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_ci__5441852A");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_em__5535A963");

                entity.HasOne(d => d.IdTypeAppointmentNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdTypeAppointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_ty__534D60F1");

                entity.HasOne(d => d.IdVaccinationCenterNavigation)
                    .WithMany(p => p.AppointmentIdVaccinationCenterNavigations)
                    .HasForeignKey(d => d.IdVaccinationCenter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_va__571DF1D5");
            });

            modelBuilder.Entity<AppointmentxsecondaryEffect>(entity =>
            {
                entity.HasKey(e => new { e.IdAppointment, e.IdSecondaryEffect });

                entity.ToTable("APPOINTMENTXSECONDARY_EFFECT");

                entity.Property(e => e.IdAppointment).HasColumnName("id_appointment");

                entity.Property(e => e.IdSecondaryEffect).HasColumnName("id_secondary_effect");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.HasOne(d => d.IdAppointmentNavigation)
                    .WithMany(p => p.AppointmentxsecondaryEffects)
                    .HasForeignKey(d => d.IdAppointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_ap__5812160E");

                entity.HasOne(d => d.IdSecondaryEffectNavigation)
                    .WithMany(p => p.AppointmentxsecondaryEffects)
                    .HasForeignKey(d => d.IdSecondaryEffect)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_se__59063A47");
            });

            modelBuilder.Entity<Center>(entity =>
            {
                entity.ToTable("CENTER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CenterAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("center_address");

                entity.Property(e => e.CenterEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("center_email");

                entity.Property(e => e.IdCenterType).HasColumnName("id_center_type");

                entity.Property(e => e.IdEmployeeInCharge).HasColumnName("id_employee_in_charge");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("tel");

                entity.HasOne(d => d.IdCenterTypeNavigation)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.IdCenterType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CENTER__id_cente__59FA5E80");

                entity.HasOne(d => d.IdEmployeeInChargeNavigation)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.IdEmployeeInCharge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CENTER__id_emplo__5AEE82B9");
            });

            modelBuilder.Entity<ChronicDisease>(entity =>
            {
                entity.ToTable("CHRONIC_DISEASE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ch_name");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__C03671B812F20856");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DUI");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("c_address");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c_name");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("tel");

                entity.HasOne(d => d.IdInstitutionNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdInstitution)
                    .HasConstraintName("FK__CITIZEN__id_inst__5070F446");
            });

            modelBuilder.Entity<CitizenxchronicDisease>(entity =>
            {
                entity.HasKey(e => new { e.IdCitizen, e.IdChronicDisease });

                entity.ToTable("CITIZENXCHRONIC_DISEASE");

                entity.Property(e => e.IdCitizen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id_citizen");

                entity.Property(e => e.IdChronicDisease).HasColumnName("id_chronic_disease");

                entity.HasOne(d => d.IdChronicDiseaseNavigation)
                    .WithMany(p => p.CitizenxchronicDiseases)
                    .HasForeignKey(d => d.IdChronicDisease)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZENXC__id_ch__52593CB8");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.CitizenxchronicDiseases)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZENXC__id_ci__5165187F");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("e_address");

                entity.Property(e => e.EName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdTypeEmployee).HasColumnName("id_type_employee");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.HasOne(d => d.IdTypeEmployeeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdTypeEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__id_typ__5DCAEF64");
            });

            modelBuilder.Entity<Employeexcenter>(entity =>
            {
                entity.ToTable("EMPLOYEEXCENTER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EXcDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("eXc_datetime");

                entity.Property(e => e.IdCenter).HasColumnName("id_center");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.HasOne(d => d.IdCenterNavigation)
                    .WithMany(p => p.Employeexcenters)
                    .HasForeignKey(d => d.IdCenter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEEX__id_ce__5CD6CB2B");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Employeexcenters)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEEX__id_em__5BE2A6F2");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("INSTITUTION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("i_name");
            });

            modelBuilder.Entity<SecondaryEffect>(entity =>
            {
                entity.ToTable("SECONDARY_EFFECT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("se_name");
            });

            modelBuilder.Entity<TypeAppointment>(entity =>
            {
                entity.ToTable("TYPE_APPOINTMENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TaName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ta_name");
            });

            modelBuilder.Entity<TypeCenter>(entity =>
            {
                entity.ToTable("TYPE_CENTER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TcName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tc_name");
            });

            modelBuilder.Entity<TypeEmployee>(entity =>
            {
                entity.ToTable("TYPE_EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("te_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
