using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fox.Microservices.Clinical.Models.Entities
{
    public partial class ClinicalContext : DbContext
    {
        public ClinicalContext()
        {
        }

        public ClinicalContext(DbContextOptions<ClinicalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CU_B_CLINICAL_EXT_AUS> CU_B_CLINICAL_EXT_AUS { get; set; }
        public virtual DbSet<CU_B_SCREENING_EXT_AUS> CU_B_SCREENING_EXT_AUS { get; set; }
        public virtual DbSet<CU_S_AUDIOGRAM_TYPE> CU_S_AUDIOGRAM_TYPE { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=CAU02DB01FOXSIT.D09.ROOT.SYS;Database=FoxAustralia_SIT2;Trusted_Connection=False;User ID=foxuser;Password=Df0x35ZZ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CU_B_CLINICAL_EXT_AUS>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.SHOP_CODE, e.CUSTOMER_CODE, e.ACTIVITY_DATE })
                    .HasName("PK__CU_B_CLI__50C4B6DE22FC6C12");

                entity.HasIndex(e => e.ROWGUID)
                    .HasName("missing_index_25019");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.ACTIVITY_DATE })
                    .HasName("missing_index_25644");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.APPOINTMENT_ID })
                    .HasName("missing_index_25642");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE })
                    .HasName("missing_index_21419");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.APPOINTMENT_ID, e.ACTIVITY_DATE })
                    .HasName("missing_index_25640");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.APPOINTMENT_ID })
                    .HasName("missing_index_25372");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.SHOP_CODE).HasMaxLength(3);

                entity.Property(e => e.CUSTOMER_CODE).HasMaxLength(8);

                entity.Property(e => e.ACTIVITY_DATE).HasColumnType("date");

                entity.Property(e => e.APPOINTMENT_ID).HasMaxLength(10);

                entity.Property(e => e.CLINICIAN_ID).HasMaxLength(50);

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.HEARING_LOSS_OUTCOME_CODE_L).HasMaxLength(50);

                entity.Property(e => e.HEARING_LOSS_OUTCOME_CODE_R).HasMaxLength(50);

                entity.Property(e => e.NALPHL).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.PTA1_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.PTA1_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.PTA2_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.PTA2_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.ROWGUID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);

                entity.HasOne(d => d.CU_S_AUDIOGRAM_TYPE)
                    .WithMany(p => p.CU_B_CLINICAL_EXT_AUS)
                    .HasForeignKey(d => new { d.COMPANY_CODE, d.DIVISION_CODE, d.AUDIOGRAM_TYPE_CODE })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CU_B_CLINICAL_EXT_AUS_CU_S_AUDIOGRAM_TYPE");
            });

            modelBuilder.Entity<CU_B_SCREENING_EXT_AUS>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.ACTIVITY_DATE })
                    .HasName("pk_CU_B_SCREENING_EXT_AUS");

                entity.HasIndex(e => e.APPOINTMENT_ID)
                    .HasName("missing_index_25211");

                entity.HasIndex(e => e.CUSTOMER_CODE)
                    .HasName("missing_index_25215");

                entity.HasIndex(e => new { e.CUSTOMER_CODE, e.APPOINTMENT_ID })
                    .HasName("missing_index_25213");

                entity.HasIndex(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.CUSTOMER_CODE, e.APPOINTMENT_ID, e.ACTIVITY_DATE, e.DT_INSERT, e.USERUPDATE, e.DT_UPDATE })
                    .HasName("missing_index_18149");

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.CUSTOMER_CODE).HasMaxLength(8);

                entity.Property(e => e.ACTIVITY_DATE).HasColumnType("date");

                entity.Property(e => e.APPOINTMENT_ID)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CLINICIAN_ID).HasMaxLength(50);

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.FREQ_1_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FREQ_1_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FREQ_2_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FREQ_2_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FREQ_3_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FREQ_3_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FREQ_4_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FREQ_4_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FREQ_500_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.FREQ_500_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.NALPHL).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.PTA1_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.PTA1_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.PTA2_L).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.PTA2_R).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.RESULT_CODE).HasMaxLength(5);

                entity.Property(e => e.ROWGUID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.STATUS_CODE).HasMaxLength(3);

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);

                entity.HasOne(d => d.CU_S_AUDIOGRAM_TYPE)
                    .WithMany(p => p.CU_B_SCREENING_EXT_AUS)
                    .HasForeignKey(d => new { d.COMPANY_CODE, d.DIVISION_CODE, d.AUDIOGRAM_TYPE_CODE })
                    .HasConstraintName("FK_CU_B_SCREENING_EXT_AUS_CU_S_AUDIOGRAM_TYPE");
            });

            modelBuilder.Entity<CU_S_AUDIOGRAM_TYPE>(entity =>
            {
                entity.HasKey(e => new { e.COMPANY_CODE, e.DIVISION_CODE, e.AUDIOGRAM_TYPE_CODE });

                entity.HasIndex(e => e.ROWGUID)
                    .HasName("UQ_CU_S_AUDIOGRAM_TYPE_ROWGUID")
                    .IsUnique();

                entity.Property(e => e.COMPANY_CODE).HasMaxLength(3);

                entity.Property(e => e.DIVISION_CODE).HasMaxLength(3);

                entity.Property(e => e.AUDIOGRAM_TYPE_DESCR).HasMaxLength(255);

                entity.Property(e => e.DT_END).HasColumnType("date");

                entity.Property(e => e.DT_INSERT).HasColumnType("datetime");

                entity.Property(e => e.DT_START).HasColumnType("date");

                entity.Property(e => e.DT_UPDATE).HasColumnType("datetime");

                entity.Property(e => e.ROWGUID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.USERINSERT).HasMaxLength(50);

                entity.Property(e => e.USERUPDATE).HasMaxLength(50);
            });

            modelBuilder.HasSequence("NextFoxid").StartsAt(0);

            modelBuilder.HasSequence("GETNEXTBATCHNUMBER").StartsAt(200);

            modelBuilder.HasSequence("NextFoxCouponid").StartsAt(0);

            modelBuilder.HasSequence("NextFoxid").StartsAt(4000);

            modelBuilder.HasSequence("NextFoxVoucherId");
        }
    }
}
