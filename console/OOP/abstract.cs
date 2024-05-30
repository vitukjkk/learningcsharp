using System;

/*
NÃO É POSSÍVEL INSTANCIAR CLASSES ABSTRATAS, SO SERVEM PARA SER HERDADAS - EM CLASSES HERDADAS, É OBRIGADO A USAR TODOS OS MÉTODOS ABSTRATOS
NOS MÉTODOS ABSTRATOS, ELES SÓ PODEM SER DEFINIDOS, NÃO PODEM TER IMPLEMENTAÇÃO
*/

abstract class Vehicle 
{
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public Vehicle()
    {
        ligado = false;
        velAtual = 0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }

    abstract public int aceleracao(int mult);

    public int getVelMax()
    {
        return velMax;
    }
}

class Carro:Vehicle
{
    public Carro()
    {
        velMax = 120;
    }

    public override int aceleracao(int mult)
    {
        velAtual += 10 * mult;
        return velAtual;
    }
}

class myC
{
    public static void Main()
    {
        Carro c1 = new Carro();

        Console.WriteLine(c1.aceleracao(10));
    }
}