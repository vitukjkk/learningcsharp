/*
STRUCTS SÃO TIPO CLASSES SÓ Q SÃO TRATADAS COMO VALUE
NAO PODE TER HERANÇA NELA
*/

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
        Carro c1 = new Carro("VW", "Golf", "Branco");
        c1.info();

        Carro c2 = new Carro("Honda", "HRV", "Vermelho");
        c2.info();

        Carro c3 = new Carro("Hyundai", "HB20s", "Prata");
        c3.info();
    }   
}