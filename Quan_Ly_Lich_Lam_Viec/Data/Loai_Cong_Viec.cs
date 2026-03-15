using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Loai_Cong_Viec")]
    class Loai_Cong_Viec
    {
        [Key]
        public int MaLoaiCV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoai { get; set; }


        public virtual ObservableCollection<Lich_Lam_Viec> Lich_Lam_Viec { get; set; }
    }
}
