using Clase3.Models;

namespace Clase3.Services;
public static class MovieServices
{
    static List<Movie> Movies { get; set; }

    static MovieServices()
    {
        Movies = new List<Movie>
        {
        new Movie{Name = "Back to the Future",   Code = "BTF",    Categoria = "Sci fi",    Minutos = 110},
        new Movie{Name = "Avatar",Code = "AVT",Categoria = "Sci fi",Minutos = 500},
        new Movie{Name="Hanibal",Code = "HNL",Categoria = "Terror",Minutos =110 }
    };
    }

    public static List<Movie> GetAll() => Movies;

    public static void Add(Movie value)
    {
        if (value == null)
        {
            return;
        }
        Movies.Add(value);
    }

    public static Movie? get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());

    public static void delete(string code)
    {
        var delete = get(code);
        if (delete != null)
        {
            Movies.Remove(delete);
        }
    }

    //DELETE
    //UPDATE
}