using System;


class area
{
    public static float aquad(float bas, float altura)
    {
        if(bas <= 0 | altura <= 0) { throw new Exception("base e altura não podem ser iguais a 0!"); }
        float res = bas * altura;
        Console.WriteLine("RESULTADO: a área do quadrado é igual a {0}", res);
        return res;
    }
}

class myC
{
    public static void Main()
    {
        try
        {
            area.aquad(0, 3);
        }
        catch(Exception e)
        {
            Console.WriteLine("ERRO: {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("FIM DO PROGRAMA!!");
        }
    }
}