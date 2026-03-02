using System.ComponentModel.DataAnnotations;

namespace Raydelis_HilarioAP1_P1.Models;

public class DetallesEntrada
{
    [Key]
    public int DetalleId { get; set; }
    public int IdEntrada { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int TipoId { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "La cantidad debe ser mayor que 0")]
    public int Cantidad { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
    public double Precio { get; set; }
}
