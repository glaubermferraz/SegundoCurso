Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";


Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 217;

Musica musica2 = new()
{
    Nome = "Bohemian Rhapsody",
    Artista = "Queen",
    Duracao = 354,
    Disponivel = false
};

albumDoQueen.AdcionarMusica(musica1);
albumDoQueen.AdcionarMusica(musica2);
albumDoQueen.ExibirMusicas();