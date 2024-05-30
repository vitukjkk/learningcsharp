// É POSSÍVEL CRIAR MAIS DE UM CONSTRUTOR
// SOBRECARGA DE CONSTRUTORES
using System;

class myC
{
    static void Main()
    {
        Player p1 = new Player();
        Console.WriteLine("[PLAYER 01]\nNome: {0}\nVida: {1}\nVivo: {2}", p1.nome, p1.life, p1.alive);

        Player p2 = new Player("vitor");
        Console.WriteLine("[PLAYER 02]\nNome: {0}\nVida: {1}\nVivo: {2}", p2.nome, p2.life, p2.alive);

        Player p3 = new Player("joão", 80);
        Console.WriteLine("[PLAYER 03]\nNome: {0}\nVida: {1}\nVivo: {2}", p3.nome, p3.life, p3.alive);

        Player p4 = new Player("marcela", 95, false);
        Console.WriteLine("[PLAYER 04]\nNome: {0}\nVida: {1}\nVivo: {2}", p4.nome, p4.life, p4.alive);
    }
}

class Player
{
    public string nome;
    public int life;
    public bool alive;
    public Player(string nome = "Player", int life = 100, bool alive = true)
    {
        this.nome = nome;
        this.life = life;
        this.alive = alive;
    }
}