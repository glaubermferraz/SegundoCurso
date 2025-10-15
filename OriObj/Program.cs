// Criando banda
Banda queen = new Banda("Queen");

// Criando Album
Album albumDoQueen = new Album("A night at the opera");

// Criando músicas
Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 217,
    Disponivel = true,
};
Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

// Adicionar músicas ao álbum
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

// Exibir discografia
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicas();
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

// Criando episódio
Console.WriteLine("\n--- Episódios do Podcast ---\n");
Episodio episodio1 = new Episodio(1, "A volta dos que não foram", 60);
Episodio episodio3 = new Episodio(3, "A volta dos Jedi", 55);
Episodio episodio2 = new Episodio(2, "O retorno dos que não foram", 45);

// Adicionando convidados
episodio1.AdicionarConvidados("João");
episodio1.AdicionarConvidados("Maria");
episodio3.AdicionarConvidados("Lucas");
episodio2.AdicionarConvidados("Pedro");
episodio2.AdicionarConvidados("Ana");

// Exibindo resumos dos episódios
Console.WriteLine("\nResumos dos Episódios:");
episodio1.ExibirResumo();
episodio3.ExibirResumo();
episodio2.ExibirResumo();

// Adicionando Episodios ao Podcast
Podcast techTalks = new Podcast("Faustao","Tech Talks");
techTalks.AdicionarEpisodio(episodio1);
techTalks.AdicionarEpisodio(episodio3);
techTalks.AdicionarEpisodio(episodio2);
techTalks.ExibirDetalhes();

