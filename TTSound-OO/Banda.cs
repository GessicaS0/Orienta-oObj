class Banda
{
    private List<Album> list_albuns = new List<Album>();

    public Banda(string nomebanda)
    {
        B_Nome = nomebanda;
    }

    public string B_Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        list_albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da banda {B_Nome}");
        foreach (Album album in list_albuns)
        {
            Console.WriteLine($"Albuns da banda: {album.A_Nome}\n");
        }

    }
}