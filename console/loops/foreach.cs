using System;

class myC
{
    static void Main()
    {
        // QUANDO PRECISAR LER E FAZER A ITERAÇÃO DESSES ELEMENTOS É MELHOR O FOREACH
        int[] num = new int[5] {11, 22, 33, 44, 55};

        foreach(int n in num)
        {
            Console.WriteLine(n);
        }
    }
}