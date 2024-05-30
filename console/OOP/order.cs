// ORDEM DOS CONSTRUTORES: DA BASE PARA BAIXO!!

using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe base!");
    }
}

class dev1:Base
{
    public dev1()
    {
        Console.WriteLine("Construtorda base derivada 01");
    }
}

class dev2:dev1
{
    public dev2()
    {
        Console.WriteLine("Construtorda base derivada 02");
    }
}

class myC
{
    static void Main()
    {
        dev2 d1 = new dev2();
    }
}