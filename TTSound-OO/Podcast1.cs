using System.Xml;

class Podcast
{
    private List<Episodio>  list_ep = new ();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }

    public int TotalEp => list_ep.Count;

    public void AdicionarEpisodio (Episodio episodio)
    {
        list_ep.Add (episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} é apresentado por {Host}\n");
        foreach (Episodio episodio in list_ep)
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEp} episódios\n");
    }

}