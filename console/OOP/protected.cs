using System;

class Vehicle
{
    protected int velMax;
    protected bool ligado;
    public Vehicle(int velMax)
    {
        this.velMax = velMax;
        ligado = false;
    }
}

class Carro:Vehicle
{
    public string nome;
    protected string cor;
    protected int ano;
    public Carro(string nome, string cor, int ano, int velMax):base(velMax)
    {
        this.nome = nome;
        this.cor = cor;
        this.ano = ano;
        this.velMax = velMax;
        ligado = true;        
    }

    public void getInfo()
    {
        Console.WriteLine("[CARRO]\nNome: " + nome + "\nCor: " + cor + "\nAno: " + ano + "\nVelocidade Max.: " + velMax + "\nEstá ligado? " + ligado);
        Console.WriteLine("======================");
    }
}

class myC
{
    static void Main()
    {
        Carro c1 = new Carro("HB20s", "Prata", 2020, 120);
        c1.getInfo();
    }
}