using System;

class myC
{
    static void Main()
    {
        /*
        // FORMATANDO COM ÍNDICES
        int n1, n2, n3;
        n1 = 10; n2 = 20; n3 = 30;
        Console.Write("n1 = {0}\n n2 = {1}\n n3 = {2}", n1, n2, n3);*/
        
        // FORMATANDO EM VALORES
        double valorCompra, valorVenda, lucro;
        valorCompra = 10;
        valorVenda = 20;
        lucro = valorCompra / valorVenda * 100;
        Console.Write("Produto: Pastel\nLucro: {0,15:p}\nValor de venda: {1,15:c}", lucro, valorVenda); // DINHEIRO - O 15 SERVE PARA COLOCAR ESPAÇOS, AO INVÉS DO /T
    }
}