using System;

class myC
{
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        string resultado = "Indefinido";

        if(num > 10)
        {
            resultado = "Maior que 10";
        }
        else if(num == 10)
        {
            resultado = "Igual a 10";
        }
        else
        {
            resultado = "Menor que 10";
        }

        Console.WriteLine(resultado);
    }
}