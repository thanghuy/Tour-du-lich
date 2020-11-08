using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace tour.Models
{
    public partial class Tour_DBContext : DbContext
    {
        public Tour_DBContext()
        {
        }

        public Tour_DBContext(DbContextOptions<Tour_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiPhis> ChiPhis { get; set; }
        public virtual DbSet<ChiTietTours> ChiTietTours { get; set; }
        public virtual DbSet<DiaDiems> DiaDiems { get; set; }
        public virtual DbSet<Doans> Doans { get; set; }
        public virtual DbSet<Gias> Gias { get; set; }
        public virtual DbSet<KhachHangs> KhachHangs { get; set; }
        public virtual DbSet<LoaiChiPhis> LoaiChiPhis { get; set; }
        public virtual DbSet<Loais> Loais { get; set; }
        public virtual DbSet<NguoiDis> NguoiDis { get; set; }
        public virtual DbSet<NhanViens> NhanViens { get; set; }
        public virtual DbSet<Tours> Tours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Tour_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiPhis>(entity =>
            {
                entity.HasKey(e => e.ChiphiId);

                entity.Property(e => e.ChiphiId).HasColumnName("chiphi_id");

                entity.Property(e => e.Chitiet).HasColumnName("chitiet");

                entity.Property(e => e.DoanId).HasColumnName("doan_id");

                entity.Property(e => e.Tongchiphi).HasColumnName("tongchiphi");
            });

            modelBuilder.Entity<ChiTietTours>(entity =>
            {
                entity.HasKey(e => e.ChitietId);

                entity.Property(e => e.ChitietId).HasColumnName("chitiet_id");

                entity.Property(e => e.DiadiemId).HasColumnName("diadiem_id");
            });

            modelBuilder.Entity<DiaDiems>(entity =>
            {
                entity.HasKey(e => e.DiadiemId);

                entity.Property(e => e.DiadiemId).HasColumnName("diadiem_id");

                entity.Property(e => e.Mota).HasColumnName("mota");

                entity.Property(e => e.Ten).HasColumnName("ten");

                entity.Property(e => e.Thanhpho)
                    .IsRequired()
                    .HasColumnName("thanhpho");
            });

            modelBuilder.Entity<Doans>(entity =>
            {
                entity.HasKey(e => e.DoanId);

                entity.Property(e => e.DoanId).HasColumnName("doan_id");

                entity.Property(e => e.Ten).HasColumnName("ten");
            });

            modelBuilder.Entity<Gias>(entity =>
            {
                entity.HasKey(e => e.GiaId);

                entity.Property(e => e.GiaId).HasColumnName("gia_id");

                entity.Property(e => e.Denngay).HasColumnName("denngay");

                entity.Property(e => e.Sotien).HasColumnName("sotien");

                entity.Property(e => e.ToudId).HasColumnName("toud_id");

                entity.Property(e => e.Tungay).HasColumnName("tungay");
            });

            modelBuilder.Entity<KhachHangs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.KhCmnd)
                    .IsRequired()
                    .HasColumnName("kh_cmnd")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.KhEmail)
                    .HasColumnName("kh_email")
                    .HasMaxLength(50);

                entity.Property(e => e.KhId)
                    .HasColumnName("kh_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KhNgaysinh)
                    .HasColumnName("kh_ngaysinh")
                    .HasMaxLength(50);

                entity.Property(e => e.KhSdt)
                    .IsRequired()
                    .HasColumnName("kh_sdt")
                    .HasMaxLength(50);

                entity.Property(e => e.KhTen)
                    .IsRequired()
                    .HasColumnName("kh_ten")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiChiPhis>(entity =>
            {
                entity.HasKey(e => e.ChiphiId);

                entity.Property(e => e.ChiphiId).HasColumnName("chiphi_id");

                entity.Property(e => e.Mota).HasColumnName("mota");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<Loais>(entity =>
            {
                entity.HasKey(e => e.LoaiId);

                entity.Property(e => e.LoaiId).HasColumnName("loai_id");

                entity.Property(e => e.Mota).HasColumnName("mota");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<NguoiDis>(entity =>
            {
                entity.HasKey(e => e.NguoidiId);

                entity.Property(e => e.NguoidiId).HasColumnName("nguoidi_id");

                entity.Property(e => e.Danhsachkhach).HasColumnName("danhsachkhach");

                entity.Property(e => e.Danhsachnhanvien).HasColumnName("danhsachnhanvien");

                entity.Property(e => e.DoanId).HasColumnName("doan_id");
            });

            modelBuilder.Entity<NhanViens>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NvEmail)
                    .HasColumnName("nv_email")
                    .HasMaxLength(50);

                entity.Property(e => e.NvId)
                    .HasColumnName("nv_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NvNgaysinh)
                    .IsRequired()
                    .HasColumnName("nv_ngaysinh")
                    .HasMaxLength(50);

                entity.Property(e => e.NvNhiemvu).HasColumnName("nv_nhiemvu");

                entity.Property(e => e.NvSdt)
                    .HasColumnName("nv_sdt")
                    .HasMaxLength(50);

                entity.Property(e => e.NvTen)
                    .IsRequired()
                    .HasColumnName("nv_ten")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tours>(entity =>
            {
                entity.HasKey(e => e.TourId);

                entity.Property(e => e.LoaiId).HasColumnName("loai_id");

                entity.Property(e => e.Mota).HasColumnName("mota");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasColumnName("ten");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
