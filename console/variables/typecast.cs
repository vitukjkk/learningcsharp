// CONVERSÕES IMPLÍCITAS (SEGURAS) O COMPILADOR FAZ AUTOMATICAMENTE

using System;

class myC
{
    static void Main()
    {
        int n1 = 10;
        double n2 = n1;

        Console.WriteLine(n2);

        // CONVERSÕES EXPLÍCITAS (NÃO SEGURAS)

        double n3 = 15.0f;
        // int n4 = n3; // ERRO - CONVERSÃO EXPLÍCITA, PRECISA DO CAST
        int n4 = (int)n3; // OPERAÇÃO DE TYPECAST (CORRETA)!!

        Console.WriteLine(n4);
    }
}

