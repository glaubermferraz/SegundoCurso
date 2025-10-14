
Musica musica1 = new Musica();
musica1.Nome = "Roxanne";
musica1.Artista = "The Police";
musica1.Duracao = 183;
musica1.Disponivel = true;
musica1.ExibirFichaTecnica();
//Console.WriteLine(musica1.NomeCompleto);

Musica musica2 = new()
{
    Nome = "Vertigo",
    Artista = "U2",
    Duracao = 191,
    Disponivel = false
};
musica2.ExibirFichaTecnica();