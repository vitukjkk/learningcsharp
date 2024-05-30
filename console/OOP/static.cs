// STATICS SÃO UM PRA TODOS POIS ESTÁ NO MESMO LUGAR DA MEMORIA - NÃO PODEM TER CONSTRUTORES NEM SER INSTANCIADOS

using System;

class myC
{
    static void Main()
    {
        // CRIANDO OS PLAYERS
        Player p1 = new Player();
        p1.Info();
        Player p2 = new Player("vitor");
        p2.Info();
        Player p3 = new Player("joao", 80);
        p3.Info();
        Player p4 = new Player("maria", 90, false);
        p4.Info(); 

        Enemy.alerta = true; // COMO É STATIC, TODOS OS VALORES SERÃO O MESMO

        // CRIANDO OS INIMIGOS
        Enemy i1 = new Enemy();
        i1.Info();
        Enemy i2 = new Enemy("Doido");
        i2.Info();
        Enemy i3 = new Enemy("Malucão", 300);
        i3.Info();
        Enemy i4 = new Enemy("Pirado", 400, false);
        i4.Info();
        Enemy i5 = new Enemy("Enlouquecido", 600, true);
        i5.Info();
    }
}

class Player
{
    private static int nextID = 1;
    public int id;
    public string nome;
    public int vida;
    public bool isvivo;

    // Construtor da classe Player
    public Player(string nome = "Player", int vida = 100, bool isvivo = true)
    {
        this.id = nextID++;
        this.nome = nome;
        this.vida = vida;
        this.isvivo = isvivo;
    }

    public void Info()
    {
        Console.WriteLine("\n[PLAYER {0}]\nNome: {1}\nVida: {2}\nVivo: {3}", id, nome, vida, isvivo);
    }
}

class Enemy
{
    private static int nextID = 1;
    public int id;
    public string nome;
    public int vida;
    public bool isvivo;
    static public bool alerta = false;

    // Construtor da classe Enemy
    public Enemy(string nome = "Inimigo", int vida = 500, bool isvivo = true)
    {
        this.id = nextID++;
        this.nome = nome;
        this.vida = vida;
        this.isvivo = isvivo;
    }

    public void Info()
    {
        Console.WriteLine("\n[INIMIGO {0}]\nNome: {1}\nVida: {2}\nVivo: {3}\nAlerta: {4}", id, nome, vida, isvivo, alerta);
    }
}
