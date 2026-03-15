using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Lich_Su_He_Thong")]
    class Lich_Su_He_Thong
    {
        [Key]
        public int MaLog { get; set; }

        public int? MaNhanVien { get; set; }
        [ForeignKey("MaNhanVien")]
        public virtual Nhan_Vien Nhan_Vien { get; set; }

        [StringLength(50)]
        public string HanhDong { get; set; }

        public string ChiTiet { get; set; }
        public DateTime ThoiGian { get; set; } = DateTime.Now;
    }
}
