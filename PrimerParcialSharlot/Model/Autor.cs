using System.ComponentModel.DataAnnotations;

namespace PrimerParcialSharlot.Model;

public class Autor
{
    [Key]
    public int AutorId { get; set;  }
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public string Nombres { get; set; } = null!;
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public string Nacionalidad { get; set; } = null!;
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public double Sueldo { get; set; }

}
