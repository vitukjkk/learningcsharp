using System;

class myC
{
    static void Main()
    {
        int[] v1 = new int[5] {10, 20, 30, 40, 50};
        int[] v2 = new int[5] {5, 15, 25, 35, 45};

        foreach(int n in v1)
        {
            Console.WriteLine(n);
        }

        /*
        // BINARY SEARCH
        Console.WriteLine("===========================================");
        Console.WriteLine("BinarySearch");
        int proc = 20;
        int pos = Array.BinarySearch(v1, proc);
        Console.WriteLine("O valor {0} está na posição {1}", proc, pos);
        Console.WriteLine("===========================================");
        */
        
        /*
        // COPY
        Console.WriteLine("===========================================");
        Console.WriteLine("Copy");
        Array.Copy(v1, v2,v1.Length); // Array.Copy(copiador, copiado, numero_elementos_a_copiar);
        foreach(int n in v2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("===========================================");
        */

        /*
        // COPYTO
        Console.WriteLine("===========================================");
        Console.WriteLine("CopyTo");
        v1.CopyTo(v2, 0); // origem.CopyTo(destino, indice_qual_comecar);
        foreach(int n in v2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("===========================================");
        */

        /*
        // GETUPPERBOUND
        Console.WriteLine("===========================================");
        Console.WriteLine("GetUpperBound");
        int smindex = v1.GetUpperBound(0); // array.GetUpperBound(qual dimensão);
        Console.WriteLine("O maior índice do vetor v1 é {0}", smindex);
        Console.WriteLine("===========================================");
        */

        /*
        // GETLOWERBOUND
        Console.WriteLine("===========================================");
        Console.WriteLine("GetLowerBound");
        int smindex = v1.GetLowerBound(0); // array.GetLowerBound(qual dimensão);
        Console.WriteLine("O menor índice do vetor v1 é {0}", smindex);
        Console.WriteLine("===========================================");
        */
        
        /*
        // GETVALUE
        Console.WriteLine("===========================================");
        Console.WriteLine("GetValue");
        int n1 = Convert.ToInt32(v1.GetValue(3)); // SE FOR MATRIZ PRECISA POR GetValue(1,3)
        Console.WriteLine(n1);
        Console.WriteLine("===========================================");
        */

        /*
        // INDEXOF
        Console.WriteLine("===========================================");
        Console.WriteLine("IndexOf");
        int i1 = Array.IndexOf(v1, 20);
        Console.WriteLine("O índice do valor 20 é o {0}", i1);
        Console.WriteLine("===========================================");
        */
        
        /*
        // lASTINDEXOF
        Console.WriteLine("===========================================");
        Console.WriteLine("LastIndexOf");
        int i2 = Array.LastIndexOf(v1, 20);
        Console.WriteLine("O último índice do valor especificado é {0}", i2);
        Console.WriteLine("===========================================");
        */

        /*
        // REVERSE
        Console.WriteLine("===========================================");
        Console.WriteLine("Reverse");
        Array.Reverse(v1);
        foreach(int n in v1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("===========================================");
        */

        /*
        // SETVALUE
        Console.WriteLine("===========================================");
        Console.WriteLine("SetValue");
        v1.SetValue(99, 0);
        foreach(int n in v1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("===========================================");
        */

        // SORT
        Console.WriteLine("===========================================");
        Console.WriteLine("Sort");
        int[] v3 = new int[5] {55, 44, 33, 22, 11};
        Array.Sort(v3);
        foreach(int n in v3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("===========================================");
    }
}