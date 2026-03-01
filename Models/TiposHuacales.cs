using System.ComponentModel.DataAnnotations;

namespace Raydelis_HilarioAP1_P1.Models;

public class TiposHuacales
{
    [Key]
    public int TipoId { get; set;  }
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Descripcion { get; set; } = null!;
    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser mayor que 0")]
    public int Existencia { get; set; }
}
