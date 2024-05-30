using System;

class myC
{
    // MÉTODOS SÃO BLOCOS DE CÓDIGOS - PODEM SER DE ENTRADA OU RETORNAR VALORES
    static void Main()
    {
        int n1, n2;
        
        Console.Write("Digite o primeiro número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        hello();

        Console.WriteLine("A soma entre {0} e {1} é igual a {2}", n1, n2, sum(n1, n2));
    }
    
    static void hello()
    {
        Console.WriteLine("hello world");
    }

    // PARA RETONRAR UM VALOR, É NECESSÁRIO COLOCAR ELE NO INÍCIO

    static int sum(int x, int y)
    {
        int res = x + y;
        return res;
    }
}  