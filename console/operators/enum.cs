using System;

class myC
{
    enum dayweek
    {
        Domingo,
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta,
        Sábado
    };

    static void Main()
    {
        dayweek ds = dayweek.Sexta; // PELO NOME DA VARIÁVEL
        dayweek dd = (dayweek)0; // PELO ÍNDICE
        int db = (int)dayweek.Sexta; // AQUI ELE PEGA O ÍNDICE CORRESPONDENTE À VARIÁVEL

        Console.WriteLine(ds);
        Console.WriteLine(dd);
        Console.WriteLine(db);
    }
}