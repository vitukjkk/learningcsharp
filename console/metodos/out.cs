// OUT PERMITE RETORNAR MAIS DE DOIS VALORES

using System;

class myC
{
    static void Main()
    {
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int resto;
        int quoc = div(n1, n2, out resto);

        Console.WriteLine("A divisão entre {0} e {1} é igual a {2} + {3} (RESTO)", n1, n2, quoc, resto);
    }

    static int div(int dividen, int divisor, out int rest)
    {
        int quo = dividen / divisor;
        rest = dividen % divisor;
        return quo; 
    }
}