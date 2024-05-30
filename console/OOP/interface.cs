/*
SERVEM PARA DEFINIR MÉTODOS, NÃO PODEM TER STATICS
*/

using System;

public interface Vehicle
{
    void ligar();
    void desligar();
    void info();
}

public interface Combate
{
    void disparar();
}

class Carro:Vehicle,Combate // É POSSÍVEL POR DUAS CLASSES BASE
{
    public Carro()
    {

    }

    public void ligar()
    {

    }

    public void desligar()
    {

    }

    public void info()
    {

    }

    public void disparar()
    {
        
    }
}

class myC
{
    public static void Main()
    {
        Carro c1 = new Carro();
    }
}