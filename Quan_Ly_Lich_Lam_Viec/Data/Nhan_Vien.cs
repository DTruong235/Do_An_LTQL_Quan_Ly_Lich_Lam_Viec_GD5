using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Nhan_Vien")]
    class Nhan_Vien
    {
        [Key]
        public int MaNhanVien { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        [RegularExpression(@"^0\d{9}$")] // giới hạn số điện thoại bắt đầu bằng 0 và có đúng 10 chữ số

        [StringLength(200)] // Giới hạn 200 ký tự
        public string DiaChi { get; set; }

        public int MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public virtual Phong_Ban Phong_Ban { get; set; }

        public int MaChucVu { get; set; }
        [ForeignKey("MaChucVu")]


        public virtual Chuc_Vu Chuc_Vu { get; set; }

        public virtual Tai_Khoan Tai_Khoan { get; set; }
        public virtual ObservableCollection<Chi_Tiet_Phan_Cong> Chi_Tiet_Phan_Cong { get; set; }


    }


}
