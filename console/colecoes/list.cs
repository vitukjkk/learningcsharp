/*
LIST É COMO SE FOSSE UM ARRAY TUNADO!!
*/

using System;
using System.Collections.Generic;

class myC
{
    public static void Main()
    {
        List<string>carros = new List<string>();
        List<string>carrostwo = new List<string>();

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("HB20s");
        carros.Add("Argo");

        carrostwo.AddRange(carros);

        // carrostwo.Clear();

        if(carrostwo.Contains("HB20s"))
        {
            Console.WriteLine("Elemento encontrado!");
        }
        else
        {
            Console.WriteLine("Elemento não encontrado!");
        }

        // carros.CopyTo(carrostwo, 2); // PRECISAR SER UMA ARRAY

        carrostwo.Insert(1, "Cruze");
        carrostwo.RemoveAt(2);

        carrostwo.Reverse(); // REVERTE
        // carrostwo.Sort(); //  ORDENA POR ORDEM ALFABÉTICA

        int aaaaa = carrostwo.LastIndexOf("HRV");

        foreach(string c in carrostwo)
        {
            Console.WriteLine(c);
        }

        string res = "HB20s";
        int pos = 0;
        pos = carrostwo.IndexOf(res); // ACHAR O ÍNDICE DO ÚLTIMO 
        Console.WriteLine("O carro {0} está na posição {1}", res, pos);
        
        Console.WriteLine(aaaaa);
        Console.WriteLine(carrostwo.Count);
        Console.WriteLine(carrostwo.Capacity);

        Console.WriteLine(carrostwo[2]);
    }
}
