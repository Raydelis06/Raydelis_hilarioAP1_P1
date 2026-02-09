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
    public int Cantidad { get; set; }
    [Required(ErrorMessage ="El campo 'Precio' es obligatorio.")]
    public double Precio { get; set; }
}
