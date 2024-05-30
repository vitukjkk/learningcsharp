/*
LINKED LIST
*/

using System;
using System.Collections.Generic;

class myC
{
    public static void Main()
    {
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Bicicleta"); // POE NO PRIMEIRO, FAZ COM QUE ELES VÃO PARA ÚLTIMO LUGAR
        transp.AddFirst("Navio");

        transp.AddLast("Moto");

        LinkedListNode<string>no;
        no = transp.FindLast("Navio");

        transp.AddAfter(no, "Patinete");
        transp.AddBefore(no, "Patins");

        if(transp.Find("Carro") == null)
        {
            Console.WriteLine("Elemento não encontrado!");
        }
        else
        {
            Console.WriteLine("Elemento encontrado!");
        }

        transp.Remove("Navio");
        transp.RemoveFirst();
        transp.RemoveLast();

        foreach(string n in transp)
        {
            Console.WriteLine(n);
        }
    }
}