using System.ComponentModel.DataAnnotations;

namespace PrimerParcialSharlot.Model;

public class Autor
{
    [Key]
    public int AutorId { get; set;  }
    public string Nombres { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;

    public double Sueldo { get; set; }

}
