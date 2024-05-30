using System;
using System.Collections.Generic;

class myC
{
    public static void Main()
    {
        Queue<string> vehicle = new Queue<string>();

        vehicle.Enqueue("Carro");
        vehicle.Enqueue("Moto");
        vehicle.Enqueue("Navio");

        Console.WriteLine(vehicle.Contains("Carro")); 
        Console.WriteLine(vehicle.Peek());
        // vehicle.Clear();

        vehicle.Dequeue(); // REMOVE O PRIMEIRO ELEMENTO

        // NAO PODEMOS USAR INDEXADORES NOS QUEUE

        Console.WriteLine("Tamanho da fila: " + vehicle.Count);

        foreach(string n in vehicle)
        {
            Console.WriteLine("Veículo: " + n);
        }
    }
}