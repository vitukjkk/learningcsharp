// É POSSÍVEL USAR O REF PARA CHAMAR OS MÉTODOS!

using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe base!");
    }

    virtual public void info() {}
}

class dev1:Base
{
    public dev1()
    {
        Console.WriteLine("Construtorda base derivada 01");
    }

    public override void info()
    {
        Console.WriteLine("Classe derivada 1!");
    }
}

class dev2:dev1
{
    public dev2()
    {
        Console.WriteLine("Construtor derivada 02");
    }

    public override void info()
    {
        Console.WriteLine("Classe derivada 2!");
    }
}

class myC
{
    static void Main()
    {
        Base Ref;
        dev1 d1 = new dev2();
        dev2 d2 = new dev2();
        d1.info();
        
        Ref = d1;
        Ref = d2;
        Ref.info();
    }
}