using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    [Table("Dia_Diem")]
    class Dia_Diem
    {
        [Key]
        public int MaDiaDiem { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDiaDiem { get; set; } = string.Empty;

        public string DiaChiCuThe { get; set; }
        public string ThietBi { get; set; }
        public int SucChua { get; set; }

        public virtual ObservableCollection<Lich_Lam_Viec> LichLamViec { get; set; }
    }
}
