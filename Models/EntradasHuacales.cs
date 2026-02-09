using System.ComponentModel.DataAnnotations;

namespace Raydelis_HilarioAP1_P1.Models;

public class EntradasHuacales
{
    [Key]
    public int ViajeId { get; set; }
    [Required(ErrorMessage = "El campo fecha de viaje es obligatorio.")]
    public DateTime FechaViaje { get; set; }
    [Required(ErrorMessage = "El campo descripcion es obligatorio.")]
    public string Descripcion { get; set; }
    [Required(ErrorMessage = "El campo costo es obligatorio.")]
    public double Costo { get; set; }
}
