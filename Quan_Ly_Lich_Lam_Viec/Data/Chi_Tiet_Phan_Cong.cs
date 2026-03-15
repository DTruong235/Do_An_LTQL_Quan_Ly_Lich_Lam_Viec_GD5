using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Chi_Tiet_Phan_Cong")]
    class Chi_Tiet_Phan_Cong
    {
        [Key]
        public int MaPhanCong { get; set; }

        public int MaNhanVien { get; set; }
        [ForeignKey("MaNhanVien")]
        public virtual Nhan_Vien Nhan_Vien { get; set; }

        public int MaLich { get; set; }
        [ForeignKey("MaLich")]
        public virtual Lich_Lam_Viec Lich_Lam_Viec { get; set; }

        public string Vai_Tro { get; set; }
        public bool Da_Xac_Nhan { get; set; }
    }
}
