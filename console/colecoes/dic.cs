/*
COLEÇÕES DE DADOS
*/

using System;
using System.Collections.Generic;

class myC
{
    public static void Main()
    {
        Dictionary <int, string> vehicle = new Dictionary<int, string>();

        // ADICIONAR VALORES

        vehicle.Add(10, "Carro");
        vehicle.Add(0, "Avião");
        vehicle.Add(5, "Navio");
        vehicle.Add(7, "Patinete");

        Console.WriteLine("Tamanho do dictionary: {0}", vehicle.Count);
        //vehicle.Clear();
        //Console.WriteLine("Tamanho do dictionary: {0}", vehicle.Count);

        // VER SE TEM A CHAVE

        int n = 10;

        if(vehicle.ContainsKey(n))
        {
            Console.WriteLine("A chave {0} está na coleção.", n);
        }
        else
        {
            Console.WriteLine("A chave {0} não está na coleção.", n);
        }

        // VENDO SE TEM VALOR
        string veh = "Carro";

        if(vehicle.ContainsValue(veh))
        {
            Console.WriteLine("O valor {0} está na coleção.", veh);
        }
        else
        {
            Console.WriteLine("O valor {0} não está na coleção.", veh);
        }


        // REMOVENDO VALORES
        vehicle.Remove(10);
        Console.WriteLine(vehicle.ContainsKey(10));

        foreach(KeyValuePair<int, string> v in vehicle)
        {
            Console.WriteLine(v.Key); // IMPRIMIR AS CHAVES
            Console.WriteLine(v.Value); // IMPRIMIR OS VALORES
        }
    }
}