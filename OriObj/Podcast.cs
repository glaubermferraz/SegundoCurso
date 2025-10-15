class Podcast
{
    private List<Episodio> listaEpisodios = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => listaEpisodios.Count;
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    
    public void AdicionarEpisodio(Episodio episodio)
    {
        listaEpisodios.Add(episodio);
        Console.WriteLine($"O episódio {episodio.Titulo} foi adicionado ao podcast {Nome}.");
    }

    public void ExibirDetalhes()
    {   
        Console.WriteLine("\n--- Detalhes do Podcast ---\n");
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de Episódios: {TotalEpisodios}");
        Console.WriteLine("Episódios:");
        foreach (var episodio in listaEpisodios)
        {
            Console.WriteLine($"> {episodio.Resumo} ({episodio.Duracao} minutos)");
        }
    }
}