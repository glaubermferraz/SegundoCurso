class Banda
{
    private List<Album> albums = new List<Album>();
    public Banda(string nome)
    {   
        Nome = nome;
    }
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
        Console.WriteLine($"O álbum {album.Nome} foi adicionado à banda {Nome}.");
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:");
        foreach (var album in albums)
        {
            Console.WriteLine($"- {album.Nome} (Duração total: {album.DuracaoTotal} segundos)");
        }
    }
}