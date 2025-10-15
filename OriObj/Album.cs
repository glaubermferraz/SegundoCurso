class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
        Console.WriteLine($"A música {musica.Nome} foi adicionada ao álbum {Nome}.");
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Músicas do álbum {Nome}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.Nome} ({musica.Duracao} segundos)");
        }
        Console.WriteLine($"Duração total do álbum: {DuracaoTotal} segundos");
    }
}