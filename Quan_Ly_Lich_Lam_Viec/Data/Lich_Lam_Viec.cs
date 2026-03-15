using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Lich_Lam_Viec")]
    class Lich_Lam_Viec
    {
        [Key]
        public int MaLich { get; set; }

        [Required]
        [StringLength(200)]
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }

        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public int SoLuongDuKien { get; set; }

        public int MaLoaiCV { get; set; }

        [ForeignKey("MaLoaiCV")]
        public virtual Loai_Cong_Viec Loai_Cong_Viec { get; set; }

        public int? MaDiaDiem { get; set; }

        [ForeignKey("MaDiaDiem")]
        public virtual Dia_Diem Dia_Diem { get; set; }

        [NotMapped] // Đảm bảo EF không cố gắng tìm cột này trong DB khi chạy
        public string TinhTrang
        {
            get
            {
                // Kiểm tra danh sách phân công
                if (Chi_Tiet_Phan_Cong == null || Chi_Tiet_Phan_Cong.Count == 0)
                {
                    return "Thêm phân công"; // Giá trị mặc định cho lịch mới
                }
                return $"Đã phân công"; // Cập nhật khi có dữ liệu
            }
        }

        public virtual ObservableCollection<Chi_Tiet_Phan_Cong> Chi_Tiet_Phan_Cong { get; set; }
        public virtual ObservableCollection<Tien_Do_Cong_Viec> Tien_Do_Cong_Viec { get; set; }


    }

}
