using System.ComponentModel.DataAnnotations;

namespace Raydelis_HilarioAP1_P1.Models;

public class DetallesEntrada
{
    [Key]
    public int DetalleId { get; set; }
    public int IdEntrada { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int TipoId { get; set; }

}
