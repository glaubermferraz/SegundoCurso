Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";


Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Artista = "The Police";
musica1.Duracao = 183;
musica1.Disponivel = true;
musica1.ExibirFichaTecnica();

Musica musica2 = new()
{
    Nome = "Bohemian Rhapsody",
    Artista = "U2",
    Duracao = 191,
    Disponivel = false
};
musica2.ExibirFichaTecnica();

albumDoQueen.AdcionarMusica(musica1);
albumDoQueen.AdcionarMusica(musica2);