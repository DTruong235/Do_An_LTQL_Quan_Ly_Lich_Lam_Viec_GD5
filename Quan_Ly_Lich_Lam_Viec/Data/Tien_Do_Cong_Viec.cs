using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Tien_Do_Cong_Viec")]
    class Tien_Do_Cong_Viec
    {
        [Key]
        public int MaTienDo { get; set; }

        public int MaLich { get; set; }
        [ForeignKey("MaLich")]
        public virtual Lich_Lam_Viec Lich_Lam_Viec { get; set; }

        public int PhanTramHoanThanh { get; set; }
        public string LyDoTreHan { get; set; }
        public DateTime NgayCapNhat { get; set; } = DateTime.Now;
    }
}
