using System;

class myC
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Nome digitado: {0}", nome);

        Console.WriteLine("Digite o primeiro número: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Primeiro valor digitado: {0}", v1);

        Console.WriteLine("Digite o segundo número: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Segundo valor digitado: {0}", v2);

        soma = v1 + v2;

        Console.Write("A soma entre {0} e {1} é igual a {2}", v1, v2, soma);
    }
}