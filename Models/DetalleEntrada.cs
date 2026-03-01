using System.ComponentModel.DataAnnotations;

namespace Raydelis_HilarioAP1_P1.Models;

public class DetalleEntrada
{
    [Key]
    public int DetalleId { get; set; }
    public int EntradaId { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int TipoId { get; set; }

}
