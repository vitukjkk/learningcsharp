using System;

class myC
{
    static void Main()
    {
        Console.WriteLine("Escolha um transporte:\n[1] Avião\n[2] Carro\n[3] Ônibus\n[4] Bicicleta");
        
        int option = Convert.ToInt32(Console.ReadLine());
        string veh = "Indefinido";
        string msg = "Transporte escolhido: ";

        switch(option)
        {
            case 1:
                veh = "Avião";
                break;
            case 2:
                veh = "Carro";
                break;
            case 3:
                veh = "Ônibus";
                break;
            case 4:
                veh = "Bicicleta";
                break;
            default:
                Console.WriteLine("ERRO: método inválido!");
                break;
        }
        
        Console.WriteLine(msg + veh);
    }
}