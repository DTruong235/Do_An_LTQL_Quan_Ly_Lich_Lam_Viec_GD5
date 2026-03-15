using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Chuc_Vu")]
    class Chuc_Vu
    {
        [Key]
        public int MaChucVu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenChucVu { get; set; }

        public virtual ObservableCollection<Nhan_Vien> Nhan_Vien { get; set; }
    }
}
