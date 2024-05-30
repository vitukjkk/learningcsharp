// GARANTE QUE O BLOCO DENTRO DO DO SERÁ EXECUTADO PELO MENOS UMA VEZ

 using System;

 class myC
 {
    static void Main()
    {
        string pass = "123";
        string passing;
        int att = 0;

        do
        {
            Console.Clear();
            att++;
            Console.Write("Digite sua senha: ");
            passing = Console.ReadLine();

            if(att > 5)
            {
                Console.Clear();
                Console.WriteLine("Limite de tentivas atingido.");
                break;
            }

        } while(pass != passing);

        if(pass == passing)
        {
            Console.WriteLine("Senha correta!\nSeja bem-vindo\nNúmero de tentativas: {0} vezes", att);
        }
        else
        {
            Console.Write("FIM DO PROGRAMA!");
        }
    }
 }