using System;

class myC
{
    public static void Main()
    {
        calc c1 = new calc(10, 2);
        c1.sum(10, 2);
        c1.info();
    }
}

public class calc
{
    public int v1;
    public int v2;

    public calc(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public int sum(int v1, int v2)
    {
        return v1 + v2;
    }

    public void info()
    {
        Console.WriteLine("[SOMA] {0} + {1} é igual a {2}", v1, v2, sum(v1, v2));
    }
}