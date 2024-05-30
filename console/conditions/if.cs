using System;

class myC
{
    static void Main(string[] args)
    {
        // if funciona com operadores de comparação
        
        int nota = Convert.ToInt32(Console.ReadLine());

        string msg = nota >= 60 ? msg = "Aprovado" : msg = "Reprovado";

        Console.WriteLine(msg);
    }
}