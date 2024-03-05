using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Vehiculos
{
    [Key]
    public int VehiculoId { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime Fecha { get; set; } = DateTime.Today;
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public string Descripcion { get; set; } = string.Empty;
    [Range(1, 1000000000, ErrorMessage = "El costo debe ser mayor a 0.")]
    public decimal Costo { get; set; }
    public decimal Gastos { get; set; }

    [ForeignKey("Vehiculos")]
    public ICollection<VehiculosDetalle> VehiculosDetalle { get; set; } = new List<VehiculosDetalle>();
}