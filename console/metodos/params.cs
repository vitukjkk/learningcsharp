using System;

class myC
{
    static void Main()
    {
        sum(1,3,4,5,6,76,7,1);
    }

    static void sum(params int[] n)
    {
        int res = 0; 

        if(n.Length == 0)
        {
            Console.WriteLine("ERRO: nenhum valor foi inserido!");
        }
        else if(n.Length == 1)
        {
            Console.WriteLine("ERRO: somente um valor foi passado!");
        }
        else
        {
            for(int i =0;  i < n.Length; i++)
            {
                res += n[i];
            }

            Console.WriteLine("RESULTADO: {0}", res);
        }
    }
}