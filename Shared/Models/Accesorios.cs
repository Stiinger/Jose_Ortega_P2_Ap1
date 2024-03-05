using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models;

public class Accesorios
{
    [Key]
    public int AccesorioId { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public string Descripcion { get; set; } = string.Empty;

    [ForeignKey("Accesorios")]
    public ICollection<VehiculosDetalle> VehiculosDetalle { get; set; } = new List<VehiculosDetalle>();
}