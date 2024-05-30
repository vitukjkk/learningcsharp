using System;

class Calc
{
    public int Soma(int[] i, double[] d)
    {
        int ss = 0;
        double sd = 0.0;
        
        for (int j = 0; j < i.Length; j++)
        {
            ss += i[j];
        }
        for (int k = 0; k < d.Length; k++)
        {
            sd += d[k];
        }

        Console.WriteLine("Resultado: {0}", ss + sd);
        
        return (int)(ss + sd);
    }
}

class Program
{
    static void Main()
    {
        Calc calc = new Calc();
        int[] ints = { 1, 2, 3 };
        double[] doubles = { 1.5, 2.5, 3.5 };

        calc.Soma(ints, doubles);
    }
}
