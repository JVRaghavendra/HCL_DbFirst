using System;
using System.Collections.Generic;
using HCL_DbFirst.BusinessEntities;
using HHCL_DbFirst.BusinessEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HCL_DbFirst.DatabaseLogic.DbConnect
{
    public partial class KarvyMfsContext : DbContext
    {
        public KarvyMfsContext()
        {
        }

        public KarvyMfsContext(DbContextOptions<KarvyMfsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AltFileUploadDatum> AltFileUploadData { get; set; } = null!;
        public virtual DbSet<Bulkmain> Bulkmains { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<ExtranetnetListResourceNet> ExtranetnetListResourceNets { get; set; } = null!;
        public virtual DbSet<InvestSignup> InvestSignups { get; set; } = null!;
        public virtual DbSet<KaDocumentType> KaDocumentTypes { get; set; } = null!;
        public virtual DbSet<KaFileDownloadLog> KaFileDownloadLogs { get; set; } = null!;
        public virtual DbSet<KaFolio> KaFolios { get; set; } = null!;
        public virtual DbSet<KaFrequency> KaFrequencies { get; set; } = null!;
        public virtual DbSet<KaFund> KaFunds { get; set; } = null!;
        public virtual DbSet<KaFundFolioOtp> KaFundFolioOtps { get; set; } = null!;
        public virtual DbSet<KaOtpserviceLog> KaOtpserviceLogs { get; set; } = null!;
        public virtual DbSet<KaPanuser> KaPanusers { get; set; } = null!;
        public virtual DbSet<KarvyAuditLog> KarvyAuditLogs { get; set; } = null!;
        public virtual DbSet<KarvyDeptTbl> KarvyDeptTbls { get; set; } = null!;
        public virtual DbSet<KarvyEmpTbl> KarvyEmpTbls { get; set; } = null!;
        public virtual DbSet<KarvyException> KarvyExceptions { get; set; } = null!;
        public virtual DbSet<KarvyLoginUser> KarvyLoginUsers { get; set; } = null!;
        public virtual DbSet<Klocbanking1> Klocbanking1s { get; set; } = null!;
        public virtual DbSet<MastProjectInfo> MastProjectInfos { get; set; } = null!;
        public virtual DbSet<TablePgperiod> TablePgperiods { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MHF1QN4;Database=KarvyMfs;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AltFileUploadDatum>(entity =>
            {
                entity.ToTable("alt_FileUploadData");
            });

            modelBuilder.Entity<Bulkmain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bulkmain");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee");

                
            });

            modelBuilder.Entity<ExtranetnetListResourceNet>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("ExtranetnetList_ResourceNet");

                entity.Property(e => e.EmployerId).HasColumnName("EmployerID");

                entity.Property(e => e.Pin).HasColumnName("PIN");
            });

            modelBuilder.Entity<InvestSignup>(entity =>
            {
                entity.ToTable("InvestSignup");

                entity.Property(e => e.Add1).HasColumnName("add1");

                entity.Property(e => e.Add2).HasColumnName("add2");

                entity.Property(e => e.Add3).HasColumnName("add3");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.HintAnswer).HasColumnName("hintAnswer");

                entity.Property(e => e.HintQuest).HasColumnName("hintQuest");

                entity.Property(e => e.Occupation).HasColumnName("occupation");

                entity.Property(e => e.Offphone).HasColumnName("offphone");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Pin).HasColumnName("pin");

                entity.Property(e => e.Resphone).HasColumnName("resphone");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<KaDocumentType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KA_DocumentType");

                entity.Property(e => e.AltDocumentType)
                    .IsUnicode(false)
                    .HasColumnName("alt_documentType");

                entity.Property(e => e.AltDocumentno).HasColumnName("alt_documentno");
            });

            modelBuilder.Entity<KaFileDownloadLog>(entity =>
            {
                entity.ToTable("KA_FileDownloadLog");

                entity.Property(e => e.Currentdate)
                    .IsUnicode(false)
                    .HasColumnName("currentdate");

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.Hostname)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.IpAddress).IsUnicode(false);

                entity.Property(e => e.Osversion)
                    .IsUnicode(false)
                    .HasColumnName("osversion");

                entity.Property(e => e.Sevicepack1)
                    .IsUnicode(false)
                    .HasColumnName("sevicepack1");

                entity.Property(e => e.User)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KaFolio>(entity =>
            {
                entity.ToTable("KA_Folio");

                entity.Property(e => e.FolioName).IsUnicode(false);

                entity.Property(e => e.FolioValue).IsUnicode(false);

                entity.HasOne(d => d.FundBasedFolioNavigation)
                    .WithMany(p => p.KaFolios)
                    .HasForeignKey(d => d.FundBasedFolio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KA_Folio_FundBasedFolio");
            });

            modelBuilder.Entity<KaFrequency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KA_Frequency");

                entity.Property(e => e.AltDocumentno).HasColumnName("alt_documentno");

                entity.Property(e => e.AltFrequency)
                    .IsUnicode(false)
                    .HasColumnName("alt_frequency");

                entity.Property(e => e.AltFrequencyno).HasColumnName("alt_frequencyno");
            });

            modelBuilder.Entity<KaFund>(entity =>
            {
                entity.ToTable("KA_Fund");

                entity.Property(e => e.FundName).IsUnicode(false);

                entity.Property(e => e.FundValue).IsUnicode(false);
            });

            modelBuilder.Entity<KaFundFolioOtp>(entity =>
            {
                entity.ToTable("KA_FundFolioOTP");

                entity.Property(e => e.Currentdate)
                    .IsUnicode(false)
                    .HasColumnName("currentdate");

                entity.Property(e => e.Folio).IsUnicode(false);

                entity.Property(e => e.Fund).IsUnicode(false);

                entity.Property(e => e.Hostname)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.IpAddress).IsUnicode(false);

                entity.Property(e => e.Osversion)
                    .IsUnicode(false)
                    .HasColumnName("osversion");

                entity.Property(e => e.Otp)
                    .IsUnicode(false)
                    .HasColumnName("OTP");

                entity.Property(e => e.Sevicepack1)
                    .IsUnicode(false)
                    .HasColumnName("sevicepack1");

                entity.Property(e => e.User)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KaOtpserviceLog>(entity =>
            {
                entity.ToTable("KA_OTPServiceLog");

                entity.Property(e => e.Currentdate)
                    .IsUnicode(false)
                    .HasColumnName("currentdate");

                entity.Property(e => e.Hostname)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.IpAddress).IsUnicode(false);

                entity.Property(e => e.Osversion)
                    .IsUnicode(false)
                    .HasColumnName("osversion");

                entity.Property(e => e.Otp)
                    .IsUnicode(false)
                    .HasColumnName("OTP");

                entity.Property(e => e.Sevicepack1)
                    .IsUnicode(false)
                    .HasColumnName("sevicepack1");

                entity.Property(e => e.User)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KaPanuser>(entity =>
            {
                entity.ToTable("KA_PANUsers");

                entity.Property(e => e.Currentdate)
                    .IsUnicode(false)
                    .HasColumnName("currentdate");

                entity.Property(e => e.Hostname)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.IpAddress).IsUnicode(false);

                entity.Property(e => e.Osversion)
                    .IsUnicode(false)
                    .HasColumnName("osversion");

                entity.Property(e => e.Pannumber)
                    .IsUnicode(false)
                    .HasColumnName("PANNUMBER");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sevicepack1)
                    .IsUnicode(false)
                    .HasColumnName("sevicepack1");
            });

            modelBuilder.Entity<KarvyAuditLog>(entity =>
            {
                entity.ToTable("KarvyAuditLog");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");
            });

            modelBuilder.Entity<KarvyDeptTbl>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__karvy_DE__1299A8616AEB96C3");

                entity.ToTable("karvy_DEPT_tbl");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");
            });

            modelBuilder.Entity<KarvyEmpTbl>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__karvy_em__1299A86184029755");

                entity.ToTable("karvy_emp_tbl");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");
            });

            modelBuilder.Entity<KarvyException>(entity =>
            {
                entity.ToTable("KarvyException");

                entity.Property(e => e.Dbname).HasColumnName("DBName");

                entity.Property(e => e.ErrorDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<KarvyLoginUser>(entity =>
            {
                entity.Property(e => e.AumRole)
                    .IsUnicode(false)
                    .HasColumnName("aum_role");
            });

            modelBuilder.Entity<Klocbanking1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("klocbanking1");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<MastProjectInfo>(entity =>
            {
                entity.HasKey(e => e.TxnId)
                    .HasName("PK__mast_Pro__1A9F2210A32E76D1");

                entity.ToTable("mast_Project_info");

                entity.HasIndex(e => e.ProjectCode, "UQ__mast_Pro__A80AE7296BB02D47")
                    .IsUnique();

                entity.Property(e => e.TxnId).HasColumnName("Txn_id");

                entity.Property(e => e.LastModefiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_Modefied_Date");

                entity.Property(e => e.LastModefiedUserid).HasColumnName("Last_Modefied_Userid");

                entity.Property(e => e.ModefiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modefied_Date");

                entity.Property(e => e.ModefiedUserid).HasColumnName("Modefied_Userid");

                entity.Property(e => e.ProjectCode).HasColumnName("Project_Code");

                entity.Property(e => e.ProjectDescription)
                    .IsUnicode(false)
                    .HasColumnName("Project_Description");

                entity.Property(e => e.ProjectName)
                    .IsUnicode(false)
                    .HasColumnName("Project_Name");
            });

            modelBuilder.Entity<TablePgperiod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TablePGPeriod");

                entity.Property(e => e.Pgperiod).HasColumnName("PGPeriod");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
