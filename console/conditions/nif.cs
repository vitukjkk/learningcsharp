using System;

class myC
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string msg = "Indefinido";

        if(n >= 70)
        {
            if(n >= 90)
            {
                msg = "Super-aprovado";
            }
            else
            {
                msg = "Aprovado";
            }
        }
        else
        {
            if(n >= 40)
            {
                msg = "Recuperação";
            }
            else
            {
                msg = "Reprovado";
            }
        }

        Console.WriteLine(msg);
    }
}