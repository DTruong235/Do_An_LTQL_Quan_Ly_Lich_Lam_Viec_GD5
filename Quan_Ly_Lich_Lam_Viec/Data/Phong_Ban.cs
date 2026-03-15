using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Phong_Ban")]
    class Phong_Ban
    {
        [Key]
        public int MaPhong { get; set; }

        [Required]
        [StringLength(100)]
        public string TenPhong { get; set; }

        public string MoTa { get; set; }

        // Quan hệ 1-n: Một phòng ban có nhiều nhân viên
        public virtual ObservableCollection<Nhan_Vien> Nhan_Vien { get; set; }
    }
}
