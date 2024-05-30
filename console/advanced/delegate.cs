/*
OBJETO QUE PODE FAZER REFERÊNCIA A UM MÉTODO (OU MAIS)
*/

using System;

delegate int op(int n1, int n2);

class mat
{
    public static int soma(int n1, int n2) { return n1 + n2; }
    public static int dobro(int n1) { return n1 * 2; }
    public static int mult(int n1, int n2) { return n1 * n2; }
}

class myC
{
    public static void Main()
    {
        Console.WriteLine(mat.soma(5,2));
        Console.WriteLine(mat.dobro(4));
        Console.WriteLine(mat.mult(3,5));

        int res;

        op d1 = new op(mat.soma);

        res = d1(10,50);
        Console.WriteLine(res);
    }
}