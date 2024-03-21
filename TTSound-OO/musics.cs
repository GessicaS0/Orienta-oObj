using System.Xml;

class Music {

    public Music(Banda artistaDAbanda, string nome_m)
    { //construtor

        Artista = artistaDAbanda;
        Nome_m = nome_m;
    }

    public string Nome_m { get; }
    public Banda Artista { get; }
    public int Duracao_m { get; set; }
    
    public bool M_Disponivel { get; set; }

    public int Somar_teste(int a, int b) => a + b; //exemplo do curso 
    
    //retornando o a leitura com lambda
    public string DescricaoResumida => $"A música {Nome_m} pertence a banda {Artista}";
    public void ExibirFicha()
    {
        Console.WriteLine($"Nome: {Nome_m}");
        Console.WriteLine($"Artista: {Artista.B_Nome}");
        Console.WriteLine($"Duração: {Duracao_m}");

        if (M_Disponivel)
        {
            Console.WriteLine("Disponível para plano vigente  :)  \n");
        }
        else
        {
            Console.WriteLine("Indisponível para plano vigente :(  \n");
        }

    }


    public void Teste()
    {

        Console.WriteLine($"Nome: {Nome_m} - Artista: {Artista} \n");

    }

}