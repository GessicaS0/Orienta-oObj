class Album
{
    private List<Music> list_musicas = new List<Music>();

    public Album(string a_Nome)
    {
        A_Nome = a_Nome;
    }

    public string A_Nome { get; }
    public int DuracaoTotal => list_musicas.Sum(m => m.Duracao_m);  //percorrento a lista de muscias e somando somente a duração

    public void AdicionarMusic (Music musica)
    {
        list_musicas.Add (musica);     //colocando as musicas dentro da lista de musicas de um album
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do album: {A_Nome}\n");
        foreach (var music in list_musicas)
        {
            Console.WriteLine($"Música: {music.Nome_m}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal} segundos disponíveis");
    }

}