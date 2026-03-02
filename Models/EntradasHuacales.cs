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

    [ForeignKey("IdEntrada")]
    public ICollection<DetallesEntrada> DetallesEntrada { get; set; } = new List<DetallesEntrada>();

}
