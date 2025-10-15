// Criando banda
Banda queen = new Banda();
queen.Nome = "Queen";

// Criando Album
Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

// Criando músicas
Musica musica1 = new Musica(queen);
musica1.Nome = "Love of my life";
musica1.Duracao = 217;
Musica musica2 = new Musica(queen);
musica1.Nome = "Bohemian Rhapsody";
musica1.Duracao =  354;


// Adicionar músicas ao álbum
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

// Exibir discografia

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();