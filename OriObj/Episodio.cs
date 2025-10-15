class Episodio
{
    private List<string> convidados = new List<string>();
    public int Duracao { get; }
    public string Titulo { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    public int Ordem { get; }
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string nomeConvidado)
    {
        convidados.Add(nomeConvidado);
        Console.WriteLine($"O convidado {nomeConvidado} foi adicionado ao episódio {Titulo}.");
    }

    public void ExibirResumo()
    {
        Console.WriteLine(Resumo);
    }
}