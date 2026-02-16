using System.ComponentModel.DataAnnotations;

namespace Raydelis_HilarioAP1_P1.Models;

public class EntradasHuacales
{
    [Key]
    public int IdEntrada { get; set; }
    [Required(ErrorMessage = "El campo 'Fecha' es obligatorio.")]
    public DateTime Fecha { get; set; }
    [Required(ErrorMessage ="El 'Nombre del cliente' es obligatorio.")]
    public string NombreCliente { get; set; }
    [Required(ErrorMessage ="El campo 'Cantidad' es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "La cantidad debe ser mayor que 0")]
    public int Cantidad { get; set; }
    [Required(ErrorMessage ="El campo 'Precio' es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
    public double Precio { get; set; }
}
