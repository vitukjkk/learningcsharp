using System;

class myC
{
    static void Main()
    {
        int z = 10, k, j;
        k = dobrar(z);
        j = doubler(ref z);
        Console.WriteLine(k);
        Console.WriteLine(j);
    }

    static int dobrar(int x)
    {
        return x *= 2;
    }

    static int doubler(ref int y)
    {
        return y *= 2;
    }
}

// REF É PASSAR POR REFERÊNCIA, SEM ELE É PASSAR POR VALOR