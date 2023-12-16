
using System.ComponentModel.DataAnnotations;

namespace Clase3.Models;

public class Movie
{
    public string Code { get; set; }
    [Display(Name = "Nombre")]
    [Required]
    public string Name { get; set; }

    public int Minutos { get; set; }

    public string Categoria { get; set; }

    public string review { get; set; }
}


