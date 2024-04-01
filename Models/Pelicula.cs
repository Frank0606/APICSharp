namespace APICsharp.Models;

public class Pelicula{
    public int PeliculaId { get; set; }
    public string Titulo { get; set; } = "Sin Titulo";
    public string Sinopsis { get; set; } = "Sin sinopsis";
    public int Anio { get; set; }
    public string Poster { get; set; } = "N/A";
    public ICollection<Categoria>? Categorias { get; set; }
}