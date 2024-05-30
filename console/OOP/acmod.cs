// PRIVATE SO PODE SER ACESSADO DENTRO DA CLASSE
// GET E SET SÃO PARA OBTER E SETAR

using System;

class Player
{
    private string nome;
    private int energia;

    public Player(string nome = "Player", int energia = 100)
    {
        this.nome = nome;
        this.energia = energia;
    }

    public void Info()
    {
        Console.WriteLine("\n[PLAYER]\nNome: {0}\nEnergia: {1}", nome, energia);
    }

    public string getNome()
    {
        return nome;
    }

    public int getEnergia()
    {
        return energia;
    }

    public void setEnergia(int e)
    {
        if(e > 100 | e < 0)
        {
            Console.WriteLine("ERRO: o valor da vida deve estar entre 1-100!");
        }
        else
        {
            energia = e;
        }
    }
}

class myC
{
    public static void Main()
    {
        Player p1 = new Player();
        p1.Info();
        Player p2 = new Player("Vitor", 90);
        p2.Info();

        Console.WriteLine("Digite a nova energia: ");
        int givenergy = Convert.ToInt32(Console.ReadLine());
        p2.setEnergia(givenergy);
        p2.Info();
    }
}