using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Tai_Khoan")]
    class Tai_Khoan
    {
        [Key]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool TrangThai { get; set; }

        public int MaNhanVien { get; set; }
        [ForeignKey("MaNhanVien")]
        public virtual Nhan_Vien Nhan_Vien { get; set; }

        public int MaQuyen { get; set; }
        [ForeignKey("MaQuyen")]
        public virtual Phan_Quyen Phan_Quyen { get; set; }
    }
}
