Episodio ep1 = new(1 , "Prólogo" , 60);
ep1.AdcionarConvidados("Kenan");
ep1.AdcionarConvidados("Kel");



Episodio ep2 = new(2, "A parada", 61);
ep2.AdcionarConvidados("Chris");
ep2.AdcionarConvidados("Drew");
ep2.AdcionarConvidados("Greg");

Podcast podcast = new Podcast("Dois mundos", "Gef");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

/* 
 * Exercicio 2
 * Banda calypso = new Banda("The Calypso");

Album albumCalypso = new Album(" Isso é Calypso - Ao vivo");

Music musica001 = new Music(calypso, "Tic tac")
{
    Duracao_m = 321,
    M_Disponivel = true,
};

Music musica002 = new Music(calypso, "Cavalo manco")
{
    Duracao_m = 654,
    M_Disponivel = false,
};


albumCalypso.AdicionarMusic(musica001);
albumCalypso.AdicionarMusic(musica002);
calypso.AdicionarAlbum(albumCalypso);

musica002.ExibirFicha();
musica001.ExibirFicha();
albumCalypso.ExibirMusicasAlbum();
calypso.ExibirDiscografia();

*/





















/*
 * Parte um do curso
Music musica01 = new Music();  //crio um obj tipo Musica
Music musica02 = new Music();

musica01.Nome_m = "Indestrutible";
musica01.Artista = "Disturbed";
musica01.Duracao_m = 250;
musica01.M_Disponivel = true;

musica02.Nome_m = "Arroxeda";
musica02.Artista = "Barões da Pisadinha";
musica02.Duracao_m = 444;
musica02.M_Disponivel = false;

musica02.ExibirFicha();
musica01.ExibirFicha();

musica02.Teste();
musica01.Teste();

Console.WriteLine(musica01.DescricaoResumida);
Console.WriteLine(musica01.Somar_teste(1, 2));

*/
