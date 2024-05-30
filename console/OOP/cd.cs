using System;

public class myC
{
    static void Main()
    {
        Player p1 = new Player("vitor");
        Console.WriteLine(p1.nome);
    }
}

public class Player
{
    public int energia;
    public bool vivo;
    public string nome;
    public Player(string n) // CONSTRUTOR - é chamado quando a classe é instanciada
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    ~Player() // DESTRUTOR - é chamado quando a instância é destruída
    {
        Console.WriteLine("Jogador {0} foi destruído", nome);
    }
}