using System;

class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("[CALCULADORA]\nSeja bem-vindo!\nInsira o primeiro número: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escolha o operador\n(1) SOMA\n(2) SUBTRAÇÃO\n(3) MULTIPLICAÇÃO\n(4) DIVISÃO");
        int option = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Agora insira o segundo número: ");
        int y = Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                Console.WriteLine(x + y);
                break;
            }
        }
    }
}