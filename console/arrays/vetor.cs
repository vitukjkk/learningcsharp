using System;

class myC
{
    static void Main()
    {
        // VETORES SÃO ARRAYS UNIDIMENSIONAIS
        int[] n = new int[5];
        // ATRIBUINDO DIRETO
        int[] num = new int[3] {666, 777, 888};
        // AQUI IRÁ DEFINIR AUTOMATICAMENTE O NUMERO DE INDICES
        int[] numtwo[3] = {999, 100, 111}; 
        // PODEM SER VÁRIOS TIPOS, COMO STRINGS, DOUBLE, FLOAT, CHAR, ETC
        string[] veh = new string[4];

        // ATRIBUINDO OS VALORES - MAIS LENTO
        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[3] = 444;
        n[4] = 555;

        veh[0] = "Carro";
        veh[1] = "Avião";
        veh[2] = "Navio";
        veh[3] = "Moto";

        Console.WriteLine(n[0]);
        Console.WriteLine(num[1]);
        Console.WriteLine(numtwo[2]);
        Console.WriteLine(veh[3]);
    }
}