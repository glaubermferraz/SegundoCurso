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