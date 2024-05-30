using System;

/*

MEMBROS E METODOS ESTATICOS NÃO PRECISAM SER INSTANCIADOS

*/

class mat
{
    public static double pi = 3.14;

    public static int dobro(int n)
    {
        return n * 2;
    }
}

class myC
{
    static void Main()
    {
        double vpi = mat.pi;
        int num = 10;
        Console.WriteLine(mat.dobro(num));
    }
}