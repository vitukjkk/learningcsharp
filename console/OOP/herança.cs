// CLASSE FILHA HERDA METODOS DA CLASSE MÃE

using System;

class Vehicle
{
    public int velMax;
    public bool ligado;
    public int rodas;
    public Vehicle(int rodas)
    {
        this.rodas = rodas;
    }
}

class Carro:Vehicle // CLASSE DERIVADA
{
    private string nome;
    private string cor;
    public Carro(string nome = "Carro", string cor = "Branco"):base(4)
    {
        this.nome = nome;
        this.cor = cor;
        ligado = false;
        rodas = 4;
        velMax=120;
    }
    public void Info()
    {
        Console.WriteLine("[CARRO]\nNome: " + nome + 
        "\nCor: " + cor + "\nEstado: " + ligado + "\nVelocidade Max.: " 
        + velMax + "\nRodas: " + rodas);
    }
}

class myC
{
    static void Main()
    {
        Vehicle v1 = new Vehicle(3);
        Carro c1 = new Carro("HB20s", "Prata");
        c1.Info();
    }
}