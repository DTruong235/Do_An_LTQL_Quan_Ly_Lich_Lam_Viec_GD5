using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Phan_Quyen")]
    class Phan_Quyen
    {
        [Key]
        public int MaQuyen { get; set; }

        [Required]
        [StringLength(50)]
        public string TenQuyen { get; set; }

        public virtual ObservableCollection<Tai_Khoan> Tai_Khoan { get; set; }
    }
}
