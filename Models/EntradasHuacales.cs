using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Raydelis_HilarioAP1_P1.Models;

public class EntradasHuacales
{
    [Key]
    public int IdEntrada { get; set; }
    [Required(ErrorMessage = "El campo 'Fecha' es obligatorio.")]
    public DateTime Fecha { get; set; } = DateTime.Now;
    [Required(ErrorMessage = "El 'Nombre del cliente' es obligatorio.")]
    public string NombreCliente { get; set; } = string.Empty;
    [Required(ErrorMessage ="El campo 'Cantidad' es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "La cantidad debe ser mayor que 0")]
    public int Cantidad { get; set; }
    [Required(ErrorMessage ="El campo 'Precio' es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
    public double Precio { get; set; }

    [ForeignKey("IdEntrada")]
    public ICollection<DetallesEntrada> DetallesEntrada { get; set; } = new List<DetallesEntrada>();

}
