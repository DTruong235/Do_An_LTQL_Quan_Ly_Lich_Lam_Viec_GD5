using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace Quan_Ly_Lich_Lam_Viec.Data
{
    class Quan_Li_Lich_Lam_DbContext : DbContext
    {
        public DbSet<Nhan_Vien> Nhan_Vien { get; set; }
        public DbSet<Phong_Ban> Phong_Ban { get; set; }
        public DbSet<Chuc_Vu> Chuc_Vu { get; set; }
        public DbSet<Tai_Khoan> Tai_Khoan { get; set; }
        public DbSet<Phan_Quyen> Phan_Quyen { get; set; }
        public DbSet<Lich_Su_He_Thong> Lich_Su_He_Thong { get; set; }
        public DbSet<Chi_Tiet_Phan_Cong> Chi_Tiet_Phan_Cong { get; set; }
        public DbSet<Lich_Lam_Viec> Lich_Lam_Viec { get; set; }
        public DbSet<Loai_Cong_Viec> Loai_Cong_Viec { get; set; }
        public DbSet<Dia_Diem> Dia_Diem { get; set; }
        public DbSet<Tien_Do_Cong_Viec> Tien_Do_Cong_Viec { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QuanLyLichLamViec_Connection"].ConnectionString);
        }

    }
}
