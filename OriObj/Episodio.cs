class Episodio
{
    private List<string> convidados = new List<string>();
    public int Duracao { get; }
    public string Titulo { get; }
    public string Resumo => $"{Ordem} - {Titulo} - {string.Join(",", convidados)}";
    public int Ordem { get; }
    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
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