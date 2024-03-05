using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class VehiculosDetalle
{
    [Key]
    public int DetalleId { get; set; }
    public int VehiculoId { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public int AccesorioId { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public decimal Valor {  get; set; }
}
