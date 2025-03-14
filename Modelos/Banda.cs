namespace ScreenSound.Modelos;
internal class Banda : IAvaliavel
{
    private List<Album> albuns = new();
    private List<Avaliacao> notas = new();

    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public string? Resumo { get; set; }

    public Banda(string nome)
    {
        Nome = nome;
    }

    public IEnumerable<Album> Albuns => albuns;

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}
