/*
FUNÇÃO CHAMANDO ELA MESMA
*/

using System;

class Mathe
{
    public int fat(int n)
    {
        int res;
        if(n <= 1)
        {
            res = 1;
        }
        else
        {
            res = n * fat(n - 1);
        }
        return res;
    }
}

class myC
{
    public static void Main()
    {
        Mathe m1 = new Mathe();
        m1.fat(8);
    }
}