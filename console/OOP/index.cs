// INDEXADORES PERMITEM OBJETOS SEREM TRANSFORMADOS EM MATRIZES / VETORES

using System;

class Carro
{
    protected string nome;
    protected string cor;
    protected int ano;
    private int[] velMax = new int[5] {80, 90, 100, 110, 120};
    public Carro(string nome = "Veículo", string cor = "Indefinido", int ano = 0000, int velMax = 100)
    {
        this.nome = nome;
        this.cor = cor;
        this.ano = ano;
    }

    public int this[int i]
    {
        get { return velMax[i]; }
        set { velMax[i] = value < 0 ? 0 : value > 300 ? 300 : value; }
    }

    public void getInfo()
    {
        Console.WriteLine("[CARRO]\nNome: {0}\nCor: {1}\nAno: {2}\nVelocidade Máxima: {3}", nome, cor, ano, velMax[0]);
    }
}

class myC
{
    public static void Main()
    {
        Carro c1 = new Carro();
        c1.getInfo();

        Carro c2 = new Carro("HB20s", "Prata", 2020);
        c2[4] = 200;
        c2.getInfo();
        Console.WriteLine("Velocidade: {0}", c2[4]);
    }
}