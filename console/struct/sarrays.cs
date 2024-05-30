using System;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info()
    {
        Console.WriteLine("[CARRO]\nMarca: {0}\nModelo: {1}\nCor: {2}", this.marca, this.modelo, this.cor);
    }
}

class myC
{
    public static void Main()
    {
        Carro[] carros = new Carro[2];

        carros[0].marca = "VW";
        carros[0].modelo = "Golf";
        carros[0].cor = "Vermelho";

        carros[1].marca = "Hyundai";
        carros[1].modelo = "HB20s";
        carros[1].cor = "Prata";

        carros[0].info();
        carros[1].info();
    }
}